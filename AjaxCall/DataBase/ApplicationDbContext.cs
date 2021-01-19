using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCall.DataBase
{
    public class ApplicationDbContext
    {
        private static string connectionString = "Server=192.168.50.129;Database=DocPractice;User Id=sa;password=dbsecret123!@#;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public static string cName { get => connectionString; }


    }
}
