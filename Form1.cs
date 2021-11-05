using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.A.D.A_SOCIOS
{
    public partial class Form1 : Form
    {
        Socios socio = new Socios();
        public Form1()
        {
            InitializeComponent();
            dg.DataSource = socio.DTS;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCarnet.Items.Add("Niño/a-$750");
            cbCarnet.Items.Add("Juvenil-$900");
            cbCarnet.Items.Add("Adulto-$1200");

            cbPlatea.Items.Add("Norte");
            cbPlatea.Items.Add("Sur");
            cbPlatea.Items.Add("Este");
            cbPlatea.Items.Add("Oeste");

            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");


        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.Nacimiento = Convert.ToInt32(txtNacimiento.Text);
            socio.Edad = Convert.ToInt32(txtEdad.Text);
            socio.Documento = Convert.ToInt32(txtDNI.Text);
            socio.Carnet = Convert.ToString(cbCarnet.SelectedItem);
            socio.Platea = Convert.ToString(cbPlatea.SelectedItem);
            socio.Estado = Convert.ToString(cbEstado.SelectedItem);

            socio.AgregarPersona();

        }
    }
}
