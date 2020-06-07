using MessageEncryption.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MessageEncryption.Utils
{
	/// <summary>
	/// Класс для шифрования
	/// </summary>
	public static class Encryptor
	{
		/// <summary>
		/// Шифрование сообщения
		/// </summary>
		/// <param name="message">исходное сообщение</param>
		/// <param name="replDict">словарь замен, ключ - старый символ, значение - новый символ</param>
		/// <returns>зашифрованное сообщение</returns>
		public static string Encrypt(string message, Dictionary<char, char> replDict)
		{
			var encryptedText = new StringBuilder(message);
			for (int i = 0; i < encryptedText.Length; i++)
			{
				if (replDict.ContainsKey(encryptedText[i])) encryptedText[i] = replDict[encryptedText[i]];
			}
			return encryptedText.ToString();
		}
	}
}