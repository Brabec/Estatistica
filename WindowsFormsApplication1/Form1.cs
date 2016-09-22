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
        static string path = "C:\\Users\\Brabec\\Documents\\Estudos\\Estatística\\Estatistica\\dictionary.txt";
        static long tempo = DateTime.Now.Ticks;
        static int cont = 0;

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

            DateTime st = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
            
            //    Calculo do tempo de digitação
            labelTempo.Text = converter.ConvertToString(t.TotalSeconds);

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

        public void dicionario()
        {
            string path = "C:\\Users\\Brabec\\Documents\\Estudos\\Estatística\\Estatistica\\dictionary.txt";
            // Open the stream and read it back.
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                //string[] word = new string[b.Length];
                List<string> words = new List<string>();

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    words.Add(temp.GetString(b));
                    //Console.WriteLine(temp.GetString(b));
                    //Console.WriteLine(word[i]);
                }

                foreach (string word in words)
                {
                    //Console.WriteLine(word);
                }

                Random r = new Random();
                // Falta pegar o indice e enviar pro label
            }
        }

        public string db()
        {
            
            string[] dicionario = { "quadrado", "bola" };
            Random r = new Random();
            //string v = dicionario[r.Next(0,dicionario.Length)];

            string v = dicionario[r.Next(0, dicionario.Length)];
            return v;
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
