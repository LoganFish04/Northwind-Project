namespace Northwind_Project.Models
{
    public class Customers
    {
        private string customerId = "n/a";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        public string CustomerId
        {
            get { return customerId; }
            set { this.customerId = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { this.fax = value; }
        }

        public Customers() : this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Customers(string aCustomerId) : this(aCustomerId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {
            this.CustomerId = aCustomerId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Customer Id: " + this.CustomerId + "<br />";
            message = message + "Customer Id: " + this.CompanyName + "<br />";
            message = message + "Customer Id: " + this.ContactName + "<br />";
            message = message + "Customer Id: " + this.ContactTitle + "<br />";
            message = message + "Customer Id: " + this.Address + "<br />";
            message = message + "Customer Id: " + this.City + "<br />";
            message = message + "Customer Id: " + this.Region + "<br />";
            message = message + "Customer Id: " + this.PostalCode + "<br />";
            message = message + "Customer Id: " + this.Country + "<br />";
            message = message + "Customer Id: " + this.Phone + "<br />";
            message = message + "Customer Id: " + this.Fax + "<br />";
            return message;
        }
    }
}
