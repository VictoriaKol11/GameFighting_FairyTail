namespace Проект_Игра
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.listBox_History = new System.Windows.Forms.ListBox();
            this.timer1000Bot = new System.Windows.Forms.Timer(this.components);
            this.timer1800Gamer = new System.Windows.Forms.Timer(this.components);
            this.timer2000Gamer = new System.Windows.Forms.Timer(this.components);
            this.timer2300 = new System.Windows.Forms.Timer(this.components);
            this.timer1000Gamer = new System.Windows.Forms.Timer(this.components);
            this.timer1800Bot = new System.Windows.Forms.Timer(this.components);
            this.timer2000Bot = new System.Windows.Forms.Timer(this.components);
            this.label_NicknameGamer = new System.Windows.Forms.Label();
            this.label_NicknameBot = new System.Windows.Forms.Label();
            this.pictureBoxBotIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxGamerIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_HpGamer = new System.Windows.Forms.Label();
            this.progressBarGamer = new System.Windows.Forms.ProgressBar();
            this.pictureBox_Bot = new System.Windows.Forms.PictureBox();
            this.label_attack_or_protection = new System.Windows.Forms.Label();
            this.pictureBox_Gamer = new System.Windows.Forms.PictureBox();
            this.label_xod_now = new System.Windows.Forms.Label();
            this.progressBarBOT = new System.Windows.Forms.ProgressBar();
            this.label_HpBot = new System.Windows.Forms.Label();
            this.button_LegsAttack = new System.Windows.Forms.Button();
            this.button_BodyAttack = new System.Windows.Forms.Button();
            this.button_HeadAttack = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_HP = new System.Windows.Forms.Button();
            this.button_LegsProtection = new System.Windows.Forms.Button();
            this.button_BodyProtection = new System.Windows.Forms.Button();
            this.button_HeadProtection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamerIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gamer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_History
            // 
            this.listBox_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_History.FormattingEnabled = true;
            this.listBox_History.Location = new System.Drawing.Point(118, 332);
            this.listBox_History.Name = "listBox_History";
            this.listBox_History.Size = new System.Drawing.Size(512, 67);
            this.listBox_History.TabIndex = 16;
            // 
            // timer1000Bot
            // 
            this.timer1000Bot.Enabled = true;
            this.timer1000Bot.Interval = 1000;
            this.timer1000Bot.Tick += new System.EventHandler(this.timer1000Bot_Tick);
            // 
            // timer1800Gamer
            // 
            this.timer1800Gamer.Enabled = true;
            this.timer1800Gamer.Interval = 1800;
            this.timer1800Gamer.Tick += new System.EventHandler(this.timer1800Gamer_Tick);
            // 
            // timer2000Gamer
            // 
            this.timer2000Gamer.Enabled = true;
            this.timer2000Gamer.Interval = 2000;
            this.timer2000Gamer.Tick += new System.EventHandler(this.timer2000Gamer_Tick);
            // 
            // timer2300
            // 
            this.timer2300.Enabled = true;
            this.timer2300.Interval = 2300;
            this.timer2300.Tick += new System.EventHandler(this.timer2300_Tick);
            // 
            // timer1000Gamer
            // 
            this.timer1000Gamer.Enabled = true;
            this.timer1000Gamer.Interval = 1000;
            this.timer1000Gamer.Tick += new System.EventHandler(this.timer1000Gamer_Tick);
            // 
            // timer1800Bot
            // 
            this.timer1800Bot.Enabled = true;
            this.timer1800Bot.Interval = 1800;
            this.timer1800Bot.Tick += new System.EventHandler(this.timer1800Bot_Tick);
            // 
            // timer2000Bot
            // 
            this.timer2000Bot.Enabled = true;
            this.timer2000Bot.Interval = 2000;
            this.timer2000Bot.Tick += new System.EventHandler(this.timer2000Bot_Tick);
            // 
            // label_NicknameGamer
            // 
            this.label_NicknameGamer.AutoSize = true;
            this.label_NicknameGamer.BackColor = System.Drawing.Color.White;
            this.label_NicknameGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NicknameGamer.Location = new System.Drawing.Point(45, 125);
            this.label_NicknameGamer.Name = "label_NicknameGamer";
            this.label_NicknameGamer.Size = new System.Drawing.Size(36, 13);
            this.label_NicknameGamer.TabIndex = 14;
            this.label_NicknameGamer.Text = "Нацу";
            // 
            // label_NicknameBot
            // 
            this.label_NicknameBot.AutoSize = true;
            this.label_NicknameBot.BackColor = System.Drawing.Color.White;
            this.label_NicknameBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NicknameBot.Location = new System.Drawing.Point(657, 125);
            this.label_NicknameBot.Name = "label_NicknameBot";
            this.label_NicknameBot.Size = new System.Drawing.Size(59, 13);
            this.label_NicknameBot.TabIndex = 15;
            this.label_NicknameBot.Text = "Макаров";
            // 
            // pictureBoxBotIcon
            // 
            this.pictureBoxBotIcon.BackColor = System.Drawing.Color.White;
            this.pictureBoxBotIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBotIcon.Image = global::Проект_Игра.Properties.Resources.MakarovStonceIcon;
            this.pictureBoxBotIcon.Location = new System.Drawing.Point(636, 12);
            this.pictureBoxBotIcon.Name = "pictureBoxBotIcon";
            this.pictureBoxBotIcon.Size = new System.Drawing.Size(101, 102);
            this.pictureBoxBotIcon.TabIndex = 23;
            this.pictureBoxBotIcon.TabStop = false;
            // 
            // pictureBoxGamerIcon
            // 
            this.pictureBoxGamerIcon.BackColor = System.Drawing.Color.White;
            this.pictureBoxGamerIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGamerIcon.Image = global::Проект_Игра.Properties.Resources.NatsuStonceIcon;
            this.pictureBoxGamerIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGamerIcon.Name = "pictureBoxGamerIcon";
            this.pictureBoxGamerIcon.Size = new System.Drawing.Size(100, 102);
            this.pictureBoxGamerIcon.TabIndex = 22;
            this.pictureBoxGamerIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Проект_Игра.Properties.Resources.BackgroundCuild;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_HpGamer);
            this.panel1.Controls.Add(this.progressBarGamer);
            this.panel1.Controls.Add(this.pictureBox_Bot);
            this.panel1.Controls.Add(this.label_attack_or_protection);
            this.panel1.Controls.Add(this.pictureBox_Gamer);
            this.panel1.Controls.Add(this.label_xod_now);
            this.panel1.Controls.Add(this.progressBarBOT);
            this.panel1.Controls.Add(this.label_HpBot);
            this.panel1.Location = new System.Drawing.Point(118, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 228);
            this.panel1.TabIndex = 21;
            // 
            // label_HpGamer
            // 
            this.label_HpGamer.AutoSize = true;
            this.label_HpGamer.BackColor = System.Drawing.Color.White;
            this.label_HpGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HpGamer.Location = new System.Drawing.Point(15, 48);
            this.label_HpGamer.Name = "label_HpGamer";
            this.label_HpGamer.Size = new System.Drawing.Size(28, 13);
            this.label_HpGamer.TabIndex = 12;
            this.label_HpGamer.Text = "100";
            // 
            // progressBarGamer
            // 
            this.progressBarGamer.Location = new System.Drawing.Point(54, 43);
            this.progressBarGamer.Name = "progressBarGamer";
            this.progressBarGamer.Size = new System.Drawing.Size(130, 23);
            this.progressBarGamer.TabIndex = 7;
            this.progressBarGamer.Value = 100;
            // 
            // pictureBox_Bot
            // 
            this.pictureBox_Bot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bot.Image = global::Проект_Игра.Properties.Resources.MakarovStonce;
            this.pictureBox_Bot.Location = new System.Drawing.Point(321, 127);
            this.pictureBox_Bot.Name = "pictureBox_Bot";
            this.pictureBox_Bot.Size = new System.Drawing.Size(145, 75);
            this.pictureBox_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Bot.TabIndex = 5;
            this.pictureBox_Bot.TabStop = false;
            // 
            // label_attack_or_protection
            // 
            this.label_attack_or_protection.AutoSize = true;
            this.label_attack_or_protection.BackColor = System.Drawing.Color.White;
            this.label_attack_or_protection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_attack_or_protection.Location = new System.Drawing.Point(240, 53);
            this.label_attack_or_protection.Name = "label_attack_or_protection";
            this.label_attack_or_protection.Size = new System.Drawing.Size(41, 13);
            this.label_attack_or_protection.TabIndex = 10;
            this.label_attack_or_protection.Text = "label2";
            this.label_attack_or_protection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Gamer
            // 
            this.pictureBox_Gamer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Gamer.Image = global::Проект_Игра.Properties.Resources.NatsuStance;
            this.pictureBox_Gamer.Location = new System.Drawing.Point(54, 90);
            this.pictureBox_Gamer.Name = "pictureBox_Gamer";
            this.pictureBox_Gamer.Size = new System.Drawing.Size(265, 112);
            this.pictureBox_Gamer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Gamer.TabIndex = 4;
            this.pictureBox_Gamer.TabStop = false;
            // 
            // label_xod_now
            // 
            this.label_xod_now.AutoSize = true;
            this.label_xod_now.BackColor = System.Drawing.Color.White;
            this.label_xod_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_xod_now.Location = new System.Drawing.Point(240, 29);
            this.label_xod_now.Name = "label_xod_now";
            this.label_xod_now.Size = new System.Drawing.Size(41, 13);
            this.label_xod_now.TabIndex = 6;
            this.label_xod_now.Text = "label1";
            // 
            // progressBarBOT
            // 
            this.progressBarBOT.Location = new System.Drawing.Point(336, 43);
            this.progressBarBOT.Name = "progressBarBOT";
            this.progressBarBOT.Size = new System.Drawing.Size(130, 23);
            this.progressBarBOT.TabIndex = 8;
            this.progressBarBOT.Value = 100;
            // 
            // label_HpBot
            // 
            this.label_HpBot.AutoSize = true;
            this.label_HpBot.BackColor = System.Drawing.Color.White;
            this.label_HpBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HpBot.Location = new System.Drawing.Point(472, 48);
            this.label_HpBot.Name = "label_HpBot";
            this.label_HpBot.Size = new System.Drawing.Size(28, 13);
            this.label_HpBot.TabIndex = 13;
            this.label_HpBot.Text = "100";
            // 
            // button_LegsAttack
            // 
            this.button_LegsAttack.BackColor = System.Drawing.Color.White;
            this.button_LegsAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LegsAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LegsAttack.Image = ((System.Drawing.Image)(resources.GetObject("button_LegsAttack.Image")));
            this.button_LegsAttack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LegsAttack.Location = new System.Drawing.Point(377, 304);
            this.button_LegsAttack.Name = "button_LegsAttack";
            this.button_LegsAttack.Size = new System.Drawing.Size(63, 23);
            this.button_LegsAttack.TabIndex = 20;
            this.button_LegsAttack.Text = "LEGS";
            this.button_LegsAttack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_LegsAttack.UseVisualStyleBackColor = false;
            this.button_LegsAttack.Click += new System.EventHandler(this.Button_LegsAttack_Click);
            // 
            // button_BodyAttack
            // 
            this.button_BodyAttack.BackColor = System.Drawing.Color.White;
            this.button_BodyAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BodyAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_BodyAttack.Image = ((System.Drawing.Image)(resources.GetObject("button_BodyAttack.Image")));
            this.button_BodyAttack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BodyAttack.Location = new System.Drawing.Point(377, 275);
            this.button_BodyAttack.Name = "button_BodyAttack";
            this.button_BodyAttack.Size = new System.Drawing.Size(63, 23);
            this.button_BodyAttack.TabIndex = 19;
            this.button_BodyAttack.Text = "BODY";
            this.button_BodyAttack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_BodyAttack.UseVisualStyleBackColor = false;
            this.button_BodyAttack.Click += new System.EventHandler(this.Button_BodyAttack_Click);
            // 
            // button_HeadAttack
            // 
            this.button_HeadAttack.BackColor = System.Drawing.Color.White;
            this.button_HeadAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_HeadAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_HeadAttack.Image = ((System.Drawing.Image)(resources.GetObject("button_HeadAttack.Image")));
            this.button_HeadAttack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HeadAttack.Location = new System.Drawing.Point(377, 246);
            this.button_HeadAttack.Name = "button_HeadAttack";
            this.button_HeadAttack.Size = new System.Drawing.Size(63, 23);
            this.button_HeadAttack.TabIndex = 18;
            this.button_HeadAttack.Text = "HEAD";
            this.button_HeadAttack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_HeadAttack.UseVisualStyleBackColor = false;
            this.button_HeadAttack.Click += new System.EventHandler(this.Button_HeadAttack_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.Location = new System.Drawing.Point(12, 376);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(60, 23);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "EXIT";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_HP
            // 
            this.button_HP.BackColor = System.Drawing.Color.White;
            this.button_HP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_HP.Image = ((System.Drawing.Image)(resources.GetObject("button_HP.Image")));
            this.button_HP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HP.Location = new System.Drawing.Point(63, 217);
            this.button_HP.Name = "button_HP";
            this.button_HP.Size = new System.Drawing.Size(49, 23);
            this.button_HP.TabIndex = 3;
            this.button_HP.Text = "HP";
            this.button_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_HP.UseVisualStyleBackColor = false;
            this.button_HP.Click += new System.EventHandler(this.Button_HP_Click);
            // 
            // button_LegsProtection
            // 
            this.button_LegsProtection.BackColor = System.Drawing.Color.White;
            this.button_LegsProtection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LegsProtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LegsProtection.Image = ((System.Drawing.Image)(resources.GetObject("button_LegsProtection.Image")));
            this.button_LegsProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LegsProtection.Location = new System.Drawing.Point(306, 304);
            this.button_LegsProtection.Name = "button_LegsProtection";
            this.button_LegsProtection.Size = new System.Drawing.Size(63, 23);
            this.button_LegsProtection.TabIndex = 2;
            this.button_LegsProtection.Text = "LEGS";
            this.button_LegsProtection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_LegsProtection.UseVisualStyleBackColor = false;
            this.button_LegsProtection.Click += new System.EventHandler(this.Button_LegsProtection_Click);
            // 
            // button_BodyProtection
            // 
            this.button_BodyProtection.BackColor = System.Drawing.Color.White;
            this.button_BodyProtection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BodyProtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_BodyProtection.Image = ((System.Drawing.Image)(resources.GetObject("button_BodyProtection.Image")));
            this.button_BodyProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BodyProtection.Location = new System.Drawing.Point(306, 275);
            this.button_BodyProtection.Name = "button_BodyProtection";
            this.button_BodyProtection.Size = new System.Drawing.Size(63, 23);
            this.button_BodyProtection.TabIndex = 1;
            this.button_BodyProtection.Text = "BODY";
            this.button_BodyProtection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_BodyProtection.UseVisualStyleBackColor = false;
            this.button_BodyProtection.Click += new System.EventHandler(this.Button_BodyProtection_Click);
            // 
            // button_HeadProtection
            // 
            this.button_HeadProtection.BackColor = System.Drawing.Color.White;
            this.button_HeadProtection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_HeadProtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_HeadProtection.Image = global::Проект_Игра.Properties.Resources.ProtectionButtonIcon;
            this.button_HeadProtection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HeadProtection.Location = new System.Drawing.Point(306, 246);
            this.button_HeadProtection.Name = "button_HeadProtection";
            this.button_HeadProtection.Size = new System.Drawing.Size(63, 23);
            this.button_HeadProtection.TabIndex = 0;
            this.button_HeadProtection.Text = "HEAD";
            this.button_HeadProtection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_HeadProtection.UseVisualStyleBackColor = false;
            this.button_HeadProtection.Click += new System.EventHandler(this.Button_HeadProtection_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(140)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.pictureBoxBotIcon);
            this.Controls.Add(this.pictureBoxGamerIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_LegsAttack);
            this.Controls.Add(this.button_BodyAttack);
            this.Controls.Add(this.button_HeadAttack);
            this.Controls.Add(this.listBox_History);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_NicknameBot);
            this.Controls.Add(this.label_NicknameGamer);
            this.Controls.Add(this.button_HP);
            this.Controls.Add(this.button_LegsProtection);
            this.Controls.Add(this.button_BodyProtection);
            this.Controls.Add(this.button_HeadProtection);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAIRY TAIL FIGHTING";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamerIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gamer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_HeadProtection;
        private System.Windows.Forms.Button button_BodyProtection;
        private System.Windows.Forms.Button button_LegsProtection;
        private System.Windows.Forms.Button button_HP;
        private System.Windows.Forms.PictureBox pictureBox_Gamer;
        private System.Windows.Forms.PictureBox pictureBox_Bot;
        private System.Windows.Forms.ProgressBar progressBarGamer;
        private System.Windows.Forms.ProgressBar progressBarBOT;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_HpGamer;
        private System.Windows.Forms.Label label_NicknameGamer;
        private System.Windows.Forms.Label label_NicknameBot;
        private System.Windows.Forms.ListBox listBox_History;
        private System.Windows.Forms.Button button_HeadAttack;
        private System.Windows.Forms.Button button_BodyAttack;
        private System.Windows.Forms.Button button_LegsAttack;
        private System.Windows.Forms.Label label_HpBot;
        private System.Windows.Forms.Label label_attack_or_protection;
        private System.Windows.Forms.Label label_xod_now;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1000Bot;
        private System.Windows.Forms.Timer timer1800Gamer;
        private System.Windows.Forms.Timer timer2000Gamer;
        private System.Windows.Forms.Timer timer2300;
        private System.Windows.Forms.Timer timer1000Gamer;
        private System.Windows.Forms.Timer timer1800Bot;
        private System.Windows.Forms.Timer timer2000Bot;
        private System.Windows.Forms.PictureBox pictureBoxGamerIcon;
        private System.Windows.Forms.PictureBox pictureBoxBotIcon;
    }
}

