namespace cukraszda
{
    partial class arlistaform
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 27);
            label1.Name = "label1";
            label1.Size = new Size(129, 45);
            label1.TabIndex = 0;
            label1.Text = "Árlista";
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 390);
            button1.Name = "button1";
            button1.Size = new Size(308, 27);
            button1.TabIndex = 1;
            button1.Text = "Megrendelem!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // arlistaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(522, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "arlistaform";
            Text = "arlistaform";
            Load += arlistaform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}