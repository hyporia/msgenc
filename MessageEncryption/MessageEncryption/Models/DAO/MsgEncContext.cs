using MessageEncryption.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageEncryption.Models.DataContext
{
	public class MsgEncContext : DbContext
	{
		public MsgEncContext() : base("msgenc") { Database.SetInitializer(new MsgEncDbInitializer()); }
		public DbSet<Replacement> Replacements { get; set; }
		public DbSet<Message> Messages { get; set; }
	}
}