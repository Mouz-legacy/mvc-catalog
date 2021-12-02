using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_953502_Strelets.Data;
using Web_953502_Strelets.Extensions;
using Web_953502_Strelets.Models;

namespace Web_953502_Strelets.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private string cartKey = "cart";
        private Cart _cart;

        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }
        public IActionResult Index()
        {
            // = HttpContext.Session.Get<Cart>(cartKey);
            return View(_cart.Items.Values);
        }
        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
           // _cart = HttpContext.Session.Get<Cart>(cartKey);
            var item = _context.Cars.Find(id);
            if (item != null)
            {
                _cart.AddToCart(item);
               // HttpContext.Session.Set<Cart>(cartKey, _cart);
            }
            return Redirect(returnUrl);
        }
    }
}
