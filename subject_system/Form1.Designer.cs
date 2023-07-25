
namespace subject_system
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbx = new System.Windows.Forms.ListBox();
            this.cklstbx = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Cnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbx
            // 
            this.lstbx.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 19;
            this.lstbx.Location = new System.Drawing.Point(325, 74);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(292, 232);
            this.lstbx.TabIndex = 0;
            // 
            // cklstbx
            // 
            this.cklstbx.CheckOnClick = true;
            this.cklstbx.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cklstbx.FormattingEnabled = true;
            this.cklstbx.Location = new System.Drawing.Point(12, 74);
            this.cklstbx.Name = "cklstbx";
            this.cklstbx.Size = new System.Drawing.Size(283, 242);
            this.cklstbx.TabIndex = 1;
            this.cklstbx.SelectedIndexChanged += new System.EventHandler(this.cklstbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "可選課程清單：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(320, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "以選擇課程：";
            // 
            // but_Add
            // 
            this.but_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Add.Location = new System.Drawing.Point(12, 341);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(195, 60);
            this.but_Add.TabIndex = 3;
            this.but_Add.Text = "加入以勾選課程";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(249, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "選擇狀態：";
            // 
            // lab_Cnt
            // 
            this.lab_Cnt.AutoSize = true;
            this.lab_Cnt.Location = new System.Drawing.Point(345, 365);
            this.lab_Cnt.Name = "lab_Cnt";
            this.lab_Cnt.Size = new System.Drawing.Size(98, 12);
            this.lab_Cnt.TabIndex = 5;
            this.lab_Cnt.Text = "以勾數量 / 總數量";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 440);
            this.Controls.Add(this.lab_Cnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cklstbx);
            this.Controls.Add(this.lstbx);
            this.Name = "MainForm";
            this.Text = "選課系統";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.CheckedListBox cklstbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_Cnt;
    }
}

