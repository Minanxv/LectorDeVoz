using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;

namespace LectorDeVoz
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conversation_Click(object sender, EventArgs e)
        {
            reader.SpeakAsync(lbTxt.Text); //Leemos el contenido
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                reader.Dispose();
            }
        }

        private void pausa_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if(reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void bandeja_entrada_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((str = openFileDialog.OpenFile())!=null)
                {
                    string fname = openFileDialog.FileName;
                    string filetxt = File.ReadAllText(fname);
                    lbTxt.Text = filetxt;
                }
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if(reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
