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
        public Form1()
        {
            InitializeComponent();
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
    }
}
