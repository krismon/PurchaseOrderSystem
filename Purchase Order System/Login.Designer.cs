namespace Purchase_Order_System
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.L_TB_User = new System.Windows.Forms.TextBox();
            this.L_TB_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.L_B_OK = new System.Windows.Forms.Button();
            this.L_B_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // L_TB_User
            // 
            this.L_TB_User.Location = new System.Drawing.Point(180, 57);
            this.L_TB_User.Name = "L_TB_User";
            this.L_TB_User.Size = new System.Drawing.Size(195, 22);
            this.L_TB_User.TabIndex = 1;
            // 
            // L_TB_Password
            // 
            this.L_TB_Password.Location = new System.Drawing.Point(180, 109);
            this.L_TB_Password.Name = "L_TB_Password";
            this.L_TB_Password.Size = new System.Drawing.Size(195, 22);
            this.L_TB_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // L_B_OK
            // 
            this.L_B_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_B_OK.Location = new System.Drawing.Point(92, 177);
            this.L_B_OK.Name = "L_B_OK";
            this.L_B_OK.Size = new System.Drawing.Size(114, 32);
            this.L_B_OK.TabIndex = 4;
            this.L_B_OK.Text = "OK";
            this.L_B_OK.UseVisualStyleBackColor = true;
            this.L_B_OK.Click += new System.EventHandler(this.L_B_OK_Click);
            // 
            // L_B_Cancel
            // 
            this.L_B_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_B_Cancel.Location = new System.Drawing.Point(222, 177);
            this.L_B_Cancel.Name = "L_B_Cancel";
            this.L_B_Cancel.Size = new System.Drawing.Size(121, 32);
            this.L_B_Cancel.TabIndex = 5;
            this.L_B_Cancel.Text = "Cancel";
            this.L_B_Cancel.UseVisualStyleBackColor = true;
            this.L_B_Cancel.Click += new System.EventHandler(this.L_B_Cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.L_B_Cancel);
            this.Controls.Add(this.L_B_OK);
            this.Controls.Add(this.L_TB_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_TB_User);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox L_TB_User;
        private System.Windows.Forms.TextBox L_TB_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button L_B_OK;
        private System.Windows.Forms.Button L_B_Cancel;
    }
}

