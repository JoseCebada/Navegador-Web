using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImagen.Image = Image.FromFile(openFileDialog1.FileName);
                this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkCalc.LinkVisited = true;
            System.Diagnostics.Process.Start("Calc");
        }

        private void LinkUcol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkUcol.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore", "http://www.ucol.mx");
        }

        private void LinkDiscoC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDiscoC.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\");
        }
    }
}
