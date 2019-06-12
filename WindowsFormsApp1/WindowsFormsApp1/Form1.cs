using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Frutas> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Frutas>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFruta.Text != "")
            {
                Frutas f = new Frutas();
                f.Fruta = txtFruta.Text;
                f.Cor = txtCor.Text;
                f.Vitamina = txtVitamina.Text;

                lista.Add(f);
                ExibeCadastros();
            }
        }

        private void ExibeCadastros()
        {
            dvgCadastros.DataSource = null;
            dvgCadastros.DataSource = lista;
        }
    }
}
