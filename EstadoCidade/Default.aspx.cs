using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ucb.Biblioteca.Model;

namespace EstadoCidade
{
    public partial class _Default : Page
    {
        private EstadoModel estadoModel;
        private CidadeModel cidadeModel;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (estadoModel == null)
                estadoModel = new EstadoModel();
            if (cidadeModel == null)
                cidadeModel = new CidadeModel();
            if (!Page.IsPostBack)
            {
                preencherDropDownEstado();
            }
        }

        protected void preencherDropDownEstado()
        {
            drpEstado.DataSource = estadoModel.listarEstados();
            drpEstado.DataBind();
            if (!drpEstado.SelectedItem.Text.Equals("Selecione"))
                preencherDropDownCidade(drpEstado.SelectedItem);
        }

        protected void preencherDropDownCidade(ListItem item)
        {

        }
    }
}