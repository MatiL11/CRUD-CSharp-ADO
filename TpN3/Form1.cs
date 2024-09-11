using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public void OcultarBotones()
        {
            btnMenuPais.Visible = false;
            btnMenuProvincia.Visible = false;
            btnMenuSocio.Visible = false;
        }
        private void btnMenuPais_Click(object sender, EventArgs e)
        {
            PaisForm paisForm = new PaisForm();
            paisForm.MdiParent = this;
            paisForm.FormClosed += new FormClosedEventHandler(VerBotones);
            paisForm.Show();

            OcultarBotones();
        }

        private void btnMenuProvincia_Click(object sender, EventArgs e)
        {
            ProvinciaForm provinciaForm = new ProvinciaForm();
            provinciaForm.MdiParent = this;
            provinciaForm.FormClosed += new FormClosedEventHandler(VerBotones);
            provinciaForm.Show();
            
            OcultarBotones();
        }

        private void btnMenuSocio_Click(object sender, EventArgs e)
        {
            SocioForm socioForm = new SocioForm();
            socioForm.MdiParent = this;
            socioForm.FormClosed += new FormClosedEventHandler(VerBotones);
            socioForm.Show();

            OcultarBotones();
        }

        private void VerBotones(object sender, FormClosedEventArgs e)
        {
            btnMenuPais.Visible = true;
            btnMenuProvincia.Visible = true;
            btnMenuSocio.Visible = true;
        }
    }
}
