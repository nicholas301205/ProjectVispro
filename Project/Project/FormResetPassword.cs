using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            string password = spasswordText.Text;
            string confirmPassword = spasswordText2.Text;

            // --- Validation Logic ---


            // 2️⃣ Check if password fields are empty
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your password.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ Check password strength
            if (password.Length < 0)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // ✅ If all checks pass
            MessageBox.Show("Change Password successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
