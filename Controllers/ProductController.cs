using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private DataContext _dataContext;
        public ProductController(DataContext db) => _dataContext = db;
        public ActionResult Category() => View(_dataContext.Categories.OrderBy(c => c.CategoryName));
    }
}