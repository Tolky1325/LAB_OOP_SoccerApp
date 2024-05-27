using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SoccerApp
{
    public partial class AuthorizationForm : MaterialForm
    {
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
             

        private void materialTextBox21_Click(object sender, EventArgs e)
        {
            
        }

        private void Password_Click(object sender, EventArgs e)
        {
            
        }

        private void signUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string userLogin = materialTextBox21.Text;
            string userPassword = Password.Text;
            if (string.IsNullOrEmpty(userLogin) == false && string.IsNullOrEmpty(userPassword) == false)
            {
                Hide();
                if (userLogin == "admin" && userPassword == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else if (userLogin == "player" && userPassword == "player")
                {
                    PlayerForm playerForm = new PlayerForm();
                    playerForm.ShowDialog();
                }
                else if (userLogin == "fan" && userPassword == "fan")
                {
                    FanForm fanForm = new FanForm();
                    fanForm.ShowDialog();
                }
                }
            else
            {
             
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }


    //private void materialTextBox21_Click(object sender, EventArgs e)
    //{
    //    materialTextBox21.Hint = "Enter your text here...";
    //}
    // example of background hint in textbox
}
