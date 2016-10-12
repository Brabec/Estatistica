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

        private List<double> temp = new List<double>();
        private Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        public Form1()
        {
            InitializeComponent();
        }

        public char mode()
        {
            int[] numbers = new int[dictionary.Count];
            int j = 0;

            foreach(KeyValuePair<char, int> kvp in dictionary)
            {
                numbers[j] = kvp.Value;
                j++;
            }
            
            var mode = numbers.GroupBy(n => n).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault();
                //Console.WriteLine(("Mode is: " + mode));

            var myKey = dictionary.FirstOrDefault(x => x.Value == mode).Key;

            return myKey;
        }

        public void dicAdd(char key)
        {
            try
            {
                dictionary[key] += 1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
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
            
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {

            //Falta calcular a probabilidade das letras digitadas**
            // KEYSTROKE
            char key = (char)e.KeyCode;
            dicAdd(key);
            // FIM

            KeysConverter converter = new KeysConverter();
            
            // Codigo da tecla digitada
            string text = converter.ConvertToString(e.KeyCode);

            // calcular o tempo digitado
            DateTime st = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var ts = new TimeSpan(DateTime.UtcNow.Ticks - st.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            temp.Add(delta);
            
            int size = temp.Count;
            double tempoAtual = 0;

            if (size > 1)
            {   
                // label tempo
                tempoAtual = (delta - temp[size - 2]);
                labelTempo.Text = converter.ConvertToString(tempoAtual);
                tempoTotal += tempoAtual;
            }
            
            media = tempoTotal / cont;
            
        }

        //Keystroke Interface
        private void playerInput_KeyDown(object sender, KeyEventArgs e)
        {

            notChar = false;

            if (playerInput.TextLength > 0)
            {
                notChar = true;
            }

            nameLabel.Text = "Ela aparece: " + numOcorrencia((char)e.KeyCode) + " vezes";
            
        }

        private void playerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notChar == true)
            {
                e.Handled = true;
                playerInput.Text = "";
            }
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
           if (input.Text.Equals(word.Text))
            {
                
                cont++;
                score = score + 25;
                scoreLabel.Text = "Score: "+score;

                if (cont == 15)
                {
                    calcBtn.Enabled = true;
                }
                
                // se for igual a função db será chamada retornando uma palavra aleatoria
                // do dicionario
                word.Text = db();
                input.Text = "";
            }
           
        }

        public string db()
        {
            Random r = new Random();
            string word = lines[r.Next(0, lines.Length)];// esse lines é um vetor de STRING 

            return word;
        }

        //numero de vezes que um caractere fornecido pelo usuário aparece no jogo.
        public int numOcorrencia(char key)
        {
            if (dictionary.ContainsKey(key))
            {
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
            input.Visible = true;
            word.Visible = true;
            word.Text = db();
            startBtn.Visible = false;
            scoreLabel.Visible = true;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            labelTempo.Visible = true;
            labelTempo.Text = "Média de Digitação: "+media+" segundos\nTempo Total: "+tempoTotal+" segundos";
            nameLabel.Visible = true;
            input.Visible = false;
            calcBtn.Visible = false;
            playerInput.Visible = true;
            word.Visible = false;
            moda.Visible = true;
            moda.Text += ": "+mode();
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