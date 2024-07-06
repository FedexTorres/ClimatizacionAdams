using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionBE
{
    public class ClienteBE
    {
		private int _Id;
		private string _Nombre;
		private string _Direccion;

		public string Direccion
		{
			get { return _Direccion; }
			set { _Direccion = value; }
		}

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

        public override string ToString()
        {
            return Nombre.ToString();
        }
    }
}
