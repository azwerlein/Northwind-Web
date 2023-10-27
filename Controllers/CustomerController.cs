using System.Data.Common;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    private DataContext _dataContext;
    public CustomerController(DataContext db) => _dataContext = db;

    public ActionResult Register()
    {
        CustomerViewModel model = new CustomerViewModel();
        model.Customer = new Customer();
        model.Customers = _dataContext.Customers;
        return View(model);
    }

    [HttpPost]
    public ActionResult Register(Customer customer)
    {
        _dataContext.Customers.Add(customer);
        _dataContext.SaveChanges();
        return Register();
    }
}

public class CustomerViewModel
{
    public Customer Customer { get; set; }
    public IEnumerable<Customer> Customers { get; set; }
}