using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;
        protected RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }
        public IActionResult Get(int id)
        {
            //var model = _manager.Product.GetOneProduct(id, false);
            //return View(model);


            Product product = _context.Products.First(x => x.ProductId.Equals(id));
            return View(product);
        }
    }
}




// var context = new RepositoryContext(
//   new DbContextOptionsBuilder<RepositoryContext>()
//  .UseSqlite("Data source = C:\\MVC\\ProductDb.db")
//  .Options);




// public IActionResult Get(int id)
// {
//     Product product = _context.Products.First(x => x.ProductId.Equals(id));
//     if (product == null)
//     {
//         return NotFound(); // 404 Not Found sayfasına yönlendirme
//     }
//     return View(product);
// }




