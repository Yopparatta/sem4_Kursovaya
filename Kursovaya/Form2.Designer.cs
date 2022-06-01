
namespace Kursovaya
{
    partial class Form2
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.bt_CreateCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(29, 61);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(109, 23);
            this.tb_username.TabIndex = 1;
            // 
            // bt_CreateCustomer
            // 
            this.bt_CreateCustomer.Location = new System.Drawing.Point(29, 90);
            this.bt_CreateCustomer.Name = "bt_CreateCustomer";
            this.bt_CreateCustomer.Size = new System.Drawing.Size(109, 41);
            this.bt_CreateCustomer.TabIndex = 2;
            this.bt_CreateCustomer.Text = "Создать пользователя";
            this.bt_CreateCustomer.UseVisualStyleBackColor = true;
            this.bt_CreateCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 175);
            this.Controls.Add(this.bt_CreateCustomer);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button bt_CreateCustomer;
    }
}