using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BinaryConverterService
{
    /// <summary>
    /// C# version of https://github.com/PlainIntricacy/Binary_Converter delivered as a web service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BinaryConverterService : System.Web.Services.WebService
    {

        [WebMethod]
        //Receives an integer as input, and returns its binary equivalent as a string.
        public string DecimalToBinary(int input)
        {
            return Convert.ToString(input, 2);
        }
        [WebMethod]
        //Receives a binary string as input, and returns its integer equivalent.
        public int BinaryToDecimal(string input)
        {
            return Convert.ToInt32(input, 2);
        }
    }
}
