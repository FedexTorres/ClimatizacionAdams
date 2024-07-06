using ClimatizacionDAL;
using ClimatizacionBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace ClimatizacionAdams
{
    public class DocumentoBLL
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        private DocumentoDAL documentoDAL = new DocumentoDAL();

        public List<ClienteBE> TraerListClientes()
        {
            List<ClienteBE> myList = new List<ClienteBE>();
            DataTable clientes = clienteDAL.TraerClientesDAL();
            foreach (DataRow cliente in clientes.Rows)
            {
                ClienteBE clienteBE = new ClienteBE()
                {
                    Nombre = cliente["Nombre"].ToString(),
                    Id = (int)cliente["Id"],
                    Direccion = cliente["Direccion"].ToString()
                };
                myList.Add(clienteBE);
            }
            return myList;
        } 

        public List<TipoDocumentoBE> LosTipos()
        {
            DataTable dataTable = documentoDAL.TiposDeDocumentos();
            List<TipoDocumentoBE> tipos = new List<TipoDocumentoBE>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                TipoDocumentoBE tipoDocumentoBE = new TipoDocumentoBE()
                {
                    ID = (int)dataRow["Id"],
                    Nombre = dataRow["Tipo"].ToString(),
                    ABR = dataRow["Tipo_Acortado"].ToString()
                };

                tipos.Add(tipoDocumentoBE);
                
            }
            return tipos;
        }


        public bool DocumentoNuevo(TipoDocumentoBE tipo, ClienteBE cliente, DateTime fecha, string lugar, string montoT, string montoMO, string montoMA, string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del archivo no puede estar vacío.");
            }

            DataTable dataTable = documentoDAL.ListaPorTipo(tipo.ID);

            int num = dataTable.Rows.Count + 1;
            string algo = num.ToString();
            
            while (algo.Length < 3)
            {
                algo = 0+ algo;
            }
            string codigo = tipo.ABR+"-"+algo;


            bool resultado = documentoDAL.AgregarDocumento(codigo, tipo.ID, cliente.Id, fecha, lugar, montoT, montoMO, montoMA, nombre);

            return resultado;
        }

        public DataTable TodosLosDocumentos(string nombre)
        {
            return documentoDAL.ObtenerDocumentoPorNombre(nombre);
        }
    }
}
