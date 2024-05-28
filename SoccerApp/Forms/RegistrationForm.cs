using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace SoccerApp.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public string adminQuan = "D:\\SoccerApp\\SoccerApp\\adminQuan.txt";
        public string playerQuan = "D:\\SoccerApp\\SoccerApp\\playerQuan.txt";
        public string fanQuan = "D:\\SoccerApp\\SoccerApp\\fanQuan.txt";

        public int DataReader(string read)
        {
            var sr = new StreamReader(read);
            return Convert.ToInt32(sr.ReadToEnd());
        }

        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void signUpMatBReg_Click(object sender, EventArgs e)
        {
            string loginType = null;
            int quan;
            if (fanRadioButtonReg.Checked == true)
            {
                loginType = "fan";
            }
            else if (playerRadioButton.Checked == true)
            {
                loginType = "player";
            }
            else if(adminRadioButtonReg.Checked == true) 
            {
                loginType = "admin";
            }
            switch (loginType)
            {
                case "fan":
                    quan = DataReader(fanQuan);
                    break;

                case "player":
                    quan = DataReader(playerQuan);
                    break;
                case "admin":
                    quan = DataReader(adminQuan);
                    break;
            }
            Hide();
            RegConfirmationForm regConfirmationForm = new RegConfirmationForm();
            regConfirmationForm.ShowDialog();
        }
    }
}
