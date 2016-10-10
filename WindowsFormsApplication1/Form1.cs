using System;
using System.IO;
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
        //static string path = Path.GetTempFileName();
        static int cont = 0;
        static string path = "C:\\Users\\Brabec\\Documents\\Estudos\\Estatística\\Estatistica\\dictionary.txt";
        static string[] lines = File.ReadAllLines(path);
        static List<double> temp = new List<double>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            
            KeysConverter converter = new KeysConverter();
            
            //    Codigo da tecla digitada
            string text = converter.ConvertToString(e.KeyCode);

            //label1.Text += text;
            //tempo = (DateTime.Now.Ticks - tempo);
            //List<long> tempo = new List<>();
            //labelTempo.Text = converter.ConvertToString(tempo);

            // calcular o tempo digitado
            DateTime st = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var ts = new TimeSpan(DateTime.UtcNow.Ticks - st.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            temp.Add(delta);

            int size = temp.Count;
            double tempoAtual = 0;

            tempoAtual = delta - temp.ElementAt(size - 1);

            // label tempo
            labelTempo.Text = converter.ConvertToString(delta);
            //letra digitada
            //labelTempo.Text = text;
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
           if (input.Text.Equals(label.Text))
            {
                cont++;
                if(cont == 3)
                {
                    btn.Enabled = true;
                }
                // se for igual a função db será chamada retornando uma palavra aleatoria
                // do dicionario
                this.label.Text = db();
                this.input.Text = "";
            }

        }

        public string db()
        {
            Random r = new Random();
            string word = lines[r.Next(0, lines.Length)];// esse lines é um vetor de STRING 

            return word;
        }

        //probabilidade de uma letra especifica dentre o espaço amostral de jogadas
        public int ocorrencia(string value)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (char c in alphabet)
            {
                if (value.Equals(c))
                {

                }
            }
            return 0;
        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.input.Visible = true;
            this.label.Text = db();
            //button1.Enabled = false;
            button1.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void labelTempo_Click(object sender, EventArgs e)
        {

        }
    }
}
