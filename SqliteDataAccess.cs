using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace StudentuSarasas
{
	public class SqliteDataAccess
	{
		public static List<StudentasModel> LoadStudentai()
		{
			using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
			{
				var output = con.Query<StudentasModel>("select * from studentai", new DynamicParameters());
				return output.ToList();
			}
		}
		public static void SaveStudentas(StudentasModel s)
		{
			using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
			{
				con.Execute("insert into studentai (vardas, pavarde, nuotrauka) values (@vardas, @pavarde, @nuotrauka)", s);
			}
		}
		public static void DeleteStudentas(StudentasModel s)
		{
			using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
			{
				con.Execute("delete from studentai where id = @Id", s);
			}
		}
		public static void EditStudentas(StudentasModel s)
		{
			using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
			{
				con.Execute("update studentai set vardas = @vardas, pavarde = @pavarde, nuotrauka = @nuotrauka where id = @Id", s);
			}
		}
		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
