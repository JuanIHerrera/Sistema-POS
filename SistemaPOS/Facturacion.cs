using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace SistemaPOS
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string vendedor = "select * from Usuarios where id_usuario = " + Login.Codigo;
            DataSet ds;
            ds = Biblioteca.Herramientas(vendedor);

            lbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nombre_cliente from Clientes where id_clientes = '{0}'", TxtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    TxtCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    TxtCodigoProducto.Focus();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
        }

        public static int contadorFila = 0;
        public static double total;
        private void BtColocar_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int numeroFila = 0;

                if (contadorFila == 0)
                {
                    dataGridView1.Rows.Add(TxtCodigoProducto.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                }
                else 
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows) 
                    {
                        if (Fila.Cells[0].Value.ToString() == TxtCodigoProducto.Text) 
                        {
                            existe = true;
                            numeroFila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        // Actualizar cantidad e importe
                        dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();

                        double importe = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                        dataGridView1.Rows[numeroFila].Cells[4].Value = importe;
                    }
                    else
                    {
                        // Agregar nuevo producto
                        int fila = dataGridView1.Rows.Add(TxtCodigoProducto.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value);
                        dataGridView1.Rows[fila].Cells[4].Value = importe;

                        contadorFila++;
                    }
                }
            }
            total = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                total += Convert.ToDouble(Fila.Cells[4].Value);
            }
            lbTotal.Text = "$" + total.ToString();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (contadorFila > 0) 
                {
                    total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                    lbTotal.Text = "$" + total.ToString();
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    contadorFila--;
                }
            }
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente ConsulClient = new ConsultarCliente();
            ConsulClient.ShowDialog();

            if (ConsulClient.DialogResult == DialogResult.OK) 
            {
                TxtCodigoCliente.Text = ConsulClient.dataGridView1.Rows[ConsulClient.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtCliente.Text = ConsulClient.dataGridView1.Rows[ConsulClient.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TxtCodigoProducto.Focus();
            }
        }

        private void BtProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConsulPro = new ConsultarProductos();
            ConsulPro.ShowDialog();
            if(ConsulPro.DialogResult == DialogResult.OK) 
            {
                TxtCodigoProducto.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtDescripcion.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TxtPrecio.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TxtCantidad.Focus();
            }  
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            TxtCodigoCliente.Text = "";
            TxtCliente.Text = "";
            TxtCodigoProducto.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            TxtCantidad.Text = "";
            lbTotal.Text = "$ 0";
            dataGridView1.Rows.Clear();
            contadorFila = 0;
            total = 0;

            TxtCodigoCliente.Focus();
        }
        private void BtFacturar_Click(object sender, EventArgs e)
        {
            if (contadorFila != 0)
            {
                try
                {
                    // Validar que el código cliente sea numérico
                    if (!int.TryParse(TxtCodigoCliente.Text.Trim(), out int codigoCliente))
                    {
                        MessageBox.Show("El código de cliente debe ser numérico");
                        return;
                    }

                    // Ejecutar ActualizarFacturas
                    string cmd = $"EXEC ActualizarFacturas {codigoCliente}";
                    DataSet DS = Biblioteca.Herramientas(cmd);

                    // Validar que haya resultados
                    if (DS.Tables.Count == 0 || DS.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No se pudo generar la factura.");
                        return;
                    }

                    int NumeroFactura = Convert.ToInt32(DS.Tables[0].Rows[0]["NumeroFactura"]);

                    // Recorrer las filas del DataGridView
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        // Evitar la fila nueva vacía
                        if (Fila.IsNewRow) continue;

                        // Validar que tenga al menos 4 celdas y que no sean nulas
                        if (Fila.Cells.Count >= 4 &&
                            Fila.Cells[0].Value != null &&
                            Fila.Cells[1].Value != null &&
                            Fila.Cells[2].Value != null &&
                            Fila.Cells[3].Value != null)
                        {
                            int codigoProducto = Convert.ToInt32(Fila.Cells[0].Value);
                            float precioVenta = float.Parse(Fila.Cells[2].Value.ToString());
                            float cantidadVendida = float.Parse(Fila.Cells[3].Value.ToString());

                            cmd = $"EXEC ActualizarDetalles {NumeroFactura},{codigoProducto},{precioVenta},{cantidadVendida}";
                            DS = Biblioteca.Herramientas(cmd);
                        }
                    }

                    // Ejecutar DatosFactura
                    cmd = $"EXEC DatosFactura {NumeroFactura}";
                    DS = Biblioteca.Herramientas(cmd);

                    if (DS.Tables.Count == 0 || DS.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos para la factura.");
                        return;
                    }

                    // Mostrar reporte
                    Factura fac = new Factura();

                    if (fac.reportViewer1.LocalReport.DataSources.Count > 0)
                    {
                        fac.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                    }
                    else
                    {
                        fac.reportViewer1.LocalReport.DataSources.Add(
                            new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DS.Tables[0])
                        );
                    }

                    fac.ShowDialog();

                    Nuevo();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
        }
    }
}

/*private void BtFacturar_Click(object sender, EventArgs e)
        {
            if (contadorFila != 0) 
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarFacturas {0}", TxtCodigoCliente.Text.Trim());
                    DataSet DS = Biblioteca.Herramientas(cmd);

                    string NumeroFactura = DS.Tables[0].Rows[0]["NumeroFactura"].ToString().Trim();
                    foreach (DataGridViewRow Fila in dataGridView1.Rows) 
                    {
                        int numeroFactura = Convert.ToInt32(Fila.Cells[0].Value);
                        int codigoProducto = Convert.ToInt32(Fila.Cells[1].Value);
                        float precioVenta = float.Parse(Fila.Cells[2].Value.ToString());
                        float cantidadVendida = float.Parse(Fila.Cells[3].Value.ToString());

                        cmd = $"EXEC ActualizarDetalles {numeroFactura},{codigoProducto},{precioVenta},{cantidadVendida}";
                        //cmd = string.Format("EXEC ActualizarDetalles {0},{1},{2},{3}", Fila.Cells[0].Value, Fila.Cells[1].Value, Fila.Cells[2].Value, Fila.Cells[3].Value);
                        DS = Biblioteca.Herramientas(cmd);
                    }
                    cmd = "EXEC DatosFactura " + NumeroFactura;

                    DS = Biblioteca.Herramientas(cmd);

                    Factura fac = new Factura();
                    fac.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                    fac.ShowDialog();

                    Nuevo();
                }
                catch (Exception error) 
                {
                    MessageBox.Show("Error " + error.Message);
                }
            }
        }*/
