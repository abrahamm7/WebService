using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class MaxNumbers
    {
        public int MaxTwo(List<int> listado)
        {
            listado.Sort();            
            return  listado.Max();
        }
    }
}