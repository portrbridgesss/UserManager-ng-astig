using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using SQLite;

namespace usermanager_ni_sir
{
    public class UserRepository
    {
        private readonly SQLiteConnection _connection;
        public UserRepository()
        {
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserData.db");

            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<UserModel>();
        }

        public bool Add(string username, string password, string email)
        {
            UserModel userModel = new UserModel
            {
                Username = username,
                Password = password,
                Email = email
            };

            _connection.Insert(userModel);

            return true;
        }

        public List<UserModel> GetAll()
        {
            return _connection.Table<UserModel>().ToList();
        }
    }
}
