using WinFormsApp1.Managers;

namespace WinFormsApp1.Forms
{
    partial class Shop11
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
            panel1 = new Panel();
            Bulletlist = new Button();
            Backgroundlist = new Button();
            Shipslist = new Button();
            panel4 = new Panel();
            coin3 = new Label();
            Showinfo2 = new Panel();
            Health = new Label();
            Itemspeed = new Label();
            Itemdamage = new Label();
            Itemprice = new Label();
            Itemname = new Label();
            Itemtype12 = new Label();
            Buybutton = new Button();
            Equipbutton = new Button();
            Sellbutton = new Button();
            panel3 = new Panel();
            playername2 = new Label();
            Shop1 = new Label();
            panel2 = new Panel();
            healthbar1 = new Panel();
            pictureBox1 = new PictureBox();
            healthbar = new Label();
            damagebar = new Label();
            HealthSpeed = new Panel();
            DamageDamage = new Panel();
            damagebar1 = new Panel();
            prebutton = new Button();
            nextbutton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            Showinfo2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DamageDamage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Bulletlist);
            panel1.Controls.Add(Backgroundlist);
            panel1.Controls.Add(Shipslist);
            panel1.Location = new Point(4, 39);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 322);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Bulletlist
            // 
            Bulletlist.Location = new Point(15, 227);
            Bulletlist.Margin = new Padding(3, 2, 3, 2);
            Bulletlist.Name = "Bulletlist";
            Bulletlist.Size = new Size(88, 75);
            Bulletlist.TabIndex = 5;
            Bulletlist.Text = "Bullet";
            Bulletlist.UseVisualStyleBackColor = true;
            Bulletlist.Click += Bulletlist_Click;
            // 
            // Backgroundlist
            // 
            Backgroundlist.Location = new Point(15, 127);
            Backgroundlist.Margin = new Padding(3, 2, 3, 2);
            Backgroundlist.Name = "Backgroundlist";
            Backgroundlist.Size = new Size(88, 75);
            Backgroundlist.TabIndex = 5;
            Backgroundlist.Text = "Background";
            Backgroundlist.UseVisualStyleBackColor = true;
            Backgroundlist.Click += Backgroundlist_Click;
            // 
            // Shipslist
            // 
            Shipslist.Location = new Point(15, 25);
            Shipslist.Margin = new Padding(3, 2, 3, 2);
            Shipslist.Name = "Shipslist";
            Shipslist.Size = new Size(88, 75);
            Shipslist.TabIndex = 5;
            Shipslist.Text = "Ships";
            Shipslist.UseVisualStyleBackColor = true;
            Shipslist.Click += Shipslist_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(coin3);
            panel4.Location = new Point(10, 4);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(108, 31);
            panel4.TabIndex = 5;
            // 
            // coin3
            // 
            coin3.AutoSize = true;
            coin3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coin3.Location = new Point(3, 6);
            coin3.Name = "coin3";
            coin3.Size = new Size(37, 22);
            coin3.TabIndex = 1;
            coin3.Text = "800";
            // 
            // Showinfo2
            // 
            Showinfo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Showinfo2.Controls.Add(Health);
            Showinfo2.Controls.Add(Itemspeed);
            Showinfo2.Controls.Add(Itemdamage);
            Showinfo2.Controls.Add(Itemprice);
            Showinfo2.Controls.Add(Itemname);
            Showinfo2.Controls.Add(Itemtype12);
            Showinfo2.Controls.Add(Buybutton);
            Showinfo2.Controls.Add(Equipbutton);
            Showinfo2.Controls.Add(Sellbutton);
            Showinfo2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Showinfo2.Location = new Point(822, 39);
            Showinfo2.Margin = new Padding(3, 2, 3, 2);
            Showinfo2.Name = "Showinfo2";
            Showinfo2.Size = new Size(377, 322);
            Showinfo2.TabIndex = 2;
            // 
            // Health
            // 
            Health.AutoSize = true;
            Health.Location = new Point(157, 202);
            Health.Name = "Health";
            Health.Size = new Size(60, 22);
            Health.TabIndex = 8;
            Health.Text = "Health";
            // 
            // Itemspeed
            // 
            Itemspeed.AutoSize = true;
            Itemspeed.Location = new Point(157, 166);
            Itemspeed.Name = "Itemspeed";
            Itemspeed.Size = new Size(53, 22);
            Itemspeed.TabIndex = 7;
            Itemspeed.Text = "Speed";
            // 
            // Itemdamage
            // 
            Itemdamage.AutoSize = true;
            Itemdamage.Location = new Point(157, 127);
            Itemdamage.Name = "Itemdamage";
            Itemdamage.Size = new Size(70, 22);
            Itemdamage.TabIndex = 6;
            Itemdamage.Text = "Damage";
            // 
            // Itemprice
            // 
            Itemprice.AutoSize = true;
            Itemprice.Location = new Point(157, 92);
            Itemprice.Name = "Itemprice";
            Itemprice.Size = new Size(49, 22);
            Itemprice.TabIndex = 5;
            Itemprice.Text = "Price";
            // 
            // Itemname
            // 
            Itemname.AutoSize = true;
            Itemname.Location = new Point(157, 52);
            Itemname.Name = "Itemname";
            Itemname.Size = new Size(53, 22);
            Itemname.TabIndex = 4;
            Itemname.Text = "Name";
            // 
            // Itemtype12
            // 
            Itemtype12.AutoSize = true;
            Itemtype12.Location = new Point(157, 12);
            Itemtype12.Name = "Itemtype12";
            Itemtype12.Size = new Size(47, 22);
            Itemtype12.TabIndex = 3;
            Itemtype12.Text = "Type";
            // 
            // Buybutton
            // 
            Buybutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buybutton.Location = new Point(157, 238);
            Buybutton.Margin = new Padding(3, 2, 3, 2);
            Buybutton.Name = "Buybutton";
            Buybutton.Size = new Size(61, 52);
            Buybutton.TabIndex = 2;
            Buybutton.Text = "Buy";
            Buybutton.UseVisualStyleBackColor = true;
            Buybutton.Click += Buybutton_Click;
            // 
            // Equipbutton
            // 
            Equipbutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Equipbutton.Location = new Point(313, 238);
            Equipbutton.Margin = new Padding(3, 2, 3, 2);
            Equipbutton.Name = "Equipbutton";
            Equipbutton.Size = new Size(61, 52);
            Equipbutton.TabIndex = 1;
            Equipbutton.Text = "Equip";
            Equipbutton.UseVisualStyleBackColor = true;
            Equipbutton.Click += Equipbutton_Click;
            // 
            // Sellbutton
            // 
            Sellbutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sellbutton.Location = new Point(3, 238);
            Sellbutton.Margin = new Padding(3, 2, 3, 2);
            Sellbutton.Name = "Sellbutton";
            Sellbutton.Size = new Size(61, 52);
            Sellbutton.TabIndex = 0;
            Sellbutton.Text = "Sell";
            Sellbutton.UseVisualStyleBackColor = true;
            Sellbutton.Click += Sellbutton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(playername2);
            panel3.Location = new Point(1070, 4);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 33);
            panel3.TabIndex = 3;
            // 
            // playername2
            // 
            playername2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playername2.AutoSize = true;
            playername2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playername2.Location = new Point(18, 6);
            playername2.Name = "playername2";
            playername2.Size = new Size(96, 22);
            playername2.TabIndex = 0;
            playername2.Text = "playername";
            // 
            // Shop1
            // 
            Shop1.Anchor = AnchorStyles.Top;
            Shop1.AutoSize = true;
            Shop1.BackColor = SystemColors.ButtonHighlight;
            Shop1.BorderStyle = BorderStyle.Fixed3D;
            Shop1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shop1.Location = new Point(399, 7);
            Shop1.Name = "Shop1";
            Shop1.Size = new Size(63, 30);
            Shop1.TabIndex = 4;
            Shop1.Text = "Shop";
            Shop1.Click += Shop1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(healthbar1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(healthbar);
            panel2.Controls.Add(damagebar);
            panel2.Controls.Add(HealthSpeed);
            panel2.Controls.Add(DamageDamage);
            panel2.Controls.Add(prebutton);
            panel2.Controls.Add(nextbutton);
            panel2.Location = new Point(123, 39);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 322);
            panel2.TabIndex = 6;
            // 
            // healthbar1
            // 
            healthbar1.Location = new Point(195, 253);
            healthbar1.Margin = new Padding(3, 2, 3, 2);
            healthbar1.Name = "healthbar1";
            healthbar1.Size = new Size(88, 38);
            healthbar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // healthbar
            // 
            healthbar.AutoSize = true;
            healthbar.Location = new Point(112, 266);
            healthbar.Name = "healthbar";
            healthbar.Size = new Size(42, 15);
            healthbar.TabIndex = 5;
            healthbar.Text = "Health";
            // 
            // damagebar
            // 
            damagebar.AutoSize = true;
            damagebar.Location = new Point(112, 214);
            damagebar.Name = "damagebar";
            damagebar.Size = new Size(51, 15);
            damagebar.TabIndex = 4;
            damagebar.Text = "Damage";
            // 
            // HealthSpeed
            // 
            HealthSpeed.Location = new Point(195, 253);
            HealthSpeed.Margin = new Padding(3, 2, 3, 2);
            HealthSpeed.Name = "HealthSpeed";
            HealthSpeed.Size = new Size(262, 38);
            HealthSpeed.TabIndex = 3;
            // 
            // DamageDamage
            // 
            DamageDamage.Controls.Add(damagebar1);
            DamageDamage.Location = new Point(195, 202);
            DamageDamage.Margin = new Padding(3, 2, 3, 2);
            DamageDamage.Name = "DamageDamage";
            DamageDamage.Size = new Size(262, 38);
            DamageDamage.TabIndex = 2;
            // 
            // damagebar1
            // 
            damagebar1.Location = new Point(0, 0);
            damagebar1.Margin = new Padding(3, 2, 3, 2);
            damagebar1.Name = "damagebar1";
            damagebar1.Size = new Size(175, 38);
            damagebar1.TabIndex = 4;
            // 
            // prebutton
            // 
            prebutton.Image = Properties.Resources.PreviousIcon;
            prebutton.Location = new Point(5, 99);
            prebutton.Margin = new Padding(3, 2, 3, 2);
            prebutton.Name = "prebutton";
            prebutton.Size = new Size(80, 80);
            prebutton.TabIndex = 1;
            prebutton.UseVisualStyleBackColor = true;
            prebutton.Click += prebutton_Click;
            // 
            // nextbutton
            // 
            nextbutton.Image = Properties.Resources.NextIcon;
            nextbutton.Location = new Point(613, 99);
            nextbutton.Margin = new Padding(3, 2, 3, 2);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(80, 80);
            nextbutton.TabIndex = 0;
            nextbutton.UseVisualStyleBackColor = true;
            nextbutton.Click += nextbutton_Click;
            // 
            // Shop11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 370);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(Shop1);
            Controls.Add(panel3);
            Controls.Add(Showinfo2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Shop11";
            Text = "Shop";
            FormClosing += Shop11_FormClosing;
            Load += Shop11_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Showinfo2.ResumeLayout(false);
            Showinfo2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DamageDamage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel Showinfo2;
        private Panel panel3;
        private Label coin3;
        private Label playername2;
        private Label Shop1;
        private Button Bulletlist;
        private Button Backgroundlist;
        private Button Shipslist;
        private Button Buybutton;
        private Button Equipbutton;
        private Button Sellbutton;
        private Panel panel4;
        private Label Itemspeed;
        private Label Itemdamage;
        private Label Itemprice;
        private Label Itemname;
        private Label Itemtype12;
        private Panel panel2;
        private Button prebutton;
        private Button nextbutton;
        private Label Health;
        private PictureBox pictureBox1;
        private Label healthbar;
        private Label damagebar;
        private Panel HealthSpeed;
        private Panel healthbar1;
        private Panel DamageDamage;
        private Panel damagebar1;
    }
}