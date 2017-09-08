using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Web.Models;

namespace Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {      
        // GET: User
        public ActionResult Index()
        {            
            var ctx = Request.GetOwinContext().Get<ApplicationDbContext>();
            var users = ctx.Users;

            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
            var users2 = manager.Users.ToList();
           
            return View(users2);
        }

        public ActionResult Perfil()
        {
            /*var IdUsuarioLogeado = User.Identity.GetUserId();
            
            var ctx = Request.GetOwinContext().Get<ApplicationDbContext>();
            var users = ctx.Users.Where(x => x.Id == IdUsuarioLogeado);

            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
            var users2 = manager.Users;*/
            var ctx = Request.GetOwinContext().Get<ApplicationDbContext>();
            string IdUser = User.Identity.GetUserId();
            ApplicationUser Logueado = ctx.Users.FirstOrDefault(x => x.Id == IdUser);
            return View(Logueado);
        }
    }
}