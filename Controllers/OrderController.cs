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
        private OrderStorage orderStorage = new OrderStorage();
        private readonly ILogger<OrderController> _logger;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return BuildResponse();
        }

        [HttpPost]
        public IActionResult Index(string senderCity, string senderAddress, string recipientCity,
        string recipientAddress, float weight, DateTime date)
        {
            Order order = new Order(senderCity, senderAddress, recipientCity, recipientAddress, weight, date);
            orderStorage.SaveOrder(order);
            return BuildResponse();
        }

        private IActionResult BuildResponse()
        {
            ViewBag.Orders = orderStorage.GetAllOrders();
            return View();
        }
    }
}
