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
            Left = r.Next(0, 500);
            Top = r.Next(0, 500);
            while (btnMe.Location == Control.MousePosition) { Left = r.Next(0, 500); Top = r.Next(0, 500); }
           this.Location =new  Point(Left, Top);

        }
        private void btnMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMe_MouseMove(object sender, MouseEventArgs e)
        {
            Point ms = Control.MousePosition;

        }
    }
}
