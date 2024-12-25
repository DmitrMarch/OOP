using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IUserView
    {
        string UserName { get; set; }
        int UserId { get; set; }
        void DisplayUsers(DataTable users);
        event EventHandler AddUser;
        event EventHandler UpdateUser;
        event EventHandler DeleteUser;
        event EventHandler ViewUsers;
    }
}
