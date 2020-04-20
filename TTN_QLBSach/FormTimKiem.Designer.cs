namespace TTN_QLBSach
{
    partial class FormTimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.texttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtheloai = new System.Windows.Forms.RadioButton();
            this.rbnamxuatban = new System.Windows.Forms.RadioButton();
            this.rbtacgia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbtacgia);
            this.groupBox1.Controls.Add(this.rbnamxuatban);
            this.groupBox1.Controls.Add(this.rbtheloai);
            this.groupBox1.Location = new System.Drawing.Point(138, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // texttimkiem
            // 
            this.texttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttimkiem.Location = new System.Drawing.Point(138, 236);
            this.texttimkiem.Name = "texttimkiem";
            this.texttimkiem.Size = new System.Drawing.Size(326, 26);
            this.texttimkiem.TabIndex = 1;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(529, 222);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(224, 54);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "TÌM KIẾM";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.Btntimkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 155);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "MỜI BẠN LỰA CHỌN MỤC TÌM KIẾM";
            // 
            // rbtheloai
            // 
            this.rbtheloai.AutoEllipsis = true;
            this.rbtheloai.AutoSize = true;
            this.rbtheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtheloai.Location = new System.Drawing.Point(230, 32);
            this.rbtheloai.Name = "rbtheloai";
            this.rbtheloai.Size = new System.Drawing.Size(115, 24);
            this.rbtheloai.TabIndex = 1;
            this.rbtheloai.Text = "THỂ LOẠI";
            this.rbtheloai.UseVisualStyleBackColor = true;
            this.rbtheloai.CheckedChanged += new System.EventHandler(this.Rbtheloai_CheckedChanged);
            // 
            // rbnamxuatban
            // 
            this.rbnamxuatban.AutoEllipsis = true;
            this.rbnamxuatban.AutoSize = true;
            this.rbnamxuatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnamxuatban.Location = new System.Drawing.Point(405, 32);
            this.rbnamxuatban.Name = "rbnamxuatban";
            this.rbnamxuatban.Size = new System.Drawing.Size(168, 24);
            this.rbnamxuatban.TabIndex = 2;
            this.rbnamxuatban.Text = "NĂM XUẤT BẢN";
            this.rbnamxuatban.UseVisualStyleBackColor = true;
            this.rbnamxuatban.CheckedChanged += new System.EventHandler(this.Rbnamxuatban_CheckedChanged);
            // 
            // rbtacgia
            // 
            this.rbtacgia.AutoEllipsis = true;
            this.rbtacgia.AutoSize = true;
            this.rbtacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtacgia.Location = new System.Drawing.Point(30, 32);
            this.rbtacgia.Name = "rbtacgia";
            this.rbtacgia.Size = new System.Drawing.Size(145, 24);
            this.rbtacgia.TabIndex = 3;
            this.rbtacgia.Text = "TÊN TÁC GIẢ";
            this.rbtacgia.UseVisualStyleBackColor = true;
            this.rbtacgia.CheckedChanged += new System.EventHandler(this.Rbtacgia_CheckedChanged);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(889, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.texttimkiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtacgia;
        private System.Windows.Forms.RadioButton rbnamxuatban;
        private System.Windows.Forms.RadioButton rbtheloai;
    }
}