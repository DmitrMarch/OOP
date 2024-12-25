using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IDepartmentView
    {
        string DepartmentTitle { get; set; }
        int DepartmentId { get; set; }
        void DisplayDepartments(DataTable departments);
        event EventHandler AddDepartment;
        event EventHandler UpdateDepartment;
        event EventHandler DeleteDepartment;
        event EventHandler ViewDepartments;
    }
}
