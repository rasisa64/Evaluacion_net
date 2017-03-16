using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeString
{
    public class MoneyParts
    {
        public String[] build(Decimal dato)
        {
            //Decimal dato = 0.1m;
            Decimal[] Var_denominacion = new Decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
            int size = 1, size0 = 0;
            String[] rpta = new String[1];
            Decimal[] rango = Var_denominacion.Where(x => x <= dato).ToArray();

            foreach (Decimal unidad in rango)
            {
                Decimal val_validar = dato % unidad;
                if (val_validar == 0)
                {
                    String varRpta = AgregarItem(unidad.ToString(), int.Parse((dato / unidad).ToString()));
                    rpta[size0] = varRpta;

                    size = size + 1;
                    Array.Resize<String>(ref rpta, size);
                    size0 = size0 + 1;
                }
            }

            return rpta;

        }

        public String AgregarItem(String dato, int cantidad)
        {
            String rpta = "";
            for (int i = 1; i <= cantidad; i++)
            {
                rpta = rpta + dato + ",";
            }
            return rpta;
        }

    }
}
