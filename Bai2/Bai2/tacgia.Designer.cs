namespace Bai2
{
    partial class tacgia
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
            this.tbxid = new System.Windows.Forms.TextBox();
            this.tbxtentacgia = new System.Windows.Forms.TextBox();
            this.tbxnamsinh = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvgidttacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvtentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnamsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvquequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btninstall = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnquanlysach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxquequan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Tac Gia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nam Sinh";
            // 
            // tbxid
            // 
            this.tbxid.Location = new System.Drawing.Point(103, 73);
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(186, 20);
            this.tbxid.TabIndex = 3;
            // 
            // tbxtentacgia
            // 
            this.tbxtentacgia.Location = new System.Drawing.Point(103, 127);
            this.tbxtentacgia.Name = "tbxtentacgia";
            this.tbxtentacgia.Size = new System.Drawing.Size(186, 20);
            this.tbxtentacgia.TabIndex = 4;
            // 
            // tbxnamsinh
            // 
            this.tbxnamsinh.Location = new System.Drawing.Point(103, 172);
            this.tbxnamsinh.Name = "tbxnamsinh";
            this.tbxnamsinh.Size = new System.Drawing.Size(186, 20);
            this.tbxnamsinh.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgidttacgia,
            this.gdvtentacgia,
            this.dgvnamsinh,
            this.dgvquequan});
            this.dataGridView1.Location = new System.Drawing.Point(356, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 367);
            this.dataGridView1.TabIndex = 6;
            // 
            // dvgidttacgia
            // 
            this.dvgidttacgia.HeaderText = "ID";
            this.dvgidttacgia.Name = "dvgidttacgia";
            // 
            // gdvtentacgia
            // 
            this.gdvtentacgia.HeaderText = "TEN TAC GIA";
            this.gdvtentacgia.Name = "gdvtentacgia";
            // 
            // dgvnamsinh
            // 
            this.dgvnamsinh.HeaderText = "NAM SINH";
            this.dgvnamsinh.Name = "dgvnamsinh";
            // 
            // dgvquequan
            // 
            this.dgvquequan.HeaderText = "QUE QUAN";
            this.dgvquequan.Name = "dgvquequan";
            // 
            // btninstall
            // 
            this.btninstall.Location = new System.Drawing.Point(6, 293);
            this.btninstall.Name = "btninstall";
            this.btninstall.Size = new System.Drawing.Size(75, 23);
            this.btninstall.TabIndex = 7;
            this.btninstall.Text = "INSTALL";
            this.btninstall.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(116, 293);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(244, 293);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnquanlysach
            // 
            this.btnquanlysach.Location = new System.Drawing.Point(76, 349);
            this.btnquanlysach.Name = "btnquanlysach";
            this.btnquanlysach.Size = new System.Drawing.Size(177, 30);
            this.btnquanlysach.TabIndex = 10;
            this.btnquanlysach.Text = "Quan Ly Sach";
            this.btnquanlysach.UseVisualStyleBackColor = true;
            this.btnquanlysach.Click += new System.EventHandler(this.btnquanlysach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Que Quan";
            // 
            // tbxquequan
            // 
            this.tbxquequan.Location = new System.Drawing.Point(104, 220);
            this.tbxquequan.Name = "tbxquequan";
            this.tbxquequan.Size = new System.Drawing.Size(186, 20);
            this.tbxquequan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxquequan);
            this.panel1.Controls.Add(this.tbxid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxtentacgia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxnamsinh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 262);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "THONG TIN TAC GIA";
            // 
            // tacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnquanlysach);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninstall);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tacgia";
            this.Text = "tacgia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxid;
        private System.Windows.Forms.TextBox tbxtentacgia;
        private System.Windows.Forms.TextBox tbxnamsinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninstall;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnquanlysach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxquequan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgidttacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdvtentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnamsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvquequan;
    }
}