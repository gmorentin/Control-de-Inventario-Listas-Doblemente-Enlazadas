using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_DE_INVENTARIO
{
    class Productos
    {
        private int _codigo;
        public int codigo { get { return _codigo; } set { _codigo = value; } }

        private int _cantidad;
        public int cantidad { get { return _cantidad; } set { _cantidad = value; } }

        private int _precio;
        public int precio { get { return _precio; } set { _precio = value; } }

        private string _nombre;
        public string nombre { get { return _nombre; } set { _nombre = value; } }

        private Productos _siguiente;
        public Productos siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Productos _anterior;
        public Productos anterior { get { return _anterior; } set { _anterior = value; } }

        public Productos()
        {
            _codigo = 0;
            _cantidad = 0;
            _precio = 0;
            _nombre = "";
        }

        public override string ToString()
        {
            return "Codigo: "+_codigo+", Nombre: "+_nombre+", Precio: "+_precio+Environment.NewLine;
        }
    }
}
