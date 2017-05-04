using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_DE_INVENTARIO
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.cantidad = Convert.ToInt16(txtCantidad.Text);
            p.codigo = Convert.ToInt16(txtCodigo.Text);
            p.nombre = txtNombre.Text;
            p.precio = Convert.ToInt16(txtPrecio.Text);
            inv.Agregar(p);
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inv.Borrar(Convert.ToInt16(txtCodigo.Text));
            txtCodigo.Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.cantidad = Convert.ToInt16(txtCantidad.Text);
            p.codigo = Convert.ToInt16(txtCodigo.Text);
            p.nombre = txtNombre.Text;
            p.precio = Convert.ToInt16(txtPrecio.Text);
            inv.Insertar(p, Convert.ToInt16(txtInsertar.Text));
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtInsertar.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos b;
            b = inv.Buscar(Convert.ToInt16(txtCodigo.Text));
            if (b == null)
                txtReporte.Text = "No existe";
            else
            {
                txtReporte.Text = b.ToString();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           txtReporte.Clear();
           txtReporte.Text+= inv.Reporte().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.cantidad = Convert.ToInt16(txtCantidad.Text);
            p.codigo = Convert.ToInt16(txtCodigo.Text);
            p.nombre = txtNombre.Text;
            p.precio = Convert.ToInt16(txtPrecio.Text);
            inv.AgregarInicio(p);
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            txtReporte.Text += inv.ReporteInverso();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            inv.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            inv.eliminarUltimo();
        }
    }
}
