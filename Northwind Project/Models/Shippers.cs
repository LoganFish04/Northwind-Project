namespace Northwind_Project.Models
{
    public class Shipper
    {
        private int shipperID = -1;
        private string shipperCompanyName = "N/A";
        private string shipperPhone = "N/A";

        public int ShipperID
        {
            get { return shipperID; }
            set { shipperID = value; }
        }

        public string ShipperCompanyName
        {
            get { return shipperCompanyName; }
            set { shipperCompanyName = value; }
        }

        public string ShipperPhone
        {
            get { return shipperPhone; }
            set { shipperPhone = value; }
        }

        public Shipper() : this(-1, "N/A", "N/A")
        {
            //empty constructor
        }

        public Shipper(int aShipperID, string aShipperCompanyName, string aShipperPhone)
        {
            this.ShipperID = aShipperID;
            this.ShipperCompanyName = aShipperCompanyName;
            this.ShipperPhone = aShipperPhone;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "ShipperID: " + this.ShipperID + "<br/>";
            message = message + "Company Name: " + this.ShipperCompanyName + "<br/>";
            message = message + "Phone Number: " + this.ShipperPhone + "<br/>";
            return message;
        }
    }
}
