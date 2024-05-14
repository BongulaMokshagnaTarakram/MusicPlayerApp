namespace Music_Player_App
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Songs = new System.Windows.Forms.ListBox();
            this.Select_Songs = new System.Windows.Forms.Button();
            this.Developed_by_Mokshagna_Tarakram = new System.Windows.Forms.Label();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Top Panel";
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(832, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Songs
            // 
            this.Songs.AccessibleName = "Songs";
            this.Songs.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songs.FormattingEnabled = true;
            this.Songs.ItemHeight = 20;
            this.Songs.Location = new System.Drawing.Point(666, 81);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(195, 304);
            this.Songs.TabIndex = 1;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            // 
            // Select_Songs
            // 
            this.Select_Songs.AccessibleName = "songs";
            this.Select_Songs.BackColor = System.Drawing.Color.Black;
            this.Select_Songs.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Songs.ForeColor = System.Drawing.Color.White;
            this.Select_Songs.Location = new System.Drawing.Point(666, 404);
            this.Select_Songs.Name = "Select_Songs";
            this.Select_Songs.Size = new System.Drawing.Size(194, 53);
            this.Select_Songs.TabIndex = 2;
            this.Select_Songs.Text = "Select Songs";
            this.Select_Songs.UseVisualStyleBackColor = false;
            this.Select_Songs.Click += new System.EventHandler(this.button1_Click);
            // 
            // Developed_by_Mokshagna_Tarakram
            // 
            this.Developed_by_Mokshagna_Tarakram.AutoSize = true;
            this.Developed_by_Mokshagna_Tarakram.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Developed_by_Mokshagna_Tarakram.Location = new System.Drawing.Point(357, 482);
            this.Developed_by_Mokshagna_Tarakram.Name = "Developed_by_Mokshagna_Tarakram";
            this.Developed_by_Mokshagna_Tarakram.Size = new System.Drawing.Size(229, 16);
            this.Developed_by_Mokshagna_Tarakram.TabIndex = 4;
            this.Developed_by_Mokshagna_Tarakram.Text = "Developed by Mokshagna Tarakram";
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.AccessibleName = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(12, 69);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(485, 316);
            this.WindowsMediaPlayer.TabIndex = 3;
            this.WindowsMediaPlayer.Enter += new System.EventHandler(this.WindowsMediaPlayer_Enter);
            // 
            // Music
            // 
            this.AccessibleName = "Music Player App";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.Developed_by_Mokshagna_Tarakram);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.Select_Songs);
            this.Controls.Add(this.Songs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.Button Select_Songs;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Label Developed_by_Mokshagna_Tarakram;
    }
}

