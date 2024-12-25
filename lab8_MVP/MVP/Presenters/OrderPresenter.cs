using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class OrderPresenter
    {
        private readonly IOrderView view;
        private readonly OrderModel model;

        public OrderPresenter(IOrderView view, OrderModel model)
        {
            this.view = view;
            this.model = model;

            view.AddOrder += OnAddUser;
            view.UpdateOrder += OnUpdateUser;
            view.DeleteOrder += OnDeleteUser;
            view.ViewOrders += OnViewUsers;
        }

        private void OnAddUser(object sender, EventArgs e)
        {
            model.CreateOrder(view.OrderTitle, view.UserId, view.DepartmentId);
            OnViewUsers(sender, e);
        }

        private void OnUpdateUser(object sender, EventArgs e)
        {
            model.UpdateOrder(view.UserId, view.DepartmentId, view.OrderId, view.OrderTitle);
            OnViewUsers(sender, e);
        }

        private void OnDeleteUser(object sender, EventArgs e)
        {
            model.DeleteUser(view.OrderId);
            OnViewUsers(sender, e);
        }

        private void OnViewUsers(object sender, EventArgs e)
        {
            view.DisplayOrders(model.ReadOrders());
        }
    }
}
