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
    public partial class AgregarArticulos : Form
    {
        private Articulo articulo = null;
        
        
        public AgregarArticulos()
        {
            InitializeComponent();
        }

        public AgregarArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                
                
                articuloNegocio.agregar(articulo);
                
                MessageBox.Show("Articulo agregado exitosamente");
                Close();
            
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarArticulos_Load(object sender, EventArgs e)
        {
           CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 
           MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre.ToString();
                    txtDescripcion.Text = articulo.Descripcion.ToString();
                    //txtUrlImagen.Text = articulo.ImagenUrl.ToString();
                    txtPrecio.Text = articulo.Precio.ToString();

                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
