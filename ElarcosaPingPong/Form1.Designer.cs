namespace ElarcosaPingPong
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
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerball = new System.Windows.Forms.Timer(this.components);
            this.scoreblue = new System.Windows.Forms.Label();
            this.scorered = new System.Windows.Forms.Label();
            this.timerai = new System.Windows.Forms.Timer(this.components);
            this.playervsplayer = new System.Windows.Forms.Button();
            this.playervsai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resume = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(65, 202);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 110);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Red;
            this.enemy.Location = new System.Drawing.Point(681, 202);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(30, 110);
            this.enemy.TabIndex = 1;
            this.enemy.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(380, 254);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerball
            // 
            this.timerball.Interval = 20;
            this.timerball.Tick += new System.EventHandler(this.timerball_Tick);
            // 
            // scoreblue
            // 
            this.scoreblue.AutoSize = true;
            this.scoreblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreblue.ForeColor = System.Drawing.Color.Blue;
            this.scoreblue.Location = new System.Drawing.Point(74, 42);
            this.scoreblue.Name = "scoreblue";
            this.scoreblue.Size = new System.Drawing.Size(21, 24);
            this.scoreblue.TabIndex = 3;
            this.scoreblue.Text = "0";
            // 
            // scorered
            // 
            this.scorered.AutoSize = true;
            this.scorered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorered.ForeColor = System.Drawing.Color.Red;
            this.scorered.Location = new System.Drawing.Point(677, 42);
            this.scorered.Name = "scorered";
            this.scorered.Size = new System.Drawing.Size(21, 24);
            this.scorered.TabIndex = 4;
            this.scorered.Text = "0";
            // 
            // timerai
            // 
            this.timerai.Interval = 20;
            this.timerai.Tick += new System.EventHandler(this.timerai_Tick);
            // 
            // playervsplayer
            // 
            this.playervsplayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playervsplayer.Location = new System.Drawing.Point(126, 84);
            this.playervsplayer.Name = "playervsplayer";
            this.playervsplayer.Size = new System.Drawing.Size(128, 46);
            this.playervsplayer.TabIndex = 5;
            this.playervsplayer.Text = "PLAYER VS PLAYER";
            this.playervsplayer.UseVisualStyleBackColor = true;
            this.playervsplayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // playervsai
            // 
            this.playervsai.Location = new System.Drawing.Point(126, 150);
            this.playervsai.Name = "playervsai";
            this.playervsai.Size = new System.Drawing.Size(128, 46);
            this.playervsai.TabIndex = 6;
            this.playervsai.Text = "PLAYER VS AI";
            this.playervsai.UseVisualStyleBackColor = true;
            this.playervsai.Click += new System.EventHandler(this.playervsai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.resume);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.playervsplayer);
            this.panel1.Controls.Add(this.playervsai);
            this.panel1.Location = new System.Drawing.Point(208, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 285);
            this.panel1.TabIndex = 7;
            // 
            // resume
            // 
            this.resume.Enabled = false;
            this.resume.Location = new System.Drawing.Point(126, 21);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(128, 46);
            this.resume.TabIndex = 8;
            this.resume.Text = "RESUME";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(126, 218);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 46);
            this.exit.TabIndex = 7;
            this.exit.Text = "EXIT GAME";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRESS \"P\" TO PAUSE ANYTIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "GAME PAUSED";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "test";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Elarcosa, Christian Jay B.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scorered);
            this.Controls.Add(this.scoreblue);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerball;
        private System.Windows.Forms.Label scoreblue;
        private System.Windows.Forms.Label scorered;
        private System.Windows.Forms.Timer timerai;
        private System.Windows.Forms.Button playervsplayer;
        private System.Windows.Forms.Button playervsai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

