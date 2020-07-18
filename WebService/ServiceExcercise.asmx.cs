using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Models;

namespace WebService
{
    /// <summary>
    /// Summary description for ServiceExcercise
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceExcercise : System.Web.Services.WebService
    {
        //Invertir numeros//
        [WebMethod]
        public string ReverseNumbers(string Number)
        {
            char[] chars = Number.ToCharArray();
            for (int i = 0, j = Number.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }

        //Determinar el mayor de 2 numeros//
        [WebMethod]
        public int MaxTwoNumbers(int a, int b)
        {
            List<int> listado = new List<int>() { a, b };

            return listado.Max();
        }

        //Determinar el mayor de 3 numeros//
        [WebMethod]
        public int MaxThreeNumbers(int a, int b, int c)
        {          
            List<int> listado = new List<int>() { a, b, c };

            return listado.Max();
        }
    }
}
