using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Web_953502_Strelets.Data;
using Web_953502_Strelets.Entities;
using Web_953502_Strelets.Extensions;
using Web_953502_Strelets.Models;

namespace Web_953502_Strelets.Controllers
{
    public class ProductController : Controller
    {
        private const int MinPageSize = 3;
        private ApplicationDbContext _context;
        private ILogger logger;
        private int pageSize;

        public ProductController(ApplicationDbContext context, ILogger<ProductController> logger)
        {
            this.pageSize = MinPageSize;
            this._context = context;
            this.logger = logger;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{page}")]
        public ActionResult Index(int? group, int page = 1)
        {
            var carsFiltered = _context.Cars.Where(d => !group.HasValue || d.CarGroupId == group.Value);
            // logger.LogInformation($"info: group={group}, page={page}");

            ViewData["Groups"] = _context.CarGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            var model = ListViewModel<Car>.GetModel(carsFiltered, page, pageSize);

            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
    }
}