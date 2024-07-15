using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionBE
{
    public class Documento
    {
		private string _codigo;
		private byte[] _archivo;
		private string _extencion;

		public string Extencion
		{
			get { return _extencion; }
			set { _extencion = value; }
		}

		public byte[] Archivo
		{
			get { return _archivo; }
			set { _archivo = value; }
		}

		public string Codigo
		{
			get { return _codigo; }
			set { _codigo = value; }
		}

	}
}
