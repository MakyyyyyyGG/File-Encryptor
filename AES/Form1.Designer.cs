namespace AES
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileInput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.encryptPanel = new System.Windows.Forms.Panel();
            this.proceedEncrypt = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.decryptPanel = new System.Windows.Forms.Panel();
            this.dkeyTextbox = new System.Windows.Forms.TextBox();
            this.proceedDecrypt = new System.Windows.Forms.Button();
            this.decryptCancelBtn = new System.Windows.Forms.Button();
            this.encryptPanel.SuspendLayout();
            this.decryptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileInput
            // 
            this.fileInput.BackColor = System.Drawing.Color.Transparent;
            this.fileInput.FlatAppearance.BorderSize = 0;
            this.fileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileInput.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileInput.Location = new System.Drawing.Point(581, 236);
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(191, 46);
            this.fileInput.TabIndex = 0;
            this.fileInput.Text = "Choose File";
            this.fileInput.UseVisualStyleBackColor = false;
            this.fileInput.Click += new System.EventHandler(this.fileInput_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(272, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 24);
            this.textBox1.TabIndex = 1;
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatAppearance.BorderSize = 0;
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.encrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.encrypt.Location = new System.Drawing.Point(260, 318);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(191, 46);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.Color.Transparent;
            this.decrypt.FlatAppearance.BorderSize = 0;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.decrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.decrypt.Location = new System.Drawing.Point(582, 318);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(191, 46);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = false;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encryptPanel
            // 
            this.encryptPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.encryptPanel.BackgroundImage = global::AES.Properties.Resources.Confidential_File_Keep__1_;
            this.encryptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encryptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.encryptPanel.Controls.Add(this.proceedEncrypt);
            this.encryptPanel.Controls.Add(this.cancel);
            this.encryptPanel.Controls.Add(this.keyTextbox);
            this.encryptPanel.Location = new System.Drawing.Point(1, 2);
            this.encryptPanel.Name = "encryptPanel";
            this.encryptPanel.Size = new System.Drawing.Size(1028, 539);
            this.encryptPanel.TabIndex = 4;
            this.encryptPanel.Visible = false;
            this.encryptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.encryptPanel_Paint);
            // 
            // proceedEncrypt
            // 
            this.proceedEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.proceedEncrypt.FlatAppearance.BorderSize = 0;
            this.proceedEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedEncrypt.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.proceedEncrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.proceedEncrypt.Location = new System.Drawing.Point(256, 307);
            this.proceedEncrypt.Name = "proceedEncrypt";
            this.proceedEncrypt.Size = new System.Drawing.Size(191, 46);
            this.proceedEncrypt.TabIndex = 3;
            this.proceedEncrypt.Text = "Proceed";
            this.proceedEncrypt.UseVisualStyleBackColor = false;
            this.proceedEncrypt.Click += new System.EventHandler(this.proceed_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(576, 307);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(191, 46);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // keyTextbox
            // 
            this.keyTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.keyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyTextbox.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.keyTextbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.keyTextbox.Location = new System.Drawing.Point(269, 239);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.Size = new System.Drawing.Size(482, 24);
            this.keyTextbox.TabIndex = 1;
            // 
            // decryptPanel
            // 
            this.decryptPanel.BackgroundImage = global::AES.Properties.Resources.Confidential_File_Keep__2_;
            this.decryptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decryptPanel.Controls.Add(this.dkeyTextbox);
            this.decryptPanel.Controls.Add(this.proceedDecrypt);
            this.decryptPanel.Controls.Add(this.decryptCancelBtn);
            this.decryptPanel.Location = new System.Drawing.Point(1, 2);
            this.decryptPanel.Name = "decryptPanel";
            this.decryptPanel.Size = new System.Drawing.Size(1023, 548);
            this.decryptPanel.TabIndex = 5;
            this.decryptPanel.Visible = false;
            this.decryptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.decryptPanel_Paint);
            // 
            // dkeyTextbox
            // 
            this.dkeyTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dkeyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dkeyTextbox.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.dkeyTextbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dkeyTextbox.Location = new System.Drawing.Point(271, 245);
            this.dkeyTextbox.Name = "dkeyTextbox";
            this.dkeyTextbox.Size = new System.Drawing.Size(482, 24);
            this.dkeyTextbox.TabIndex = 1;
            // 
            // proceedDecrypt
            // 
            this.proceedDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.proceedDecrypt.FlatAppearance.BorderSize = 0;
            this.proceedDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedDecrypt.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.proceedDecrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.proceedDecrypt.Location = new System.Drawing.Point(258, 316);
            this.proceedDecrypt.Name = "proceedDecrypt";
            this.proceedDecrypt.Size = new System.Drawing.Size(191, 46);
            this.proceedDecrypt.TabIndex = 3;
            this.proceedDecrypt.Text = "Proceed";
            this.proceedDecrypt.UseVisualStyleBackColor = false;
            this.proceedDecrypt.Click += new System.EventHandler(this.proceedDecrypt_Click);
            // 
            // decryptCancelBtn
            // 
            this.decryptCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.decryptCancelBtn.FlatAppearance.BorderSize = 0;
            this.decryptCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptCancelBtn.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.decryptCancelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decryptCancelBtn.Location = new System.Drawing.Point(578, 316);
            this.decryptCancelBtn.Name = "decryptCancelBtn";
            this.decryptCancelBtn.Size = new System.Drawing.Size(191, 46);
            this.decryptCancelBtn.TabIndex = 2;
            this.decryptCancelBtn.Text = "Cancel";
            this.decryptCancelBtn.UseVisualStyleBackColor = false;
            this.decryptCancelBtn.Click += new System.EventHandler(this.decryptCancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AES.Properties.Resources.Confidential_File_Keep__3_;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.decryptPanel);
            this.Controls.Add(this.encryptPanel);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Anthony Clerigo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.encryptPanel.ResumeLayout(false);
            this.encryptPanel.PerformLayout();
            this.decryptPanel.ResumeLayout(false);
            this.decryptPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Panel encryptPanel;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button proceedEncrypt;
        private System.Windows.Forms.Panel decryptPanel;
        private System.Windows.Forms.Button proceedDecrypt;
        private System.Windows.Forms.Button decryptCancelBtn;
        private System.Windows.Forms.TextBox dkeyTextbox;
    }
}

