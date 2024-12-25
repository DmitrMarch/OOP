using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    internal class UserPresenter
    {
        private readonly IUserView view;
        private readonly UserModel model;

        public UserPresenter(IUserView view, UserModel model)
        {
            this.view = view;
            this.model = model;

            view.AddUser += OnAddUser;
            view.UpdateUser += OnUpdateUser;
            view.DeleteUser += OnDeleteUser;
            view.ViewUsers += OnViewUsers;
        }

        private void OnAddUser(object sender, EventArgs e)
        {
            model.CreateUser(view.UserName);
            OnViewUsers(sender, e);
        }

        private void OnUpdateUser(object sender, EventArgs e)
        {
            model.UpdateUser(view.UserId, view.UserName);
            OnViewUsers(sender, e);
        }

        private void OnDeleteUser(object sender, EventArgs e)
        {
            model.DeleteUser(view.UserId);
            OnViewUsers(sender, e);
        }

        private void OnViewUsers(object sender, EventArgs e)
        {
            view.DisplayUsers(model.ReadUsers());
        }
    }
}
