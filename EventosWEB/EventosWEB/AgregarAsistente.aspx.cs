using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class AgregarAsistente : System.Web.UI.Page
    {
        private IRegionesDAL regionesDAL = new RegionesDALDB();
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.regionDDL.DataSource = this.regionesDAL.ObtenerRegiones();
                this.regionDDL.DataTextField = "Nombre";
                this.regionDDL.DataValueField = "Id";
                this.regionDDL.DataBind();
            }
        }
    }
}