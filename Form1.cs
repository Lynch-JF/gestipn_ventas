using Gestion_de_ventas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas
{
    public partial class Form1 : Form
    {

        conexion cn = new conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            int contrasena;

            if (int.TryParse(tbpass.Text, out contrasena))
            {
                if (cn.Consql(tbuser.Text, contrasena) == 1)
                {
                    MessageBox.Show("Operación completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Matricula y Contraseña deben ser números válidos");
            }

            string nombreUsuario = tbuser.Text;

            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void chmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chmostrar.Checked)
            {
                tbpass.PasswordChar = '\0'; 
            }
            else
            {
                tbpass.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
