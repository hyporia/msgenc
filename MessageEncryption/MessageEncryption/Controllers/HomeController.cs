using MessageEncryption.Models;
using MessageEncryption.Models.DAO;
using MessageEncryption.Models.DataContext;
using MessageEncryption.Services.Interfaces;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageEncryption.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}