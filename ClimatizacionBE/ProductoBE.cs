using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionBE
{
    public class ProductoBE
    {
		private int _Id;
		private int _Cantidad;
		private int _Precio;
		private int _Ansal;
		private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public int Ansal
        {
            get { return _Ansal; }
            set { _Ansal = value; }
        }
        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

        public ProductoBE()
        {
            
        }
    }
}
