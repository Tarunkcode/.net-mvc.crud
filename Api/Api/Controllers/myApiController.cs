using Api.Models;
using ESCommon;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class myApiController : ApiController
    {
        string ConnStr = ConfigurationManager.ConnectionStrings["DataCon"].ToString();

        public dynamic MyApi(string FID)
        {

            try
            {
                string MainQry = "select ClientName from dbo.FeedbackData where FID= '" + FID + "'";
                SQLHELPER dl = new SQLHELPER(ConnStr);

                bool connresult = dl.Connect();
                if (connresult)
                {
                    DataTable dtt = dl.getTable(MainQry);
                    if (dtt != null && dtt.Rows.Count > 0)
                    {
                        ClientDetails cl = new ClientDetails();

                        cl.ClientName = clsMain.MyString(dtt.Rows[0]["ClientDetails"]);
                        return new { state = 1, Msg = true, Data = cl };
                    }
                    else
                    {
                        return new { state = -2, Msg = false, Data = "table has no elements" };
                    }
                }
                else
                {
                    return new { state = -1, Msg = false, Data = "Database connection failed" };
                }
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = false, Data = ex.Message.ToString() };

            }

        }
    }
}
