# Columns-in-.NET-MAUI-DataGrid
In this article, we’ll guide you through defining, generating, and manipulating columns in the .NET MAUI DataGrid (SfDataGrid). You’ll learn how to declare various column types in XAML, bind data effectively, and programmatically add, edit, remove, or clear columns at runtime. Additionally, we’ll cover techniques for formatting and customizing headers using the AutoGeneratingColumn event. For more details, please refer the official documentation: [Columns in MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/columns).

## xaml
```
    <ContentPage.BindingContext>
        <local:OrderInfoRepo />
    </ContentPage.BindingContext>

    <StackLayout>

        <StackLayout Orientation="Horizontal">
            <Button Text="Add" Clicked="Button_Clicked_1" Margin="3" />
            <Button Text="Edit" Clicked="Button_Clicked_2" Margin="3" />
            <Button Text="Remove" Clicked="Button_Clicked_3" Margin="3" />
            <Button Text="Clear" Clicked="Button_Clicked_4" Margin="3" />
        </StackLayout>

        <syncfusion:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding Orders}"
                               ColumnWidthMode="FitByHeader"
                               AutoGenerateColumnsMode="None" >
            <syncfusion:SfDataGrid.Columns>
                <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID"/>
                <syncfusion:DataGridTextColumn MappingName="Customer" HeaderText="Customer"/>
                <syncfusion:DataGridCheckBoxColumn MappingName="IsShipped" HeaderText="Is Shipped"/>
                <syncfusion:DataGridDateColumn MappingName="ShipTime" HeaderText="Ship Time"/>
            </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>

    </StackLayout>
```

### What this XAML shows
- Binding to a view model (OrderInfoRepo) that exposes an Orders collection.
- Disabling auto-generation and declaring explicit columns using Syncfusion types:
  - DataGridNumericColumn for numeric fields (OrderID)
  - DataGridTextColumn for strings (Customer)
  - DataGridCheckBoxColumn for booleans (IsShipped)
  - DataGridDateColumn for DateTime values (ShipTime)
- Buttons wired to event handlers for runtime column manipulation.

## C#
The following code-behind demonstrates how to add a new column, edit a column header, remove a specific column, clear all columns, and customize formatting/headers during auto-generation.
```
    private void Button_Clicked_1(object sender, EventArgs e)
	{
		var shipCountry = new DataGridTextColumn() { MappingName = "ShipCountry", HeaderText="Ship Country" };
		this.dataGrid.Columns.Add(shipCountry);
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
		else if (e.Column.MappingName == "ShipTime")
			e.Column.HeaderText = "Ship Time";
		else if (e.Column.MappingName == "ShipCountry")
			e.Column.HeaderText = "ShipCountry";
	}
```

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to generate columns and how to manipulate columns in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!