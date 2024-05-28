namespace SoccerApp
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.adminHomeTab = new System.Windows.Forms.TabPage();
            this.controlUserTab = new System.Windows.Forms.TabPage();
            this.settingsAdmTab = new System.Windows.Forms.TabPage();
            this.accountAdmTab = new System.Windows.Forms.TabPage();
            this.adminImageList = new System.Windows.Forms.ImageList(this.components);
            this.logOutAdm = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.accountAdmTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.adminHomeTab);
            this.materialTabControl1.Controls.Add(this.controlUserTab);
            this.materialTabControl1.Controls.Add(this.settingsAdmTab);
            this.materialTabControl1.Controls.Add(this.accountAdmTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.adminImageList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(676, 364);
            this.materialTabControl1.TabIndex = 0;
            // 
            // adminHomeTab
            // 
            this.adminHomeTab.BackColor = System.Drawing.Color.White;
            this.adminHomeTab.ImageKey = "soccer (Custom).png";
            this.adminHomeTab.Location = new System.Drawing.Point(4, 39);
            this.adminHomeTab.Name = "adminHomeTab";
            this.adminHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminHomeTab.Size = new System.Drawing.Size(668, 321);
            this.adminHomeTab.TabIndex = 0;
            this.adminHomeTab.Text = "Home";
            // 
            // controlUserTab
            // 
            this.controlUserTab.BackColor = System.Drawing.Color.White;
            this.controlUserTab.ImageKey = "account-group-outline-custom.png";
            this.controlUserTab.Location = new System.Drawing.Point(4, 39);
            this.controlUserTab.Name = "controlUserTab";
            this.controlUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlUserTab.Size = new System.Drawing.Size(668, 321);
            this.controlUserTab.TabIndex = 1;
            this.controlUserTab.Text = "User control";
            // 
            // settingsAdmTab
            // 
            this.settingsAdmTab.BackColor = System.Drawing.Color.White;
            this.settingsAdmTab.ImageKey = "cog (Custom).png";
            this.settingsAdmTab.Location = new System.Drawing.Point(4, 39);
            this.settingsAdmTab.Name = "settingsAdmTab";
            this.settingsAdmTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsAdmTab.Size = new System.Drawing.Size(668, 321);
            this.settingsAdmTab.TabIndex = 2;
            this.settingsAdmTab.Text = "Settings";
            // 
            // accountAdmTab
            // 
            this.accountAdmTab.BackColor = System.Drawing.Color.White;
            this.accountAdmTab.Controls.Add(this.logOutAdm);
            this.accountAdmTab.ImageKey = "account-outline (Custom).png";
            this.accountAdmTab.Location = new System.Drawing.Point(4, 39);
            this.accountAdmTab.Name = "accountAdmTab";
            this.accountAdmTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountAdmTab.Size = new System.Drawing.Size(668, 321);
            this.accountAdmTab.TabIndex = 3;
            this.accountAdmTab.Text = "Your account";
            // 
            // adminImageList
            // 
            this.adminImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("adminImageList.ImageStream")));
            this.adminImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.adminImageList.Images.SetKeyName(0, "soccer (Custom).png");
            this.adminImageList.Images.SetKeyName(1, "account-group-outline-custom.png");
            this.adminImageList.Images.SetKeyName(2, "cog (Custom).png");
            this.adminImageList.Images.SetKeyName(3, "account-outline (Custom).png");
            this.adminImageList.Images.SetKeyName(4, "account-remove-outline (Custom).png");
            // 
            // logOutAdm
            // 
            this.logOutAdm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutAdm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logOutAdm.Depth = 0;
            this.logOutAdm.HighEmphasis = true;
            this.logOutAdm.Icon = global::SoccerApp.Properties.Resources.account_remove_outline__Custom_;
            this.logOutAdm.Location = new System.Drawing.Point(551, 276);
            this.logOutAdm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logOutAdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutAdm.Name = "logOutAdm";
            this.logOutAdm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logOutAdm.Size = new System.Drawing.Size(110, 36);
            this.logOutAdm.TabIndex = 0;
            this.logOutAdm.Text = "LOG OUT";
            this.logOutAdm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logOutAdm.UseAccentColor = false;
            this.logOutAdm.UseVisualStyleBackColor = true;
            this.logOutAdm.Click += new System.EventHandler(this.logOutAdm_Click);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Sizable = false;
            this.Text = "AdminForm";
            this.materialTabControl1.ResumeLayout(false);
            this.accountAdmTab.ResumeLayout(false);
            this.accountAdmTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl adminTabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage userControlTab;
        private System.Windows.Forms.TabPage accountTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.ImageList adminPageImageList;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage adminHomeTab;
        private System.Windows.Forms.TabPage controlUserTab;
        private System.Windows.Forms.TabPage settingsAdmTab;
        private System.Windows.Forms.TabPage accountAdmTab;
        private System.Windows.Forms.ImageList adminImageList;
        private MaterialSkin.Controls.MaterialButton logOutAdm;
    }
}