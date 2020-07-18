using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        //Funcion Math//
        [WebMethod]
        public List<double> MathOperations(double Number)
        {
            var raiz = Math.Sqrt(Number);           
            var abs = Math.Abs(Number);           
            var log = Math.Log10(Number);           
            var expo = Math.Exp(Number);           
            List<double> listado = new List<double>();
            listado.Add(raiz);
            listado.Add(abs);
            listado.Add(log);
            listado.Add(expo);

            return listado;
        }

        //Operaciones basicas//
        [WebMethod]
        public List<int> BasicOperations (int Number, int SecondNumber)
        {
            var sum = Number + SecondNumber;
            var rest = Number - SecondNumber;
            var mul = Number * SecondNumber;
            var div = Number / SecondNumber;
            List<int> listado = new List<int>();
            listado.Add(sum);
            listado.Add(rest);
            listado.Add(mul);
            listado.Add(div);

            return listado;           
        }

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
        public int MaxTwoNumbers(int Number, int SecondNumber)
        {
            List<int> listado = new List<int>() { Number, SecondNumber };

            return listado.Max();
        }

        //Determinar el mayor de 3 numeros//
        [WebMethod]
        public int MaxThreeNumbers(int a, int b, int c)
        {          
            List<int> listado = new List<int>() { a, b, c };

            return listado.Max();
        
        }

        //Compras en restaurant//
        [WebMethod]
        public List<string> Restaurant(string item1, string item2, string item3, string item4)
        {
            Random random = new Random();
            var x = random.Next(500, 1500);
            List<string> listado = new List<string>();
            listado.Add(item1);
            listado.Add(item2);
            listado.Add(item3);
            listado.Add(item4);
            listado.Add(x.ToString());

            return listado;
        }
    }
}
