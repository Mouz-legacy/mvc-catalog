using Microsoft.AspNetCore.Mvc;
using Web_953502_Strelets.Extensions;
using Web_953502_Strelets.Models;

namespace Web_953502_Strelets.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;

        public CartViewComponent(Cart cart)
        {
            this._cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
