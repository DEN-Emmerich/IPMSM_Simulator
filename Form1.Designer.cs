namespace IPMSM_Simulator
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label_speed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Combo_pole = new System.Windows.Forms.ComboBox();
            this.Label_combo_pole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_speed
            // 
            this.Label_speed.AutoSize = true;
            this.Label_speed.Location = new System.Drawing.Point(12, 9);
            this.Label_speed.Name = "Label_speed";
            this.Label_speed.Size = new System.Drawing.Size(11, 12);
            this.Label_speed.TabIndex = 0;
            this.Label_speed.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(115, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 257);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Combo_pole
            // 
            this.Combo_pole.FormattingEnabled = true;
            this.Combo_pole.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.Combo_pole.Location = new System.Drawing.Point(137, 9);
            this.Combo_pole.Name = "Combo_pole";
            this.Combo_pole.Size = new System.Drawing.Size(51, 20);
            this.Combo_pole.TabIndex = 2;
            this.Combo_pole.SelectedIndexChanged += new System.EventHandler(this.Combo_pole_SelectedIndexChanged);
            // 
            // Label_combo_pole
            // 
            this.Label_combo_pole.AutoSize = true;
            this.Label_combo_pole.Location = new System.Drawing.Point(41, 12);
            this.Label_combo_pole.Name = "Label_combo_pole";
            this.Label_combo_pole.Size = new System.Drawing.Size(90, 12);
            this.Label_combo_pole.TabIndex = 3;
            this.Label_combo_pole.Text = "Number of Poles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_combo_pole);
            this.Controls.Add(this.Combo_pole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_speed);
            this.Name = "Form1";
            this.Text = "IPMSM Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label_speed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Combo_pole;
        private System.Windows.Forms.Label Label_combo_pole;
    }
}

