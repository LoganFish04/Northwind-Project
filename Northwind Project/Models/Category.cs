namespace Northwind_Project.Models
{
    public class Category
    {
        private int categoryID = -1;
        private string categoryName = "N/A";
        private string description = "N/A";

        public int CategoryID
        {
            get { return categoryID; }
            set { this.categoryID = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { this.categoryName = value; }
        }

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public Category() : this(-1, "N/A", "N/A")
        {
            //empty conductor
        }

        public Category(int aCategoryID, string aCategoryName, string aDescription)
        {
            this.CategoryID = aCategoryID;
            this.CategoryName = aCategoryName;
            this.Description = aDescription;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "CategoryID: " + this.CategoryID + "<br/>";
            message = message + "CategoryName: " + this.CategoryName + "<br/>";
            message = message + "Description: " + this.Description + "<br/>";
            return message;
        }
    }
}
