using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPWinForms
{
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            dgvListadoArticulos.DataSource = articulo.listar();

            dgvListadoArticulos.Columns["Id"].Visible = false;
            dgvListadoArticulos.Columns["IdMarca"].Visible = false;
            dgvListadoArticulos.Columns["IdCategoria"].Visible = false;
            dgvListadoArticulos.Columns["ImagenUrl"].Visible = false;
        }
    }
}
