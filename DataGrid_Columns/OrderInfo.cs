using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Columns
{
	public class OrderInfo
	{
		public int OrderID { get; set; }
		public bool IsShipped { get; set; }
		public string Customer { get; set; }
		public DateTime ShipTime { get; set; }
		public string ShipCountry { get; set; }

		public OrderInfo(int orderId, string customer, bool isShipped, DateTime shipTime, string shipCountry)
		{
			OrderID = orderId;
			Customer = customer;
			IsShipped = isShipped;
			ShipTime = shipTime;
			ShipCountry = shipCountry;
		}
	}
}
