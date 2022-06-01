
namespace Kursovaya
{
    partial class Form3
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
            this.dgv_parts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_parts
            // 
            this.dgv_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.parts_type,
            this.car,
            this.amount,
            this.price});
            this.dgv_parts.Location = new System.Drawing.Point(12, 12);
            this.dgv_parts.Name = "dgv_parts";
            this.dgv_parts.RowTemplate.Height = 25;
            this.dgv_parts.Size = new System.Drawing.Size(776, 351);
            this.dgv_parts.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Art.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // parts_type
            // 
            this.parts_type.HeaderText = "Part type";
            this.parts_type.Name = "parts_type";
            this.parts_type.ReadOnly = true;
            // 
            // car
            // 
            this.car.HeaderText = "Car";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // bt_order
            // 
            this.bt_order.Location = new System.Drawing.Point(12, 369);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(100, 44);
            this.bt_order.TabIndex = 2;
            this.bt_order.Text = "Сделать заказ";
            this.bt_order.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.dgv_parts);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button bt_order;
    }
}