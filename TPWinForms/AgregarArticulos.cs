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
            Text = "Modificar Articulo";
            this.BackColor = SystemColors.ControlDark;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();


            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                
                if(string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Ingrese código del artículo");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese Nombre del artículo");
                    return;
                }


                foreach (char caracter in txtPrecio.Text)
                {
                    if(!(char.IsNumber(caracter)))
                     {
                        MessageBox.Show("Ingrese solo números en precio del artículo");
                        return;
                     }
                }
               

                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese precio del artículo");
                    return;
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;


                if (articulo.Id != 0) { 

                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");

                    ListadoArticulos listadoArticulos = new ListadoArticulos();
                    //listadoArticulos.
                
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }
                
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
                    txtUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarImagen(string imagen)
        {

            try
            {
                pbUrlImagenMod.Load(imagen);
                

            }

            catch (Exception)
            {
                pbUrlImagenMod.Load("https://educacionprivada.org/wp-content/plugins/all-in-one-video-gallery/public/assets/images/placeholder-image.png");
            }

        }

        private void pbUrlImagenMod_Click(object sender, EventArgs e)
        {

        }
    }
}
