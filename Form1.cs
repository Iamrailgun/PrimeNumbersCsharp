using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PrimeNumbersCsharp
{
    public partial class Form1 : Form
    {
        Searcher searcher = new Searcher();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start, end;
            try
            {
                start = int.Parse(StartText.Text);
                end = int.Parse(EndText.Text);
                if (start >= end | start <= 0 | end <= 0)
                {
                    throw new Exception();
                }
                searcher.search(start, end, this);
            }
            catch (Exception)
            {
                textBox1.Text = "ERROR!!!";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoundLabel.Text = "Found :0";
            CheckedLabel.Text = "checked :0";
            textBox1.Text = null;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SearchPanel.Visible = true;
                CheckPanel.Visible = false;
                SearchPanel.Location = new Point(8, 30);
                CheckPanel.Location = new Point(8, 150);
            }
            else
            {
                SearchPanel.Visible = false;
                CheckPanel.Visible = true;
                SearchPanel.Location = new Point(8, 150);
                CheckPanel.Location = new Point(8, 30);
            }
            textBox1.Text = null;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            FoundLabel.Text = "Found :0";
            CheckedLabel.Text = "checked :0";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Sans Serif", trackBar1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox4.Text) < 2)
                {
                    throw new Exception();
                }
                textBox1.Text = Checker.check(int.Parse(textBox4.Text));
            }
            catch (Exception)
            {
                textBox1.Text = "ERROR!!!";
                return;
            }
        }
    }
}
