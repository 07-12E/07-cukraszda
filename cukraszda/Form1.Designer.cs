namespace cukraszda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            megnyitásToolStripMenuItem = new ToolStripMenuItem();
            süteményekToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, süteményekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(666, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { megnyitásToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            megnyitásToolStripMenuItem.Size = new Size(180, 22);
            megnyitásToolStripMenuItem.Text = "Megnyitás";
            megnyitásToolStripMenuItem.Click += megnyitásToolStripMenuItem_Click;
            // 
            // süteményekToolStripMenuItem
            // 
            süteményekToolStripMenuItem.Enabled = false;
            süteményekToolStripMenuItem.Name = "süteményekToolStripMenuItem";
            süteményekToolStripMenuItem.Size = new Size(84, 20);
            süteményekToolStripMenuItem.Text = "Sütemények";
            süteményekToolStripMenuItem.Click += süteményekToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.torta;
            pictureBox1.Location = new Point(74, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 411);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem süteményekToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem megnyitásToolStripMenuItem;
    }
}
