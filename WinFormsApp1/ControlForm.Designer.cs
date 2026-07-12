namespace WinFormsApp1
{
    partial class ControlForm
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
            Newgame = new Button();
            Play = new Button();
            comboBox1 = new ComboBox();
            WaveSelector = new Button();
            SuspendLayout();
            // 
            // Newgame
            // 
            Newgame.Location = new Point(399, 20);
            Newgame.Name = "Newgame";
            Newgame.Size = new Size(260, 66);
            Newgame.TabIndex = 0;
            Newgame.Text = "Newgame";
            Newgame.UseVisualStyleBackColor = true;
            Newgame.Click += Newgame_Click;
            // 
            // Play
            // 
            Play.Location = new Point(399, 126);
            Play.Name = "Play";
            Play.Size = new Size(260, 66);
            Play.TabIndex = 1;
            Play.Text = "Play/continue";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(399, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 27);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // WaveSelector
            // 
            WaveSelector.Location = new Point(399, 230);
            WaveSelector.Name = "WaveSelector";
            WaveSelector.Size = new Size(260, 66);
            WaveSelector.TabIndex = 3;
            WaveSelector.Text = "Playthiswave";
            WaveSelector.UseVisualStyleBackColor = true;
            WaveSelector.Click += WaveSelector_Click;
            // 
            // ControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 428);
            Controls.Add(WaveSelector);
            Controls.Add(comboBox1);
            Controls.Add(Play);
            Controls.Add(Newgame);
            Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ControlForm";
            Text = "ControlForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Newgame;
        private Button Play;
        private ComboBox comboBox1;
        private Button WaveSelector;
    }
}