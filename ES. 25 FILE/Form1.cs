using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;///

namespace ES._25_FILE
{
    public partial class Form1 : Form
    {
        string esfile;///
        public Form1()
        {
            InitializeComponent();
            esfile = @"FILE.txt"; ///
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //funzione che crea il file
        public void CreazioneFile(string nprodotti, string prezzo)
        {
            if(!File.Exists(esfile))
            {
                using(StreamWriter sw = new StreamWriter(esfile, append: false))
                {
                    sw.WriteLine(nprodotti + " " + prezzo + " ");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(esfile, append: true))
                {
                    sw.WriteLine(nprodotti + " " + prezzo + " ");
                }
            }
        }
        //richiamo della funzione nel bottone usato per salvare le modifiche
        private void button1_Click(object sender, EventArgs e)
        {
            CreazioneFile(textBox1.Text, textBox2.Text);
        }
    }
}
