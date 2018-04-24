using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Ex_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            lbAlt.Text = e.Alt ? "Sim" : "Não";
            lbShift.Text = e.Shift ? "Sim" : "Não";
            lbCtrl.Text = e.Control ? "Sim" : "Não";
            lbKeyCode.Text = e.KeyCode.ToString();
            lbKeyData.Text = e.KeyData.ToString();
            lbKeyValue.Text = e.KeyValue.ToString(); 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbChar.Text = e.KeyChar.ToString();
        }
    }
}
