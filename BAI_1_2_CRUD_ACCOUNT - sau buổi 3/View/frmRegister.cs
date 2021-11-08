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
    public partial class frmRegister : Form
    {

        private IAccountService _iaccountService;
        private IFileService _iFileService;
        private string _fileNamePath; // link đường đãn
        private List<Account> _lstAccounts;
        public frmRegister()
        {
            InitializeComponent();
            // khởi tạo 
            _iaccountService = new AccountService();
            _iFileService = new FileService();
            rdb_nam.Checked = true;
            loadCbxNmaSInh();
            cbo_sinh.SelectedIndex = cbo_sinh.Items.Count - 20;
            //load gt măc định của combobox năm sinh
           
        }

        void loadata()// đọc dữ liệu trong file  lên khi thêm thò sẽ thêm tào khoản vào cuối danh sách giúp ko bị dè dl
        {
            if (_iFileService.openfile<Account>(_fileNamePath) !=null)
            {
                _lstAccounts = _iFileService.openfile<Account>(_fileNamePath);
              return;
            }

            _lstAccounts = new List<Account>();
        }
        void loadCbxNmaSInh()// đổ dữ liêu liên comboboxx năm sinh
        {
            foreach (var x in _iaccountService.getyearOffBirths())
            {
                cbo_sinh.Items.Add(x);
            }
        }
        public void SenderFileNameoathFormLogin(string path)
        {
            _fileNamePath = path; // gán lại ggt đg dẫn từ form 
            // sang bên đăng kí 
        }
        private void btn_taotk_Click(object sender, EventArgs e)
        {
            loadata();// đọc data từ file
            Account account = new Account();
            //gán giá trị cho đối tượng
            account.Id = _lstAccounts == null ? 1 : _lstAccounts.Count;// giúp cho id tự sinh
            account.Acc = txt_tk.Text;
            account.Pass = txt_mk.Text;
            account.Sex = rdb_nam.Checked ? 1 : 0;
            account.YearofBirth = Convert.ToInt32(cbo_sinh.SelectedItem);
            _lstAccounts.Add(account);// thêm đối tựng vào danh sách
           string temb= _iFileService.saveFile(_fileNamePath, _lstAccounts);
            // sau khi thêm mới vào list thì tiến hành lưu vào file đã chỉ định
            MessageBox.Show("Đăng nhập thành công", "thông báo");
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
