using ClimatizacionDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionAdams
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public DataTable TraerClientes()
        {
            return clienteDAL.TraerClientesDAL();
        }

        public bool ClienteAgregado(string nombre, string direccion)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }

                ClienteDAL clienteDAL = new ClienteDAL();

                bool resultado = clienteDAL.AgregaCliente(nombre, direccion);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error: " + ex.Message);
            } 
        }

        public DataTable ObtenerCliente(string nombre)
        {
            return clienteDAL.ObtenerClientePorNombre(nombre);
        }
    }
}
