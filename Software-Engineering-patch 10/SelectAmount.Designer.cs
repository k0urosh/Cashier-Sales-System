namespace CashierSystem
{
    partial class SelectAmount
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_confirm = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_confirm
            // 
            this.b_confirm.Location = new System.Drawing.Point(139, 174);
            this.b_confirm.Name = "b_confirm";
            this.b_confirm.Size = new System.Drawing.Size(75, 23);
            this.b_confirm.TabIndex = 1;
            this.b_confirm.Text = "Confirm";
            this.b_confirm.UseVisualStyleBackColor = true;
            this.b_confirm.Click += new System.EventHandler(this.b_confirm_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(265, 174);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(75, 23);
            this.b_close.TabIndex = 2;
            this.b_close.Text = "Close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // SelectAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 296);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_confirm);
            this.Controls.Add(this.textBox1);
            this.Name = "SelectAmount";
            this.Text = "SelectAmount";
            this.Load += new System.EventHandler(this.SelectAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_confirm;
        private System.Windows.Forms.Button b_close;
    }
}