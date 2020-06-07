using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageEncryption.Controllers.Models
{
	/// <summary>
	/// Простой класс-обертка для ответа сервера
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class ActionResult<T> 
	{
		public T data { get; set; }
		public string error { get; set; }
	}
}