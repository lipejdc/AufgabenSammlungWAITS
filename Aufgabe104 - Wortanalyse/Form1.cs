using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Aufgabe104___Wortanalyse
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            Words.Items.Add(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wortAnalyse_Click(object sender, EventArgs e)
        { 
            int vowels = 0;
            int consonants = 0;
            int length = Words.Items.Count;

            // Gehe durch die Wordbox und hole nächste Zeile
            foreach (string word in Words.Items)
            { 
                vowels = 0;
                int allChars = word.Length;

                //Gehe durch jedes Wort und prüfe die Werte (Buchstaben)
                vowels = new Regex(@"[aeiouAEIOU]+").Matches(word).Count;
                consonants = allChars - vowels;
                Results.Items.Add($"Number of vowels: {vowels} || Number of consonants: {consonants}");
            }
        }

        //private void wortAnalyse_Click2(object sender, EventArgs e)
        //{
        //    int vowels = 0;
        //    int consonants = 0;
        //    int length = Words.Items.Count;

        //    // Gehe durch die Wordbox und hole nächste Zeile
        //    for (int i = 0; i < length; i++)
        //    {
        //        var tmp = Words.Items[i].ToString();
        //        vowels = 0;
        //        consonants = 0;

        //        //Gehe durch jedes Wort und prüfe die Werte (Buchstaben)
        //        for (int j = 0; j < tmp.Length; j++)
        //        {
        //            if (tmp[j] == 'a' || tmp[j] == 'ä' || tmp[j] == 'e' || tmp[j] == 'i' ||
        //                tmp[j] == 'o' || tmp[j] == 'ö' || tmp[j] == 'u' || tmp[j] == 'ü' ||
        //                tmp[j] == 'A' || tmp[j] == 'Ä' || tmp[j] == 'E' || tmp[j] == 'I' ||
        //                tmp[j] == 'O' || tmp[j] == 'Ö' || tmp[j] == 'U' || tmp[j] == 'Ü')
        //            {
        //                vowels++;
        //            }

        //            else if ((tmp[j] >= 'a' && tmp[j] <= 'z') || (tmp[j] >= 'A' && tmp[j] <= 'Z'))
        //            {
        //                consonants++;
        //            }
        //        }
        //        Results.Items.Add($"Number of vowels: {vowels} || Number of consonants: {consonants}");
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Start();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            Words.Items.Clear();
            Results.Items.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            BackColor = randomColor;
        }
    }
}
