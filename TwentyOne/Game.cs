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
using static System.Windows.Forms.VisualStyles.
    VisualStyleElement.TextBox;
using System.Reflection;
using System.Media;

namespace TwentyOne
{
    public partial class Game : Form
    {
        Thread th;
        public Game()
        {
            InitializeComponent();
        }
        public void BackToMenu(object obj)
        {
            Application.Run(new Form1());
        }
        public void game(object obj)
        {
            Application.Run(new Game());
        }

        // При загрузке формы скрывает элементы,
        // которые будут использоваться в будущим
        private void Game_Load(object sender, EventArgs e)
        {
            PassClick.Hide();
            More.Hide();
            GoMenu.Hide();
            Draw.Hide();
            Lose.Hide();
            Win.Hide();
            PlayMore.Hide();
        }

        private Button[] buttons = new Button[2];
        private PictureBox[] pictureBoxes = 
            new PictureBox[18];
        string fileName = System.IO.Path.Combine
            (Environment.CurrentDirectory, "Settings.txt");
        string FilePath = System.IO.Path.Combine
            (Environment.CurrentDirectory, "path.txt");

        // В totalCardFor... считаются суммы карт
        int totalCardForDiller = 0;
        int totalCardForPlayer = 0;

        // В GoldenPontFor... считаются случаи
        // выпадения карты "Туз"
        int GoldenPointForDiller = 0;
        int GoldenPointForPlayer = 0;

        // Создаётся 36 экземпляров класса под каждую карту
        Cards[] card = new Cards[36];
        int countCard = 0;
        int index = 4;

        Random random = new Random();
        int rangeRandom = 35;
        int randomCard;
        string className;

        // Описывается алгоритм выдачи первых двух карт
        // игроку и первых двух карт дилеру,
        // по выбору сложности игры
        private void GoPlay(object sender, EventArgs e)
        {
            PassClick.Show();
            More.Show();
            GoMenu.Show();
            FirstGoMenu.Hide();

            StreamReader sr = new StreamReader(FilePath);
            var cardPath = new List<string>() { };
            var cardValue = new List<int>() 
            { 6, 7, 8, 9, 10, 2, 3, 4, 11 };
            //  Каждой карте присваевается путь
            //  до картинки и стоимость карты
            for (int i = 0; i < 36; i++)
            {
                string text = sr.ReadLine();

                cardPath.Add(text);
            }
            for (int i = 0; i < 36; i++)
            {
                card[i] = new Cards();
                card[i].path = cardPath[i];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    card[countCard].value = cardValue[i];
                    countCard++;
                }
            }
            sr.Close();

            this.Controls.Remove(sender as Button);

            // Выдаются две карты дилеру, если
            // установленна сложность "Сложно",
            // то дилеру выдаются карты "10", "Туз"
            sr = new StreamReader(fileName);
            if (sr.ReadLine() == "Сложный")
            {
                Random rnd = new Random();
                int nrnd = rnd.Next(2);
                int forten = 0;
                
                if(nrnd == 0)
                {
                    randomCard = random.Next(16, 19);
                    forten++;
                }
                else
                {
                    randomCard = random.Next(32, 35);
                }

                className = card[randomCard].path;
                totalCardForDiller += 
                    card[randomCard].value;

                if (card[randomCard].value == 11)
                {
                    GoldenPointForDiller++;
                }

                // Удаление уже выпавшей карты
                card = Cards.DelElement(card, randomCard);

                // Создается элемент PictureBox в который
                // вставляется фотография выпавшей карты
                pictureBoxes[2] = new PictureBox();
                this.SuspendLayout();
                pictureBoxes[2].Location = new Point
                    (135, 50);
                pictureBoxes[2].Size = new Size(70, 96);
                pictureBoxes[2].Image = Image.FromFile
                    (className);
                this.Controls.Add(pictureBoxes[2]);
                this.ResumeLayout();
                rangeRandom--;

                nrnd = rnd.Next(2);

                if (forten == 1)
                {
                    if(nrnd == 0)
                    {
                        randomCard = random.Next(16, 18);
                    }
                    else
                    {
                        randomCard = random.Next(31, 34);
                    }
                }
                else
                {
                    if (nrnd == 0)
                    {
                        randomCard = random.Next(16, 19);
                    }
                    else
                    {
                        randomCard = random.Next(32, 34);
                    }
                }

                className = card[randomCard].path;
                totalCardForDiller += 
                    card[randomCard].value;
                if (card[randomCard].value == 11)
                {
                    GoldenPointForDiller++;
                }
                card = Cards.DelElement(card, randomCard);

                pictureBoxes[3] = new PictureBox();
                this.SuspendLayout();
                pictureBoxes[3].Location = new Point
                    (170, 50);
                pictureBoxes[3].Size = new Size(70, 96);
                pictureBoxes[3].Image = Image.FromFile
                    (className);
                this.Controls.Add(pictureBoxes[3]);
                this.ResumeLayout();
                rangeRandom--;
            }

            // Выдаются две карты дилеру, если установленна сложность "Легко",
            // то игроку и дилеру выпадают случайные карты
            else
            {
                // Выбирается случайное число из карт, которые не были использованы,
                // Затем в "ClassName" идет путь к изображению карты,
                // A в "totalCardForDiller" идет стоимость карты
                randomCard = random.Next(0, rangeRandom);
                className = card[randomCard].path;
                totalCardForDiller += card[randomCard].value;
                if (card[randomCard].value == 11)
                {
                    GoldenPointForDiller++;
                }
                card = Cards.DelElement(card, randomCard);

                pictureBoxes[2] = new PictureBox();
                this.SuspendLayout();
                pictureBoxes[2].Location = new Point
                    (135, 50);
                pictureBoxes[2].Size = new Size(70, 96);
                pictureBoxes[2].Image = Image.FromFile
                    (className);
                this.Controls.Add(pictureBoxes[2]);
                this.ResumeLayout();
                rangeRandom--;

                randomCard = random.Next(0, rangeRandom);
                className = card[randomCard].path;
                totalCardForDiller +=
                    card[randomCard].value;

                if (card[randomCard].value == 11)
                {
                    GoldenPointForDiller++;
                }
                card = Cards.DelElement(card, randomCard);

                pictureBoxes[3] = new PictureBox();
                this.SuspendLayout();
                pictureBoxes[3].Location = new Point
                    (170, 50);
                pictureBoxes[3].Size = new Size(70, 96);
                pictureBoxes[3].Image = Image.FromFile
                    (className);
                this.Controls.Add(pictureBoxes[3]);
                this.ResumeLayout();
                rangeRandom--;
            }
            sr.Close();

            randomCard = random.Next(0, rangeRandom);
            className = card[randomCard].path;
            totalCardForPlayer += card[randomCard].value;
            if (card[randomCard].value == 11)
            {
                GoldenPointForPlayer++;
            }
            card = Cards.DelElement(card, randomCard);

            pictureBoxes[0] = new PictureBox();
            this.SuspendLayout();
            pictureBoxes[0].Location = new Point
                (135, 220);
            pictureBoxes[0].Size = new Size(70, 96);
            pictureBoxes[0].Image = Image.FromFile
                (className);
            this.Controls.Add(pictureBoxes[0]);
            this.ResumeLayout();
            rangeRandom--;

            randomCard = random.Next(0, rangeRandom);
            className = card[randomCard].path;
            totalCardForPlayer += card[randomCard].value;
            if (card[randomCard].value == 11)
            {
                GoldenPointForPlayer++;
            }
            card = Cards.DelElement(card, randomCard);

            pictureBoxes[1] = new PictureBox();
            this.SuspendLayout();
            pictureBoxes[1].Location = new Point
                (170, 220);
            pictureBoxes[1].Size = new Size(70, 96);
            pictureBoxes[1].Image = Image.FromFile
                (className);
            this.Controls.Add(pictureBoxes[1]);
            this.ResumeLayout();
            rangeRandom--;

            // Выбор исхода если выпала комбинация из
            // двух карт "Туз"
            if(GoldenPointForDiller == 2
                && GoldenPointForPlayer < 2)
            {
                Lose.Show();
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User\\Downloads" +
                    "\\fail-wha-wha-version.wav");
                Audio.Load();
                Audio.Play();

                label1.Text = "ЗОЛОТОЕ ОЧКО";
                label1.BackColor = Color.Gold;
                label2.Text = "У вас: " + 
                    totalCardForPlayer;
                Lose.Show();
                More.Enabled = false;
                PassClick.Enabled = false;

                PlayMore.Show();
            }
            else if(GoldenPointForDiller == 2 
                && GoldenPointForPlayer == 2)
            {
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User\\Downloads" +
                    "\\46f2f70edf1b92b.wav");
                Audio.Load();
                Audio.Play();

                label1.Text = "ЗОЛОТОЕ ОЧКО";
                label2.Text = "ЗОЛОТОЕ ОЧКО";
                label1.BackColor = Color.Gold;
                label2.BackColor = Color.Gold;
                Draw.Show();
                More.Enabled = false;
                PassClick.Enabled = false;

                PlayMore.Show();
            }
            else if(GoldenPointForPlayer == 2 
                && GoldenPointForDiller < 2)
            {
                Win.Show();
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User\\Downloads" +
                    "\\1984a9f3474ab6d.wav");
                Audio.Load();
                Audio.Play();

                label2.Text = "ЗОЛОТОЕ ОЧКО";
                label2.BackColor = Color.Gold;
                label1.Text = "У дилера: " + 
                    totalCardForDiller;
                Win.Show();
                More.Enabled = false;
                PassClick.Enabled = false;

                PlayMore.Show();
            }
            else
            {
                label1.Text = "У дилера: " + 
                    totalCardForDiller;
                label2.Text = "У вас: " +
                    totalCardForPlayer;
            }

            if(totalCardForPlayer == 21)
            {
                More.Enabled = false;
            }
        }

        // При нажатии кнопки "Ещё",
        // выдает одну карту игроку
        private void MoreCard(object sender, EventArgs e)
        {
            randomCard = random.Next(0, rangeRandom);
            className = card[randomCard].path;
            totalCardForPlayer += card[randomCard].value;
            card = Cards.DelElement(card, randomCard);

            pictureBoxes[index] = new PictureBox();
            this.SuspendLayout();
            pictureBoxes[index].Location = new Point
                (135 + 35 * (index - 2), 220);
            pictureBoxes[index].Size = new Size(70, 96);
            pictureBoxes[index].Image = Image.FromFile
                (className);
            this.Controls.Add(pictureBoxes[index]);
            this.ResumeLayout();
            rangeRandom--;
            index++;

            if (totalCardForPlayer >= 21)
            {
                More.Enabled = false;
            }
            label2.Text = "У вас: " + totalCardForPlayer;
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(BackToMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        // При нажатии кнопки "Пас"
        // из оставшихся карт выбирает
        // случайную дилеру, дилер останавливает набор
        // карты при сумме равной 17 и больше
        private void Pass(object sender, EventArgs e)
        {
            int PositionForDiller = 4;

            More.Enabled = false;
            PassClick.Enabled = false;

            //дилер набирает карты
            if (totalCardForPlayer < 22)
            {
                while (totalCardForDiller < 17)
                {
                    randomCard = random.Next
                        (0, rangeRandom);
                    className = card[randomCard].path;
                    totalCardForDiller += 
                        card[randomCard].value;
                    card = Cards.DelElement
                        (card, randomCard);

                    pictureBoxes[index] = new PictureBox();
                    this.SuspendLayout();
                    pictureBoxes[index].Location = new Point
                        (135 + 35 * (PositionForDiller
                        - 2), 50);
                    pictureBoxes[index].Size = new Size
                        (70, 96);
                    pictureBoxes[index].Image = 
                        Image.FromFile(className);
                    this.Controls.Add(pictureBoxes[index]);
                    this.ResumeLayout();
                    rangeRandom--;
                    index++;
                }
            }
            label1.Text = "У дилера: " + 
                totalCardForDiller;

            //после полного набора карт выбирается исход
            if ((totalCardForDiller == totalCardForPlayer 
                && totalCardForPlayer < 22
                && totalCardForDiller < 22) 
                || (GoldenPointForDiller == 2 
                && GoldenPointForPlayer < 2))
            {
                Draw.Show();
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User\\Downloads" +
                    "\\46f2f70edf1b92b.wav");
                Audio.Load();
                Audio.Play();
            }
            else if ((totalCardForDiller > 
                totalCardForPlayer
                && totalCardForDiller <= 21) 
                || totalCardForPlayer > 21 || 
                (GoldenPointForDiller == 2 
                && GoldenPointForPlayer == 2))
            {
                Lose.Show();
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User\\Downloads" +
                    "\\fail-wha-wha-version.wav");
                Audio.Load();
                Audio.Play();
            }
            else
            {
                Win.Show();
                System.Media.SoundPlayer Audio;
                Audio = new System.Media.SoundPlayer
                    ("C:\\Users\\User" +
                    "\\Downloads\\1984a9f3474ab6d.wav");
                Audio.Load();
                Audio.Play();
            }
            PlayMore.Show();
        }
        private void BAckToMenuFirst(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(BackToMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void PlayMore_Click(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(game);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
