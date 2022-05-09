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

                 datos.setearConsulta("select a.Id,a.ImagenUrl,a.codigo,a.nombre,a.descripcion,c.descripcion as categoria,m.descripcion as marca,a.precio,a.IdMarca,a.IdCategoria from articulos as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id");
                 datos.ejecutarLectura();

                 while (datos.Lector.Read())
                 {
                   
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];



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
    
        public void eliminar(int id)
        {
            try 
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from articulos where id = @id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            
            try
            {
                accesoDatos.setearConsulta("update articulos set codigo = @codigo,nombre = @nombre,descripcion = @descripcion, precio = @precio where id =@Id");
                accesoDatos.setearParametro("@codigo", articulo.Codigo);
                accesoDatos.setearParametro("@nombre",articulo.Nombre );
                accesoDatos.setearParametro("@descripcion",articulo.Descripcion );
                //accesoDatos.setearParametro("@urlimagen",articulo.ImagenUrl );
                accesoDatos.setearParametro("@precio", articulo.Precio);
                accesoDatos.setearParametro("@Id", articulo.Id);
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Articulo listarDetalle(int id)
        {
           
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select a.id,a.codigo,a.nombre,a.descripcion,a.imagenurl,a.precio,c.descripcion as categoria, a.idcategoria, m.descripcion as marca, a.idmarca from articulos as a inner join categorias as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id where a.id = " + id);
                datos.ejecutarLectura();

                Articulo aux = new Articulo();
                if (datos.Lector.Read())
                {

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                }
                return aux;

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
    }
}
