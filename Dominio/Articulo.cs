using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        private int Id { get; set; }

        private string Codigo { get; set; }

        private string Nombre { get; set; }

        private string Descripcion { get; set; }

        private int Idmarca { get; set; }

        private int IdCategoria { get; set; }

        private string ImagenUrl { get; set; }

        private float Precio  { get; set; }



    }
}
