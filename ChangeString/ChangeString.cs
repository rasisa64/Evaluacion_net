using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ChangeString
{
    public class ChangeString
    {
        public String build(String cadena) {
            String var_letra = null;
            String var_Total = null;
            String var_letraEspecial = null;
            int var_remp = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                var_letra = cadena.Substring(i, 1);

                Regex r = new Regex("^[A-Za-z_áéíóúñ_ÁÉÍÓÚÑ]+$");
                if (r.IsMatch(var_letra) == true)
                {
                    if (var_letra == "z")
                        var_letraEspecial = "a";
                    else if (var_letra == "Z")
                        var_letraEspecial = "A";
                    else if (var_letra == "ñ")
                        var_letraEspecial = "o";
                    else if (var_letra == "Ñ")
                        var_letraEspecial = "O";
                    else if (var_letra == "n")
                        var_letraEspecial = "ñ";
                    else if (var_letra == "N")
                        var_letraEspecial = "Ñ";
                    else if (var_letra == "á")
                        var_letraEspecial = "b";
                    else if (var_letra == "é")
                        var_letraEspecial = "f";
                    else if (var_letra == "í")
                        var_letraEspecial = "j";
                    else if (var_letra == "ó")
                        var_letraEspecial = "p";
                    else if (var_letra == "ú")
                        var_letraEspecial = "v";
                    else if (var_letra == "Á")
                        var_letraEspecial = "B";
                    else if (var_letra == "É")
                        var_letraEspecial = "F";
                    else if (var_letra == "Í")
                        var_letraEspecial = "J";
                    else if (var_letra == "Ó")
                        var_letraEspecial = "P";
                    else if (var_letra == "Ú")
                        var_letraEspecial = "V";
                    else
                    {
                        var_remp = System.Text.Encoding.ASCII.GetBytes(var_letra)[0];
                        var_letraEspecial = Convert.ToChar(var_remp + 1).ToString();
                    }

                    var_Total = var_Total + var_letraEspecial;
                }
                else
                {
                    var_Total = var_Total + var_letra;
                }
            }
            return var_Total;
        }


    }
}
