using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    internal class DepartmentPresenter
    {
        private readonly IDepartmentView view;
        private readonly DepartmentModel model;

        public DepartmentPresenter(IDepartmentView view, DepartmentModel model)
        {
            this.view = view;
            this.model = model;

            view.AddDepartment += OnAddDepartment;
            view.UpdateDepartment += OnUpdateDepartment;
            view.DeleteDepartment += OnDeleteDepartment;
            view.ViewDepartments += OnViewDepartments;
        }

        private void OnAddDepartment(object sender, EventArgs e)
        {
            model.CreateDepartment(view.DepartmentTitle);
            OnViewDepartments(sender, e);
        }

        private void OnUpdateDepartment(object sender, EventArgs e)
        {
            model.UpdateDepartment(view.DepartmentId, view.DepartmentTitle);
            OnViewDepartments(sender, e);
        }

        private void OnDeleteDepartment(object sender, EventArgs e)
        {
            model.DeleteDepartment(view.DepartmentId);
            OnViewDepartments(sender, e);
        }

        private void OnViewDepartments(object sender, EventArgs e)
        {
            view.DisplayDepartments(model.ReadDepartments());
        }
    }
}
