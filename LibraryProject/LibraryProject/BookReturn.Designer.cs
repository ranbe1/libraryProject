namespace LibraryProject
{
    partial class BookReturn
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
            this.ReturnList = new System.Windows.Forms.ListBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.returnBookTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ReturnList
            // 
            this.ReturnList.FormattingEnabled = true;
            this.ReturnList.Location = new System.Drawing.Point(12, 12);
            this.ReturnList.Name = "ReturnList";
            this.ReturnList.Size = new System.Drawing.Size(144, 212);
            this.ReturnList.TabIndex = 0;
            this.ReturnList.SelectedIndexChanged += new System.EventHandler(this.ReturnList_SelectedIndexChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(200, 151);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(94, 59);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(200, 295);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 59);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // returnBookTb
            // 
            this.returnBookTb.Location = new System.Drawing.Point(12, 262);
            this.returnBookTb.Name = "returnBookTb";
            this.returnBookTb.Size = new System.Drawing.Size(144, 96);
            this.returnBookTb.TabIndex = 3;
            this.returnBookTb.Text = "";
            this.returnBookTb.TextChanged += new System.EventHandler(this.returnBookTb_TextChanged);
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 365);
            this.Controls.Add(this.returnBookTb);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ReturnList);
            this.Name = "BookReturn";
            this.Text = "BookReturn";
            this.Load += new System.EventHandler(this.BookReturn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ReturnList;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RichTextBox returnBookTb;
    }
}