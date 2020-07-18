using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Operations
    {
        public List<int> BasicOperations(int a, int b)
        {
            List<int> listado = new List<int>();
            var sum = a + b;          
            var rest = a - b;
            listado.Add(sum);
            listado.Add(rest);
            return listado;
        }
    }
}