using MaterialSkin;
using MaterialSkin.Controls;
using SoccerApp.Forms;
using System;
using System.Windows.Forms;
using System.Linq;

namespace SoccerApp
{
    public partial class AuthorizationForm : MaterialForm
    {
        private bool isPasswordVisible = false;
        public AuthorizationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialTextBox21.Hint = "LOGIN";
            Password.Hint = "PASSWORD";
        }

        private void signUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string userLogin = materialTextBox21.Text;
            string userPassword = Password.Text;
            if (!string.IsNullOrEmpty(userLogin) && !string.IsNullOrEmpty(userPassword))
            {
                string loginType = null;

                if (fanAuth.Checked)
                {
                    loginType = "fan";
                }
                else if (admAuth.Checked)
                {
                    loginType = "admin";
                }

                if (loginType == null)
                {
                    MessageBox.Show("Please select a user type.");
                    return;
                }

                using (var appContext = new AppDbContext())
                {
                    bool isAuthenticated = false;

                    if (loginType == "admin")
                    {
                        var admin = appContext.AdminTable
                            .Where(a => a.Login == userLogin && a.Password == userPassword && a.Role == "admin")
                            .FirstOrDefault();

                        isAuthenticated = admin != null;
                    }
                    else if (loginType == "fan")
                    {
                        var fan = appContext.FanTable
                            .Where(f => f.Login == userLogin && f.Password == userPassword && f.Role == "fan")
                            .FirstOrDefault();

                        isAuthenticated = fan != null;
                    }

                    if (isAuthenticated && loginType == "admin")
                    {
                        Hide();
                        AdminForm adminform = new AdminForm();
                        adminform.Show();
                    }
                    else if(isAuthenticated  && loginType == "fan")
                    {
                        Hide();
                        FanForm fanform = new FanForm();
                        fanform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login or password.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter both login and password.");
            }
        }
    }
}
