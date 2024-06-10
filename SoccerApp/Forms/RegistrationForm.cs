using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SoccerApp.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void backRegMB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }

        private void signUpMatBReg_Click_1(object sender, EventArgs e)
        {
            string login = loginCreateRegTB.Text;
            string password = passwordRegTB.Text;
            string confpassword = confPasswordRegTB.Text;

            if (!string.IsNullOrEmpty(login) && password == confpassword)
            {
                string loginType = null;

                if (fanRadioButtonReg.Checked)
                {
                    loginType = "fan";
                }
                else if (adminRadioButtonReg.Checked)
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
                    if (loginType == "admin")
                    {
                        var admin = new Admin
                        {
                            Login = login,
                            Password = password,
                            Role = "admin"
                        };
                        appContext.AdminTable.Add(admin);
                    }
                    else if (loginType == "fan")
                    {
                        var fan = new Fan
                        {
                            Login = login,
                            Password = password,
                            Role = "fan"
                        };
                        appContext.FanTable.Add(fan);
                    }
                    appContext.SaveChanges();
                }

                Hide();
                RegConfirmationForm regConfirmationForm = new RegConfirmationForm();
                regConfirmationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly and passwords match.");
            }
        }
    }
}
