using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Project.Models
{
    public class DBGateway
    {
        public List<Product> GetProducts()
        {
            List<Product> listOfProducts = new List<Product>();

            Product aProduct;

            long productId = 0;
            string productName = "n/a";
            long supplierId = 0;
            long categoryId = 0;
            string quantityPerUnit = "n/a";
            double unitPrice = 99999.99;
            long unitsInStock = 0;
            long unitsOnOrder = 0;
            long reorderLevel = 0;
            long discontinued = 0;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();
            // Now create a command
            SqliteCommand command = connection.CreateCommand();
            // Setting up the SQL statement
            command.CommandText = "select productid, productname, supplierid, categoryid, quantityperunit, unitprice, unitsinstock, unitsonorder, reorderlevel, discontinued from products;";
            // Now run the SQL statement
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                // Try to access the different columns in the reader
                // local variable name = (cast) reader ["database column name"]

                // The conversions are because the C# data types do no match the
                // SQLite datatypes, they are from different companies

                // First get it from the database

                productId = (long)reader["productId"];
                productName = (string)reader["productName"];
                supplierId = (long)reader["supplierId"];
                categoryId = (long)reader["categoryId"];

                if (reader["quantityPerUnit"] == DBNull.Value)
                {
                    quantityPerUnit = "n/a";
                }
                else
                {
                    quantityPerUnit = (string)reader["quantityPerUnit"];
                }

                unitPrice = Convert.ToDouble(reader["unitPrice"]);
                unitsInStock = (long)reader["unitsInStock"];
                unitsOnOrder = (long)reader["unitsOnOrder"];
                reorderLevel = (long)reader["reorderLevel"];
                discontinued = (long)reader["discontinued"];

                // Now I put it in a C# class

                aProduct = new Product();

                aProduct.ProductID = Convert.ToInt32(productId);
                aProduct.ProductName = productName;
                aProduct.SupplierID = Convert.ToInt32(supplierId);
                aProduct.CategoryID = Convert.ToInt32(categoryId);
                aProduct.QuantityPerUnit = quantityPerUnit;
                aProduct.UnitPrice = unitPrice;
                aProduct.UnitsInStock = Convert.ToInt32(unitsInStock);
                aProduct.UnitsOnOrder = Convert.ToInt32(unitsOnOrder);
                aProduct.ReorderLevel = Convert.ToInt32(reorderLevel);
                aProduct.Discontinued = Convert.ToInt32(discontinued);

                listOfProducts.Add(aProduct);
            }

            connection.Close();

            return listOfProducts;

        }

        public List<Product> GetProductById(int aProductId)
        {
        
            List<Product> listOfProducts = new List<Product>();

            Product aProduct;

            long productId = 0;
            string productName = "n/a";
            long supplierId = 0;
            long categoryId = 0;
            string quantityPerUnit = "n/a";
            double unitPrice = 99999.99;
            long unitsInStock = 0;
            long unitsOnOrder = 0;
            long reorderLevel = 0;
            long discontinued = 0;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();
            // Now create a command
            SqliteCommand command = connection.CreateCommand();
            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductId;
            // Setting up the SQL statement
            command.CommandText = "select productid, productname, supplierid, categoryid, quantityperunit, unitprice, unitsinstock, unitsonorder, reorderlevel, discontinued from products where productid = @productid";
            // we could potentially make a stored procedure 
            
            // Now run the SQL statement
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                // Try to access the different columns in the reader
                // local variable name = (cast) reader ["database column name"]

                // The conversions are because the C# data types do no match the
                // SQLite datatypes, they are from different companies

                // First get it from the database

                productId = (long)reader["productId"];
                productName = (string)reader["productName"];
                supplierId = (long)reader["supplierId"];
                categoryId = (long)reader["categoryId"];
            
                if (reader["quantityPerUnit"] == DBNull.Value)
                {
                    quantityPerUnit = "n/a";
                }
                else
                {
                    quantityPerUnit = (string)reader["quantityPerUnit"];
                }

                unitPrice = Convert.ToDouble(reader["unitPrice"]);
                unitsInStock = (long)reader["unitsInStock"];
                unitsOnOrder = (long)reader["unitsOnOrder"];
                reorderLevel = (long)reader["reorderLevel"];
                discontinued = (long)reader["discontinued"];

                // Now I put it in a C# class

                aProduct = new Product();

                aProduct.ProductID = Convert.ToInt32(productId);
                aProduct.ProductName = productName;
                aProduct.SupplierID = Convert.ToInt32(supplierId);
                aProduct.CategoryID = Convert.ToInt32(categoryId);
                aProduct.QuantityPerUnit = quantityPerUnit;
                aProduct.UnitPrice = unitPrice;
                aProduct.UnitsInStock = Convert.ToInt32(unitsInStock);
                aProduct.UnitsOnOrder = Convert.ToInt32(unitsOnOrder);
                aProduct.ReorderLevel = Convert.ToInt32(reorderLevel);
                aProduct.Discontinued = Convert.ToInt32(discontinued);

                listOfProducts.Add(aProduct);
            }

            connection.Close();

            return listOfProducts;

        }

        public List<Employee> GetEmployees()
        {
            List<Employee> listOfEmployees = new List<Employee>();

            Employee aEmployee;

            long employeeId = 0;
            string lastName = "n/a";
            string firstName = "n/a";
            string title = "n/a";
            string titleOfCourtesy = "n/a";
            string birthDate = "n/a";
            string hireDate = "n/a";
            string address = "n/a";
            string city = "n/a";
            string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string homePhone = "n/a";
            string extension = "n/a";
            string notes = "n/a";
            long reportsTo = 0;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select employeeid, lastname, firstname, title, titleofcourtesy, birthdate, hiredate, address, city, region, postalcode, country, homephone, extension, notes, reportsto from employees;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                employeeId = (long)reader["employeeId"];
                lastName = (string)reader["lastName"];
                firstName = (string)reader["firstName"];
                title = (string)reader["title"];
                titleOfCourtesy = (string)reader["titleOfCourtesy"];
                birthDate = (string)reader["birthDate"];
                hireDate = (string)reader["hireDate"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                if (reader["region"] == DBNull.Value)
                {
                    region = "n/a";
                }
                else
                {
                    region = (string)reader["region"];
                }
                postalCode = (string)reader["postalCode"];
                country = (string)reader["country"];
                homePhone = (string)reader["homePhone"];
                extension = (string)reader["extension"];
                notes = (string)reader["notes"];
                if (reader["reportsTo"] == DBNull.Value)
                {
                    reportsTo = 0;
                }
                else
                {
                    reportsTo = (long)reader["reportsTo"];
                }

                aEmployee = new Employee();

                aEmployee.EmployeeId = Convert.ToInt32(employeeId);
                aEmployee.LastName = lastName;
                aEmployee.FirstName = firstName;
                aEmployee.Title = title;
                aEmployee.TitleOfCourtesy = titleOfCourtesy;
                aEmployee.BirthDate = birthDate;
                aEmployee.HireDate = hireDate;
                aEmployee.Address = address;
                aEmployee.City = city;
                aEmployee.Region = region;
                aEmployee.PostalCode = postalCode;
                aEmployee.Country = country;
                aEmployee.HomePhone = homePhone;
                aEmployee.Extension = extension;
                aEmployee.Notes = notes;
                aEmployee.ReportsTo = Convert.ToInt32(reportsTo);

                listOfEmployees.Add(aEmployee);
            }

            connection.Close();

            return listOfEmployees;
        }

        public List<Supplier> GetSuppliers()
        {
            List<Supplier> listOfSuppliers = new List<Supplier>();

            Supplier aSupplier;

            long supplierId = 0;
            string companyName = "n/a";
            string contactName = "n/a";
            string contactTitle = "n/a";
            string address = "n/a";
            string city = "n/a";
            string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string phone = "n/a";
            string fax = "n/a";
            string homePage = "n/a";

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select supplierid, companyname, contactname, contacttitle, address, city, region, postalcode, country, phone, fax, homepage from suppliers;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                supplierId = (long)reader["supplierId"];
                companyName = (string)reader["companyName"];
                contactName = (string)reader["contactName"];
                contactTitle = (string)reader["contactTitle"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                if (reader["region"] == DBNull.Value)
                {
                    region = "n/a";
                }
                else
                {
                    region = (string)reader["region"];
                }
                postalCode = (string)reader["postalCode"];
                country = (string)reader["country"];
                phone = (string)reader["phone"];
                if (reader["fax"] == DBNull.Value)
                {
                    fax = "n/a";
                }
                else
                {
                    fax = (string)reader["fax"];
                }
                if (reader["homePage"] == DBNull.Value)
                {
                    homePage = "n/a";
                }
                else
                {
                    homePage = (string)reader["homePage"];
                }

                aSupplier = new Supplier();

                aSupplier.SupplierId = Convert.ToInt32(supplierId);
                aSupplier.CompanyName = companyName;
                aSupplier.ContactName = contactName;
                aSupplier.ContactTitle = contactTitle;
                aSupplier.Address = address;
                aSupplier.City = city;
                aSupplier.Region = region;
                aSupplier.PostalCode = postalCode;
                aSupplier.Country = country;
                aSupplier.Phone = phone;
                aSupplier.Fax = fax;
                aSupplier.HomePage = homePage;

                listOfSuppliers.Add(aSupplier);
            }

            connection.Close();

            return listOfSuppliers;
        }

        public List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> listOfOrderDetails = new List<OrderDetail>();

            OrderDetail aOrderDetail;

            long orderID = 0;
            long productID = 0;
            double unitPrice = 99999.99;
            long quantity = 0;
            double discount = 99999.99;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select orderid, productid, unitprice, quantity, discount from 'order details';";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                orderID = (long)reader["orderID"];
                productID = (long)reader["productID"];
                unitPrice = Convert.ToDouble(reader["unitPrice"]);
                quantity = (long)reader["quantity"];
                discount = Convert.ToDouble(reader["discount"]);

                aOrderDetail = new OrderDetail();

                aOrderDetail.OrderID = Convert.ToInt32(orderID);
                aOrderDetail.ProductID = Convert.ToInt32(productID);
                aOrderDetail.UnitPrice = unitPrice;
                aOrderDetail.Quantity = Convert.ToInt32(quantity);
                aOrderDetail.Discount = discount;

                listOfOrderDetails.Add(aOrderDetail);
            }

            connection.Close();

            return listOfOrderDetails;
        }

        public List<Category> GetCategories()
        {
            List<Category> listOfCategories = new List<Category>();

            Category aCategory;

            long categoryID = 0;
            string categoryName = "n/a";
            string description = "n/a";

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select categoryid, categoryname, description from categories;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                categoryID = (long)reader["categoryID"];
                categoryName = (string)reader["categoryName"];
                description = (string)reader["description"];


                aCategory = new Category();

                aCategory.CategoryID = Convert.ToInt32(categoryID);
                aCategory.CategoryName = categoryName;
                aCategory.Description = description;

                listOfCategories.Add(aCategory);
            }

            connection.Close();

            return listOfCategories;
        }

        public List<Orders> GetOrders()
        {
            List<Orders> listOfOrders = new List<Orders>();
            Orders aOrder;

            long orderId = 0;
            string customerId = "n/a";
            long employeeId = 0;
            string orderDate = "n/a";
            string requiredDate = "n/a";
            string shippedDate = "n/a";
            long shipVia = 0;
            double freight = 99999.99;
            string shipName = "n/a";
            string shipAddress = "n/a";
            string shipCity = "n/a";
            string shipRegion = "n/a";
            string shipPostalCode = "n/a";
            string shipCountry = "n/a";

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select * from orders;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                orderId = (long)reader["orderId"];
                customerId = (string)reader["customerId"];
                employeeId = (long)reader["employeeId"];
                orderDate = (string)reader["orderDate"];
                requiredDate = (string)reader["requiredDate"];
                //Use this IF ELSE statement if the value is a DBNull
                if (reader["shippedDate"] == DBNull.Value)
                {
                    shippedDate = "n/a";
                }
                else
                {
                    shippedDate = (string)reader["shippedDate"];
                }

                shipVia = (long)reader["shipVia"];
                freight = Convert.ToDouble(reader["freight"]);
                shipName = (string)reader["shipName"];
                shipAddress = (string)reader["shipAddress"];
                shipCity = (string)reader["shipCity"];
                if (reader["shipRegion"] == DBNull.Value)
                {
                    shipRegion = "n/a";
                }
                else
                {
                    shipRegion = (string)reader["shipRegion"];
                }

                if (reader["shipPostalCode"] == DBNull.Value)
                {
                    shipPostalCode = "n/a";
                }
                else
                {
                    shipPostalCode = (string)reader["shipPostalCode"];
                }
                shipCountry = (string)reader["shipCountry"];

                aOrder = new Orders();

                aOrder.OrderId = Convert.ToInt32(orderId);
                aOrder.CustomerId = customerId;
                aOrder.EmployeeId = Convert.ToInt32(employeeId);
                aOrder.OrderDate = orderDate;
                aOrder.RequiredDate = requiredDate;
                aOrder.ShippedDate = shippedDate;
                aOrder.ShipVia = Convert.ToInt32(shipVia);
                aOrder.Freight = freight;
                aOrder.ShipName = shipName;
                aOrder.ShipAddress = shipAddress;
                aOrder.ShipCity = shipCity;
                aOrder.ShipRegion = shipRegion;
                aOrder.ShipPostalCode = shipPostalCode;
                aOrder.ShipCountry = shipCountry;

                listOfOrders.Add(aOrder);
            }


            connection.Close();

            return listOfOrders;

        }


        public List<Product> InsertProduct(string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "insert into products(productName, supplierId, categoryId, unitPrice)values(@productname, @supplierid, @categoryid, @unitprice)";
            command.Parameters.Add("@productname", SqliteType.Text).Value = aProductName;
            command.Parameters.Add("@supplierid", SqliteType.Integer).Value = aSupplierId;
            command.Parameters.Add("@categoryid", SqliteType.Integer).Value = aCategoryId;
            command.Parameters.Add("@unitprice", SqliteType.Real).Value = aUnitPrice;

            command.ExecuteNonQuery();

            // returns new list after insertion
            List<Product> listOfProducts = GetProducts();

            return listOfProducts;
        }

        public List<Product> UpdateAProduct(int aProductId, string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "update products set productname = @productname, supplierid = @supplierid, categoryid = @categoryid, unitprice = @unitprice where productid = @productid";
            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductId;
            command.Parameters.Add("@productname", SqliteType.Text).Value = aProductName;
            command.Parameters.Add("@supplierid", SqliteType.Integer).Value = aSupplierId;
            command.Parameters.Add("@categoryid", SqliteType.Integer).Value = aCategoryId;
            command.Parameters.Add("@unitprice", SqliteType.Real).Value = aUnitPrice;

            command.ExecuteNonQuery();

            // returns new list after insertion
            List<Product> listOfProducts = GetProducts();

            return listOfProducts;
        }


        public List<Employee> InsertEmployee(string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, int aReportsTo)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();
    
            command.CommandText = "insert into employees(lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, notes, reportsTo)values(@lastname, @firstname, @title, @titleofcourtesy, @birthdate, @hiredate, @address, @city, @region, @postalcode, @country, @homephone, @extension, @notes, @reportsto)";
            command.Parameters.Add("@lastname", SqliteType.Text).Value = aLastName;
            command.Parameters.Add("@firstname", SqliteType.Text).Value = aFirstName;
            command.Parameters.Add("@title", SqliteType.Text).Value = aTitle;
            command.Parameters.Add("@titleofcourtesy", SqliteType.Text).Value = aTitleOfCourtesy;
            command.Parameters.Add("@birthdate", SqliteType.Text).Value = aBirthDate;
            command.Parameters.Add("@hiredate", SqliteType.Text).Value = aHireDate;
            command.Parameters.Add("@address", SqliteType.Text).Value = aAddress;
            command.Parameters.Add("@city", SqliteType.Text).Value = aCity;
            command.Parameters.Add("@region", SqliteType.Text).Value = aRegion;
            command.Parameters.Add("@postalcode", SqliteType.Text).Value = aPostalCode;
            command.Parameters.Add("@country", SqliteType.Text).Value = aCountry;
            command.Parameters.Add("@homephone", SqliteType.Text).Value = aHomePhone;
            command.Parameters.Add("@extension", SqliteType.Text).Value = aExtension;
            command.Parameters.Add("@notes", SqliteType.Text).Value = aNotes;
            command.Parameters.Add("@reportsto", SqliteType.Integer).Value = aReportsTo;
     

            command.ExecuteNonQuery();

            // returns new list after insertion
            List<Employee> listOfEmployees = this.GetEmployees();

            return listOfEmployees;
        }

        public List<Employee> UpdateAEmployee(string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, int aReportsTo)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "update employees set lastName = @lastname, firstName = @firstname, title = @title, titleOfCourtesy = @titleofcourtesy, birthDate = @birthdate, hireDate = @hiredate, address = @address, city = @city, region = @region, postalCode = @postalcode, country = @country, homePhone = @homephone, extension = @extension, notes = @notes, reportsTo = @reportsTo";
            command.Parameters.Add("@lastname", SqliteType.Text).Value = aLastName;
            command.Parameters.Add("@firstname", SqliteType.Text).Value = aFirstName;
            command.Parameters.Add("@title", SqliteType.Text).Value = aTitle;
            command.Parameters.Add("@titleofcourtesy", SqliteType.Text).Value = aTitleOfCourtesy;
            command.Parameters.Add("@birthdate", SqliteType.Text).Value = aBirthDate;
            command.Parameters.Add("@hiredate", SqliteType.Text).Value = aHireDate;
            command.Parameters.Add("@address", SqliteType.Text).Value = aAddress;
            command.Parameters.Add("@city", SqliteType.Text).Value = aCity;
            command.Parameters.Add("@region", SqliteType.Text).Value = aRegion;
            command.Parameters.Add("@postalcode", SqliteType.Text).Value = aPostalCode;
            command.Parameters.Add("@country", SqliteType.Text).Value = aCountry;
            command.Parameters.Add("@homephone", SqliteType.Text).Value = aHomePhone;
            command.Parameters.Add("@extension", SqliteType.Text).Value = aExtension;
            command.Parameters.Add("@notes", SqliteType.Text).Value = aNotes;
            command.Parameters.Add("@reportsto", SqliteType.Integer).Value = aReportsTo;


            command.ExecuteNonQuery();

            // returns new list after insertion
            List<Employee> listOfEmployees = this.GetEmployees();

            return listOfEmployees;
        }

        public List<Supplier> InsertSupplier(string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "insert into suppliers(companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage)values(@companyname, @contactname, @contacttitle, @address, @city, @region, @postalcode, @country, @phone, @fax, @homepage)";
            command.Parameters.Add("@companyname", SqliteType.Text).Value = aCompanyName;
            command.Parameters.Add("@contactname", SqliteType.Text).Value = aContactName;
            command.Parameters.Add("@contacttitle", SqliteType.Text).Value = aContactTitle;
            command.Parameters.Add("@address", SqliteType.Text).Value = aAddress;
            command.Parameters.Add("@city", SqliteType.Text).Value = aCity;
            command.Parameters.Add("@region", SqliteType.Text).Value = aRegion;
            command.Parameters.Add("@postalcode", SqliteType.Text).Value = aPostalCode;
            command.Parameters.Add("@country", SqliteType.Text).Value = aCountry;
            command.Parameters.Add("@phone", SqliteType.Text).Value = aPhone;
            command.Parameters.Add("@fax", SqliteType.Text).Value = aFax;
            command.Parameters.Add("@homepage", SqliteType.Text).Value = aHomePage;


            command.ExecuteNonQuery();

            // returns new list after insertion
            List<Supplier> listOfSuppliers = this.GetSuppliers();

            return listOfSuppliers;
        }

		public List<OrderDetail> InsertOrderDetails(int aOrderID, int aProductID, double aUnitPrice, int aQuantity, double aDiscount)
		{
			SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Logan\\OneDrive\\Documents\\Northwind\\NorthwindV2.db");

			connection.Open();

			SqliteCommand command = connection.CreateCommand();

            command.CommandText = "insert into 'order details'(orderID, productID, unitPrice, quantity, discount)values(@orderid, @productid, @unitprice, @quantity, @discount)";
            command.Parameters.Add("@orderid", SqliteType.Integer).Value = aOrderID;
            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductID;
            command.Parameters.Add("@unitprice", SqliteType.Real).Value = aUnitPrice;
			command.Parameters.Add("@quantity", SqliteType.Integer).Value = aQuantity;
			command.Parameters.Add("@discount", SqliteType.Real).Value = aDiscount;

			command.ExecuteNonQuery();

			// returns new list after insertion
			List<OrderDetail> listOfOrderDetails = this.GetOrderDetails();

			return listOfOrderDetails;
		}


	}
}
