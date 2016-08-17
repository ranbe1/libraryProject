namespace LibraryProject
{
    partial class LibraryHall
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.BooksLibraryButton = new System.Windows.Forms.Button();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.ContributeButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminButton.Location = new System.Drawing.Point(13, 327);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(117, 76);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // BooksLibraryButton
            // 
            this.BooksLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BooksLibraryButton.Location = new System.Drawing.Point(169, 209);
            this.BooksLibraryButton.Name = "BooksLibraryButton";
            this.BooksLibraryButton.Size = new System.Drawing.Size(232, 84);
            this.BooksLibraryButton.TabIndex = 1;
            this.BooksLibraryButton.Text = "To the Library";
            this.BooksLibraryButton.UseVisualStyleBackColor = true;
            this.BooksLibraryButton.Click += new System.EventHandler(this.BooksLibraryButton_Click);
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(300, 103);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(101, 84);
            this.ReturnBookButton.TabIndex = 1;
            this.ReturnBookButton.Text = "Return a book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // ContributeButton
            // 
            this.ContributeButton.Location = new System.Drawing.Point(169, 103);
            this.ContributeButton.Name = "ContributeButton";
            this.ContributeButton.Size = new System.Drawing.Size(101, 84);
            this.ContributeButton.TabIndex = 1;
            this.ContributeButton.Text = "Contribute a book";
            this.ContributeButton.UseVisualStyleBackColor = true;
            this.ContributeButton.Click += new System.EventHandler(this.ContributeButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(431, 327);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(117, 76);
            this.SignOutButton.TabIndex = 2;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeLabel.Location = new System.Drawing.Point(165, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 39);
            this.welcomeLabel.TabIndex = 3;
            // 
            // LibraryHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 414);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.ContributeButton);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.BooksLibraryButton);
            this.Controls.Add(this.AdminButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "LibraryHall";
            this.Text = "Library Hall";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button BooksLibraryButton;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button ContributeButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}