using ClimatizacionBE;
using ClimatizacionDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimatizacionBLL
{
    public class ProductoBLL
    {
        private ProductoDAL productoDAL = new ProductoDAL();
        public List<ProductoBE> VerTodosLosProductos()
        {
            List<ProductoBE> productos = new List<ProductoBE>();
            //ProductoDAL productoDAL = new ProductoDAL();

            productoDAL.VerProductos(productos);
            return productos;
        }

        public bool ProductoAgregado(string nombre, string codigo, string precio, string cant)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    throw new ArgumentException("El codigo no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(precio))
                {
                    throw new ArgumentException("El precio no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(cant))
                {
                    throw new ArgumentException("La cantidad no puede estar vacío.");
                }

                ProductoDAL productoDAL = new ProductoDAL();

                bool resultado = productoDAL.AgregaProducto(nombre, codigo, precio, cant);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error: " + ex.Message);               
            }
        }

        public void TraerProductoBLL(ProductoBE produ, int elprodu)
        {
            //ProductoDAL productoDAL = new ProductoDAL();
            DataTable Latabla =  productoDAL.TraerProducto(elprodu);

            foreach (DataRow item in Latabla.Rows)
            {
                produ.Precio = (int)item["Precio_Venta"];
                produ.Cantidad = (int)item["Metros_Venta"];
                produ.Nombre = item["Nombre_Producto"].ToString();
                produ.Ansal = (int)item["Codigo_Ansal"];
                produ.Id = (int)item["Id"];
            }
        }

        public bool ProductoModificado(string nombre, string codigo, string precio, string cant, int id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    throw new ArgumentException("El codigo no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(precio))
                {
                    throw new ArgumentException("El precio no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(cant))
                {
                    throw new ArgumentException("La cantidad no puede estar vacío.");
                }

                //ProductoDAL productoDAL = new ProductoDAL();

                bool resultado = productoDAL.ModificarProducto(nombre, codigo, precio, cant, id);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error: " + ex.Message);
            }
        }

        public float Paquete(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            DataTable producto1 = productoDAL.TraerProducto(num1);
            DataTable producto2 = productoDAL.TraerProducto(num2);
            DataTable producto3 = productoDAL.TraerProducto(num3);
            DataTable producto4 = productoDAL.TraerProducto(num4);
            DataTable producto5 = productoDAL.TraerProducto(num5);
            DataTable producto6 = productoDAL.TraerProducto(num6);

            float p1 = Convert.ToSingle(producto1.Rows[0]["Precio_Venta"]);
            float c1 = Convert.ToSingle(producto1.Rows[0]["Metros_Venta"]);

            float p2 = Convert.ToSingle(producto2.Rows[0]["Precio_Venta"]);
            float c2 = Convert.ToSingle(producto2.Rows[0]["Metros_Venta"]);

            float p3 = Convert.ToSingle(producto3.Rows[0]["Precio_Venta"]);
            float c3 = Convert.ToSingle(producto3.Rows[0]["Metros_Venta"]);

            float p4 = Convert.ToSingle(producto4.Rows[0]["Precio_Venta"]);
            float c4 = Convert.ToSingle(producto4.Rows[0]["Metros_Venta"]);

            float p5 = Convert.ToSingle(producto5.Rows[0]["Precio_Venta"]);
            float c5 = Convert.ToSingle(producto5.Rows[0]["Metros_Venta"]);

            float p6 = Convert.ToSingle(producto6.Rows[0]["Precio_Venta"]);
            float c6 = Convert.ToSingle(producto6.Rows[0]["Metros_Venta"]);

            float resultado = (p1/c1)+(p2/c2)+(p3/c3)+(p4/c4)+(p5/c5)+(p6/c6);

            return resultado;
        }
    }
}
