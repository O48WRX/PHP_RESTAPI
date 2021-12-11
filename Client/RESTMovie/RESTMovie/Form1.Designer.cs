
namespace RESTMovie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.F1_LOGOUT = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.F1_LOGIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F1_PWBOX = new System.Windows.Forms.TextBox();
            this.F1_USERNAMEBOX = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Users_MenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoviesMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // F1_LOGOUT
            // 
            this.F1_LOGOUT.Location = new System.Drawing.Point(485, 145);
            this.F1_LOGOUT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F1_LOGOUT.Name = "F1_LOGOUT";
            this.F1_LOGOUT.Size = new System.Drawing.Size(82, 22);
            this.F1_LOGOUT.TabIndex = 4;
            this.F1_LOGOUT.Text = "Log out";
            this.F1_LOGOUT.UseVisualStyleBackColor = true;
            this.F1_LOGOUT.Visible = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.F1_LOGIN);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.label1);
            this.LoginBox.Controls.Add(this.F1_PWBOX);
            this.LoginBox.Controls.Add(this.F1_USERNAMEBOX);
            this.LoginBox.Location = new System.Drawing.Point(51, 114);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBox.Size = new System.Drawing.Size(397, 151);
            this.LoginBox.TabIndex = 3;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // F1_LOGIN
            // 
            this.F1_LOGIN.Location = new System.Drawing.Point(161, 112);
            this.F1_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F1_LOGIN.Name = "F1_LOGIN";
            this.F1_LOGIN.Size = new System.Drawing.Size(82, 22);
            this.F1_LOGIN.TabIndex = 4;
            this.F1_LOGIN.Text = "Log in";
            this.F1_LOGIN.UseVisualStyleBackColor = true;
            this.F1_LOGIN.Click += new System.EventHandler(this.F1_LOGIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // F1_PWBOX
            // 
            this.F1_PWBOX.Location = new System.Drawing.Point(128, 62);
            this.F1_PWBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F1_PWBOX.Name = "F1_PWBOX";
            this.F1_PWBOX.PasswordChar = '*';
            this.F1_PWBOX.Size = new System.Drawing.Size(201, 23);
            this.F1_PWBOX.TabIndex = 1;
            // 
            // F1_USERNAMEBOX
            // 
            this.F1_USERNAMEBOX.Location = new System.Drawing.Point(128, 30);
            this.F1_USERNAMEBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F1_USERNAMEBOX.Name = "F1_USERNAMEBOX";
            this.F1_USERNAMEBOX.Size = new System.Drawing.Size(201, 23);
            this.F1_USERNAMEBOX.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Users_MenuStripItem,
            this.MoviesMenuStripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Users_MenuStripItem
            // 
            this.Users_MenuStripItem.Name = "Users_MenuStripItem";
            this.Users_MenuStripItem.Size = new System.Drawing.Size(61, 25);
            this.Users_MenuStripItem.Text = "Users";
            // 
            // MoviesMenuStripItem
            // 
            this.MoviesMenuStripItem.Name = "MoviesMenuStripItem";
            this.MoviesMenuStripItem.Size = new System.Drawing.Size(72, 25);
            this.MoviesMenuStripItem.Text = "Movies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.F1_LOGOUT);
            this.Controls.Add(this.LoginBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F1_LOGOUT;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Button F1_LOGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F1_PWBOX;
        private System.Windows.Forms.TextBox F1_USERNAMEBOX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Users_MenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem MoviesMenuStripItem;
    }
}

