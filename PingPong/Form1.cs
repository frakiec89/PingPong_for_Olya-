using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        private int speed_vertical = 4;
        private int speed_hor = 4;
        private int score = 0;
           
        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            GamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);

        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
