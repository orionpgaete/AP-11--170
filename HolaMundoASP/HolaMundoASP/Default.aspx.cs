using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saludarBtn_Click(object sender, EventArgs e)
        {
            //Para los asp componets, la propuiedad para obtener valor es TEXT
            string nombre = this.nombreTxt.Text.Trim();

            //Para los HTML Elements, la propiedad es InnerText
            this.mensajeH1.InnerText = "Hola "+nombre+" , para de faltar a clases....";
        }
    }
}