using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private DataContext _dataContext;
        public ProductController(DataContext db) => _dataContext = db;
        public ActionResult Category() => View(_dataContext.Categories.OrderBy(c => c.CategoryName));
        public ActionResult Index(int id) => View(_dataContext.Products.Where(p => p.CategoryId == id && !p.Discontinued).OrderBy(p => p.ProductName));
    }
}