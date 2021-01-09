namespace WindowsFormsApp1.Modules
{
    partial class Module1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputNum1 = new System.Windows.Forms.NumericUpDown();
            this.inputNum2 = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(69, 47);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(120, 20);
            this.inputNum1.TabIndex = 0;
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(209, 47);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(120, 20);
            this.inputNum2.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(351, 44);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Module1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.inputNum1);
            this.Name = "Module1";
            this.Size = new System.Drawing.Size(530, 127);
            ((System.ComponentModel.ISupportInitialize)(this.inputNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNum2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputNum1;
        private System.Windows.Forms.NumericUpDown inputNum2;
        private System.Windows.Forms.Button btn;
    }
}
