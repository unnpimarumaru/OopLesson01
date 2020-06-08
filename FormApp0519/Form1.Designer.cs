namespace FormApp0519
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMessage.Location = new System.Drawing.Point(40, 74);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(55, 19);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "label2";
            // 
            // buttonDisp
            // 
            this.buttonDisp.Location = new System.Drawing.Point(79, 108);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(75, 23);
            this.buttonDisp.TabIndex = 2;
            this.buttonDisp.Text = "表示";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.buttonDisp_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(79, 17);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 19);
            this.nametextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 172);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.TextBox nametextBox;
    }
}

