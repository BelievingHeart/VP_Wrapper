namespace UI
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._btnEdit = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_passLight = new System.Windows.Forms.Label();
            this.label_emptyLight = new System.Windows.Forms.Label();
            this.label_rejectLight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnEdit
            // 
            this._btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnEdit.Location = new System.Drawing.Point(22, 289);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(71, 25);
            this._btnEdit.TabIndex = 1;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this._btnEdit_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(395, 12);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(126, 134);
            this.textBox_message.TabIndex = 3;
            // 
            // label_passLight
            // 
            this.label_passLight.AutoSize = true;
            this.label_passLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_passLight.Location = new System.Drawing.Point(308, 221);
            this.label_passLight.Name = "label_passLight";
            this.label_passLight.Size = new System.Drawing.Size(36, 37);
            this.label_passLight.TabIndex = 4;
            this.label_passLight.Text = "●";
            // 
            // label_emptyLight
            // 
            this.label_emptyLight.AutoSize = true;
            this.label_emptyLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emptyLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_emptyLight.Location = new System.Drawing.Point(308, 289);
            this.label_emptyLight.Name = "label_emptyLight";
            this.label_emptyLight.Size = new System.Drawing.Size(36, 37);
            this.label_emptyLight.TabIndex = 5;
            this.label_emptyLight.Text = "●";
            // 
            // label_rejectLight
            // 
            this.label_rejectLight.AutoSize = true;
            this.label_rejectLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rejectLight.ForeColor = System.Drawing.Color.Red;
            this.label_rejectLight.Location = new System.Drawing.Point(308, 252);
            this.label_rejectLight.Name = "label_rejectLight";
            this.label_rejectLight.Size = new System.Drawing.Size(36, 37);
            this.label_rejectLight.TabIndex = 6;
            this.label_rejectLight.Text = "●";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "无料";
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(12, 12);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(346, 206);
            this.cogRecordDisplay1.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 325);
            this.Controls.Add(this.cogRecordDisplay1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_rejectLight);
            this.Controls.Add(this.label_emptyLight);
            this.Controls.Add(this.label_passLight);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this._btnEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.TextBox textBox_message;
        public System.Windows.Forms.Label label_passLight;
        public System.Windows.Forms.Label label_emptyLight;
        public System.Windows.Forms.Label label_rejectLight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
    }
}

