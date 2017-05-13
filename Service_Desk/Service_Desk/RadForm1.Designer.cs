namespace Service_Desk
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.username_txt = new Telerik.WinControls.UI.RadTextBoxControl();
            this.password_txt = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.login_btn = new Telerik.WinControls.UI.RadButton();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.username_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.username_txt.Location = new System.Drawing.Point(246, 135);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(186, 30);
            this.username_txt.TabIndex = 0;
            this.username_txt.ThemeName = "Material";
            // 
            // password_txt
            // 
            this.password_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.password_txt.Location = new System.Drawing.Point(246, 177);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(186, 30);
            this.password_txt.TabIndex = 1;
            this.password_txt.ThemeName = "Material";
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(163, 141);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 20);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Username:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel1.ThemeName = "Material";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(165, 181);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(77, 20);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Password:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabel2.ThemeName = "Material";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.login_btn.Location = new System.Drawing.Point(271, 222);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(120, 29);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.ThemeName = "Material";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 486);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 523);
            this.MinimumSize = new System.Drawing.Size(670, 523);
            this.Name = "login_form";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(670, 523);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Services Login";
            this.ThemeName = "Material";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.username_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl username_txt;
        private Telerik.WinControls.UI.RadTextBoxControl password_txt;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton login_btn;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;

    }
}