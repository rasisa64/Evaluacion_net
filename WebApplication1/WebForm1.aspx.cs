using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using ChangeString;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPregunta1_Click(object sender, EventArgs e)
        {
            string cadena = "* abcdefghijklllmnñopqrstuvwxyz";
            ChangeString.ChangeString obj = new ChangeString.ChangeString();
            
            lblRpta.Text = obj.build(cadena);

        }

        protected void btnPregunta2_Click(object sender, EventArgs e)
        {
            int[] valores = { 5, 2, 6, 2 };
            Array.Sort(valores);
            int var_fin = valores[valores.Length - 1];
            int[] rpta = new int[var_fin];

            ChangeString.CompleteRange obj = new ChangeString.CompleteRange();
            lblRpta.Text = obj.build(valores).ToString();

        }


        protected void btnPregunta3_Click(object sender, EventArgs e)
        {
            Decimal dato = 0.1m;
            ChangeString.MoneyParts obj = new ChangeString.MoneyParts();
            obj.build(dato);
        }

    }
}
 