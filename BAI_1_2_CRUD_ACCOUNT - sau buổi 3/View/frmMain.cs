using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_ACCOUNT.IServices;
using BAI_1_2_CRUD_ACCOUNT.Models;
using BAI_1_2_CRUD_ACCOUNT.Service;

namespace BAI_1_2_CRUD_ACCOUNT.View
{
    public partial class frmMain : Form
    {
        private AccountService _accountService;
        private IAccountService _iaccountService;
        private IFileService _iFileService;
        private string _fileNamePath; // link đường đãn
        private List<Account> _lstAccounts;
        public frmMain()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _iFileService = new FileService();
            _iaccountService = new AccountService();
            _lstAccounts = new List<Account>();
            rdb_nam.Checked = true;
            cbx_kh.Checked = true;
            loadCbxNmaSInh();
            
            
        }
        void loadCbxNmaSInh()// đổ dữ liêu liên comboboxx năm sinh
        {
            foreach (var x in _iaccountService.getyearOffBirths())
            {
                cbo_sinh.Items.Add(x);
            }
        }
        public void senderFileNameoathFormLogin(TextBox txtacc,string path)
        {
            _fileNamePath = path; // gán lại gt đg dẫn từ form  sang bên đăng kí 
            lbl_acclogin.Text = txtacc.Text;
            // khi lấy đc đường dẫn tù form login lên main thì chúng ta tiến hành đọc
            //file và đổ dl vò accountservice
            _iaccountService.filldataFromFileToService(_iFileService.openfile<Account>(path));
            Loadata();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void Loadata()
        {
            _lstAccounts = new List<Account>();// khởi tại lại lst
            _lstAccounts = _iaccountService.getlstAccounts();//đổ dl vào lst hiện tại
                // đếm sl thuộc tính có trong đối tượng
                Type type = typeof(Account);
                int slthuoctinh = type.GetProperties().Length;// sl thuộc tính có trong đó
                GV_chucnang.ColumnCount = slthuoctinh + 1;//ví có thêm cooyj tuổi
                GV_chucnang.Columns[0].Name = "ID";
                GV_chucnang.Columns[1].Name = "Tài khoản";
                GV_chucnang.Columns[2].Name = "Mật khẩu";
                GV_chucnang.Columns[3].Name = "Giới tính";
                GV_chucnang.Columns[4].Name = "Năm sinh";
                GV_chucnang.Columns[5].Name = "Tuổi";
                GV_chucnang.Columns[6].Name = "Trạng thái";
            GV_chucnang.Rows.Clear();
            // đổ d
            foreach (var x in _lstAccounts)
            {
                GV_chucnang.Rows.Add(x.Id, x.Acc, x.Pass, x.Sex == 1 ? "nam" : "nữ", x.YearofBirth,
                    DateTime.Now.Year - x.YearofBirth, x.Status ? "Hoạt động": "không hoaatj động");
            }
        }
        private void txt_mk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            //gán giá trị cho đối tượng
            account.Id = _lstAccounts == null ? 1 : _lstAccounts.Count;// giúp cho id tự sinh
            account.Acc = txt_tk.Text;
            account.Pass = txt_mk.Text;
            account.Sex = rdb_nam.Checked ? 1 : 0;
            account.YearofBirth = Convert.ToInt32(cbo_sinh.SelectedItem);
            account.Status = cbx_kh.Checked;
            // sau khi đổ dl gấn gl thì lienf tiến hành sd chcucws năng thêm đối tượng
            _iaccountService.addAccount(account);
            // sau khi thêm xong thì tiến hành load data 
            Loadata();
        }

        private void cbx_kh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_kh.Checked)
            {
                cbx_khd.Checked = false;
            }
        }
    }
}
