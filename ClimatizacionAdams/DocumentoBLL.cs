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


        public string DocumentoNuevo(TipoDocumentoBE tipo, ClienteBE cliente, DateTime fecha, string lugar, string montoT, string montoMO, string montoMA)
        {
            DataTable dataTable = documentoDAL.ListaPorTipo(tipo.ID);

            int num = dataTable.Rows.Count + 1;
            string algo = num.ToString();
            
            while (algo.Length < 3)
            {
                algo = 0+ algo;
            }
            string codigo = tipo.ABR+"-"+algo;

            bool resultado = documentoDAL.AgregarDocumento(codigo, tipo.ID, cliente.Id, fecha, lugar, montoT, montoMO, montoMA);

            if (resultado==false)
            {
                throw new Exception("Fallo en la base al agregar un documento");
            }
            return codigo;
        }

        public DataTable TodosLosDocumentos(string nombre)
        {
            return documentoDAL.ObtenerDocumentoPorNombre(nombre);
        }

        public string AgregarRutaBLL(Documento docu)
        {
            return documentoDAL.AgregarRuta(docu.Archivo, docu.Extencion, docu.Codigo);
        }

        public List<Documento> VerDocumento(string nombre)
        {
            List<Documento> list = new List<Documento>();
            DataTable tabla = documentoDAL.ObtenerDocumentoParaVer(nombre);

            foreach (DataRow item in tabla.Rows)
            {
                Documento documento = new Documento()
                {
                    Codigo = item["Codigo_Asignado"].ToString(),
                    Archivo = (byte[])item["Archivo"],
                    Extencion = item["Extencion"].ToString()
                };
                list.Add(documento);
            }
           
            return list;
        }
    }
}
