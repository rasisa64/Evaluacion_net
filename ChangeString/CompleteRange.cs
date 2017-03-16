using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeString
{
    public class CompleteRange
    {
        public int[] build(int[] valores) 
        {
            Array.Sort(valores);
            int var_fin = valores[valores.Length - 1];
            int[] rpta = new int[var_fin];
            int contador = 0;
            int k = 1;

            for (int i = 0; i < valores.Length; i++)
            {
                int var_buscar = valores[i] - 1;
                int pos = Array.IndexOf(rpta, var_buscar);
                int num = Array.IndexOf(rpta, valores[i]);

                if ((num > -1 || rpta[0] == 0) && pos == -1)
                {
                    for (k = 1; k <= valores[i]; k++)
                    {
                        rpta[contador] = k;
                        contador += 1;
                    }

                }
                else
                {
                    if (num == -1)
                    {
                        for (int m = k; m <= valores[i]; m++)
                        {
                            rpta[contador] = m;
                            contador += 1;

                        }
                        k = valores[i] + 1;
                    }

                }
            }

            return rpta;

        }



    }
}
