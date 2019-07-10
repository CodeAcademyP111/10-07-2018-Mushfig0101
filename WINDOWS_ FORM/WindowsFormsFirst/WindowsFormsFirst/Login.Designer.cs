namespace WindowsFormsFirst
{
    partial class Login
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
            System.Windows.Forms.Button confirm;
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.textusername = new System.Windows.Forms.TextBox();
            confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.RoyalBlue;
            this.username.Location = new System.Drawing.Point(15, 59);
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(2);
            this.username.Size = new System.Drawing.Size(101, 31);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.UseCompatibleTextRendering = true;
            this.username.Click += new System.EventHandler(this.Label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.password.Location = new System.Drawing.Point(15, 148);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(2);
            this.password.Size = new System.Drawing.Size(96, 28);
            this.password.TabIndex = 3;
            this.password.Text = "Password\r\n";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(15, 179);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(125, 29);
            this.textpassword.TabIndex = 3;
            this.textpassword.TextChanged += new System.EventHandler(this.TextBox2_TextChanged_1);
            // 
            // confirm
            // 
            confirm.BackColor = System.Drawing.SystemColors.HotTrack;
            confirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confirm.ForeColor = System.Drawing.SystemColors.HighlightText;
            confirm.Location = new System.Drawing.Point(19, 239);
            confirm.Name = "confirm";
            confirm.Size = new System.Drawing.Size(100, 28);
            confirm.TabIndex = 5;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox.Location = new System.Drawing.Point(15, 214);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(110, 19);
            this.checkbox.TabIndex = 6;
            this.checkbox.Text = "show password\r\n";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(15, 107);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(125, 29);
            this.textusername.TabIndex = 7;
            this.textusername.TextChanged += new System.EventHandler(this.Textusername_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 360);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(confirm);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.TextBox textusername;
    }
}