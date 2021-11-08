using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_ACCOUNT.Models;

namespace BAI_1_2_CRUD_ACCOUNT.IServices
{
    public interface IAccountService
    {
        string addAccount(Account account);// phương thức  thêm
        string editAccount(Account account);// phương thức  sửa
        string removeAccount(int id);// phương thức  xóa

        Account findaAccount(int id);// phương thức  tìm 1 đối tượng
        List<Account> getlstAccounts(); // lấy danh sách
        List<Account> getlstAccountsByacc(string acc); // lấy danh sách gần dúng theo
        // tài khoản 

        // phupngw thức để đổ đữ liệu từ file về service 
        void filldataFromFileToService(List<Account> lstAccounts);
        string[] getyearOffBirths(); // phuong thức lấy danh sách  năm sih


    }
}
