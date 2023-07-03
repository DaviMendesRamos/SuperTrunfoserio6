using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTrunfoserio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void abrirJogo(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Vercartas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form3();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void SairJogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
