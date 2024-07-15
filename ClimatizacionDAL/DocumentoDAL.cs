using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionDAL
{
    public class DocumentoDAL
    {
        private Conexion objConexion = new Conexion();
        public DataTable TiposDeDocumentos()
        {
            string consulta = "select * from Tipo_Documento";

            DataTable tipos = objConexion.LeerPorComando(consulta);

            return tipos;
        }

        public bool AgregarDocumento(string codigo,int tipo, int cliente, DateTime fecha, string lugar, string montoT, string montoMO, string montoMA)
        {
            string productoagregado = "insert into Documento (Codigo_Asignado, Id_Tipo_Documento, Id_Cliente, Fecha, Lugar, Monto_Mano_de_Obra, Monto_Materiales, Monto_Total) values (@codigo, @tipo, @cliente, @fecha, @lugar, @montoMO, @montoMA, @montoT)";

            SqlParameter[] agregar = new SqlParameter[]
            {
                new SqlParameter("@codigo",codigo),
                new SqlParameter("@tipo",tipo),
                new SqlParameter("@cliente",cliente),
                new SqlParameter("@fecha",fecha),
                new SqlParameter("@lugar",lugar),
                new SqlParameter("@montoMO",montoMO),
                new SqlParameter("@montoMA",montoMA),
                new SqlParameter("@montoT",montoT)
            };

            int algo = objConexion.EscribirPorComando(productoagregado, agregar);

            if (algo > 0)
            {
                return true;
            }
            else { return false; }

        }

        public DataTable ListaPorTipo(int tipo)
        {
            string consulta = $"select * from Documento where Id_Tipo_Documento = {tipo}";

            DataTable tipos = objConexion.LeerPorComando(consulta);

            return tipos;
        }

        public DataTable ObtenerDocumentoPorNombre(string nombre)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sql = "spTraerDocumentos";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", nombre)
                };

                DataTable dtDocumentos = objConexion.LeerPorStoreProcedure(sql, parametros);
                //objConexion.Desconectar();
                return dtDocumentos;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string AgregarRuta(byte[] archivo, string extencion, string codigo)
        {
            string documentoeditado = "update Documento set Archivo = @archivo, Extencion = @extencion where Codigo_Asignado = @codigo";

            SqlParameter[] agregar = new SqlParameter[]
            {
                new SqlParameter("@archivo",archivo),
                new SqlParameter("@extencion",extencion),
                new SqlParameter("@codigo",codigo)
            };

            int algo = objConexion.EscribirPorComando(documentoeditado, agregar);
            //int resultado = objConexion.LeerPorComando(productoagregado);

            if (algo > 0)
            {
                return "Ruta Agregada";
            }
            else { return "Error al agregar Ruta"; }
        }

        public DataTable ObtenerDocumentoParaVer(string nombre)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sql = "select * from Documento where Codigo_Asignado like @nombre";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", "%"+nombre+"%")
                };

                //DataTable dtDocumentos = objConexion.LeerPorStoreProcedure(sql, parametros);
                DataTable dtDocumentos = objConexion.LeerPorComando(sql,parametros);
                //objConexion.Desconectar();
                return dtDocumentos;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
