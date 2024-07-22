namespace TwentyOne
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.PassClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoMenu = new System.Windows.Forms.Button();
            this.Win = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.Lose = new System.Windows.Forms.Label();
            this.FirstGoMenu = new System.Windows.Forms.Button();
            this.PlayMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(350, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Играть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.GoPlay);
            // 
            // More
            // 
            this.More.BackColor = System.Drawing.Color.Lime;
            this.More.Location = new System.Drawing.Point(12, 200);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(89, 44);
            this.More.TabIndex = 4;
            this.More.Text = "Ещё";
            this.More.UseVisualStyleBackColor = false;
            this.More.Click += new System.EventHandler(this.MoreCard);
            // 
            // PassClick
            // 
            this.PassClick.BackColor = System.Drawing.Color.Lime;
            this.PassClick.Location = new System.Drawing.Point(699, 200);
            this.PassClick.Name = "PassClick";
            this.PassClick.Size = new System.Drawing.Size(89, 44);
            this.PassClick.TabIndex = 5;
            this.PassClick.Text = "Пас";
            this.PassClick.UseVisualStyleBackColor = false;
            this.PassClick.Click += new System.EventHandler(this.Pass);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.Color.Red;
            this.GoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoMenu.Location = new System.Drawing.Point(699, 394);
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(89, 44);
            this.GoMenu.TabIndex = 8;
            this.GoMenu.Text = "В меню";
            this.GoMenu.UseVisualStyleBackColor = false;
            this.GoMenu.Click += new System.EventHandler(this.BackToMenu);
            // 
            // Win
            // 
            this.Win.AutoSize = true;
            this.Win.BackColor = System.Drawing.Color.Lime;
            this.Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win.Location = new System.Drawing.Point(293, 205);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(183, 38);
            this.Win.TabIndex = 10;
            this.Win.Text = "Победа 😁";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.BackColor = System.Drawing.Color.Yellow;
            this.Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Draw.Location = new System.Drawing.Point(304, 205);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(161, 38);
            this.Draw.TabIndex = 11;
            this.Draw.Text = "Ничья 😐";
            // 
            // Lose
            // 
            this.Lose.AutoSize = true;
            this.Lose.BackColor = System.Drawing.Color.OrangeRed;
            this.Lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lose.Location = new System.Drawing.Point(267, 205);
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(228, 38);
            this.Lose.TabIndex = 12;
            this.Lose.Text = "Проигрыш 😢";
            // 
            // FirstGoMenu
            // 
            this.FirstGoMenu.BackColor = System.Drawing.Color.Red;
            this.FirstGoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstGoMenu.Location = new System.Drawing.Point(350, 247);
            this.FirstGoMenu.Name = "FirstGoMenu";
            this.FirstGoMenu.Size = new System.Drawing.Size(89, 44);
            this.FirstGoMenu.TabIndex = 13;
            this.FirstGoMenu.Text = "В меню";
            this.FirstGoMenu.UseVisualStyleBackColor = false;
            this.FirstGoMenu.Click += new System.EventHandler(this.BAckToMenuFirst);
            // 
            // PlayMore
            // 
            this.PlayMore.BackColor = System.Drawing.Color.Lime;
            this.PlayMore.Location = new System.Drawing.Point(350, 246);
            this.PlayMore.Name = "PlayMore";
            this.PlayMore.Size = new System.Drawing.Size(89, 44);
            this.PlayMore.TabIndex = 14;
            this.PlayMore.Text = "Ещё раз";
            this.PlayMore.UseVisualStyleBackColor = false;
            this.PlayMore.Click += new System.EventHandler(this.PlayMore_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayMore);
            this.Controls.Add(this.FirstGoMenu);
            this.Controls.Add(this.Lose);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.GoMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassClick);
            this.Controls.Add(this.More);
            this.Controls.Add(this.button3);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Button PassClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoMenu;
        private System.Windows.Forms.Label Win;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label Lose;
        private System.Windows.Forms.Button FirstGoMenu;
        private System.Windows.Forms.Button PlayMore;
    }
}

