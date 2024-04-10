using Microsoft.AspNetCore.Mvc;
using Northwind_Project.Models;
using System.Diagnostics;

namespace Northwind_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        [Route("/GetProducts")]
        public IActionResult GetProducts()
        {
            DBGateway aGateway = new DBGateway();
            List<Product> aListOfProducts = aGateway.GetProducts();

            ViewBag.listOfProducts = aListOfProducts;
            return View();
        }

        public IActionResult GetProductById(int aProductId)
        {
            DBGateway aGateway = new DBGateway();
            List<Product> aListOfProducts = aGateway.GetProductById(aProductId);

            ViewBag.listOfProducts = aListOfProducts;
            return View();
        }

        [Route("/GetEmployees")]
        public IActionResult GetEmployees()
        {
            DBGateway aGateway = new DBGateway();
            List<Employee> aListOfEmployees = aGateway.GetEmployees();

            ViewBag.listOfEmployees = aListOfEmployees;
            return View();
        }

        [Route("/GetSuppliers")]
        public IActionResult GetSuppliers()
        {
            DBGateway aGateway = new DBGateway();
            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();

            ViewBag.listOfSuppliers = aListOfSuppliers;
            return View();
        }

        [Route("/GetOrderDetails")]
        public IActionResult GetOrderDetails()
        {
            DBGateway aGateway = new DBGateway();
            List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetails();

            ViewBag.listOfOrderDetails = aListOfOrderDetails;
            return View();
        }

        [Route("/GetOrders")]
        public IActionResult GetOrders()
        {
            DBGateway aGateway = new DBGateway();
            List<Orders> aListOfOrders = aGateway.GetOrders();

            ViewBag.listOfOrders = aListOfOrders;
            return View();
        }


        [Route("/InsertAProductForm")]
        public IActionResult InsertAProductForm()
        {
            DBGateway aGateway = new DBGateway();

            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();
            List<Category> aListOfCategories = aGateway.GetCategories();

            ViewBag.listOfSuppliers = aListOfSuppliers;
            ViewBag.listOfCategories = aListOfCategories;

            return View();
        }

        [Route("/InsertAProduct")]
        public IActionResult InsertAProduct(string productName, int supplierId, int categoryId, double unitPrice)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertProduct(productName, supplierId, categoryId, unitPrice);

            List<Product> aListOfProducts = aGateway.GetProducts();
            ViewBag.listOfProducts = aListOfProducts;
            
            // the reason we are returning GetProducts is because if you are an employee and you
            // insert a Product, you will probably want to see it after inserting 
            return View("GetProducts");
        }

        // Insert Employees

        [Route("/InsertAEmployeeForm")]
        public IActionResult InsertAEmployeeForm()
        {

            return View();
        }

        [Route("/InsertAEmployee")]
        public IActionResult InsertAEmployee(string lastName, string firstName, string title, string titleOfCourtesy, string birthDate, string hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, string notes, int reportsTo)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertEmployee(lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, notes, reportsTo);

            List<Employee> aListOfEmployees = aGateway.GetEmployees();
            ViewBag.listOfEmployees = aListOfEmployees;

            // the reason we are returning GetProducts is because if you are an employee and you
            // insert a Product, you will probably want to see it after inserting 
            return View("GetEmployees");
        }

        [Route("/UpdateAEmployeeForm")]
        public IActionResult UpdateAEmployeeForm(int aEmployeeId)
        {
            DBGateway aGateway = new DBGateway();
            List<Employee> aListOfEmployees = new List<Employee>();

            // aListOfEmployees = aGateway.GetEmployeeById(aEmployeeId);

            ViewBag.listOfEmployees = aListOfEmployees;

            return View();
        }

        [Route("/InsertASupplier")]
        public IActionResult InsertASupplier(string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax, string homePage)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertSupplier(companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);

            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();
            ViewBag.listOfSuppliers = aListOfSuppliers;

            // the reason we are returning GetProducts is because if you are an employee and you
            // insert a Product, you will probably want to see it after inserting 
            return View("GetSuppliers");
        }

        [Route("/InsertASupplierForm")]
        public IActionResult InsertASupplierForm()
        {


            return View();
        }

        [Route("/InsertAOrderDetail")]
		public IActionResult InsertAOrderDetail(int orderID, int productID, double unitPrice, int quantity, double discount) { 
			DBGateway aGateway = new DBGateway();

			aGateway.InsertOrderDetails(orderID, productID, unitPrice, quantity, discount);

			List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetails();

			ViewBag.listOfOrderDetails = aListOfOrderDetails;


			// the reason we are returning GetProducts is because if you are an employee and you
			// insert a Product, you will probably want to see it after inserting 
			return View("GetOrderDetails");
		}

		[Route("/InsertAOrderDetailForm")]
		public IActionResult InsertAOrderDetailForm()
		{
            DBGateway aGateway = new DBGateway();

            List<Product> aListOfProducts = aGateway.GetProducts();
            List<Orders> aListOfOrders = aGateway.GetOrders();

            ViewBag.listOfProducts = aListOfProducts;
            ViewBag.listOfOrders = aListOfOrders;

            return View();
		}


		// Update Products
		public IActionResult UpdateAProduct(int productId, string productName, int supplierId, int categoryId, double unitPrice)
        {
            DBGateway aGateway = new DBGateway();
            aGateway.UpdateAProduct(productId, productName, supplierId, categoryId, unitPrice);

            List<Product> aListOfProducts = new List<Product>();
            return View("GetProducts");
        }

        [Route("/UpdateAProductForm")]
        public IActionResult UpdateAProductForm(int aProductId)
        {
            DBGateway aGateway = new DBGateway();
            List<Product> aListOfProducts = new List<Product>();
            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();
            List<Category> aListOfCategories = aGateway.GetCategories();

            aListOfProducts = aGateway.GetProductById(aProductId);

            ViewBag.listOfSuppliers = aListOfSuppliers;
            ViewBag.listOfCategories = aListOfCategories;
            ViewBag.listOfProducts = aListOfProducts;
            
            return View();

        }



    }
}
