using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace adminpanel.ecommercecom.Pages;

[PageAuthorize(typeof(categoryRow))]
public class categoryPage : Controller
{
    [Route("ecommercecom/category")]
    public ActionResult Index()
    {
        return this.GridPage<categoryRow>("@/ecommercecom/category/categoryPage");
    }
}