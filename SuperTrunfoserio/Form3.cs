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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            List<PictureBox> list = new List<PictureBox>()
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7,pictureBox8
            };
            for (int i = 0; i < list.Count; i++)
            {

                list[i].SizeMode = PictureBoxSizeMode.StretchImage;
                list[i].Width = 199;
                list[i].Height = 259;
            }


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
