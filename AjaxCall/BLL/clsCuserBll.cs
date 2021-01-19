using AjaxCall.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCall.BLL
{
    public class clsCuserBll
    {
        clsCuserDal objdl = new clsCuserDal();
        //public DataTable GetCountryAll1()
        //{
        //    DataTable dt = new DataTable();
        //    dt = objdl.GetCountryAll1(this);
        //    return dt;
        //}
        public DataTable GetCountryAll1(int ID)
        {
            return objdl.GetCountryAll1(ID);
        }

    }
}
