namespace LibraryProject
{
    partial class AdminOptions
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
            this.MakeAdminRadio = new System.Windows.Forms.RadioButton();
            this.KickRadio = new System.Windows.Forms.RadioButton();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MakeAdminRadio
            // 
            this.MakeAdminRadio.AutoSize = true;
            this.MakeAdminRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MakeAdminRadio.Location = new System.Drawing.Point(114, 90);
            this.MakeAdminRadio.Name = "MakeAdminRadio";
            this.MakeAdminRadio.Size = new System.Drawing.Size(84, 17);
            this.MakeAdminRadio.TabIndex = 0;
            this.MakeAdminRadio.TabStop = true;
            this.MakeAdminRadio.Text = "Make Admin";
            this.MakeAdminRadio.UseVisualStyleBackColor = true;
            this.MakeAdminRadio.CheckedChanged += new System.EventHandler(this.MakeAdminRadio_CheckedChanged);
            // 
            // KickRadio
            // 
            this.KickRadio.AutoSize = true;
            this.KickRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.KickRadio.Location = new System.Drawing.Point(114, 126);
            this.KickRadio.Name = "KickRadio";
            this.KickRadio.Size = new System.Drawing.Size(46, 17);
            this.KickRadio.TabIndex = 1;
            this.KickRadio.TabStop = true;
            this.KickRadio.Text = "Kick";
            this.KickRadio.UseVisualStyleBackColor = true;
            this.KickRadio.CheckedChanged += new System.EventHandler(this.KickRadio_CheckedChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ApplyButton.Location = new System.Drawing.Point(93, 182);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(129, 36);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(93, 36);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(129, 20);
            this.UsernameTb.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UsernameLabel.Location = new System.Drawing.Point(11, 39);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(67, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 263);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.KickRadio);
            this.Controls.Add(this.MakeAdminRadio);
            this.Name = "AdminOptions";
            this.Text = "AdminOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MakeAdminRadio;
        private System.Windows.Forms.RadioButton KickRadio;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Label UsernameLabel;
    }
}