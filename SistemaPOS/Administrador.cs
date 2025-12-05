using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL; //Importacion de libreria creada por nosotros para usar dataset.

namespace SistemaPOS
{
    public partial class Administrador : FormBase
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Cierra la ventana y deja de reproducir el programa en segundo plano.
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario="+ Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta); //Instanciamos un objeto de tipo dataset para guardar archivos en la memoria caché de la consulta que hicimos arriba.

            lAdminName.Text = Data.Tables[0].Rows[0]["username"].ToString();
            lAdminUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            lAdminCodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = Data.Tables[0].Rows[0]["imagen"].ToString();
            pictureBox1.Image = Image.FromFile(imagen);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            this.Hide();
            con_principal.Show();
        }
    }
}
