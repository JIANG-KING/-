using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠标指针
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMe_MouseEnter(object sender, EventArgs e)
        {
 
            Random r = new Random();
            int Left, Top;
            Left = r.Next(0, this.Width-btnMe.Width-5);
            Top = r.Next(0,this.Height-btnMe.Height-5);
            while (Top>=350) {
                Left = r.Next(0, this.Width - btnMe.Width - 5);
                Top = r.Next(0, this.Height - btnMe.Height - 5);
            }
           btnMe.Location =new  Point(Left, Top);

        }
        private void btnMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你赢了", "提示");
            this.Close();
        }

        private void btnMe_MouseMove(object sender, MouseEventArgs e)
        {
            Point ms = Control.MousePosition;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
