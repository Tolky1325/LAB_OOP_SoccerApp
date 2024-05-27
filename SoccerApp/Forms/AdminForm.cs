using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SoccerApp
{
    public partial class AdminForm : MaterialForm
    {
        
        
        public AdminForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            var adminTabControl = new MaterialTabControl
            {
                Dock = DockStyle.Fill,
            };

            var homeTab = new TabPage("Home")
            {

            };
            var userControlTab = new TabPage("User control");
            var accountTab = new TabPage("Your account");
            var settingsTab = new TabPage("Settings");

            adminTabControl.Controls.Add(homeTab);
            adminTabControl.Controls.Add(userControlTab);
            adminTabControl.Controls.Add(accountTab);
            adminTabControl.Controls.Add(settingsTab);

            var exitButton = new MaterialButton
            {
                Text = "",
                Width = 32,
                Height = 32,
                Location = new System.Drawing.Point(150, 10), // Adjust the location as needed
                BackColor = System.Drawing.Color.Transparent
            };

            // Bring the button to the front
            exitButton.BringToFront();

            // Add button to the form
            this.Controls.Add(adminTabControl);
            this.Controls.Add(exitButton);
        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }
    }

    

}
