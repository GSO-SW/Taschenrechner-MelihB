using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TbxZahl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxErgebnis_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxZahl2_TextChanged(object sender, EventArgs e)
        {
            #region Addition von zwei ganzen Zahlen

            //int zahl1 = Convert.ToInt32(tbxZahl1.Text);
            //int zahl2 = Convert.ToInt32(tbxZahl2.Text);

            //int Ergbenis = zahl1 + zahl2;
            //tbxErgebnis.Text = Convert.ToString(Ergbenis);
            #endregion

        }
    }
}
