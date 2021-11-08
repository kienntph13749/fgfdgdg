using System.Collections.Generic;
using System.IO;
using System.Linq;
using BAI_1_2_CRUD_ACCOUNT.IServices;
using BAI_1_2_CRUD_ACCOUNT.Models;

namespace BAI_1_2_CRUD_ACCOUNT.Service
{
    public class AccountService :IAccountService
    {
        private List<Account> _lstAccounts;

        public AccountService()
        {
            _lstAccounts = new List<Account>();
        }
        public string addAccount(Account account)
        {
            if (account ==null)
            {
                return " không được null";
            }
           _lstAccounts.Add(account);
           return "thêm thành công";
        }

        public string editAccount(Account account)
        {
            throw new System.NotImplementedException();
        }

        public string removeAccount(int id)
        {
            if (id<0)
            {
                return "xóa thất bại";
            }
            _lstAccounts.RemoveAt(_lstAccounts.FindIndex(c =>c.Id==id));
            return " xáo ";
        }

        public Account findaAccount(int id)
        {
            return _lstAccounts.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Account> getlstAccounts()
        {
           return _lstAccounts;
        }

        public List<Account> getlstAccountsByacc(string acc)
        {
            throw new System.NotImplementedException();
        }

        public void filldataFromFileToService(List<Account> lstAccounts)
        {
            _lstAccounts = lstAccounts;
        }

        public string[] getyearOffBirths()
        {
            string[] tembNS = new string[2021 - 1900];
            int temb = 1900;
            for (int i = 0; i < tembNS.Length; i++)
            {
                tembNS[i] = temb.ToString();
                temb++;
            }

            return tembNS;
        }
    }
}