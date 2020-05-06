using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Thread Desthread = new Thread(new ThreadStart(Desert));
            Desthread.Start();

            try
            {
                volume.Text = ((float.Parse(bt_sizeA.Text) * float.Parse(tb_sizeB.Text) * float.Parse(bt_height.Text)) / 1000).ToString();
                volumeGround.Text = ((float.Parse(bt_sizeA.Text) * float.Parse(tb_sizeB.Text) * float.Parse(bt_layer.Text)) / 1000).ToString();

                if (String.IsNullOrEmpty(volume.Text))               
                        return;
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                Console.Write("Произошла ошибка");
            }
        }
        
        
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            volume.Text = "0";
            volumeGround.Text = "0";
            amountGround.Text = "0";
        }

        public static void Desert()
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно уверены в том, что нужен именно такой аквариум?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

           
        }


    }
}
