namespace Northwind_Project.Models
{
    public class Supplier
    {
        private int supplierId = -1;
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
        private string homePage = "n/a";

        public int SupplierId
        {
            get { return supplierId; }

            set { supplierId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }

            set { companyName = value; }
        }

        public string ContactName
        {
            get { return contactName; }

            set { contactName = value; }
        }

        public string ContactTitle
        {
            get { return contactTitle; }

            set { contactTitle = value; }
        }

        public string Address
        {
            get { return address; }

            set { address = value; }
        }

        public string City
        {
            get { return city; }

            set { city = value; }
        }

        public string Region
        {
            get { return region; }

            set { region = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }

            set { postalCode = value; }
        }

        public string Country
        {
            get { return country; }

            set { country = value; }
        }

        public string Phone
        {
            get { return phone; }

            set { phone = value; }
        }

        public string Fax
        {
            get { return fax; }

            set { fax = value; }
        }

        public string HomePage
        {
            get { return homePage; }

            set { homePage = value; }
        }

        public Supplier()
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {
            this.SupplierId = aSupplierId;
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
            this.HomePage = aHomePage;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Supplier Id: " + this.SupplierId + "<br />";
            message = message + "Company Name: " + this.CompanyName + "<br />";
            message = message + "Contact Name: " + this.ContactName + "<br />";
            message = message + "Address: " + this.Address + "<br />";
            message = message + "City: " + this.City + "<br />";
            message = message + "Region: " + this.Region + "<br />";
            message = message + "Postal Code: " + this.PostalCode + "<br />";
            message = message + "Country: " + this.Country + "<br />";
            message = message + "Phone Number: " + this.Phone + "<br />";
            message = message + "Fax Number: " + this.Fax + "<br />";
            message = message + "Homepage URL: " + this.HomePage + "<br />";

            return message;
        }
    }
}
