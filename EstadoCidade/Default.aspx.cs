using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ucb.Biblioteca.Model;
using br.ucb.Biblioteca.DTO;

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
            }else
            {
                preencherDropDownCidade();
            }
        }

        protected void preencherDropDownEstado()
        {
            drpEstado.DataSource = estadoModel.listarEstados();
            drpEstado.DataBind();
            drpEstado.Items.Insert(0, "Selecione");
        }

        protected void preencherDropDownCidade()
        {
            if (!drpEstado.SelectedItem.Text.Equals("Selecione"))
            {
                drpCidade.Visible = true;
                txtCidade.Visible = true;
                EstadoDTO dto = new EstadoDTO();
                dto.idEstado = Convert.ToInt64(drpEstado.SelectedItem.Value);
                drpCidade.DataSource = cidadeModel.listarCidadesPorEstado(dto);
                drpCidade.DataBind();
            }else
            {
                drpCidade.Visible = false;
                txtCidade.Visible = false;
            }
        }
    }
}