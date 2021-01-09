namespace WindowsFormsApp1.Modules
{
    partial class ControlModule
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
            this.btnInputs = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInputs
            // 
            this.btnInputs.Location = new System.Drawing.Point(137, 32);
            this.btnInputs.Name = "btnInputs";
            this.btnInputs.Size = new System.Drawing.Size(75, 23);
            this.btnInputs.TabIndex = 0;
            this.btnInputs.Text = "Inputs";
            this.btnInputs.UseVisualStyleBackColor = true;
            // 
            // btnModules
            // 
            this.btnModules.Location = new System.Drawing.Point(137, 101);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(75, 23);
            this.btnModules.TabIndex = 2;
            this.btnModules.Text = "Modules";
            this.btnModules.UseVisualStyleBackColor = true;
            // 
            // ControlModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnInputs);
            this.Name = "ControlModule";
            this.Size = new System.Drawing.Size(341, 171);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInputs;
        private System.Windows.Forms.Button btnModules;
    }
}
