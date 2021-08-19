using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava5
{
    public partial class Form1 : Form
    {
        //Tee jono
        List<int> jono = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Numero_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Numero_textBox.Text == "-999")
                {
                    Vastaus_label.Text = "";
                    //Muuta taulukoksi
                    int[] jonot = jono.ToArray();
                    Array.Sort(jonot);
                    //Lisää tyhjään jonoon
                    foreach (var item in jonot)
                    {
                        Vastaus_label.Text += item + " ";
                    }
                    Vastaus_label.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(Numero_textBox.Text));
                    Numero_textBox.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }  
        }
        private void
        TyhjaaLomake()
        {
         Numero_textBox.Text = "";
        }
    }
}
