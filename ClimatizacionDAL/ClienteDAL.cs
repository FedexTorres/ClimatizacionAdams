using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionDAL
{
    public class ClienteDAL
    {
        private Conexion objConexion = new Conexion();

        public DataTable TraerClientesDAL()
        {
            string consulta = "select * from Clientes";

            DataTable producto = objConexion.LeerPorComando(consulta);

            return producto;
        }

        public DataTable ObtenerClientePorNombre(string nombre)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sql = "SELECT * FROM Clientes WHERE Nombre LIKE @nombre";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", "%" + nombre + "%")
                };

                DataTable dtUsuarios = objConexion.LeerPorComando(sql, parametros);
                //objConexion.Desconectar();
                return dtUsuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool AgregaCliente(string nombre, string direccion)
        {
            string productoagregado = "insert into Clientes (Nombre, Direccion) values (@nombre, @direccion)";

            SqlParameter[] agregar = new SqlParameter[]
            {
                new SqlParameter("@direccion",direccion),
                new SqlParameter("@nombre",nombre)
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
