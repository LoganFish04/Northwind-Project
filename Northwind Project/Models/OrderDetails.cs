namespace Northwind_Project.Models
{
    public class OrderDetail
    {
        private int orderID = -1;
        private int productID = -1;
        private double unitPrice = 9999999.99;
        private int quantity = -1;
        private double discount = 9999999.99;

        public int OrderID
        {
            get { return this.orderID; }
            set { this.orderID = value; }
        }

        public int ProductID
        {
            get { return this.productID; }
            set { this.productID = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public double Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }

        public OrderDetail()
        {

        }
        public OrderDetail(int aOrderID, int aProductID, double aUnitPrice, int aQuantity, double aDiscount)
        {
            this.OrderID = aOrderID;
            this.ProductID = aProductID;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "OrderID: " + this.OrderID + "<br/>";
            message = message + "ProductID: " + this.ProductID + "<br/>";
            message = message + "Unit Price:  " + this.UnitPrice + "<br/>";
            message = message + "Quantity: " + this.Quantity + "<br/>";
            message = message + "Discount:  " + this.Discount + "<br/>";
            return message;
        }
    }
}
