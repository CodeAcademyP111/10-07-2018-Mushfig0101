using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFirst
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int blockCount = 0;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           string Username = "CodeAcademy"; string Password = "CodeP111"; 
            if(blockCount < 2)
            {
                if (textusername.Text.Trim() == Username && textpassword.Text.Trim() == Password)
                {
                    MessageBox.Show("Xos Gelmisiniz");
                }
                else if (textusername.Text.Trim() != Username)
                {
                    MessageBox.Show("Username isn't correct");
                }
                else if (textpassword.Text.Trim() != Password)
                {
                    MessageBox.Show("Password isn't correct");
                }

                blockCount++;
            }
            else
            {
                MessageBox.Show("Sisteme girisiniz qadagan olunub");
                this.Close();
            }
     }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
          
            if (checkbox.Checked) 
            {
                // MessageBox.Show("Is checked");
               textpassword.UseSystemPasswordChar = false;
             
            }
            else
            {
                // MessageBox.Show("It isn't checked");
                textpassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Textusername_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
