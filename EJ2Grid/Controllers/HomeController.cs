using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using System.Collections;

namespace EJ2Grid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataSource = OrdersDetails.GetAllRecords();
            return View();
        }
    }
    public class OrdersDetails
    {
        public static List<OrdersDetails> order = new List<OrdersDetails>();
        public OrdersDetails()
        {
        }
        public OrdersDetails(int OrderID, int EmployeeId, double Freight, DateTime OrderDate, string ShipCountry)
        {
            this.OrderID = OrderID;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShipCountry = ShipCountry;
        }
        public static List<OrdersDetails> GetAllRecords()
        {
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new OrdersDetails(code + 1, i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Denmark"));
                    order.Add(new OrdersDetails(code + 2, i + 1, 3.3 * i, new DateTime(1990, 04, 04), "Brazil"));
                    order.Add(new OrdersDetails(code + 3, i + 2, 4.3 * i, new DateTime(1957, 11, 30), "Germany"));
                    order.Add(new OrdersDetails(code + 4, i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Austria"));
                    order.Add(new OrdersDetails(code + 5, i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Switzerland"));
                    code += 5;
                }
            }
            return order;
        }
        public int? OrderID { get; set; }
        public int? EmployeeID { get; set; }
        public double? Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCountry { get; set; }
    }
}

