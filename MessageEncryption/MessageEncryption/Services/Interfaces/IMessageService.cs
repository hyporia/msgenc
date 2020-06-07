using MessageEncryption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageEncryption.Controllers.Models;

namespace MessageEncryption.Services.Interfaces
{
	public interface IMessageService
	{
		/// <summary>
		/// Зашифорвка сообщения
		/// </summary>
		/// <returns></returns>
		Task<string> EncryptMessage(MessageModel msg);
	}
}
