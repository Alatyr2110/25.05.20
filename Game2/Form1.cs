using Game2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
    public partial class Form1 : Form
    {
        GameIgra game;
        string s;
        int current;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сообщение из Windows Forms с заголовком", "Заголовок");
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            s = textBox1.Text;
            current = Convert.ToInt32(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //game.   ??     ();
            //UpdateInfo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
        void UpdateInfo()
        {
            //lblFinish.Text = game.Finish.ToString();
            //lblCount.Text = game.Count.ToString();
            //lblCurrent.Text = game.Current.ToString();
            //lblSteps.Text = game.Steps.ToString();
            //lblVv.Text = game.Vv.ToString();
        }
    }
}
