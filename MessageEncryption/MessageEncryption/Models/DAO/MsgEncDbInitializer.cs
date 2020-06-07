using MessageEncryption.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageEncryption.Models.DAO
{
    /// <summary>
    /// Заполнение базы данными при инициализации
    /// </summary>
	public class MsgEncDbInitializer : DropCreateDatabaseIfModelChanges<MsgEncContext>
	{
        protected override void Seed(MsgEncContext context)
        {
            IList<Replacement> replacements = new List<Replacement>();

            replacements.Add(new Replacement() { OldSymb = "а", NewSymb = "н" });
            replacements.Add(new Replacement() { OldSymb = "б", NewSymb = "к" });
            replacements.Add(new Replacement() { OldSymb = "в", NewSymb = "ы" });

            context.Replacements.AddRange(replacements);

            base.Seed(context);
        }
    }
}