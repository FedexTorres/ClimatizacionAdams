using ClimatizacionBE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionDAL
{
    public class ProductoDAL
    {
        private Conexion objConexion = new Conexion();

        public void VerProductos(List<ProductoBE> list)
        {
            string sqlvisualizarcliente = "select * from Producto";

            DataTable tabla = objConexion.LeerPorComando(sqlvisualizarcliente);

            foreach (DataRow row in tabla.Rows)
            {
                
                ProductoBE cliente = new ProductoBE()
                {
                    Id = (int)row["Id"],
                    Cantidad = (int)row["Metros_Venta"],
                    Precio = (int)row["Precio_Venta"],
                    Nombre = row["Nombre_Producto"].ToString(),
                    Ansal = (int)row["Codigo_Ansal"]
                };

                list.Add(cliente);
            }
        }

        public bool AgregaProducto(string nombre, string codigo, string precio, string cant)
        {
            string productoagregado = "insert into Producto (Codigo_Ansal, Nombre_Producto, Precio_Venta, Metros_Venta) values (@codigo, @nombre, @precio, @cant)";

            SqlParameter[] agregar = new SqlParameter[]
            {
                new SqlParameter("@codigo",codigo),
                new SqlParameter("@nombre",nombre),
                new SqlParameter("@precio",precio),
                new SqlParameter("@cant",cant)
            };

            int algo = objConexion.EscribirPorComando(productoagregado, agregar);
            //int resultado = objConexion.LeerPorComando(productoagregado);

            if (algo > 0)
            {
                return true;
            }
            else { return false; }

        }

        public DataTable TraerProducto(int num)
        {
            string consulta = $"select * from Producto where Id = {num}";

            DataTable producto = objConexion.LeerPorComando(consulta);

            return producto;
        }

        public bool ModificarProducto(string nombre, string codigo, string precio, string cant, int id)
        {
            string productoagregado = "update Producto set Codigo_Ansal = @codigo, Nombre_Producto = @nombre, Precio_Venta = @precio, Metros_Venta = @cant where Id = @id";

            SqlParameter[] agregar = new SqlParameter[]
            {
                new SqlParameter("@codigo",codigo),
                new SqlParameter("@nombre",nombre),
                new SqlParameter("@precio",precio),
                new SqlParameter("@cant",cant),
                new SqlParameter("@id",id)
            };

            int algo = objConexion.EscribirPorComando(productoagregado, agregar);
            //int resultado = objConexion.LeerPorComando(productoagregado);

            if (algo > 0)
            {
                return true;
            }
            else { return false; }

        }
    }
}
