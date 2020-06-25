namespace AddressManagement
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.btImageClear = new System.Windows.Forms.Button();
            this.btImageOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(64, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(337, 31);
            this.tbName.TabIndex = 1;
            // 
            // cbGroup
            // 
            this.cbGroup.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(64, 270);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(337, 32);
            this.cbGroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "グループ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "画像";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(593, 36);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(234, 154);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(963, 153);
            this.dataGridView1.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(1025, 479);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 81);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(43, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "住所";
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCompany.Location = new System.Drawing.Point(593, 220);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(355, 31);
            this.tbCompany.TabIndex = 1;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(64, 344);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(337, 57);
            this.tbMemo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(43, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "メモ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(50, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "TEL";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(64, 118);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(337, 31);
            this.tbAddress.TabIndex = 1;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTelephone.Location = new System.Drawing.Point(64, 198);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(337, 31);
            this.tbTelephone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(572, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(572, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "部署";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDepartment.Location = new System.Drawing.Point(593, 297);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(355, 31);
            this.tbDepartment.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(572, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "役職";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPosition.Location = new System.Drawing.Point(593, 363);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(355, 31);
            this.tbPosition.TabIndex = 1;
            // 
            // btImageClear
            // 
            this.btImageClear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageClear.Location = new System.Drawing.Point(1016, 118);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(107, 40);
            this.btImageClear.TabIndex = 5;
            this.btImageClear.Text = "クリア";
            this.btImageClear.UseVisualStyleBackColor = true;
            // 
            // btImageOpen
            // 
            this.btImageOpen.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageOpen.Location = new System.Drawing.Point(1016, 36);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(107, 41);
            this.btImageOpen.TabIndex = 5;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1149, 600);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.btImageClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "アドレス管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Button btImageClear;
        private System.Windows.Forms.Button btImageOpen;
    }
}

