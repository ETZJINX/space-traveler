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
            prebutton = new Button();
            nextbutton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            Showinfo2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Bulletlist);
            panel1.Controls.Add(Backgroundlist);
            panel1.Controls.Add(Shipslist);
            panel1.Location = new Point(5, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 429);
            panel1.TabIndex = 0;
            // 
            // Bulletlist
            // 
            Bulletlist.Location = new Point(17, 303);
            Bulletlist.Name = "Bulletlist";
            Bulletlist.Size = new Size(100, 100);
            Bulletlist.TabIndex = 5;
            Bulletlist.Text = "Bullet";
            Bulletlist.UseVisualStyleBackColor = true;
            Bulletlist.Click += Bulletlist_Click;
            // 
            // Backgroundlist
            // 
            Backgroundlist.Location = new Point(17, 169);
            Backgroundlist.Name = "Backgroundlist";
            Backgroundlist.Size = new Size(100, 100);
            Backgroundlist.TabIndex = 5;
            Backgroundlist.Text = "Background";
            Backgroundlist.UseVisualStyleBackColor = true;
            Backgroundlist.Click += Backgroundlist_Click;
            // 
            // Shipslist
            // 
            Shipslist.Location = new Point(17, 33);
            Shipslist.Name = "Shipslist";
            Shipslist.Size = new Size(100, 100);
            Shipslist.TabIndex = 5;
            Shipslist.Text = "Ships";
            Shipslist.UseVisualStyleBackColor = true;
            Shipslist.Click += Shipslist_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(coin3);
            panel4.Location = new Point(12, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(123, 41);
            panel4.TabIndex = 5;
            // 
            // coin3
            // 
            coin3.AutoSize = true;
            coin3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coin3.Location = new Point(3, 8);
            coin3.Name = "coin3";
            coin3.Size = new Size(45, 26);
            coin3.TabIndex = 1;
            coin3.Text = "800";
            // 
            // Showinfo2
            // 
            Showinfo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Showinfo2.Controls.Add(Itemspeed);
            Showinfo2.Controls.Add(Itemdamage);
            Showinfo2.Controls.Add(Itemprice);
            Showinfo2.Controls.Add(Itemname);
            Showinfo2.Controls.Add(Itemtype12);
            Showinfo2.Controls.Add(Buybutton);
            Showinfo2.Controls.Add(Equipbutton);
            Showinfo2.Controls.Add(Sellbutton);
            Showinfo2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Showinfo2.Location = new Point(939, 52);
            Showinfo2.Name = "Showinfo2";
            Showinfo2.Size = new Size(431, 429);
            Showinfo2.TabIndex = 2;
            // 
            // Itemspeed
            // 
            Itemspeed.AutoSize = true;
            Itemspeed.Location = new Point(179, 240);
            Itemspeed.Name = "Itemspeed";
            Itemspeed.Size = new Size(67, 26);
            Itemspeed.TabIndex = 7;
            Itemspeed.Text = "Speed";
            // 
            // Itemdamage
            // 
            Itemdamage.AutoSize = true;
            Itemdamage.Location = new Point(179, 183);
            Itemdamage.Name = "Itemdamage";
            Itemdamage.Size = new Size(89, 26);
            Itemdamage.TabIndex = 6;
            Itemdamage.Text = "Damage";
            // 
            // Itemprice
            // 
            Itemprice.AutoSize = true;
            Itemprice.Location = new Point(179, 122);
            Itemprice.Name = "Itemprice";
            Itemprice.Size = new Size(61, 26);
            Itemprice.TabIndex = 5;
            Itemprice.Text = "Price";
            // 
            // Itemname
            // 
            Itemname.AutoSize = true;
            Itemname.Location = new Point(179, 61);
            Itemname.Name = "Itemname";
            Itemname.Size = new Size(68, 26);
            Itemname.TabIndex = 4;
            Itemname.Text = "Name";
            // 
            // Itemtype12
            // 
            Itemtype12.AutoSize = true;
            Itemtype12.Location = new Point(179, 16);
            Itemtype12.Name = "Itemtype12";
            Itemtype12.Size = new Size(58, 26);
            Itemtype12.TabIndex = 3;
            Itemtype12.Text = "Type";
            // 
            // Buybutton
            // 
            Buybutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buybutton.Location = new Point(179, 318);
            Buybutton.Name = "Buybutton";
            Buybutton.Size = new Size(70, 70);
            Buybutton.TabIndex = 2;
            Buybutton.Text = "Buy";
            Buybutton.UseVisualStyleBackColor = true;
            Buybutton.Click += Buybutton_Click;
            // 
            // Equipbutton
            // 
            Equipbutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Equipbutton.Location = new Point(358, 318);
            Equipbutton.Name = "Equipbutton";
            Equipbutton.Size = new Size(70, 70);
            Equipbutton.TabIndex = 1;
            Equipbutton.Text = "Equip";
            Equipbutton.UseVisualStyleBackColor = true;
            Equipbutton.Click += Equipbutton_Click;
            // 
            // Sellbutton
            // 
            Sellbutton.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sellbutton.Location = new Point(3, 318);
            Sellbutton.Name = "Sellbutton";
            Sellbutton.Size = new Size(70, 70);
            Sellbutton.TabIndex = 0;
            Sellbutton.Text = "Sell";
            Sellbutton.UseVisualStyleBackColor = true;
            Sellbutton.Click += Sellbutton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(playername2);
            panel3.Location = new Point(1223, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 44);
            panel3.TabIndex = 3;
            // 
            // playername2
            // 
            playername2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            playername2.AutoSize = true;
            playername2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playername2.Location = new Point(20, 8);
            playername2.Name = "playername2";
            playername2.Size = new Size(125, 26);
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
            Shop1.Location = new Point(692, 5);
            Shop1.Name = "Shop1";
            Shop1.Size = new Size(79, 38);
            Shop1.TabIndex = 4;
            Shop1.Text = "Shop";
            // 
            // panel2
            // 
            panel2.Controls.Add(prebutton);
            panel2.Controls.Add(nextbutton);
            panel2.Location = new Point(141, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 429);
            panel2.TabIndex = 6;
            // 
            // prebutton
            // 
            prebutton.Location = new Point(3, 183);
            prebutton.Name = "prebutton";
            prebutton.Size = new Size(120, 40);
            prebutton.TabIndex = 1;
            prebutton.Text = "Previous";
            prebutton.UseVisualStyleBackColor = true;
            prebutton.Click += prebutton_Click;
            // 
            // nextbutton
            // 
            nextbutton.Location = new Point(672, 183);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(120, 40);
            nextbutton.TabIndex = 0;
            nextbutton.Text = "Next";
            nextbutton.UseVisualStyleBackColor = true;
            nextbutton.Click += nextbutton_Click;
            // 
            // Shop11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 493);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(Shop1);
            Controls.Add(panel3);
            Controls.Add(Showinfo2);
            Controls.Add(panel1);
            Name = "Shop11";
            Text = "Shop";
            Load += Shop11_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Showinfo2.ResumeLayout(false);
            Showinfo2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
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
    }
}