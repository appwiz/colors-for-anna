using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToddlerApp
{
    public partial class Form1 : Form
    {
        private System.Speech.Synthesis.SpeechSynthesizer speechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void resetFocus()
        {
            txtInput.Focus();
            txtInput.SelectAll();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text;

            sayPrefix("", "");

            resetFocus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizer.SelectVoice("Microsoft Zira Desktop");

            lblDisplay.ResetText();

            btnPurple.BackColor = Color.BlueViolet;
            btnPink.BackColor = Color.HotPink;
            btnBlue.BackColor = Color.DarkBlue;
            btnGreen.BackColor = Color.Green;
            btnOrange.BackColor = Color.Orange;
            btnBrown.BackColor = Color.SaddleBrown;
            btnBlack.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sayPrefix(string prefix, string suffix)
        {
            resetFocus();

            if (txtInput.Text.Length > 0)
            {
                lblDisplay.Text = txtInput.Text;
                speechSynthesizer.SpeakAsync((prefix.Length > 0 ? prefix : "") + txtInput.Text + ", " + (suffix.Length > 0 ? suffix : ""));
            }
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            sayPrefix("Hey ", "the color is purple!");
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
            sayPrefix("Look ", "Now the color is so pink!");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.DarkBlue;
            sayPrefix("Wow ", "the color became Blue!");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            sayPrefix("Cool ", "the color became Green!");
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            sayPrefix("Nice! ", "the color became Orange!");
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SaddleBrown;
            sayPrefix("Very pretty ", "the color became Brown!");
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            sayPrefix("Okay ", "the color is Black again");
        }
    }
}
