using AprilBatchMVCProject.Models;
using AprilBatchMVCProject.Repo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AprilBatchMVCProject.Service
{
	public class EmpDAL : EmpRepo
	{
		SqlConnection conn;
		public EmpDAL()
		{
			string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
			conn = new SqlConnection(cs);
			conn.Open();
		}

		public void AddEmp(Emp e)
		{
			string q = $"exec SaveEmp '{e.Name}','{e.Email}','{e.Dept}','{e.Salary}'";
			SqlCommand cmd = new SqlCommand(q, conn);
			cmd.ExecuteNonQuery();
		}

		public List<Emp> FetchEmp()
		{
			string q = "exec FetchEmpData";
			SqlDataAdapter ada = new SqlDataAdapter(q, conn);
			DataTable ds = new DataTable();
			ada.Fill(ds);

			List<Emp> e = new List<Emp>();
			foreach(DataRow r in ds.Rows)
			{
				e.Add(new Emp()
				{
					Id = int.Parse(r["id"].ToString()),
					Name = r["name"].ToString(),
					Email = r["email"].ToString(),
					Dept = r["dept"].ToString(),
					Salary = double.Parse(r["salary"].ToString())
				});
			}

			return e;
		}

		
	}
}