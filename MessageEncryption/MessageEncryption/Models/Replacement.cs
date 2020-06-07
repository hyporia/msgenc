using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MessageEncryption.Models
{
	public class Replacement
	{
		/// <summary>
		/// Id
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Заменяемый символ
		/// </summary>
		[Required, MaxLength(1)]
		public string OldSymb { get; set; }
		/// <summary>
		/// Заменяющий символ
		/// </summary>
		[Required, MaxLength(1)]
		public string NewSymb { get; set; }
	}
}