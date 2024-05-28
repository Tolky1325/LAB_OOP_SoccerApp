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

        }

        private void logOutAdm_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }
    }
}
