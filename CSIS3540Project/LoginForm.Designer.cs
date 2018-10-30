namespace CSIS3540Project
{
    partial class LoginForm
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
            this.loginGrid = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.loginButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.registerGrid = new System.Windows.Forms.TableLayoutPanel();
            this.labelRegisterName = new System.Windows.Forms.Label();
            this.textBoxRegisterName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterWord = new System.Windows.Forms.TextBox();
            this.labelRegisterWord = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.buttonRegOk = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.loginGrid.SuspendLayout();
            this.loginButtons.SuspendLayout();
            this.registerGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGrid
            // 
            this.loginGrid.ColumnCount = 2;
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginGrid.Controls.Add(this.textBoxPassword, 1, 1);
            this.loginGrid.Controls.Add(this.loginButtons, 0, 2);
            this.loginGrid.Controls.Add(this.labelUsername, 0, 0);
            this.loginGrid.Controls.Add(this.labelPassword, 0, 1);
            this.loginGrid.Controls.Add(this.textBoxUsername, 1, 0);
            this.loginGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginGrid.Location = new System.Drawing.Point(0, 0);
            this.loginGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginGrid.Name = "loginGrid";
            this.loginGrid.RowCount = 3;
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginGrid.Size = new System.Drawing.Size(392, 154);
            this.loginGrid.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 55);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // loginButtons
            // 
            this.loginButtons.ColumnCount = 3;
            this.loginGrid.SetColumnSpan(this.loginButtons, 2);
            this.loginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loginButtons.Controls.Add(this.buttonQuit, 2, 0);
            this.loginButtons.Controls.Add(this.buttonRegister, 1, 0);
            this.loginButtons.Controls.Add(this.buttonLogin, 0, 0);
            this.loginButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButtons.Location = new System.Drawing.Point(4, 106);
            this.loginButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButtons.Name = "loginButtons";
            this.loginButtons.RowCount = 1;
            this.loginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.loginButtons.Size = new System.Drawing.Size(384, 44);
            this.loginButtons.TabIndex = 0;
            // 
            // buttonQuit
            // 
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Location = new System.Drawing.Point(260, 4);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(100, 33);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.Location = new System.Drawing.Point(142, 4);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 33);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.BeginRegister);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Location = new System.Drawing.Point(24, 4);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 33);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(115, 27);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 7);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 17);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(119, 58);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 7, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUsername.Location = new System.Drawing.Point(200, 25);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // registerGrid
            // 
            this.registerGrid.ColumnCount = 2;
            this.registerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerGrid.Controls.Add(this.labelRegisterName, 0, 0);
            this.registerGrid.Controls.Add(this.textBoxRegisterName, 1, 0);
            this.registerGrid.Controls.Add(this.textBoxRegisterWord, 1, 1);
            this.registerGrid.Controls.Add(this.labelRegisterWord, 0, 1);
            this.registerGrid.Controls.Add(this.labelStudentId, 0, 2);
            this.registerGrid.Controls.Add(this.textBoxStudentId, 1, 2);
            this.registerGrid.Controls.Add(this.buttonRegOk, 0, 3);
            this.registerGrid.Controls.Add(this.buttonBack, 1, 3);
            this.registerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerGrid.Location = new System.Drawing.Point(0, 0);
            this.registerGrid.Name = "registerGrid";
            this.registerGrid.RowCount = 4;
            this.registerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.registerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registerGrid.Size = new System.Drawing.Size(392, 154);
            this.registerGrid.TabIndex = 5;
            this.registerGrid.Visible = false;
            // 
            // labelRegisterName
            // 
            this.labelRegisterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisterName.AutoSize = true;
            this.labelRegisterName.Location = new System.Drawing.Point(116, 17);
            this.labelRegisterName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.labelRegisterName.Name = "labelRegisterName";
            this.labelRegisterName.Size = new System.Drawing.Size(77, 17);
            this.labelRegisterName.TabIndex = 0;
            this.labelRegisterName.Text = "Username:";
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRegisterName.Location = new System.Drawing.Point(199, 15);
            this.textBoxRegisterName.Name = "textBoxRegisterName";
            this.textBoxRegisterName.Size = new System.Drawing.Size(100, 22);
            this.textBoxRegisterName.TabIndex = 2;
            // 
            // textBoxRegisterWord
            // 
            this.textBoxRegisterWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRegisterWord.Location = new System.Drawing.Point(199, 49);
            this.textBoxRegisterWord.Name = "textBoxRegisterWord";
            this.textBoxRegisterWord.Size = new System.Drawing.Size(100, 22);
            this.textBoxRegisterWord.TabIndex = 3;
            // 
            // labelRegisterWord
            // 
            this.labelRegisterWord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRegisterWord.AutoSize = true;
            this.labelRegisterWord.Location = new System.Drawing.Point(120, 51);
            this.labelRegisterWord.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
            this.labelRegisterWord.Name = "labelRegisterWord";
            this.labelRegisterWord.Size = new System.Drawing.Size(73, 17);
            this.labelRegisterWord.TabIndex = 1;
            this.labelRegisterWord.Text = "Password:";
            // 
            // labelStudentId
            // 
            this.labelStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(115, 85);
            this.labelStudentId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(78, 17);
            this.labelStudentId.TabIndex = 4;
            this.labelStudentId.Text = "Student ID:";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(199, 83);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentId.TabIndex = 5;
            // 
            // buttonRegOk
            // 
            this.buttonRegOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegOk.AutoSize = true;
            this.buttonRegOk.Location = new System.Drawing.Point(60, 123);
            this.buttonRegOk.Name = "buttonRegOk";
            this.buttonRegOk.Size = new System.Drawing.Size(75, 27);
            this.buttonRegOk.TabIndex = 6;
            this.buttonRegOk.Text = "OK";
            this.buttonRegOk.UseVisualStyleBackColor = true;
            this.buttonRegOk.Click += new System.EventHandler(this.RegisterOk);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBack.AutoSize = true;
            this.buttonBack.Location = new System.Drawing.Point(256, 123);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 27);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Cancel";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.RegisterCancel);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonQuit;
            this.ClientSize = new System.Drawing.Size(392, 154);
            this.Controls.Add(this.registerGrid);
            this.Controls.Add(this.loginGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginGrid.ResumeLayout(false);
            this.loginGrid.PerformLayout();
            this.loginButtons.ResumeLayout(false);
            this.loginButtons.PerformLayout();
            this.registerGrid.ResumeLayout(false);
            this.registerGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginGrid;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TableLayoutPanel loginButtons;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TableLayoutPanel registerGrid;
        private System.Windows.Forms.Label labelRegisterName;
        private System.Windows.Forms.TextBox textBoxRegisterName;
        private System.Windows.Forms.TextBox textBoxRegisterWord;
        private System.Windows.Forms.Label labelRegisterWord;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Button buttonRegOk;
        private System.Windows.Forms.Button buttonBack;
    }
}