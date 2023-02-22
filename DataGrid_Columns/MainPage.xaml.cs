using Syncfusion.Maui.DataGrid;

namespace DataGrid_Columns;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		var shipCountry = new DataGridTextColumn() { MappingName = "ShipCountry", HeaderText="Ship Country" };
		this.dataGrid.Columns.Add(shipCountry);
		
		//this.dataGrid.Columns.Insert(1, shipCountry);
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		var column = this.dataGrid.Columns[0];
		column.HeaderText = "Client";
	}

	private void Button_Clicked_3(object sender, EventArgs e)
	{
		if (this.dataGrid.Columns.Count > 0)
			this.dataGrid.Columns.RemoveAt(0);
	}

	private void Button_Clicked_4(object sender, EventArgs e)
	{
		this.dataGrid.Columns.Clear();
	}

	private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
	{
		if(e.Column.MappingName == "ShipTime")
		{
			e.Column.Format = "MMM yy";
		}

		if (e.Column.MappingName == "OrderID")
			e.Column.HeaderText = "Order ID";
		else if (e.Column.MappingName == "IsShipped")
			e.Column.HeaderText = "Is Shipped";
		else if (e.Column.MappingName == "CustomerID")
			e.Column.HeaderText = "Customer ID";
		else if (e.Column.MappingName == "ShipTime")
			e.Column.HeaderText = "Ship Time";
		else if (e.Column.MappingName == "ShipCountry")
			e.Column.HeaderText = "ShipCountry";
	}
}

