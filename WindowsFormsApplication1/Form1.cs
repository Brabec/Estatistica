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
        private bool notChar = false;

        static int cont = 0;
        static int score = 0;

        static double media = 0;
        static double tempoTotal = 0;
        static int mediana = 0;
        
        static string path = "C:\\Users\\Brabec\\Documents\\Estudos\\Estatística\\Estatistica\\dictionary.txt";
        static string[] lines = File.ReadAllLines(path);

        private List<double> temp = new List<double>();
        private Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private bool exist(double member)
        {
            bool is_exist = false;
            int i = 0;
            while (i <= temp.Count - 1 && !is_exist)
            {
                is_exist = (temp[i] == member);
                i++;
            }
            return is_exist;
        }

        public double Z(double member)
        {
            try
            {
                if (exist(member)) return (member - media) / s();
                else return double.NaN;
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }

        public double var()
        {
            try
            {
                double s = 0;
                for (int i = 0; i <= temp.Count - 1; i++)
                    s += Math.Pow(temp[i], 2);
                return (s - temp.Count * Math.Pow(media, 2)) / (temp.Count - 1);
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }

        public double s()
        {
            return Math.Sqrt(var());
        }

        public char median()
        {
            int[] values;
            double median;
            int j = 0;
            values = new int[dictionary.Count];

            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                values[j] = kvp.Value;
                j++;
            }

            Array.Sort(values);

            if (values.Length % 2 != 0)
            {
                median = values[values.Length / 2];
            }
            else
            {
                int middle = values.Length / 2;
                double first = values[middle];
                double second = values[middle - 1];
                median = (int)((first + second) / 2);
            }

            mediana = (int)median;
            char med = dictionary.FirstOrDefault(x => x.Value == median).Key;

            return med;
        }

       
        public char mode()
        {
            char mode = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Key;

            return mode;
        }

        public void dicAdd(char key)
        {
            try
            {
                dictionary[key] += 1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
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
            // KEYSTROKE
            // Codigo da tecla digitada
            char key = (char)e.KeyCode;
            dicAdd(key);
            // FIM
            
            KeysConverter converter = new KeysConverter();
            
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
        
        public double erroProb()
        {
            int total = 0;
            float erro = 0;

            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                total++;
                if (kvp.Key == (char)Keys.Back)
                {
                    erro = kvp.Value;
                }

            }
            
            double prob = erro / total;

            //Console.WriteLine("Erro: " + erro);
            //Console.WriteLine("total: " + total);
            //Console.WriteLine("prob: " + prob);

            return prob * 100;
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
            sdLabel.Visible = true;
            sdLabel.Text += ":" + String.Format("{0:0.00}", s());

            varLabel.Visible = true;
            varLabel.Text += ":" + String.Format("{0:0.00}", var());

            medianLabel.Visible = true;
            medianLabel.Text += ": " + median() + " \nValor da Mediana: "+mediana;

            labelTempo.Visible = true;
            labelTempo.Text = "Média de Digitação: "+ String.Format("{0:0.00}", media) + " segundos\n\nTempo Total: "+ String.Format("{0:0.00}", tempoTotal) + " segundos";

            erroLabel.Visible = true;
            erroLabel.Text += ": " + String.Format("{0:00}", erroProb())+"%";

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