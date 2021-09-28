using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMVCApps.Models;

namespace SampleMVCApps.Controllers
{
    public class OrderController : Controller
    {
        private OrderHandlerModel orderHandler = new OrderHandlerModel();
        private readonly ILogger<OrderController> _logger;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Model = orderHandler;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string senderCity, string senderAddress, string recipientCity,
        string recipientAddress, float weight, DateTime date)
        {
            Order data = new Order(senderCity, senderAddress, recipientCity, recipientAddress, weight, date);
            orderHandler.SaveDataToDB(data);
            ViewBag.Model = orderHandler;
            string testData = $"Login: {senderCity}   Password: {senderAddress}";
            return View(GetDataBase());
        }

        public List<Order> GetDataBase()
        {
            return orderHandler.DataBase;
        }
    }
}
