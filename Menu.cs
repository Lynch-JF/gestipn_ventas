using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Reporting.WinForms;
using Gestion_de_ventas.Report;

namespace Gestion_de_ventas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

   



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible= false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnmante_Click(object sender, EventArgs e)
        {
            pmantenimiento.Visible = true;
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            pmantenimiento.Visible = false;

            formproduct(new Productos());
        }

        private void btninven_Click(object sender, EventArgs e)
        {
          pprocesos.Visible = false;

            formproduct(new Inventario());
        }

        private void pprocesos_Paint(object sender, PaintEventArgs e)
        {
        //    pmantenimiento.Visible = true;
        }

        private void btnproceso_Click(object sender, EventArgs e)
        {
            pprocesos.Visible = true;

        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            pprocesos.Visible = false;

            formproduct(new Facturacion());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pprocesos.Visible = false;

            formproduct(new Factura());
        }

        private void pmantenimiento_Paint(object sender, PaintEventArgs e)
        {
       //     pprocesos.Visible = false;

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            preporte.Visible = true;
        }

        private void btnR_factura_Click(object sender, EventArgs e)
        {
            preporte.Visible = false;

            formproduct(new Reportefactura());
        }

        private void btnR_inven_Click(object sender, EventArgs e)
        {
            preporte.Visible = false;

            formproduct(new ReporteInventario());
        }

        private void formproduct(object formproduct)
        {
            if (this.pconteiner.Controls.Count > 0)
                this.pconteiner.Controls.RemoveAt(0);
            Form rp = formproduct as Form;
            rp.TopLevel = false;
            rp.Dock = DockStyle.Fill;
            this.pconteiner.Controls.Add(rp);
            this.pconteiner.Tag = formproduct;
            rp.Show();
            

            
        }

        private void pconteiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            formproduct(new Clientes());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
