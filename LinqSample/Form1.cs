using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqSample
{
    public partial class Form1 : Form
    {
        int[]  _numbers = {14,58,52,475,11,20,14,47,58,36,48,89,47,13,22 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinqSample01_Click(object sender, EventArgs e)
        {
            var result = from n in _numbers
                         where n % 2 != 0
                         select n;
            AddToListBox(result.ToArray());

            //foreach (var item in result)
            //{
            // listBox1.Items.Add(item);
            //}
        }

        private void btnSample02_Click(object sender, EventArgs e)
        {
            var result = from q in _numbers
                         where q % 2 ==0
                         orderby q descending
                         select q;
           
            AddToListBox(result.ToArray());


            //foreach (var item in result)
            //{
            //    listBox1.Items.Add(item);
            //}

        }
        private void AddToListBox(int[] items)
        {   
         listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnLinqSample3_Click(object sender, EventArgs e)
        {
            var result = from r in _numbers
                         where r > 38 & r < 65 
                         orderby r descending   
                         select r;
            AddToListBox(result.ToArray());
        }

        private void LinqSample04_Click(object sender, EventArgs e)
        {
            var result = from s in _numbers
                         where s > 38 & s < 65
                         orderby s ascending
                         select s + 3;
            AddToListBox(result.ToArray());
        }
    }
}
