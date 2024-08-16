namespace WindowsFormsApp2
{
    partial class frm11
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
            this.btnbt = new System.Windows.Forms.Button();
            this.btnbtfl = new System.Windows.Forms.Button();
            this.ckbMauchu = new System.Windows.Forms.CheckBox();
            this.ckbMaunen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnbt
            // 
            this.btnbt.Location = new System.Drawing.Point(32, 41);
            this.btnbt.Name = "btnbt";
            this.btnbt.Size = new System.Drawing.Size(75, 23);
            this.btnbt.TabIndex = 0;
            this.btnbt.Text = "Button";
            this.btnbt.UseVisualStyleBackColor = true;
            // 
            // btnbtfl
            // 
            this.btnbtfl.Location = new System.Drawing.Point(32, 113);
            this.btnbtfl.Name = "btnbtfl";
            this.btnbtfl.Size = new System.Drawing.Size(75, 23);
            this.btnbtfl.TabIndex = 1;
            this.btnbtfl.Text = "Button Flat";
            this.btnbtfl.UseVisualStyleBackColor = true;
            // 
            // ckbMauchu
            // 
            this.ckbMauchu.AutoSize = true;
            this.ckbMauchu.Location = new System.Drawing.Point(167, 34);
            this.ckbMauchu.Name = "ckbMauchu";
            this.ckbMauchu.Size = new System.Drawing.Size(112, 17);
            this.ckbMauchu.TabIndex = 2;
            this.ckbMauchu.Text = "Thay đổi màu chữ";
            this.ckbMauchu.UseVisualStyleBackColor = true;
            this.ckbMauchu.CheckedChanged += new System.EventHandler(this.ckbMauchu_CheckedChanged);
            // 
            // ckbMaunen
            // 
            this.ckbMaunen.AutoSize = true;
            this.ckbMaunen.Location = new System.Drawing.Point(167, 57);
            this.ckbMaunen.Name = "ckbMaunen";
            this.ckbMaunen.Size = new System.Drawing.Size(112, 17);
            this.ckbMaunen.TabIndex = 3;
            this.ckbMaunen.Text = "Thay đổi màu nền";
            this.ckbMaunen.UseVisualStyleBackColor = true;
            this.ckbMaunen.CheckedChanged += new System.EventHandler(this.ckbMaunen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(167, 93);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(66, 17);
            this.rdFlat.TabIndex = 4;
            this.rdFlat.TabStop = true;
            this.rdFlat.Text = "Kiểu Flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Location = new System.Drawing.Point(167, 130);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(80, 17);
            this.rdPopup.TabIndex = 5;
            this.rdPopup.TabStop = true;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // frm11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 218);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.ckbMaunen);
            this.Controls.Add(this.ckbMauchu);
            this.Controls.Add(this.btnbtfl);
            this.Controls.Add(this.btnbt);
            this.Name = "frm11";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbt;
        private System.Windows.Forms.Button btnbtfl;
        private System.Windows.Forms.CheckBox ckbMauchu;
        private System.Windows.Forms.CheckBox ckbMaunen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
    }
}