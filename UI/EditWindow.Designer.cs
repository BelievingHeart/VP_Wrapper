namespace UI
{
    partial class EditWindow
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
            this.cogToolGroupEditV21 = new Cognex.VisionPro.ToolGroup.CogToolGroupEditV2();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV21)).BeginInit();
            this.SuspendLayout();
            // 
            // cogToolGroupEditV21
            // 
            this.cogToolGroupEditV21.AllowDrop = true;
            this.cogToolGroupEditV21.ContextMenuCustomizer = null;
            this.cogToolGroupEditV21.Location = new System.Drawing.Point(-3, 12);
            this.cogToolGroupEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolGroupEditV21.Name = "cogToolGroupEditV21";
            this.cogToolGroupEditV21.ShowNodeToolTips = true;
            this.cogToolGroupEditV21.Size = new System.Drawing.Size(808, 410);
            this.cogToolGroupEditV21.SuspendElectricRuns = false;
            this.cogToolGroupEditV21.TabIndex = 0;
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cogToolGroupEditV21);
            this.Name = "EditWindow";
            this.Text = "EditWindow";
            this.Load += new System.EventHandler(this.EditWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.ToolGroup.CogToolGroupEditV2 cogToolGroupEditV21;
    }
}