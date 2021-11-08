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
    public partial class frmLogin : Form
    {
        private AccountService _accountService;
        private IAccountService _iaccountService;
        private IFileService _iFileService;
        private string _fileNamePath; // link đường đãn
        private List<Account> _lstAccounts;
        public frmLogin()
        {
            InitializeComponent();
            _iFileService = new FileService();
            _iaccountService = new AccountService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fileNamePath = dlg.FileName;// gán lại đg dẫn file cho biến
                lbl_fileNmaePath.Text = _fileNamePath;
                _lstAccounts = _iFileService.openfile<Account>(_fileNamePath);
                //đọc file lên và lấ giá trị ở trong file gán lại cho lisst
                _iaccountService.filldataFromFileToService(_lstAccounts);
                // đổ giá trị vao list pử bên trong accountservice
                lbl_checkdata.Text = (_iaccountService.getlstAccounts() == null
                    ? 0 : _iaccountService.getlstAccounts().Count).ToString();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.SenderFileNameoathFormLogin(_fileNamePath);
            // gọi phương thức  bên class  đăng kí và truuyenf đg dẫn sang để gán lại
            this.Hide();// ẩn form hiện tại
            frmRegister.Show();// hiện thị form gọi đến
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_iaccountService.getlstAccounts().Any(c => c.Acc == txt_tk.Text && c.Pass == txt_mk.Text))
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                frmMain frmMain = new frmMain();
                frmMain.senderFileNameoathFormLogin(txt_tk,_fileNamePath);
                // truyền dl từ login vào main khi đăng nhập thành công
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại ", "Thông báo");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
