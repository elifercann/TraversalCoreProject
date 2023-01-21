using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.Id = item.AnnouncementId;
                announcementListViewModel.Content = item.Content;
                announcementListViewModel.Title = item.Title;

                model.Add(announcementListViewModel);

            }
            return View(model);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(string a)
        {

            return View();
        }
    }
}
