using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCap
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }

        protected void cargagrilla()
        {
            List<Cliente> clientes = clientesDAL.Obtener();
            this.grillaCliente.DataSource = clientes;
            this.grillaCliente.DataBind();
        }

        protected void grillaCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="elimina")
            {
                //significa que el usuario apreto boton
                //por lo tanto, eliminar el cliente

                string rut = Convert.ToString(e.CommandArgument);
                clientesDAL.Eliminar(rut);
                cargagrilla();
            }
        }
    }
}