using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            //var formplay = new Form1();
            //this.Hide();
            //formplay.ShowDialog();
            //this.Close();

            Form1 newgame = new Form1(true);
            Visible = false;
            if (!newgame.IsDisposed)
            {
                newgame.ShowDialog();
            }
            Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Form1 newgame = new Form1(false, textBoxIP.Text);
            Visible = false;
            if (!newgame.IsDisposed)
            {
                newgame.ShowDialog();
            }
            Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
