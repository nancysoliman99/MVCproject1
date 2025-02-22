using System.Diagnostics;
using E_commerce.Models;
using E_commerce.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        EcommerceContext db =new EcommerceContext();
       

        public IActionResult Index()
        {
            IndexVm vm = new IndexVm();
            vm.Categories=db.Categories.ToList();
            vm.Products=db.Products.ToList();
            vm.Reviews=db.Reviews.ToList();
           
            return View(vm);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Categories()
        {
          var cats=  db.Categories.ToList();
            return View(cats);
        }
        public IActionResult Products(int id)
        {
            var products = db.Products.Where(x => x.catid == id).ToList();
            return View(products);
        }
        [Route("Home/ProductDetails/{id}")]
        public IActionResult ProductDetails(int id)
        {
            var products = db.Products.Include(x=>x.cat).FirstOrDefault(x => x.id == id);
            return View(products);
        }
        //-------------------------------------------------------------------

        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var products =new List<Product>();
            if (string.IsNullOrEmpty(xname))
                products = db.Products.ToList();
            else products=db.Products.Where(x => x.name.Contains(xname)).ToList();
             return View(products);
        }

        [HttpPost]
        public IActionResult sendReview(Review model)
        {
             db.Reviews.Add(new Review { name=model.name,email= model.email,subject= model.subject,description= model.description });
            db.SaveChanges();
            return RedirectToAction("index");
        }
        //-----------------------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
