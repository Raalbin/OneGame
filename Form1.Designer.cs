namespace OneGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doroga = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.doroga2 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doroga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doroga2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // doroga
            // 
            this.doroga.Image = ((System.Drawing.Image)(resources.GetObject("doroga.Image")));
            this.doroga.Location = new System.Drawing.Point(0, 0);
            this.doroga.Name = "doroga";
            this.doroga.Size = new System.Drawing.Size(840, 650);
            this.doroga.TabIndex = 0;
            this.doroga.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(457, 428);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(128, 187);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // doroga2
            // 
            this.doroga2.Image = ((System.Drawing.Image)(resources.GetObject("doroga2.Image")));
            this.doroga2.Location = new System.Drawing.Point(0, -650);
            this.doroga2.Name = "doroga2";
            this.doroga2.Size = new System.Drawing.Size(840, 650);
            this.doroga2.TabIndex = 2;
            this.doroga2.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(457, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(128, 187);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(118, -190);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(128, 187);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Goldenrod;
            this.labelLose.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLose.Location = new System.Drawing.Point(324, 221);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(224, 45);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "Доездился...";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.Location = new System.Drawing.Point(332, 288);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 43);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Погонять ещё";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(499, -550);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(42, 42);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.BackColor = System.Drawing.Color.Goldenrod;
            this.labelCoin.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoin.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCoin.Location = new System.Drawing.Point(0, 614);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(143, 36);
            this.labelCoin.TabIndex = 8;
            this.labelCoin.Text = "Монеты: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.doroga);
            this.Controls.Add(this.doroga2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.doroga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doroga2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doroga;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox doroga2;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoin;
    }
}

