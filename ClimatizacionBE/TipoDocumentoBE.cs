using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionBE
{
    public class TipoDocumentoBE
    {
		private int _id;
		private string _nombre;
		private string _abr;

		public string ABR
		{
			get { return _abr; }
			set { _abr = value; }
		}

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

        public override string ToString()
        {
            return Nombre.ToString();
        }
    }
}
