using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Columns
{
	public class OrderInfoRepo
	{
		private ObservableCollection<OrderInfo> _orders;
		public ObservableCollection<OrderInfo> Orders
		{
			get { return _orders; }
			set { _orders = value; }
		}

		public OrderInfoRepo()
		{
			Orders = new ObservableCollection<OrderInfo>();
			this.GenerateOrders();
		}

		public void GenerateOrders()
		{
			_orders.Add(new OrderInfo(1001, "Maria Anders", true, new DateTime(2023, 1, 5), "Germany"));
			_orders.Add(new OrderInfo(1002, "Ana Trujillo", true, new DateTime(2023, 2, 6), "Mexico"));
			_orders.Add(new OrderInfo(1003, "Ant Fuller", false, new DateTime(2023, 1, 5), "Canada"));
			_orders.Add(new OrderInfo(1004, "Thomas Hardy", true, new DateTime(2023, 2, 7), "Germany"));
			_orders.Add(new OrderInfo(1005, "Tim Adams", false, new DateTime(2023, 3, 8), "UK"));
			_orders.Add(new OrderInfo(1006, "Hanna Moos", true, new DateTime(2023, 1, 5), "Germany"));
			_orders.Add(new OrderInfo(1007, "Andrew Fuller", true, new DateTime(2023, 1, 5), "Mexico"));
			_orders.Add(new OrderInfo(1008, "Martin King", false, new DateTime(2023, 3, 8), "Germany"));
			_orders.Add(new OrderInfo(1009, "Lenny Lin", true, new DateTime(2023, 2, 5), "France"));
			_orders.Add(new OrderInfo(1010, "John Carter", true, new DateTime(2023, 1, 6), "Germany"));
			_orders.Add(new OrderInfo(1011, "Laura King", false, new DateTime(2023, 3, 8), "UK"));
			_orders.Add(new OrderInfo(1012, "Anne Wilson", true, new DateTime(2023, 1, 5), "Canada"));
			_orders.Add(new OrderInfo(1013, "Martin King", false, new DateTime(2023, 3, 7), "France"));
			_orders.Add(new OrderInfo(1014, "Gina Irene", true, new DateTime(2023, 1, 5), "Sweden"));

		}
	}
}
