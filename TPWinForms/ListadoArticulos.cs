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
        private List<Articulo> listaArticulo;

        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {

            ArticuloNegocio articulo = new ArticuloNegocio();
            listaArticulo = articulo.listar();
            dgvListadoArticulos.DataSource = listaArticulo;

            cargarImagen(listaArticulo[0].ImagenUrl);
            

            dgvListadoArticulos.Columns["Id"].Visible = false;
            dgvListadoArticulos.Columns["IdMarca"].Visible = false;
            dgvListadoArticulos.Columns["IdCategoria"].Visible = false;
            dgvListadoArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            
            
            Form modificar = new AgregarArticulos(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Form E = new EliminarArticulos();
            //E.ShowDialog();

            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                articulo.eliminar(seleccionado.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            
            List<Articulo> listaFiltrada;

            listaFiltrada = listaArticulo.FindAll(x => x.Nombre == txtFiltro.Text);

            dgvListadoArticulos.DataSource = null;
            dgvListadoArticulos.DataSource = listaFiltrada;
            
            
        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
           
        }
    
     
        private void cargarImagen(string imagen)
        {

            try
            {
                pbUrlImagen.Load(imagen);

            }

            catch (Exception)
            {
                pbUrlImagen.Load("https://educacionprivada.org/wp-content/plugins/all-in-one-video-gallery/public/assets/images/placeholder-image.png");
            }
            
        }
    
    
    }
}
