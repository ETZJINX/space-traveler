namespace WinFormsApp1
{
    partial class Playform
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
            coin = new Label();
            score = new Label();
            panel1 = new Panel();
            healthbar = new Panel();
            PlayPanl = new Panel();
            health = new Label();
            coinamount = new Label();
            scoreamount = new Label();
            SuspendLayout();
            // 
            // coin
            // 
            coin.Anchor = AnchorStyles.Top;
            coin.AutoSize = true;
            coin.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coin.Location = new Point(332, 8);
            coin.Name = "coin";
            coin.Size = new Size(63, 19);
            coin.TabIndex = 0;
            coin.Text = "COINS:";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.Location = new Point(31, 9);
            score.Name = "score";
            score.Size = new Size(66, 19);
            score.TabIndex = 1;
            score.Text = "SCORE:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(881, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 19);
            panel1.TabIndex = 2;
            // 
            // healthbar
            // 
            healthbar.Location = new Point(881, 9);
            healthbar.Name = "healthbar";
            healthbar.Size = new Size(191, 19);
            healthbar.TabIndex = 3;
            // 
            // PlayPanl
            // 
            PlayPanl.Location = new Point(12, 34);
            PlayPanl.Name = "PlayPanl";
            PlayPanl.Size = new Size(1033, 540);
            PlayPanl.TabIndex = 4;
            PlayPanl.Paint += PlayPanl_Paint;
            // 
            // health
            // 
            health.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            health.AutoSize = true;
            health.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            health.Location = new Point(724, 8);
            health.Name = "health";
            health.Size = new Size(136, 19);
            health.TabIndex = 5;
            health.Text = "PLAYERHEALTH";
            // 
            // coinamount
            // 
            coinamount.Anchor = AnchorStyles.Top;
            coinamount.AutoSize = true;
            coinamount.Location = new Point(401, 8);
            coinamount.Name = "coinamount";
            coinamount.Size = new Size(51, 19);
            coinamount.TabIndex = 6;
            coinamount.Text = "label1";
            // 
            // scoreamount
            // 
            scoreamount.AutoSize = true;
            scoreamount.Location = new Point(116, 8);
            scoreamount.Name = "scoreamount";
            scoreamount.Size = new Size(51, 19);
            scoreamount.TabIndex = 7;
            scoreamount.Text = "label2";
            // 
            // Playform
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 597);
            Controls.Add(scoreamount);
            Controls.Add(coinamount);
            Controls.Add(healthbar);
            Controls.Add(panel1);
            Controls.Add(health);
            Controls.Add(PlayPanl);
            Controls.Add(score);
            Controls.Add(coin);
            Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Playform";
            Text = "Playform";
            KeyDown += Playform_KeyDown;
            KeyUp += Playform_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coin;
        private Label score;
        private Panel panel1;
        private Panel healthbar;
        private Panel PlayPanl;
        private Label health;
        private Label coinamount;
        private Label scoreamount;
    }
}