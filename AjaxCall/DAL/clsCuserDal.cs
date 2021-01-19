using AjaxCall.DataBase;
using AjaxCall.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCall.DAL
{
    public class clsCuserDal
    {
        string _connectionStrings = ApplicationDbContext.cName;

        public IEnumerable<CUser> GetUserCountry()
        {
            List<CUser> cuslist = new List<CUser>();
            using (SqlConnection connection = new SqlConnection(_connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("DocumentListbox", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CUser stu = new CUser();
                    stu.ID = Convert.ToInt32(rdr["ID"]);
                    stu.DESCRIPTION = rdr["DESCRIPTION"].ToString();
                    cuslist.Add(stu);
                }
                connection.Close();
            }
            return cuslist;

        }


        public DataTable GetCountryAll1(int ID)
        {
            CUser conlist = new CUser();
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("DocumentListbox", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CONCODE", ID);
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    conlist.ID = Convert.ToInt32(rdr["ID"]);
                    conlist.DESCRIPTION = rdr["DESCRIPTION"].ToString();                  
                }
            }
            if (dt != null)
            {

            }
            return dt;
        }


        public void InsertUser(CUser u)
        {
            using (SqlConnection connection = new SqlConnection(_connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("InsertDocAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(u.ID));
                cmd.Parameters.AddWithValue("@CONCODE", Convert.ToInt32(u.CONCODE));
                cmd.Parameters.AddWithValue("@DESCRIPTION", u.DESCRIPTION);
                cmd.Parameters.AddWithValue("@NDESCRIPTION", u.NDESCRIPTION);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
