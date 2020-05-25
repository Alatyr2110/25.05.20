using Game1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    
    public partial class Form1 : Form
    {
        GameDoubler game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToLongTimeString());
        }

        private void timer1_Tick(object sender, EventArgs e)
       {
            MessageBox.Show(DateTime.Now.ToLongTimeString());
       }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?","Warning",MessageBoxButtons.YesNo)==DialogResult.Yes) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            game.Plus();
            UpdateInfo();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnMulty_Click(object sender, EventArgs e)
        {
            game.Multi();
            UpdateInfo();

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameDoubler.action += UpdateInfo;
            game = new GameDoubler();
            UpdateInfo();
            btnMulty.Enabled = true;
            btnPlus.Enabled = true;
            btnBack.Enabled = true;
            btnReset.Enabled = true;
        }
        void UpdateInfo()
        {
            lblFinish.Text = game.Finish.ToString();
            lblCount.Text = game.Count.ToString(); //?????
            lblCurrent.Text = game.Current.ToString();//???
            lblSteps.Text = game.Steps.ToString();
            lblVv.Text = game.Vv.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            game.Back();
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            game.Reset();
            UpdateInfo();
        }

        private void lblFinish_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
