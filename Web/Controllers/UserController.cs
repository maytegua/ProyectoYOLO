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
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: User
        public ActionResult Index()
        {
            // LISTAR USUARIOS DE ASPNETUSERS
            /*var ctx = Request.GetOwinContext().Get<ApplicationDbContext>();
            var users = ctx.Users;

            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
            var users2 = manager.Users.ToList(); */
           
            return View();
        }

        public ActionResult Perfil()
        {           
            // Contexto para recuperar el Usuario Logueado Actualmente
            var ctx = Request.GetOwinContext().Get<ApplicationDbContext>();
            string IdUser = User.Identity.GetUserId();

            ApplicationUser Logueado = ctx.Users.FirstOrDefault(x => x.Id == IdUser);
            return View(Logueado);
        }

        public ActionResult Viajes()
        {
            return View();
        }

        public ActionResult Mapa()
        {
            return View();
        }
    }
}