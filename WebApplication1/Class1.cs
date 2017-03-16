using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        public String build(String dato)
        {
            String var_Rpta = null;
            String var_reemplazo = null;
            var_reemplazo.Replace("a", "b");
            for (int i = 65; i <= 90; i++)
            {

                var_Rpta = var_Rpta + " - " + Convert.ToChar(i);
            }
            return var_Rpta;
        }
    }
}