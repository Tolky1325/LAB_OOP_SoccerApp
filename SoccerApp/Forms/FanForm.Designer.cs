namespace SoccerApp
{
    partial class FanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FanForm));
            this.fanLogOut = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // fanLogOut
            // 
            this.fanLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fanLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.fanLogOut.Depth = 0;
            this.fanLogOut.HighEmphasis = true;
            this.fanLogOut.Icon = null;
            this.fanLogOut.Location = new System.Drawing.Point(623, 373);
            this.fanLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fanLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.fanLogOut.Name = "fanLogOut";
            this.fanLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.fanLogOut.Size = new System.Drawing.Size(158, 36);
            this.fanLogOut.TabIndex = 0;
            this.fanLogOut.Text = "LOG OUT";
            this.fanLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fanLogOut.UseAccentColor = false;
            this.fanLogOut.UseVisualStyleBackColor = true;
            this.fanLogOut.Click += new System.EventHandler(this.fanLogOut_Click);
            // 
            // FanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fanLogOut);
            this.DrawerShowIconsWhenHidden = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FanForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton fanLogOut;
    }
}