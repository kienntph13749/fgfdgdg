using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_CRUD_ACCOUNT.IServices
{
    public interface IFileService
    {
        // phương thức lưu file4
        string saveFile<T>(string path, T lsttemb);
        // đọc file lên
        List<T> openfile<T>(string path);
    }
}
