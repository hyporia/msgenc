using MessageEncryption.Controllers.Models;
using MessageEncryption.Models;
using MessageEncryption.Models.DAO;
using MessageEncryption.Services.Interfaces;
using MessageEncryption.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MessageEncryption.Services
{
	/// <summary>
	/// Сервис для сообщений
	/// </summary>
	public class MessageService : IMessageService
	{
		private UnitOfWork uow = new UnitOfWork();
		/// <summary>
		/// Сохранение исходного сообщения в базе и зашифровка сообщения
		/// </summary>
		/// <param name="msg">Модель с исходным сообщением</param>
		/// <returns>зашифрованное сообщеник</returns>
		public async Task<string> EncryptMessage(MessageModel msg)
		{

			var normalMessage = new Message { Text = msg.Text, RcvTime = DateTime.Now };
			uow.MessageRepository.Insert(normalMessage);
			uow.Save();

			var replacements = await uow.ReplacementRepository.GetAsync();
			var replDict = replacements.ToDictionary(x => x.OldSymb[0], x => x.NewSymb[0]);

			var encryptedText = Encryptor.Encrypt(msg.Text, replDict);

			return encryptedText;
		}
	}
}