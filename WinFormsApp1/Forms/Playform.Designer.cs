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
            playerhealth = new Label();
            enemyremain = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // coin
            // 
            coin.Anchor = AnchorStyles.Top;
            coin.AutoSize = true;
            coin.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coin.Location = new Point(274, 8);
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
            panel1.Controls.Add(healthbar);
            panel1.Location = new Point(845, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 20);
            panel1.TabIndex = 2;
            // 
            // healthbar
            // 
            healthbar.Location = new Point(0, 0);
            healthbar.Name = "healthbar";
            healthbar.Size = new Size(150, 20);
            healthbar.TabIndex = 3;
            // 
            // PlayPanl
            // 
            PlayPanl.BackColor = Color.Transparent;
            PlayPanl.Location = new Point(12, 34);
            PlayPanl.Name = "PlayPanl";
            PlayPanl.Size = new Size(1033, 788);
            PlayPanl.TabIndex = 4;
            PlayPanl.Paint += PlayPanl_Paint;
            // 
            // health
            // 
            health.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            health.AutoSize = true;
            health.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            health.Location = new Point(646, 8);
            health.Name = "health";
            health.Size = new Size(136, 19);
            health.TabIndex = 5;
            health.Text = "PLAYERHEALTH";
            // 
            // coinamount
            // 
            coinamount.Anchor = AnchorStyles.Top;
            coinamount.AutoSize = true;
            coinamount.Location = new Point(343, 8);
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
            // playerhealth
            // 
            playerhealth.AutoSize = true;
            playerhealth.Location = new Point(788, 8);
            playerhealth.Name = "playerhealth";
            playerhealth.Size = new Size(51, 19);
            playerhealth.TabIndex = 8;
            playerhealth.Text = "label1";
            // 
            // enemyremain
            // 
            enemyremain.AutoSize = true;
            enemyremain.Location = new Point(466, 8);
            enemyremain.Name = "enemyremain";
            enemyremain.Size = new Size(51, 19);
            enemyremain.TabIndex = 9;
            enemyremain.Text = "label1";
            // 
            // Playform
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 834);
            Controls.Add(enemyremain);
            Controls.Add(playerhealth);
            Controls.Add(scoreamount);
            Controls.Add(coinamount);
            Controls.Add(panel1);
            Controls.Add(health);
            Controls.Add(PlayPanl);
            Controls.Add(score);
            Controls.Add(coin);
            Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Playform";
            Text = "Playform";
            FormClosed += Playform_FormClosed;
            KeyDown += Playform_KeyDown;
            KeyUp += Playform_KeyUp;
            panel1.ResumeLayout(false);
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
        private Label playerhealth;
        private Label enemyremain;
    }
}