using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IOrderView
    {
        string OrderTitle { get; set; }
        int OrderId { get; set; }
        int UserId { get; set; }
        int DepartmentId { get; set; }
        void DisplayOrders(DataTable orders);
        event EventHandler AddOrder;
        event EventHandler UpdateOrder;
        event EventHandler DeleteOrder;
        event EventHandler ViewOrders;
    }
}
