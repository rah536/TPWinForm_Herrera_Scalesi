using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Form E = new ListadoArticulos();
            E.Show();
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            Form E = new BusquedaArticulos();
            E.Show();
        }
    }
}
