
namespace Quan_ly_cua_hang_TH_True_Mart
{
    partial class frmMaQLNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaQL = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(239, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP MÃ QUẢN LÝ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã quản lý:";
            // 
            // txtMaQL
            // 
            this.txtMaQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQL.Location = new System.Drawing.Point(341, 185);
            this.txtMaQL.Name = "txtMaQL";
            this.txtMaQL.PasswordChar = '*';
            this.txtMaQL.Size = new System.Drawing.Size(288, 34);
            this.txtMaQL.TabIndex = 2;
            // 
            // btnThuchien
            // 
            this.btnThuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchien.Location = new System.Drawing.Point(323, 281);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(182, 60);
            this.btnThuchien.TabIndex = 3;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // frmMaQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtMaQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUYỀN TRUY CẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaQL;
        private System.Windows.Forms.Button btnThuchien;
    }
}