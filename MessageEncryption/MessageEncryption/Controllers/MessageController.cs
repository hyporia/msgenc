using MessageEncryption.Controllers.Models;
using MessageEncryption.Models;
using MessageEncryption.Models.DAO;
using MessageEncryption.Services;
using MessageEncryption.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MessageEncryption.Controllers
{
	public class MessageController : Controller
	{
		private IMessageService _messageService;
		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}
		// POST: /message/EncryptMessage
		[HttpPost]
		public async Task<JsonResult> EncryptMessage(MessageModel msg)
		{
			try
			{
				if (msg == null || msg.Text == null) { throw new Exception("Неверный запрос"); }
				if (msg.Text.Length == 0) { throw new Exception("Пустое сообщение"); }
				var result = await _messageService.EncryptMessage(msg);
				return Json(new ActionResult<string> { data = result, error = ""});
			}
			catch(Exception ex)
			{
				return Json(new ActionResult<string> { data = null, error = ex.Message } );
			}
		}
	}
}