using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
    
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {

                 datos.setearConsulta("select a.codigo,a.nombre,a.descripcion,c.descripcion as categoria,m.descripcion as marca,a.precio from articulos as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id");
                 datos.ejecutarLectura();

                 while (datos.Lector.Read())
                 {
                   
                    Articulo aux = new Articulo();
                    
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["marca"];

                    lista.Add(aux);

                }
                 
                 return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregar (Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            
            
            try
            {
                accesoDatos.setearConsulta("insert into dbo.ARTICULOS (Codigo, Nombre,Descripcion,ImagenUrl,Precio,IdMarca,IdCategoria) values('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "', '" + articulo.ImagenUrl + "'," + articulo.Precio + " , @IdMarca, @IdCategoria)");
                accesoDatos.setearParametro("@IdMarca",articulo.Marca.Id);
                accesoDatos.setearParametro("@IdCategoria",articulo.Categoria.Id);
                
                accesoDatos.ejecutarAccion();
            
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoDatos.cerrarConexion();   
            }
        }
    
    }
}
