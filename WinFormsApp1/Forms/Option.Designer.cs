using WinFormsApp1.Managers;

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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            AUDIO = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            shootbox = new ComboBox();
            leftbox = new ComboBox();
            rightbox = new ComboBox();
            backwardbox = new ComboBox();
            forwardbox = new ComboBox();
            Shootkey = new Label();
            Moveleftkey = new Label();
            Moverightkey = new Label();
            Movebackwardkey = new Label();
            Moveforwardkey = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)soundeffect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music).BeginInit();
            groupBox1.SuspendLayout();
            AUDIO.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // soundeffect
            // 
            soundeffect.Location = new Point(22, 50);
            soundeffect.Maximum = 100;
            soundeffect.Name = "soundeffect";
            soundeffect.Size = new Size(606, 56);
            soundeffect.TabIndex = 0;
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
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Location = new Point(268, 258);
            button2.Name = "button2";
            button2.Size = new Size(130, 37);
            button2.TabIndex = 10;
            button2.Text = "music";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(268, 112);
            button1.Name = "button1";
            button1.Size = new Size(130, 37);
            button1.TabIndex = 9;
            button1.Text = "sound";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            tabPage2.Controls.Add(shootbox);
            tabPage2.Controls.Add(leftbox);
            tabPage2.Controls.Add(rightbox);
            tabPage2.Controls.Add(backwardbox);
            tabPage2.Controls.Add(forwardbox);
            tabPage2.Controls.Add(Shootkey);
            tabPage2.Controls.Add(Moveleftkey);
            tabPage2.Controls.Add(Moverightkey);
            tabPage2.Controls.Add(Movebackwardkey);
            tabPage2.Controls.Add(Moveforwardkey);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1310, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CONTROL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // shootbox
            // 
            shootbox.FormattingEnabled = true;
            shootbox.Location = new Point(653, 308);
            shootbox.Name = "shootbox";
            shootbox.Size = new Size(151, 34);
            shootbox.TabIndex = 14;
            shootbox.SelectedIndexChanged += shootbox_SelectedIndexChanged;
            // 
            // leftbox
            // 
            leftbox.FormattingEnabled = true;
            leftbox.Location = new Point(653, 232);
            leftbox.Name = "leftbox";
            leftbox.Size = new Size(151, 34);
            leftbox.TabIndex = 13;
            leftbox.SelectedIndexChanged += leftbox_SelectedIndexChanged;
            // 
            // rightbox
            // 
            rightbox.FormattingEnabled = true;
            rightbox.Location = new Point(653, 157);
            rightbox.Name = "rightbox";
            rightbox.Size = new Size(151, 34);
            rightbox.TabIndex = 12;
            rightbox.SelectedIndexChanged += rightbox_SelectedIndexChanged;
            // 
            // backwardbox
            // 
            backwardbox.FormattingEnabled = true;
            backwardbox.Location = new Point(653, 89);
            backwardbox.Name = "backwardbox";
            backwardbox.Size = new Size(151, 34);
            backwardbox.TabIndex = 11;
            backwardbox.SelectedIndexChanged += backwardbox_SelectedIndexChanged;
            // 
            // forwardbox
            // 
            forwardbox.FormattingEnabled = true;
            forwardbox.Location = new Point(653, 24);
            forwardbox.Name = "forwardbox";
            forwardbox.Size = new Size(151, 34);
            forwardbox.TabIndex = 10;
            forwardbox.SelectedIndexChanged += forwardbox_SelectedIndexChanged;
            // 
            // Shootkey
            // 
            Shootkey.AutoSize = true;
            Shootkey.Location = new Point(405, 308);
            Shootkey.Name = "Shootkey";
            Shootkey.Size = new Size(81, 26);
            Shootkey.TabIndex = 9;
            Shootkey.Text = "label13";
            // 
            // Moveleftkey
            // 
            Moveleftkey.AutoSize = true;
            Moveleftkey.Location = new Point(405, 232);
            Moveleftkey.Name = "Moveleftkey";
            Moveleftkey.Size = new Size(81, 26);
            Moveleftkey.TabIndex = 8;
            Moveleftkey.Text = "label12";
            // 
            // Moverightkey
            // 
            Moverightkey.AutoSize = true;
            Moverightkey.Location = new Point(405, 157);
            Moverightkey.Name = "Moverightkey";
            Moverightkey.Size = new Size(81, 26);
            Moverightkey.TabIndex = 7;
            Moverightkey.Text = "label11";
            // 
            // Movebackwardkey
            // 
            Movebackwardkey.AutoSize = true;
            Movebackwardkey.Location = new Point(405, 89);
            Movebackwardkey.Name = "Movebackwardkey";
            Movebackwardkey.Size = new Size(81, 26);
            Movebackwardkey.TabIndex = 6;
            Movebackwardkey.Text = "label10";
            // 
            // Moveforwardkey
            // 
            Moveforwardkey.AutoSize = true;
            Moveforwardkey.Location = new Point(405, 24);
            Moveforwardkey.Name = "Moveforwardkey";
            Moveforwardkey.Size = new Size(70, 26);
            Moveforwardkey.TabIndex = 5;
            Moveforwardkey.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(145, 308);
            label8.Name = "label8";
            label8.Size = new Size(85, 26);
            label8.TabIndex = 4;
            label8.Text = "SHOOT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 232);
            label7.Name = "label7";
            label7.Size = new Size(131, 26);
            label7.TabIndex = 3;
            label7.Text = "MOVE LEFT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 157);
            label6.Name = "label6";
            label6.Size = new Size(149, 26);
            label6.TabIndex = 2;
            label6.Text = "MOVE RIGHT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 89);
            label5.Name = "label5";
            label5.Size = new Size(203, 26);
            label5.TabIndex = 1;
            label5.Text = "MOVE BACKWARD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 24);
            label4.Name = "label4";
            label4.Size = new Size(189, 26);
            label4.TabIndex = 0;
            label4.Text = "MOVE FORWARD";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Button button2;
        private Button button1;
        private ComboBox shootbox;
        private ComboBox leftbox;
        private ComboBox rightbox;
        private ComboBox backwardbox;
        private ComboBox forwardbox;
        private Label Shootkey;
        private Label Moveleftkey;
        private Label Moverightkey;
        private Label Movebackwardkey;
        private Label Moveforwardkey;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}