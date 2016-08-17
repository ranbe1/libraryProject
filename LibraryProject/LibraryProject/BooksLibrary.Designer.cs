namespace LibraryProject
{
    partial class BooksLibrary
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
            this.subjectsLb = new System.Windows.Forms.ListBox();
            this.BooksLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SummaryTb = new System.Windows.Forms.RichTextBox();
            this.LoanButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectsLb
            // 
            this.subjectsLb.FormattingEnabled = true;
            this.subjectsLb.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Romantic",
            "History",
            "Horror",
            "Children",
            "Adventures"});
            this.subjectsLb.Location = new System.Drawing.Point(14, 39);
            this.subjectsLb.Name = "subjectsLb";
            this.subjectsLb.Size = new System.Drawing.Size(120, 186);
            this.subjectsLb.TabIndex = 0;
            this.subjectsLb.SelectedIndexChanged += new System.EventHandler(this.TopicsLb_SelectedIndexChanged);
            // 
            // BooksLb
            // 
            this.BooksLb.FormattingEnabled = true;
            this.BooksLb.Location = new System.Drawing.Point(254, 39);
            this.BooksLb.Name = "BooksLb";
            this.BooksLb.Size = new System.Drawing.Size(195, 303);
            this.BooksLb.TabIndex = 1;
            this.BooksLb.SelectedIndexChanged += new System.EventHandler(this.BooksLb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(254, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(251, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subjects:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // SummaryTb
            // 
            this.SummaryTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.SummaryTb.Location = new System.Drawing.Point(254, 385);
            this.SummaryTb.Name = "SummaryTb";
            this.SummaryTb.ReadOnly = true;
            this.SummaryTb.Size = new System.Drawing.Size(195, 96);
            this.SummaryTb.TabIndex = 3;
            this.SummaryTb.Text = "";
            // 
            // LoanButton
            // 
            this.LoanButton.Location = new System.Drawing.Point(133, 406);
            this.LoanButton.Name = "LoanButton";
            this.LoanButton.Size = new System.Drawing.Size(101, 75);
            this.LoanButton.TabIndex = 4;
            this.LoanButton.Text = "Loan Book";
            this.LoanButton.UseVisualStyleBackColor = true;
            this.LoanButton.Click += new System.EventHandler(this.LoanButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(16, 406);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 75);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BooksLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 493);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LoanButton);
            this.Controls.Add(this.SummaryTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BooksLb);
            this.Controls.Add(this.subjectsLb);
            this.Name = "BooksLibrary";
            this.Text = "BooksLibrary";
            this.Load += new System.EventHandler(this.BooksLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox subjectsLb;
        private System.Windows.Forms.ListBox BooksLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SummaryTb;
        private System.Windows.Forms.Button LoanButton;
        private System.Windows.Forms.Button BackButton;
    }
}