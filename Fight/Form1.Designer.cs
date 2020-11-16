namespace Fight
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player_bar = new System.Windows.Forms.ProgressBar();
            this.bot_bar = new System.Windows.Forms.ProgressBar();
            this.player_a1 = new System.Windows.Forms.Button();
            this.player_a2 = new System.Windows.Forms.Button();
            this.player_a3 = new System.Windows.Forms.Button();
            this.bot_a3 = new System.Windows.Forms.Button();
            this.bot_a2 = new System.Windows.Forms.Button();
            this.bot_a1 = new System.Windows.Forms.Button();
            this.start_butt = new System.Windows.Forms.Button();
            this.player_log = new System.Windows.Forms.TextBox();
            this.bot_log = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_a2 = new System.Windows.Forms.Timer(this.components);
            this.time_a3 = new System.Windows.Forms.Timer(this.components);
            this.time_player_a3 = new System.Windows.Forms.Timer(this.components);
            this.time_bot_a3 = new System.Windows.Forms.Timer(this.components);
            this.time_a2_bot = new System.Windows.Forms.Timer(this.components);
            this.time_a3_bot = new System.Windows.Forms.Timer(this.components);
            this.time_bot = new System.Windows.Forms.Timer(this.components);
            this.easy_butt = new System.Windows.Forms.Button();
            this.normal_butt = new System.Windows.Forms.Button();
            this.player_hp_label = new System.Windows.Forms.Label();
            this.bot_hp_label = new System.Windows.Forms.Label();
            this.player_win = new System.Windows.Forms.Label();
            this.bot_win = new System.Windows.Forms.Label();
            this.hard_butt = new System.Windows.Forms.Button();
            this.rip_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fight.Properties.Resources._1266;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1266, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // player_bar
            // 
            this.player_bar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.player_bar.Location = new System.Drawing.Point(12, 12);
            this.player_bar.Maximum = 1000000;
            this.player_bar.Name = "player_bar";
            this.player_bar.Size = new System.Drawing.Size(596, 29);
            this.player_bar.TabIndex = 1;
            this.player_bar.Value = 656547;
            // 
            // bot_bar
            // 
            this.bot_bar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bot_bar.Location = new System.Drawing.Point(656, 12);
            this.bot_bar.Maximum = 1000000;
            this.bot_bar.Name = "bot_bar";
            this.bot_bar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bot_bar.RightToLeftLayout = true;
            this.bot_bar.Size = new System.Drawing.Size(596, 29);
            this.bot_bar.TabIndex = 2;
            this.bot_bar.Value = 656547;
            // 
            // player_a1
            // 
            this.player_a1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player_a1.FlatAppearance.BorderSize = 0;
            this.player_a1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player_a1.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_a1.ForeColor = System.Drawing.Color.White;
            this.player_a1.Location = new System.Drawing.Point(11, 460);
            this.player_a1.Name = "player_a1";
            this.player_a1.Size = new System.Drawing.Size(153, 116);
            this.player_a1.TabIndex = 3;
            this.player_a1.Text = "A1";
            this.player_a1.UseVisualStyleBackColor = false;
            this.player_a1.Click += new System.EventHandler(this.player_a1_Click);
            // 
            // player_a2
            // 
            this.player_a2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player_a2.FlatAppearance.BorderSize = 0;
            this.player_a2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player_a2.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_a2.ForeColor = System.Drawing.Color.White;
            this.player_a2.Location = new System.Drawing.Point(170, 460);
            this.player_a2.Name = "player_a2";
            this.player_a2.Size = new System.Drawing.Size(153, 116);
            this.player_a2.TabIndex = 4;
            this.player_a2.Text = "A1";
            this.player_a2.UseVisualStyleBackColor = false;
            this.player_a2.Click += new System.EventHandler(this.player_a2_Click);
            // 
            // player_a3
            // 
            this.player_a3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player_a3.FlatAppearance.BorderSize = 0;
            this.player_a3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player_a3.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_a3.ForeColor = System.Drawing.Color.White;
            this.player_a3.Location = new System.Drawing.Point(329, 460);
            this.player_a3.Name = "player_a3";
            this.player_a3.Size = new System.Drawing.Size(153, 116);
            this.player_a3.TabIndex = 5;
            this.player_a3.Text = "A1";
            this.player_a3.UseVisualStyleBackColor = false;
            this.player_a3.Click += new System.EventHandler(this.player_a3_Click);
            // 
            // bot_a3
            // 
            this.bot_a3.BackColor = System.Drawing.Color.Crimson;
            this.bot_a3.FlatAppearance.BorderSize = 0;
            this.bot_a3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_a3.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_a3.ForeColor = System.Drawing.Color.White;
            this.bot_a3.Location = new System.Drawing.Point(1098, 460);
            this.bot_a3.Name = "bot_a3";
            this.bot_a3.Size = new System.Drawing.Size(153, 116);
            this.bot_a3.TabIndex = 8;
            this.bot_a3.Text = "A1";
            this.bot_a3.UseVisualStyleBackColor = false;
            // 
            // bot_a2
            // 
            this.bot_a2.BackColor = System.Drawing.Color.Crimson;
            this.bot_a2.FlatAppearance.BorderSize = 0;
            this.bot_a2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_a2.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_a2.ForeColor = System.Drawing.Color.White;
            this.bot_a2.Location = new System.Drawing.Point(939, 460);
            this.bot_a2.Name = "bot_a2";
            this.bot_a2.Size = new System.Drawing.Size(153, 116);
            this.bot_a2.TabIndex = 7;
            this.bot_a2.Text = "A1";
            this.bot_a2.UseVisualStyleBackColor = false;
            // 
            // bot_a1
            // 
            this.bot_a1.BackColor = System.Drawing.Color.Crimson;
            this.bot_a1.FlatAppearance.BorderSize = 0;
            this.bot_a1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_a1.Font = new System.Drawing.Font("Kanit SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_a1.ForeColor = System.Drawing.Color.White;
            this.bot_a1.Location = new System.Drawing.Point(780, 460);
            this.bot_a1.Name = "bot_a1";
            this.bot_a1.Size = new System.Drawing.Size(153, 116);
            this.bot_a1.TabIndex = 6;
            this.bot_a1.Text = "A1";
            this.bot_a1.UseVisualStyleBackColor = false;
            // 
            // start_butt
            // 
            this.start_butt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_butt.FlatAppearance.BorderSize = 0;
            this.start_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_butt.Font = new System.Drawing.Font("Kanit SemiBold", 20.75F, System.Drawing.FontStyle.Bold);
            this.start_butt.ForeColor = System.Drawing.Color.White;
            this.start_butt.Location = new System.Drawing.Point(488, 530);
            this.start_butt.Name = "start_butt";
            this.start_butt.Size = new System.Drawing.Size(286, 46);
            this.start_butt.TabIndex = 9;
            this.start_butt.Text = "START";
            this.start_butt.UseVisualStyleBackColor = false;
            this.start_butt.Click += new System.EventHandler(this.start_butt_Click);
            // 
            // player_log
            // 
            this.player_log.BackColor = System.Drawing.Color.BurlyWood;
            this.player_log.Font = new System.Drawing.Font("Kanit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_log.ForeColor = System.Drawing.Color.White;
            this.player_log.Location = new System.Drawing.Point(12, 47);
            this.player_log.Multiline = true;
            this.player_log.Name = "player_log";
            this.player_log.ReadOnly = true;
            this.player_log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.player_log.Size = new System.Drawing.Size(250, 392);
            this.player_log.TabIndex = 10;
            // 
            // bot_log
            // 
            this.bot_log.BackColor = System.Drawing.Color.BurlyWood;
            this.bot_log.Font = new System.Drawing.Font("Kanit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_log.ForeColor = System.Drawing.Color.White;
            this.bot_log.Location = new System.Drawing.Point(1002, 47);
            this.bot_log.Multiline = true;
            this.bot_log.Name = "bot_log";
            this.bot_log.ReadOnly = true;
            this.bot_log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bot_log.Size = new System.Drawing.Size(250, 392);
            this.bot_log.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_a2
            // 
            this.time_a2.Tick += new System.EventHandler(this.time_a2_Tick);
            // 
            // time_a3
            // 
            this.time_a3.Tick += new System.EventHandler(this.time_a3_Tick);
            // 
            // time_player_a3
            // 
            this.time_player_a3.Tick += new System.EventHandler(this.time_player_a3_Tick);
            // 
            // time_bot_a3
            // 
            this.time_bot_a3.Tick += new System.EventHandler(this.time_bot_a3_Tick);
            // 
            // time_a2_bot
            // 
            this.time_a2_bot.Tick += new System.EventHandler(this.time_a2_bot_Tick);
            // 
            // time_a3_bot
            // 
            this.time_a3_bot.Tick += new System.EventHandler(this.time_a3_bot_Tick);
            // 
            // time_bot
            // 
            this.time_bot.Tick += new System.EventHandler(this.time_bot_Tick);
            // 
            // easy_butt
            // 
            this.easy_butt.BackColor = System.Drawing.Color.Khaki;
            this.easy_butt.FlatAppearance.BorderSize = 0;
            this.easy_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy_butt.Font = new System.Drawing.Font("Kanit SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.easy_butt.ForeColor = System.Drawing.Color.White;
            this.easy_butt.Location = new System.Drawing.Point(488, 460);
            this.easy_butt.Name = "easy_butt";
            this.easy_butt.Size = new System.Drawing.Size(90, 29);
            this.easy_butt.TabIndex = 15;
            this.easy_butt.Text = "EASY";
            this.easy_butt.UseVisualStyleBackColor = false;
            this.easy_butt.Click += new System.EventHandler(this.easy_butt_Click);
            // 
            // normal_butt
            // 
            this.normal_butt.BackColor = System.Drawing.Color.SandyBrown;
            this.normal_butt.FlatAppearance.BorderSize = 0;
            this.normal_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normal_butt.Font = new System.Drawing.Font("Kanit SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.normal_butt.ForeColor = System.Drawing.Color.White;
            this.normal_butt.Location = new System.Drawing.Point(586, 460);
            this.normal_butt.Name = "normal_butt";
            this.normal_butt.Size = new System.Drawing.Size(90, 29);
            this.normal_butt.TabIndex = 16;
            this.normal_butt.Text = "NORMAL";
            this.normal_butt.UseVisualStyleBackColor = false;
            this.normal_butt.Click += new System.EventHandler(this.normal_butt_Click);
            // 
            // player_hp_label
            // 
            this.player_hp_label.AutoSize = true;
            this.player_hp_label.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player_hp_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player_hp_label.Font = new System.Drawing.Font("Kanit", 15F);
            this.player_hp_label.Location = new System.Drawing.Point(268, 47);
            this.player_hp_label.Name = "player_hp_label";
            this.player_hp_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player_hp_label.Size = new System.Drawing.Size(318, 30);
            this.player_hp_label.TabIndex = 18;
            this.player_hp_label.Text = "PLAYER HP: 1000000 / 1000000";
            // 
            // bot_hp_label
            // 
            this.bot_hp_label.AutoSize = true;
            this.bot_hp_label.BackColor = System.Drawing.Color.Crimson;
            this.bot_hp_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_hp_label.Font = new System.Drawing.Font("Kanit", 15F);
            this.bot_hp_label.Location = new System.Drawing.Point(712, 47);
            this.bot_hp_label.Name = "bot_hp_label";
            this.bot_hp_label.Size = new System.Drawing.Size(284, 30);
            this.bot_hp_label.TabIndex = 19;
            this.bot_hp_label.Text = "BOT HP: 1000000 / 1000000";
            // 
            // player_win
            // 
            this.player_win.AutoSize = true;
            this.player_win.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player_win.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player_win.Font = new System.Drawing.Font("Kanit", 50F);
            this.player_win.Location = new System.Drawing.Point(430, 98);
            this.player_win.Name = "player_win";
            this.player_win.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player_win.Size = new System.Drawing.Size(421, 100);
            this.player_win.TabIndex = 20;
            this.player_win.Text = "PLAYER WIN";
            this.player_win.Visible = false;
            // 
            // bot_win
            // 
            this.bot_win.AutoSize = true;
            this.bot_win.BackColor = System.Drawing.Color.Crimson;
            this.bot_win.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bot_win.Font = new System.Drawing.Font("Kanit", 50F);
            this.bot_win.Location = new System.Drawing.Point(484, 98);
            this.bot_win.Name = "bot_win";
            this.bot_win.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bot_win.Size = new System.Drawing.Size(307, 100);
            this.bot_win.TabIndex = 21;
            this.bot_win.Text = "BOT WIN";
            this.bot_win.Visible = false;
            // 
            // hard_butt
            // 
            this.hard_butt.BackColor = System.Drawing.Color.PaleVioletRed;
            this.hard_butt.FlatAppearance.BorderSize = 0;
            this.hard_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard_butt.Font = new System.Drawing.Font("Kanit SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.hard_butt.ForeColor = System.Drawing.Color.White;
            this.hard_butt.Location = new System.Drawing.Point(684, 460);
            this.hard_butt.Name = "hard_butt";
            this.hard_butt.Size = new System.Drawing.Size(90, 29);
            this.hard_butt.TabIndex = 17;
            this.hard_butt.Text = "HARD";
            this.hard_butt.UseVisualStyleBackColor = false;
            this.hard_butt.Click += new System.EventHandler(this.hard_butt_Click);
            // 
            // rip_butt
            // 
            this.rip_butt.BackColor = System.Drawing.Color.IndianRed;
            this.rip_butt.FlatAppearance.BorderSize = 0;
            this.rip_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rip_butt.Font = new System.Drawing.Font("Kanit SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.rip_butt.ForeColor = System.Drawing.Color.White;
            this.rip_butt.Location = new System.Drawing.Point(488, 495);
            this.rip_butt.Name = "rip_butt";
            this.rip_butt.Size = new System.Drawing.Size(286, 29);
            this.rip_butt.TabIndex = 22;
            this.rip_butt.Text = "RIP";
            this.rip_butt.UseVisualStyleBackColor = false;
            this.rip_butt.Click += new System.EventHandler(this.rip_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 586);
            this.Controls.Add(this.rip_butt);
            this.Controls.Add(this.bot_win);
            this.Controls.Add(this.player_win);
            this.Controls.Add(this.bot_hp_label);
            this.Controls.Add(this.player_hp_label);
            this.Controls.Add(this.hard_butt);
            this.Controls.Add(this.normal_butt);
            this.Controls.Add(this.easy_butt);
            this.Controls.Add(this.bot_log);
            this.Controls.Add(this.player_log);
            this.Controls.Add(this.start_butt);
            this.Controls.Add(this.bot_a3);
            this.Controls.Add(this.bot_a2);
            this.Controls.Add(this.bot_a1);
            this.Controls.Add(this.player_a3);
            this.Controls.Add(this.player_a2);
            this.Controls.Add(this.player_a1);
            this.Controls.Add(this.bot_bar);
            this.Controls.Add(this.player_bar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Click Fighting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar player_bar;
        private System.Windows.Forms.ProgressBar bot_bar;
        private System.Windows.Forms.Button player_a1;
        private System.Windows.Forms.Button player_a2;
        private System.Windows.Forms.Button player_a3;
        private System.Windows.Forms.Button bot_a3;
        private System.Windows.Forms.Button bot_a2;
        private System.Windows.Forms.Button bot_a1;
        private System.Windows.Forms.Button start_butt;
        private System.Windows.Forms.TextBox player_log;
        private System.Windows.Forms.TextBox bot_log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer time_a2;
        private System.Windows.Forms.Timer time_a3;
        private System.Windows.Forms.Timer time_player_a3;
        private System.Windows.Forms.Timer time_bot_a3;
        private System.Windows.Forms.Timer time_a2_bot;
        private System.Windows.Forms.Timer time_a3_bot;
        private System.Windows.Forms.Timer time_bot;
        private System.Windows.Forms.Button easy_butt;
        private System.Windows.Forms.Button normal_butt;
        private System.Windows.Forms.Label player_hp_label;
        private System.Windows.Forms.Label bot_hp_label;
        private System.Windows.Forms.Label player_win;
        private System.Windows.Forms.Label bot_win;
        private System.Windows.Forms.Button hard_butt;
        private System.Windows.Forms.Button rip_butt;
    }
}

