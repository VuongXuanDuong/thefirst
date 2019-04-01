namespace Bai2
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxtensach = new System.Windows.Forms.TextBox();
            this.tbxtacgia = new System.Windows.Forms.TextBox();
            this.tbxnamxuatban = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.danhsach = new System.Windows.Forms.DataGridView();
            this.btninstall = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btntacgia = new System.Windows.Forms.Button();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnamxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN TÁC GIẢ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NĂM XUẤT BẢN";
            // 
            // tbxtensach
            // 
            this.tbxtensach.Location = new System.Drawing.Point(121, 95);
            this.tbxtensach.Name = "tbxtensach";
            this.tbxtensach.Size = new System.Drawing.Size(207, 20);
            this.tbxtensach.TabIndex = 3;
            // 
            // tbxtacgia
            // 
            this.tbxtacgia.Location = new System.Drawing.Point(121, 144);
            this.tbxtacgia.Name = "tbxtacgia";
            this.tbxtacgia.Size = new System.Drawing.Size(207, 20);
            this.tbxtacgia.TabIndex = 4;
            // 
            // tbxnamxuatban
            // 
            this.tbxnamxuatban.Location = new System.Drawing.Point(121, 188);
            this.tbxnamxuatban.Name = "tbxnamxuatban";
            this.tbxnamxuatban.Size = new System.Drawing.Size(207, 20);
            this.tbxnamxuatban.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxnamxuatban);
            this.panel1.Controls.Add(this.tbxtensach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxtacgia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 239);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "THONG TIN QUAN LY SACH";
            // 
            // danhsach
            // 
            this.danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvtensach,
            this.dgvtacgia,
            this.dgvnamxuatban});
            this.danhsach.Location = new System.Drawing.Point(423, 12);
            this.danhsach.Name = "danhsach";
            this.danhsach.Size = new System.Drawing.Size(443, 329);
            this.danhsach.TabIndex = 7;
            this.danhsach.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.danhsach_RowHeaderMouseDoubleClick);
            // 
            // btninstall
            // 
            this.btninstall.Location = new System.Drawing.Point(15, 294);
            this.btninstall.Name = "btninstall";
            this.btninstall.Size = new System.Drawing.Size(75, 23);
            this.btninstall.TabIndex = 8;
            this.btninstall.Text = "INSTALL";
            this.btninstall.UseVisualStyleBackColor = true;
            this.btninstall.Click += new System.EventHandler(this.btninstall_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(144, 294);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(294, 294);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btntacgia
            // 
            this.btntacgia.Location = new System.Drawing.Point(83, 337);
            this.btntacgia.Name = "btntacgia";
            this.btntacgia.Size = new System.Drawing.Size(219, 23);
            this.btntacgia.TabIndex = 11;
            this.btntacgia.Text = "Quan Ly Tac Gia";
            this.btntacgia.UseVisualStyleBackColor = true;
            this.btntacgia.Click += new System.EventHandler(this.btntacgia_Click);
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "ID";
            this.dgvid.Name = "dgvid";
            // 
            // dgvtensach
            // 
            this.dgvtensach.HeaderText = "TEN SACH";
            this.dgvtensach.Name = "dgvtensach";
            // 
            // dgvtacgia
            // 
            this.dgvtacgia.HeaderText = "TAC GIA";
            this.dgvtacgia.Name = "dgvtacgia";
            // 
            // dgvnamxuatban
            // 
            this.dgvnamxuatban.HeaderText = "NAM XUAT BAN";
            this.dgvnamxuatban.Name = "dgvnamxuatban";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 372);
            this.Controls.Add(this.btntacgia);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninstall);
            this.Controls.Add(this.danhsach);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxtensach;
        private System.Windows.Forms.TextBox tbxtacgia;
        private System.Windows.Forms.TextBox tbxnamxuatban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView danhsach;
        private System.Windows.Forms.Button btninstall;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btntacgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnamxuatban;
    }
}

