using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOne
{
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(BackToMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void BackToMenu(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
