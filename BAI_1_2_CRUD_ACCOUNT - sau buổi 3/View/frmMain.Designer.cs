
namespace BAI_1_2_CRUD_ACCOUNT.View
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_luufile = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_automk = new System.Windows.Forms.Button();
            this.cbo_sinh = new System.Windows.Forms.ComboBox();
            this.cbx_khd = new System.Windows.Forms.CheckBox();
            this.cbx_kh = new System.Windows.Forms.CheckBox();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.Btn_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GV_chucnang = new System.Windows.Forms.DataGridView();
            this.lbl_tktk = new System.Windows.Forms.Label();
            this.txt_tktk = new System.Windows.Forms.TextBox();
            this.lbl_acclogin = new System.Windows.Forms.Label();
            this.lbl_chao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_chucnang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_luufile,
            this.đọcFileToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mn_luufile
            // 
            this.mn_luufile.Name = "mn_luufile";
            this.mn_luufile.Size = new System.Drawing.Size(224, 26);
            this.mn_luufile.Text = "Lưu file";
            // 
            // đọcFileToolStripMenuItem
            // 
            this.đọcFileToolStripMenuItem.Name = "đọcFileToolStripMenuItem";
            this.đọcFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đọcFileToolStripMenuItem.Text = "Đọc file";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_automk);
            this.groupBox1.Controls.Add(this.cbo_sinh);
            this.groupBox1.Controls.Add(this.cbx_khd);
            this.groupBox1.Controls.Add(this.cbx_kh);
            this.groupBox1.Controls.Add(this.rdb_nu);
            this.groupBox1.Controls.Add(this.rdb_nam);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản";
            // 
            // btn_automk
            // 
            this.btn_automk.Location = new System.Drawing.Point(330, 65);
            this.btn_automk.Name = "btn_automk";
            this.btn_automk.Size = new System.Drawing.Size(131, 23);
            this.btn_automk.TabIndex = 10;
            this.btn_automk.Text = "Mật khẩu đề xuất";
            this.btn_automk.UseVisualStyleBackColor = true;
            // 
            // cbo_sinh
            // 
            this.cbo_sinh.FormattingEnabled = true;
            this.cbo_sinh.Location = new System.Drawing.Point(140, 149);
            this.cbo_sinh.Name = "cbo_sinh";
            this.cbo_sinh.Size = new System.Drawing.Size(163, 24);
            this.cbo_sinh.TabIndex = 9;
            // 
            // cbx_khd
            // 
            this.cbx_khd.AutoSize = true;
            this.cbx_khd.Location = new System.Drawing.Point(241, 191);
            this.cbx_khd.Name = "cbx_khd";
            this.cbx_khd.Size = new System.Drawing.Size(139, 21);
            this.cbx_khd.TabIndex = 8;
            this.cbx_khd.Text = "Không hoạt động";
            this.cbx_khd.UseVisualStyleBackColor = true;
            // 
            // cbx_kh
            // 
            this.cbx_kh.AutoSize = true;
            this.cbx_kh.Location = new System.Drawing.Point(137, 191);
            this.cbx_kh.Name = "cbx_kh";
            this.cbx_kh.Size = new System.Drawing.Size(96, 21);
            this.cbx_kh.TabIndex = 7;
            this.cbx_kh.Text = "Hoạt động";
            this.cbx_kh.UseVisualStyleBackColor = true;
            this.cbx_kh.CheckedChanged += new System.EventHandler(this.cbx_kh_CheckedChanged);
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(232, 120);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(47, 21);
            this.rdb_nu.TabIndex = 6;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(143, 120);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(58, 21);
            this.rdb_nam.TabIndex = 6;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(140, 67);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(149, 22);
            this.txt_mk.TabIndex = 4;
            this.txt_mk.TextChanged += new System.EventHandler(this.txt_mk_TextChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(140, 30);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(149, 22);
            this.txt_tk.TabIndex = 5;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trạng thái";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm sinh";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.Btn_them);
            this.groupBox2.Location = new System.Drawing.Point(585, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 143);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(131, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(31, 104);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(131, 23);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(31, 66);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(131, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // Btn_them
            // 
            this.Btn_them.Location = new System.Drawing.Point(31, 37);
            this.Btn_them.Name = "Btn_them";
            this.Btn_them.Size = new System.Drawing.Size(131, 23);
            this.Btn_them.TabIndex = 10;
            this.Btn_them.Text = "Thêm";
            this.Btn_them.UseVisualStyleBackColor = true;
            this.Btn_them.Click += new System.EventHandler(this.Btn_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GV_chucnang);
            this.groupBox3.Controls.Add(this.lbl_tktk);
            this.groupBox3.Controls.Add(this.txt_tktk);
            this.groupBox3.Location = new System.Drawing.Point(58, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 341);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // GV_chucnang
            // 
            this.GV_chucnang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_chucnang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_chucnang.Location = new System.Drawing.Point(6, 64);
            this.GV_chucnang.MultiSelect = false;
            this.GV_chucnang.Name = "GV_chucnang";
            this.GV_chucnang.RowHeadersWidth = 51;
            this.GV_chucnang.RowTemplate.Height = 24;
            this.GV_chucnang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_chucnang.Size = new System.Drawing.Size(699, 271);
            this.GV_chucnang.TabIndex = 0;
            // 
            // lbl_tktk
            // 
            this.lbl_tktk.AutoSize = true;
            this.lbl_tktk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tktk.Location = new System.Drawing.Point(21, 28);
            this.lbl_tktk.Name = "lbl_tktk";
            this.lbl_tktk.Size = new System.Drawing.Size(95, 20);
            this.lbl_tktk.TabIndex = 3;
            this.lbl_tktk.Text = "Tìm kiếm tk";
            this.lbl_tktk.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tktk
            // 
            this.txt_tktk.Location = new System.Drawing.Point(130, 28);
            this.txt_tktk.Name = "txt_tktk";
            this.txt_tktk.Size = new System.Drawing.Size(149, 22);
            this.txt_tktk.TabIndex = 5;
            this.txt_tktk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // lbl_acclogin
            // 
            this.lbl_acclogin.AutoSize = true;
            this.lbl_acclogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acclogin.Location = new System.Drawing.Point(696, 0);
            this.lbl_acclogin.Name = "lbl_acclogin";
            this.lbl_acclogin.Size = new System.Drawing.Size(80, 20);
            this.lbl_acclogin.TabIndex = 3;
            this.lbl_acclogin.Text = "Chào bạn";
            this.lbl_acclogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_chao
            // 
            this.lbl_chao.AutoSize = true;
            this.lbl_chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chao.Location = new System.Drawing.Point(595, 39);
            this.lbl_chao.Name = "lbl_chao";
            this.lbl_chao.Size = new System.Drawing.Size(80, 20);
            this.lbl_chao.TabIndex = 3;
            this.lbl_chao.Text = "Chào bạn";
            this.lbl_chao.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 707);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_acclogin);
            this.Controls.Add(this.lbl_chao);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(824, 754);
            this.MinimumSize = new System.Drawing.Size(824, 754);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_chucnang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_luufile;
        private System.Windows.Forms.ToolStripMenuItem đọcFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_khd;
        private System.Windows.Forms.CheckBox cbx_kh;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_sinh;
        private System.Windows.Forms.Button btn_automk;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button Btn_them;
        private System.Windows.Forms.DataGridView GV_chucnang;
        private System.Windows.Forms.Label lbl_tktk;
        private System.Windows.Forms.TextBox txt_tktk;
        private System.Windows.Forms.Label lbl_acclogin;
        private System.Windows.Forms.Label lbl_chao;
    }
}