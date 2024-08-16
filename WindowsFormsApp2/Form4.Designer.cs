namespace WindowsFormsApp2
{
    partial class frm4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm4));
            this.imlDemo = new System.Windows.Forms.ImageList(this.components);
            this.cbbChonHinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // imlDemo
            // 
            this.imlDemo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlDemo.ImageStream")));
            this.imlDemo.TransparentColor = System.Drawing.Color.Transparent;
            this.imlDemo.Images.SetKeyName(0, "iml4.jpg");
            this.imlDemo.Images.SetKeyName(1, "iml3.jpg");
            this.imlDemo.Images.SetKeyName(2, "iml2.jpg");
            this.imlDemo.Images.SetKeyName(3, "iml1.jpg");
            // 
            // cbbChonHinh
            // 
            this.cbbChonHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonHinh.FormattingEnabled = true;
            this.cbbChonHinh.Location = new System.Drawing.Point(300, 67);
            this.cbbChonHinh.Name = "cbbChonHinh";
            this.cbbChonHinh.Size = new System.Drawing.Size(121, 21);
            this.cbbChonHinh.Sorted = true;
            this.cbbChonHinh.TabIndex = 0;
            this.cbbChonHinh.SelectedIndexChanged += new System.EventHandler(this.cbbChonHinh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(114, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn hình hiển thị:";
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Location = new System.Drawing.Point(118, 115);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(256, 256);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 2;
            this.pbHinhAnh.TabStop = false;
            this.pbHinhAnh.Click += new System.EventHandler(this.pbHinhAnh_Click);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 427);
            this.Controls.Add(this.pbHinhAnh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChonHinh);
            this.Name = "frm4";
            this.Text = "Demo ImageList";
            this.Load += new System.EventHandler(this.frm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imlDemo;
        private System.Windows.Forms.ComboBox cbbChonHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHinhAnh;
    }
}