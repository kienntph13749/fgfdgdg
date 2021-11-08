using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BAI_1_2_CRUD_ACCOUNT.IServices;

namespace BAI_1_2_CRUD_ACCOUNT.Service
{
    public class FileService : IFileService
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        public string saveFile<T>(string path, T lsttemb)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lsttemb);
                _fs.Close();
                return "ghi file thành công";
            }
            catch (System.Exception e)
            {

                Console.WriteLine(e);
                _fs.Close();
                return "ghi file thất bại";
            }
        }

        public List<T> openfile<T>(string path)
        {
            try
            {
                List<T> lsttemb = new List<T>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                lsttemb = (List<T>)data;
                _fs.Close();
                return lsttemb;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
              _fs.Close();
                return null;
            }

        }
    }
}