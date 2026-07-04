namespace WinFormsApp1.Forms
{
    partial class Option
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
            soundeffect = new TrackBar();
            music = new TrackBar();
            label1 = new Label();
            musiceffect = new Label();
            SFX = new Label();
            MuteMusic = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            AUDIO = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)soundeffect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music).BeginInit();
            groupBox1.SuspendLayout();
            AUDIO.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // soundeffect
            // 
            soundeffect.Location = new Point(22, 50);
            soundeffect.Maximum = 100;
            soundeffect.Name = "soundeffect";
            soundeffect.Size = new Size(606, 56);
            soundeffect.TabIndex = 0;
            soundeffect.Value = 60;
            soundeffect.Scroll += soundeffect_Scroll;
            // 
            // music
            // 
            music.Anchor = AnchorStyles.Left;
            music.Location = new Point(22, 196);
            music.Maximum = 100;
            music.Name = "music";
            music.Size = new Size(606, 56);
            music.TabIndex = 1;
            music.Scroll += music_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(625, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 2;
            label1.Text = "OPTION FORM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // musiceffect
            // 
            musiceffect.Anchor = AnchorStyles.None;
            musiceffect.AutoSize = true;
            musiceffect.Location = new Point(813, 226);
            musiceffect.Name = "musiceffect";
            musiceffect.Size = new Size(69, 26);
            musiceffect.TabIndex = 3;
            musiceffect.Text = "Music";
            // 
            // SFX
            // 
            SFX.Anchor = AnchorStyles.Top;
            SFX.AutoSize = true;
            SFX.Location = new Point(813, 50);
            SFX.Name = "SFX";
            SFX.Size = new Size(127, 26);
            SFX.TabIndex = 4;
            SFX.Text = "SoundEffect";
            // 
            // MuteMusic
            // 
            MuteMusic.Anchor = AnchorStyles.Right;
            MuteMusic.AutoSize = true;
            MuteMusic.Location = new Point(1038, 222);
            MuteMusic.Name = "MuteMusic";
            MuteMusic.Size = new Size(141, 30);
            MuteMusic.TabIndex = 5;
            MuteMusic.Text = "MuteMusic";
            MuteMusic.UseVisualStyleBackColor = true;
            MuteMusic.CheckedChanged += MuteMusic_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1058, 46);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 30);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "MuteSFX";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(soundeffect);
            groupBox1.Controls.Add(music);
            groupBox1.Controls.Add(MuteMusic);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(musiceffect);
            groupBox1.Controls.Add(SFX);
            groupBox1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1301, 363);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "AUDIO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(650, 226);
            label3.Name = "label3";
            label3.Size = new Size(70, 26);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 50);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 7;
            label2.Text = "lable2";
            // 
            // AUDIO
            // 
            AUDIO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AUDIO.Controls.Add(tabPage1);
            AUDIO.Controls.Add(tabPage2);
            AUDIO.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AUDIO.Location = new Point(26, 52);
            AUDIO.Name = "AUDIO";
            AUDIO.SelectedIndex = 0;
            AUDIO.Size = new Size(1318, 411);
            AUDIO.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1310, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "AUDIO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1310, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CONTROL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 475);
            Controls.Add(AUDIO);
            Controls.Add(label1);
            Name = "Option";
            Text = "Option";
            ((System.ComponentModel.ISupportInitialize)soundeffect).EndInit();
            ((System.ComponentModel.ISupportInitialize)music).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            AUDIO.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar soundeffect;
        private TrackBar music;
        private Label label1;
        private Label musiceffect;
        private Label SFX;
        private CheckBox MuteMusic;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TabControl AUDIO;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}