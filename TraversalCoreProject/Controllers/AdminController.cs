using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult _header()
        {
            return PartialView();
        }
        public PartialViewResult _appBrandDemo()
        {
            return PartialView();
        }
        public PartialViewResult _sideBar()
        {
            return PartialView();
        }

        public PartialViewResult _navbar()
        {
            return PartialView();
        }
        public PartialViewResult _footer()
        {
            return PartialView();
        }
        public PartialViewResult _script()
        {
            return PartialView();
        }
    }
}
