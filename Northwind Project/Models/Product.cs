namespace Northwind_Project.Models
{
    public class Product

    {   //private variables can only be accessed from within the class 

        private int productID = -1;
        private string productName = "N/A";
        private int supplierID = -1;
        private int categoryID = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = 999999999.99;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = -1;
        private int discontinued = -1;

        public int ProductID
        {
            get { return this.productID; }
            set { this.productID = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int SupplierID
        {
            get { return this.supplierID; }
            set { this.supplierID = value; }
        }

        public int CategoryID
        {
            get { return this.categoryID; }
            set { this.categoryID = value; }
        }

        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set { this.unitsInStock = value; }
        }

        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set { this.unitsOnOrder = value; }
        }

        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set { this.reorderLevel = value; }
        }

        public int Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }


        //Constructors 

        public Product() : this(-1, "n/a", -1, "n/a", -1, 999999999.99, -1, -1, -1, -1)
        {
            //empty constructor--chained
        }

        public Product(int aProductID) : this(-1, "n/a", -1, "n/a", -1, 999999999.99, -1, -1, -1, -1)
        {
            //chained constructor
        }


        public Product(int aProductID, string aProductName, int aSupplierID, string aQuantityPerOrder, int aCategoryID, double aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel, int aDiscontinued)
        {
            this.ProductID = aProductID;
            this.ProductName = aProductName;
            this.SupplierID = aSupplierID;
            this.QuantityPerUnit = aQuantityPerOrder;
            this.CategoryID = aCategoryID;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsOnOrder = aUnitsOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;
        }


        //ToSting Method 
        public override string ToString()
        {
            string message = "";
            message = message + "ProductID: " + this.ProductID + "<br/>";
            message = message + "ProductName: " + this.ProductName + "<br/>";
            message = message + "SupplierID: " + this.SupplierID + "<br/>";
            message = message + "SupplierID: " + this.QuantityPerUnit + "<br/>";
            message = message + "CategoryID: " + this.CategoryID + "<br/>";
            message = message + "UnitPrice: " + this.UnitPrice + "<br/>";
            message = message + "SupplierID: " + this.UnitsInStock + "<br/>";
            message = message + "SupplierID: " + this.UnitsOnOrder + "<br/>";
            message = message + "CategoryID: " + this.ReorderLevel + "<br/>";
            message = message + "UnitPrice: " + this.Discontinued + "<br/>";
            return message;
        }
    }
}
