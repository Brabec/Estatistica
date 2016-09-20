using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {   

            if (input.Text.Equals(label.Text))
            {
                btn.Enabled = true;
                // se for igual a função db será chamada retornando uma palavra aleatoria
                // do dicionario
                this.label.Text = db();
                this.input.Text = "";
            }

        }

        public string db()
        {
            string[] dicionario = {"quadrado","bola" };
            Random r = new Random();
            string v = dicionario[r.Next(0,dicionario.Length)];
            return v;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
