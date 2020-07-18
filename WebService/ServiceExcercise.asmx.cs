using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
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
        public string MaxTwoNumbers(int Number, int SecondNumber)
        {
            List<MaxTwo> listado = new List<MaxTwo>();
            if (Number > SecondNumber)
            {
                listado.Add(new MaxTwo { firstnumber = Number, secondnumber = SecondNumber, max = Number });
                var text = JsonConvert.SerializeObject(listado, Newtonsoft.Json.Formatting.Indented);
                return text;
            }
            else
            {
                listado.Add(new MaxTwo { firstnumber = Number, secondnumber = SecondNumber, max = SecondNumber });
                var text = JsonConvert.SerializeObject(listado, Newtonsoft.Json.Formatting.Indented);
                return text;
            }
            
            
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
        public string Restaurant(string item1, string item2, string item3, string item4)
        {
            Random random = new Random();
            var x = random.Next(500, 1500);
            List<Purchase> listado = new List<Purchase>();
            listado.Add(new Purchase { item = item1});
            listado.Add(new Purchase { item = item2});
            listado.Add(new Purchase { item = item3});
            listado.Add(new Purchase { item = item4});
            listado.Add(new Purchase { price = x});

            var text = JsonConvert.SerializeObject(listado, Newtonsoft.Json.Formatting.Indented);

            return text;
        }

        //Formatos de salida//
        [WebMethod]
        public string Formats()
        {
            List<Formats> listado = new List<Formats>();
            var x = DateTime.Now;           
            listado.Add(new Formats { mdy = string.Format("Fecha en formato: {0:MM / dd / yyyy}", x),
            dmy = string.Format("Fecha en formato: {0:dddd, dd MMMM yyyy}", x), hm = string.Format("Fecha en formato: {0:HH:mm}", x), 
            ymd = string.Format("Fecha en formato: {0:yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK}", x)});

            var text = JsonConvert.SerializeObject(listado, Newtonsoft.Json.Formatting.Indented);
            return text;
        }

        //Ejercicio propuesto//
        [WebMethod]
        public int EjerPropuesto(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}
