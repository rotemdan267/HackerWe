namespace HackerWe.UI
{
    partial class ClientsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.lblIdentityNumberValidation = new System.Windows.Forms.Label();
            this.lblFirstNameValidation = new System.Windows.Forms.Label();
            this.lblLastNameValidation = new System.Windows.Forms.Label();
            this.lblEmailValidation = new System.Windows.Forms.Label();
            this.lblPhoneNumberValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(122, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(122, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(122, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(122, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(122, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone number";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(146, 74);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(191, 23);
            this.txtIdentityNumber.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(192, 107);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(192, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(214, 228);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(123, 23);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveClient.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSaveClient.ForeColor = System.Drawing.Color.Indigo;
            this.btnSaveClient.Location = new System.Drawing.Point(185, 297);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 2;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // lblIdentityNumberValidation
            // 
            this.lblIdentityNumberValidation.AutoSize = true;
            this.lblIdentityNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.lblIdentityNumberValidation.Location = new System.Drawing.Point(363, 77);
            this.lblIdentityNumberValidation.Name = "lblIdentityNumberValidation";
            this.lblIdentityNumberValidation.Size = new System.Drawing.Size(147, 15);
            this.lblIdentityNumberValidation.TabIndex = 3;
            this.lblIdentityNumberValidation.Text = "This field cannot be empty";
            this.lblIdentityNumberValidation.Visible = false;
            // 
            // lblFirstNameValidation
            // 
            this.lblFirstNameValidation.AutoSize = true;
            this.lblFirstNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameValidation.Location = new System.Drawing.Point(363, 110);
            this.lblFirstNameValidation.Name = "lblFirstNameValidation";
            this.lblFirstNameValidation.Size = new System.Drawing.Size(385, 15);
            this.lblFirstNameValidation.TabIndex = 3;
            this.lblFirstNameValidation.Text = "First name must be at least 2 letters, and can contain only english letters";
            this.lblFirstNameValidation.Visible = false;
            // 
            // lblLastNameValidation
            // 
            this.lblLastNameValidation.AutoSize = true;
            this.lblLastNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameValidation.Location = new System.Drawing.Point(363, 148);
            this.lblLastNameValidation.Name = "lblLastNameValidation";
            this.lblLastNameValidation.Size = new System.Drawing.Size(384, 15);
            this.lblLastNameValidation.TabIndex = 3;
            this.lblLastNameValidation.Text = "Last name must be at least 2 letters, and can contain only english letters";
            this.lblLastNameValidation.Visible = false;
            // 
            // lblEmailValidation
            // 
            this.lblEmailValidation.AutoSize = true;
            this.lblEmailValidation.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidation.Location = new System.Drawing.Point(363, 189);
            this.lblEmailValidation.Name = "lblEmailValidation";
            this.lblEmailValidation.Size = new System.Drawing.Size(117, 15);
            this.lblEmailValidation.TabIndex = 3;
            this.lblEmailValidation.Text = "Invalid email address";
            this.lblEmailValidation.Visible = false;
            // 
            // lblPhoneNumberValidation
            // 
            this.lblPhoneNumberValidation.AutoSize = true;
            this.lblPhoneNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberValidation.Location = new System.Drawing.Point(363, 231);
            this.lblPhoneNumberValidation.Name = "lblPhoneNumberValidation";
            this.lblPhoneNumberValidation.Size = new System.Drawing.Size(124, 15);
            this.lblPhoneNumberValidation.TabIndex = 3;
            this.lblPhoneNumberValidation.Text = "Invalid phone number";
            this.lblPhoneNumberValidation.Visible = false;
            // 
            // ClientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblPhoneNumberValidation);
            this.Controls.Add(this.lblEmailValidation);
            this.Controls.Add(this.lblLastNameValidation);
            this.Controls.Add(this.lblFirstNameValidation);
            this.Controls.Add(this.lblIdentityNumberValidation);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtIdentityNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ClientsUserControl";
            this.Size = new System.Drawing.Size(1161, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Label lblIdentityNumberValidation;
        private System.Windows.Forms.Label lblFirstNameValidation;
        private System.Windows.Forms.Label lblLastNameValidation;
        private System.Windows.Forms.Label lblEmailValidation;
        private System.Windows.Forms.Label lblPhoneNumberValidation;
    }
}
