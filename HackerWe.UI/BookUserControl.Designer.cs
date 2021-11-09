namespace HackerWe.UI
{
    partial class BookUserControl
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
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumOfPages = new System.Windows.Forms.TextBox();
            this.txtNumOfCopies = new System.Windows.Forms.TextBox();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.lblNumOfPagesValidation = new System.Windows.Forms.Label();
            this.lblNumOfCopiesValidation = new System.Windows.Forms.Label();
            this.lblAuthorValidation = new System.Windows.Forms.Label();
            this.lblNameValidation = new System.Windows.Forms.Label();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(151, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(151, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(151, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(151, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(151, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date published";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(201, 98);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(147, 23);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtNumOfPages
            // 
            this.txtNumOfPages.Location = new System.Drawing.Point(259, 181);
            this.txtNumOfPages.Name = "txtNumOfPages";
            this.txtNumOfPages.Size = new System.Drawing.Size(54, 23);
            this.txtNumOfPages.TabIndex = 1;
            // 
            // txtNumOfCopies
            // 
            this.txtNumOfCopies.Location = new System.Drawing.Point(259, 218);
            this.txtNumOfCopies.Name = "txtNumOfCopies";
            this.txtNumOfCopies.Size = new System.Drawing.Size(54, 23);
            this.txtNumOfCopies.TabIndex = 1;
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePublished.Location = new System.Drawing.Point(243, 260);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(105, 23);
            this.dtpDatePublished.TabIndex = 2;
            // 
            // lblNumOfPagesValidation
            // 
            this.lblNumOfPagesValidation.AutoSize = true;
            this.lblNumOfPagesValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNumOfPagesValidation.Location = new System.Drawing.Point(374, 184);
            this.lblNumOfPagesValidation.Name = "lblNumOfPagesValidation";
            this.lblNumOfPagesValidation.Size = new System.Drawing.Size(82, 15);
            this.lblNumOfPagesValidation.TabIndex = 4;
            this.lblNumOfPagesValidation.Text = "Numbers only";
            this.lblNumOfPagesValidation.Visible = false;
            // 
            // lblNumOfCopiesValidation
            // 
            this.lblNumOfCopiesValidation.AutoSize = true;
            this.lblNumOfCopiesValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNumOfCopiesValidation.Location = new System.Drawing.Point(374, 221);
            this.lblNumOfCopiesValidation.Name = "lblNumOfCopiesValidation";
            this.lblNumOfCopiesValidation.Size = new System.Drawing.Size(82, 15);
            this.lblNumOfCopiesValidation.TabIndex = 4;
            this.lblNumOfCopiesValidation.Text = "Numbers only";
            this.lblNumOfCopiesValidation.Visible = false;
            // 
            // lblAuthorValidation
            // 
            this.lblAuthorValidation.AutoSize = true;
            this.lblAuthorValidation.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorValidation.Location = new System.Drawing.Point(364, 101);
            this.lblAuthorValidation.Name = "lblAuthorValidation";
            this.lblAuthorValidation.Size = new System.Drawing.Size(400, 15);
            this.lblAuthorValidation.TabIndex = 5;
            this.lblAuthorValidation.Text = "Author name must be at least 2 letters, and can contain only english letters";
            this.lblAuthorValidation.Visible = false;
            // 
            // lblNameValidation
            // 
            this.lblNameValidation.AutoSize = true;
            this.lblNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNameValidation.Location = new System.Drawing.Point(364, 145);
            this.lblNameValidation.Name = "lblNameValidation";
            this.lblNameValidation.Size = new System.Drawing.Size(362, 15);
            this.lblNameValidation.TabIndex = 5;
            this.lblNameValidation.Text = "Name must be at least 2 letters, and can contain only english letters";
            this.lblNameValidation.Visible = false;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSaveBook.Location = new System.Drawing.Point(219, 318);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBook.TabIndex = 6;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // BookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.btnSaveBook);
            this.Controls.Add(this.lblNameValidation);
            this.Controls.Add(this.lblAuthorValidation);
            this.Controls.Add(this.lblNumOfCopiesValidation);
            this.Controls.Add(this.lblNumOfPagesValidation);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.txtNumOfCopies);
            this.Controls.Add(this.txtNumOfPages);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookUserControl";
            this.Size = new System.Drawing.Size(1583, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumOfPages;
        private System.Windows.Forms.TextBox txtNumOfCopies;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.Label lblNumOfPagesValidation;
        private System.Windows.Forms.Label lblNumOfCopiesValidation;
        private System.Windows.Forms.Label lblAuthorValidation;
        private System.Windows.Forms.Label lblNameValidation;
        private System.Windows.Forms.Button btnSaveBook;
    }
}
