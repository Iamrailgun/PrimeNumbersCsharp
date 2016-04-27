using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeNumbersCsharp
{
    class Searcher
    {

        public void search(int start, int end, Form1 form)
        {
            form.progressBar1.Minimum = start;
            form.progressBar1.Maximum = end;
            Boolean prime;
            int found = 0;
            while (start <= end)
            {
                prime = true;
                for (int i = 2; i < start; i++)
                {
                    if (start % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    found++;
                    form.textBox1.AppendText(start + " ");
                    form.FoundLabel.Text = "Found :" + found;
                }
                form.progressBar1.Value = start;
                form.CheckedLabel.Text = "Checked :" + start;
                start++;
            }
        }
    }
}
