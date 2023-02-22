using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel account)
        {
            var valueSender = _accountService.TGetbyId(account.SenderId);
            var valueReceiver = _accountService.TGetbyId(account.ReceiveId);

            valueSender.Balance -= account.Amount;
            valueReceiver.Balance += account.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,valueReceiver
            };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
