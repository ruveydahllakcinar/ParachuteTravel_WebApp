using BusinessLayer.Abstract.AbstractUnitOfWork;
using DTOLayer.DTOs.AccountDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountUOWService _accountUOWService;

        public AccountController(IAccountUOWService accountUOWService)
        {
            _accountUOWService = accountUOWService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var sender = _accountUOWService.TGetById(model.SenderId);
            var receiver = _accountUOWService.TGetById(model.ReceiverId);
            sender.Balance -= model.Amount;
            receiver.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                sender,
                receiver
            };
            _accountUOWService.TMultiUpdate(modifiedAccounts);

            return RedirectToAction("Index");
        }
    }
}
