
namespace HackerWe.UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.btnSearchByAuthor = new System.Windows.Forms.Button();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(124, 9);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(95, 65);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(225, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Borowing";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(326, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Returning";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(10, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 363);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblMessages
            // 
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 17);
            // 
            // btnOverdue
            // 
            this.btnOverdue.Location = new System.Drawing.Point(427, 11);
            this.btnOverdue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(95, 63);
            this.btnOverdue.TabIndex = 1;
            this.btnOverdue.Text = "Overdue books";
            this.btnOverdue.UseVisualStyleBackColor = true;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // btnSearchByAuthor
            // 
            this.btnSearchByAuthor.Location = new System.Drawing.Point(528, 12);
            this.btnSearchByAuthor.Name = "btnSearchByAuthor";
            this.btnSearchByAuthor.Size = new System.Drawing.Size(159, 33);
            this.btnSearchByAuthor.TabIndex = 6;
            this.btnSearchByAuthor.Text = "Search book by author";
            this.btnSearchByAuthor.UseVisualStyleBackColor = true;
            this.btnSearchByAuthor.Click += new System.EventHandler(this.btnSearchByAuthor_Click);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(528, 51);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(99, 23);
            this.cmbAuthors.TabIndex = 7;
            this.cmbAuthors.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(633, 50);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(54, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 503);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.btnSearchByAuthor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOverdue);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HackerWE Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessages;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.Button btnSearchByAuthor;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Button btnSelect;
    }
}

