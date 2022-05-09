using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForms
{
    public partial class DetalleArticulos : Form
    {
        Articulo articulo = new Articulo();
        public DetalleArticulos()
        {
            InitializeComponent();
        }
        public DetalleArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void DetalleArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articulo = articuloNegocio.listarDetalle(articulo.Id);

            lblMuestraIdArticulo.Text = articulo.Id.ToString();
            lblMuestraNombre.Text = articulo.Nombre;
            lblMuestraCodigo.Text = articulo.Codigo;

            lblMuestraIdMarca.Text = articulo.Marca.Id.ToString();
            lblMuestraMarca.Text = articulo.Marca.Descripcion;
            lblMuestraIdCategoria.Text = articulo.Categoria.Id.ToString();
            lblMuestraCategoria.Text = articulo.Categoria.Descripcion;
            
            lblMuestraPrecio.Text = articulo.Precio.ToString();
            lblMuestraUrlImagen.Text = articulo.ImagenUrl;
            lblMuestraDescripcion.Text = articulo.Descripcion;

            try
            {
                pbImagenUrl.Load(articulo.ImagenUrl);


            }

            catch (Exception)
            {
                pbImagenUrl.Load("https://educacionprivada.org/wp-content/plugins/all-in-one-video-gallery/public/assets/images/placeholder-image.png");
            }


           
        }

        private void pbImagenUrl_Click(object sender, EventArgs e)
        {

        }
    }
}
