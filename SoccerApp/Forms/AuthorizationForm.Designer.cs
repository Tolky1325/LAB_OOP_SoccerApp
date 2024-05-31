namespace SoccerApp
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.signUpButton = new System.Windows.Forms.LinkLabel();
            this.noAccountLabelAuth = new System.Windows.Forms.Label();
            this.signInButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account-arrow-right-outline (Custom).png");
            this.imageList1.Images.SetKeyName(1, "account-outline (Custom).png");
            this.imageList1.Images.SetKeyName(2, "account-remove-outline (Custom).png");
            this.imageList1.Images.SetKeyName(3, "cog (Custom).png");
            this.imageList1.Images.SetKeyName(4, "soccer (Custom).png");
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(289, 141);
            this.materialTextBox21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(251, 48);
            this.materialTextBox21.TabIndex = 3;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.HideSelection = true;
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(289, 202);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.MaxLength = 32767;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.PrefixSuffixText = null;
            this.Password.ReadOnly = false;
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(251, 48);
            this.Password.TabIndex = 4;
            this.Password.TabStop = false;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.TrailingIcon = null;
            this.Password.UseSystemPasswordChar = false;
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Location = new System.Drawing.Point(455, 300);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(61, 16);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.TabStop = true;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpButton_LinkClicked);
            // 
            // noAccountLabelAuth
            // 
            this.noAccountLabelAuth.AutoSize = true;
            this.noAccountLabelAuth.Location = new System.Drawing.Point(301, 300);
            this.noAccountLabelAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noAccountLabelAuth.Name = "noAccountLabelAuth";
            this.noAccountLabelAuth.Size = new System.Drawing.Size(146, 16);
            this.noAccountLabelAuth.TabIndex = 7;
            this.noAccountLabelAuth.Text = "Don\'t have an account?";
            // 
            // signInButton
            // 
            this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signInButton.Depth = 0;
            this.signInButton.HighEmphasis = true;
            this.signInButton.Icon = global::SoccerApp.Properties.Resources.account_arrow_right_outline__Custom_;
            this.signInButton.Image = global::SoccerApp.Properties.Resources.account_arrow_right_outline__Custom_;
            this.signInButton.Location = new System.Drawing.Point(362, 258);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInButton.Name = "signInButton";
            this.signInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signInButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signInButton.Size = new System.Drawing.Size(112, 36);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "   SIGN IN   ";
            this.signInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signInButton.UseAccentColor = false;
            this.signInButton.UseCompatibleTextRendering = true;
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noAccountLabelAuth);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.materialTextBox21);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 Password;
        private MaterialSkin.Controls.MaterialButton signInButton;
        private System.Windows.Forms.LinkLabel signUpButton;
        private System.Windows.Forms.Label noAccountLabelAuth;
    }
}

