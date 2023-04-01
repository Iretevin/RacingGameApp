namespace RacingAPP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Award = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.Award);
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.RoadTrack2);
            this.panel1.Controls.Add(this.RoadTrack1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 520);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // A2
            // 
            this.A2.Image = global::RacingAPP.Properties.Resources.carGrey;
            this.A2.Location = new System.Drawing.Point(432, 12);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(50, 100);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A2.TabIndex = 2;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // player
            // 
            this.player.Image = global::RacingAPP.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(390, 334);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Award
            // 
            this.Award.Image = global::RacingAPP.Properties.Resources.bronze;
            this.Award.Location = new System.Drawing.Point(289, 152);
            this.Award.Name = "Award";
            this.Award.Size = new System.Drawing.Size(250, 100);
            this.Award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Award.TabIndex = 2;
            this.Award.TabStop = false;
            this.Award.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Explosion
            // 
            this.Explosion.Image = global::RacingAPP.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(151, 306);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosion.TabIndex = 2;
            this.Explosion.TabStop = false;
            this.Explosion.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // A1
            // 
            this.A1.Image = global::RacingAPP.Properties.Resources.carGreen;
            this.A1.Location = new System.Drawing.Point(289, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(50, 101);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A1.TabIndex = 2;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::RacingAPP.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(0, 520);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(797, 520);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 1;
            this.RoadTrack2.TabStop = false;
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.Image = global::RacingAPP.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(0, -520);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(797, 1000);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 0;
            this.RoadTrack1.TabStop = false;
            this.RoadTrack1.Click += new System.EventHandler(this.RoadTrack1_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(369, 527);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(71, 20);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score:0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(365, 550);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 105);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press Left and Right to control the game.\r\n\r\nDon\'t Hit any other car in the game " +
    "And Survive as log as you can.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RACING GAME.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.PictureBox Award;
        private System.Windows.Forms.Timer GameTimer;
    }
}

