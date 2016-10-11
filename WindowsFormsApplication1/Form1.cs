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
        private bool notChar = false;
        //static string path = Path.GetTempFileName();
        static int cont = 0;
        static double media = 0;
        static double tempoTotal = 0;
        static int score = 0;

        static string path = "C:\\Users\\Brabec\\Documents\\Estudos\\Estatística\\Estatistica\\dictionary.txt";
        static string[] lines = File.ReadAllLines(path);

        static List<double> temp = new List<double>();
        static Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            
            //KEYSTROKE
            //Falta calcular a probabilidade das letras digitadas**
            char key = (char)e.KeyCode;
            try
            {
                dictionary[key] += 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            //FIM

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

            if (size > 1)
            {   // label tempo
                tempoAtual = (delta - temp[size - 2]);
                labelTempo.Text = converter.ConvertToString(tempoAtual);
                tempoTotal += tempoAtual;
            }
            
            media = tempoTotal / cont;
            //letra digitada
            //labelTempo.Text = text;
            
        }

        //Keystroke #1
        private void playerName_KeyDown(object sender, KeyEventArgs e)
        {
            notChar = false;
            if(playerName.TextLength > 0)
            {
                notChar = true;
                
            }
            nameLabel.Text = "Ela aparece: " + gambiarraOcorrencia((char)e.KeyCode) + " vezes";

        }

        private void playerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notChar == true)
            {
                e.Handled = true;
            }
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
           if (input.Text.Equals(title.Text))
            {
                score = score + 25;
                cont++;
                scoreLabel.Text = "Score: "+score;
                if(cont == 3)
                {
                    calcBtn.Enabled = true;
                }
                // se for igual a função db será chamada retornando uma palavra aleatoria
                // do dicionario
                this.title.Text = db();
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
        public int gambiarraOcorrencia(char key)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz1234567890'´[]~ç;.,\\";

            foreach (char c in alphabet)
            {
                dictionary.Add(c, 0);
            }

            if (dictionary.ContainsKey(key))
            {
                dictionary[key] += 1;
                return dictionary[key];
            }
            
            //se não encontrar a tecla digitada
            return 0;
        }

        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.input.Visible = true;
            this.title.Text = db();
            //button1.Enabled = false;
            startBtn.Visible = false;
            scoreLabel.Visible = true;
            
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            labelTempo.Visible = true;
            labelTempo.Text = "Média de Digitação: "+media+" segundos";
            nameLabel.Visible = true;
            input.Visible = false;
            calcBtn.Visible = false;
            playerName.Visible = true;
        }

        private void labelTempo_Click(object sender, EventArgs e)
        {

        }
    }
}

/*  
 *  UNIVERSIDADE FEDERAL DE SERGIPE (UFS)
 *  Keystroke C# Project - Estatística Aplicada
 *  Created by: Lucas Brabec Barreto Santana 
 *  date:10/2016
 */