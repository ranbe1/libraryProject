namespace LibraryProject
{
    partial class ContributeBook
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
            this.BookNameTb = new System.Windows.Forms.TextBox();
            this.BookYearTb = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ContributeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookSummaryTb = new System.Windows.Forms.RichTextBox();
            this.BookSubjectCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BookNameTb
            // 
            this.BookNameTb.Location = new System.Drawing.Point(130, 64);
            this.BookNameTb.Name = "BookNameTb";
            this.BookNameTb.Size = new System.Drawing.Size(145, 20);
            this.BookNameTb.TabIndex = 0;
            // 
            // BookYearTb
            // 
            this.BookYearTb.Location = new System.Drawing.Point(130, 102);
            this.BookYearTb.Name = "BookYearTb";
            this.BookYearTb.Size = new System.Drawing.Size(145, 20);
            this.BookYearTb.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(42, 356);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 47);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ContributeButton
            // 
            this.ContributeButton.Location = new System.Drawing.Point(200, 356);
            this.ContributeButton.Name = "ContributeButton";
            this.ContributeButton.Size = new System.Drawing.Size(75, 47);
            this.ContributeButton.TabIndex = 2;
            this.ContributeButton.Text = "Contribute";
            this.ContributeButton.UseVisualStyleBackColor = true;
            this.ContributeButton.Click += new System.EventHandler(this.ContributeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(39, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Summary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(39, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(39, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contribute";
            // 
            // BookSummaryTb
            // 
            this.BookSummaryTb.Location = new System.Drawing.Point(130, 142);
            this.BookSummaryTb.Name = "BookSummaryTb";
            this.BookSummaryTb.Size = new System.Drawing.Size(145, 129);
            this.BookSummaryTb.TabIndex = 5;
            this.BookSummaryTb.Text = "";
            // 
            // BookSubjectCb
            // 
            this.BookSubjectCb.FormattingEnabled = true;
            this.BookSubjectCb.Items.AddRange(new object[] {
            "Action",
            "Adventures",
            "Comedy",
            "Children",
            "History",
            "Horror",
            "Romantic"});
            this.BookSubjectCb.Location = new System.Drawing.Point(130, 291);
            this.BookSubjectCb.Name = "BookSubjectCb";
            this.BookSubjectCb.Size = new System.Drawing.Size(145, 21);
            this.BookSubjectCb.TabIndex = 6;
            this.BookSubjectCb.Text = "Choose one...";
            // 
            // ContributeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 425);
            this.Controls.Add(this.BookSubjectCb);
            this.Controls.Add(this.BookSummaryTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContributeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BookYearTb);
            this.Controls.Add(this.BookNameTb);
            this.Name = "ContributeBook";
            this.Text = "ContributeBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookNameTb;
        private System.Windows.Forms.TextBox BookYearTb;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ContributeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox BookSummaryTb;
        private System.Windows.Forms.ComboBox BookSubjectCb;
    }
}