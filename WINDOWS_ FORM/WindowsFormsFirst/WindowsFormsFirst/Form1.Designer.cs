namespace WindowsFormsFirst
{
    partial class Form1
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
            this.P11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.indexL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P11
            // 
            this.P11.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.P11.AutoSize = true;
            this.P11.Dock = System.Windows.Forms.DockStyle.Top;
            this.P11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P11.ForeColor = System.Drawing.Color.ForestGreen;
            this.P11.Location = new System.Drawing.Point(3, 3);
            this.P11.Name = "P11";
            this.P11.Size = new System.Drawing.Size(861, 32);
            this.P11.TabIndex = 0;
            this.P11.Text = "P111";
            this.P11.UseVisualStyleBackColor = true;
            this.P11.Click += new System.EventHandler(this.P11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // indexL1
            // 
            this.indexL1.AutoSize = true;
            this.indexL1.BackColor = System.Drawing.Color.SteelBlue;
            this.indexL1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexL1.Location = new System.Drawing.Point(28, 63);
            this.indexL1.Name = "indexL1";
            this.indexL1.Padding = new System.Windows.Forms.Padding(3);
            this.indexL1.Size = new System.Drawing.Size(57, 27);
            this.indexL1.TabIndex = 1;
            this.indexL1.Text = "Label";
            this.indexL1.Click += new System.EventHandler(this.IndexL1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(867, 441);
            this.Controls.Add(this.indexL1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P11);
            this.Font = new System.Drawing.Font("Ink Free", 8.25F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label indexL1;
    }
}

