namespace WindowsFormsApp1
{
    partial class ParentForm
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
            this.sumModule = new WindowsFormsApp1.Modules.Module1();
            this.resultModule = new WindowsFormsApp1.Modules.ResultModule();
            this.controlModule = new WindowsFormsApp1.Modules.ControlModule();
            this.SuspendLayout();
            // 
            // sumModule
            // 
            this.sumModule.BackColor = System.Drawing.Color.Red;
            this.sumModule.Location = new System.Drawing.Point(146, 36);
            this.sumModule.Name = "sumModule";
            this.sumModule.OnClickCallback = null;
            this.sumModule.Size = new System.Drawing.Size(530, 127);
            this.sumModule.TabIndex = 0;
            // 
            // resultModule
            // 
            this.resultModule.Location = new System.Drawing.Point(418, 189);
            this.resultModule.Name = "resultModule";
            this.resultModule.Size = new System.Drawing.Size(258, 132);
            this.resultModule.TabIndex = 1;
            // 
            // controlModule
            // 
            this.controlModule.GlobalForm = null;
            this.controlModule.Location = new System.Drawing.Point(28, 221);
            this.controlModule.Name = "controlModule";
            this.controlModule.Size = new System.Drawing.Size(341, 171);
            this.controlModule.TabIndex = 2;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlModule);
            this.Controls.Add(this.resultModule);
            this.Controls.Add(this.sumModule);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Modules.Module1 sumModule;
        private Modules.ResultModule resultModule;
        private Modules.ControlModule controlModule;
    }
}