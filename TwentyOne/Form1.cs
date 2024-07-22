using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOne
{
    public partial class Form1 : Form
    {

        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint
            (object sender, PaintEventArgs e)
        {
           
        }
        //покраска клеток меню
        private void TableLayoutPanel1_CellPaint
            (object sender, 
            TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle
                    (Brushes.RoyalBlue, e.CellBounds);
            else
                e.Graphics.FillRectangle
                    (Brushes.White, e.CellBounds);
        }

        private void Exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void AboutGame(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenAboutGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();    
        }

        public void OpenAboutGame(object obj)
        {
            Application.Run(new Form2());
        }
        public void Setting(object obj)
        {
            Application.Run(new Form3());
        }
        public void Game(object obj)
        {
            Application.Run(new Game());
        }
        private void Setting(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Setting);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Play(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Game);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}