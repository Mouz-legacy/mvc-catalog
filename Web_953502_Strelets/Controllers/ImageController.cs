using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web_953502_Strelets.Entities;

namespace Web_953502_Strelets.Controllers
{
    public class ImageController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IWebHostEnvironment env;

        public ImageController(UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            this.env = env;
            this.userManager = userManager;
        }

        public async Task<FileResult> GetAvatar()
        {
            var user = await userManager.GetUserAsync(User);
            if (user.AvatarImage != null)
            {
                return File(user.AvatarImage, "image/...");
            }
            else
            {
                var avatarPath = "/Images/anonymous.png";

                return File(env.WebRootFileProvider.GetFileInfo(avatarPath).CreateReadStream(), "image/...");
            }
        }
    }
}
