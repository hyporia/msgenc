using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageEncryption.Models
{
	public class Message
	{
		/// <summary>
		/// Id
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Текст сообщения
		/// </summary>
		[Required]
		public string Text { get; set; }
		/// <summary>
		/// Время получения
		/// </summary>
		public DateTime RcvTime { get; set; }

	}
}