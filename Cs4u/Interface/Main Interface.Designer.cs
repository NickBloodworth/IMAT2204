namespace Interface
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
            this.btnStockControl = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStockControl
            // 
            this.btnStockControl.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStockControl.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStockControl.FlatAppearance.BorderSize = 3;
            this.btnStockControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockControl.Location = new System.Drawing.Point(76, 440);
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Size = new System.Drawing.Size(219, 82);
            this.btnStockControl.TabIndex = 0;
            this.btnStockControl.Text = "Stock Control";
            this.btnStockControl.UseVisualStyleBackColor = false;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(343, 35);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(115, 13);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Computer Solutions 4U";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 582);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnStockControl);
            this.Name = "Form1";
            this.Text = "Main Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStockControl;
        private System.Windows.Forms.Label lblHead;
    }
}

