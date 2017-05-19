using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BinaryConverterService
{
    /// <summary>
    /// Summary description for BinaryConverterService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BinaryConverterService : System.Web.Services.WebService
    {

        [WebMethod]
        public string DecimalToBinary(int input)
        {
            return "";
        }
        [WebMethod]
        public string BinaryToDecimal(string input)
        {
            return "";
        }
    }
}
