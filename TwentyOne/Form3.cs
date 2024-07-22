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
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace TwentyOne
{
    public partial class Form3 : Form
    {
        Thread th;
        string FileName = System.IO.Path.Combine
            (Environment.CurrentDirectory, "Settings.txt");

        // Считывает сложность, которая ранее
        // была установлена игроком
        public Form3()
        {
            string difficult;
            using (FileStream setting = new FileStream
                (FileName, FileMode.OpenOrCreate))
            {
                StreamReader rw =
                    new StreamReader(setting);

                difficult = rw.ReadLine();

                rw.Close();
            }
            InitializeComponent();
            label2.Text = difficult;
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

        // Смотрит какую сложность выбрал игрок и меняет
        // её, записывая в текстовый документ
        private void ChangeDificult
            (object sender, EventArgs e)
        {
            using (FileStream setting = new FileStream
                (FileName, FileMode.OpenOrCreate))
            {
                string dificult = "Легкий";
                if (radioButton1.Checked == true)
                {
                    dificult = "Лёгкий";
                }
                else
                {
                    dificult = "Сложный";
                }
                StreamWriter sw = 
                    new StreamWriter(setting);

                sw.Write(dificult);

                sw.Close();
                label2.Text = dificult;
            }
        }
    }
}
