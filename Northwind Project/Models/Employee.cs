namespace Northwind_Project.Models
{
    public class Employee
    {
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        public int EmployeeId
        {
            get { return this.employeeId; }

            set { this.employeeId = value; }
        }

        public string LastName
        {
            get { return this.lastName; }

            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }

            set { this.firstName = value; }
        }

        public string Title
        {
            get { return this.title; }

            set { this.title = value; }
        }

        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }

            set { this.titleOfCourtesy = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }

            set { this.birthDate = value; }
        }

        public string HireDate
        {
            get { return this.hireDate; }

            set { this.hireDate = value; }
        }

        public string Address
        {
            get { return this.address; }

            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }

            set { this.city = value; }
        }

        public string Region
        {
            get { return this.region; }

            set { this.region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }

            set { this.postalCode = value; }
        }

        public string Country
        {
            get { return this.country; }

            set { this.country = value; }
        }

        public string HomePhone
        {
            get { return this.homePhone; }

            set { this.homePhone = value; }
        }

        public string Extension
        {
            get { return this.extension; }

            set { this.extension = value; }
        }

        public string Notes
        {
            get { return this.notes; }

            set { this.notes = value; }
        }

        public int ReportsTo
        {
            get { return this.reportsTo; }

            set { this.reportsTo = value; }
        }

        public Employee()
        {

        }
        public Employee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, int aReportsTo)
        {
            this.EmployeeId = aEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;

        }

        public override string ToString()
        {
            string message = "";
            message = message + "Employee Id: " + this.EmployeeId + "<br />";
            message = message + "Last Name: " + this.LastName + "<br />";
            message = message + "First Name: " + this.FirstName + "<br />";
            message = message + "Title: " + this.Title + "<br />";
            message = message + "Title Of Courtesy: " + this.TitleOfCourtesy + "<br />";
            message = message + "Birth Date: " + this.BirthDate + "<br />";
            message = message + "Hire Date: " + this.HireDate + "<br />";
            message = message + "Address: " + this.Address + "<br />";
            message = message + "City: " + this.City + "<br />";
            message = message + "Region: " + this.Region + "<br />";
            message = message + "Postal Code: " + this.PostalCode + "<br />";
            message = message + "Country: " + this.Country + "<br />";
            message = message + "Home Phone: " + this.HomePhone + "<br />";
            message = message + "Phone Extension: " + this.Extension + "<br />";
            message = message + "Notes: " + this.Notes + "<br />";
            message = message + "Reports To: " + this.ReportsTo + "<br />";

            return message;
        }
    }
}
