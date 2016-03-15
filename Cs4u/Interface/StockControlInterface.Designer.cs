namespace Interface
{
    partial class StockControlInterface
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
            this.btnAddStockItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.Location = new System.Drawing.Point(305, 350);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(140, 56);
            this.btnAddStockItem.TabIndex = 0;
            this.btnAddStockItem.Text = "Add Item";
            this.btnAddStockItem.UseVisualStyleBackColor = true;
            this.btnAddStockItem.Click += new System.EventHandler(this.btnAddStockItem_Click);
            // 
            // StockControlInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 563);
            this.Controls.Add(this.btnAddStockItem);
            this.Name = "StockControlInterface";
            this.Text = "StockControlInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStockItem;
    }
}