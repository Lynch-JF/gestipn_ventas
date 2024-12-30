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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (RespuestoEntities4 repuesto = new RespuestoEntities4())
            {
                Usuario user = new Usuario
                {
                    usuario1 = tbuser.Text,
                    contrasena = tbpass.Text
                };
                repuesto.Usuario.Add(user);
                repuesto.SaveChanges();

                MessageBox.Show("Operación completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
