using Pedly.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Pedly.Services
{
    public static class pedlyService
    {
        static SQLiteAsyncConnection db; 

        static async Task init()
        {
            if(db != null)
            {
                return;
            }
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            var db = new SQLiteConnection(databasePath);

            await db.CreateTableAsync<User>();
        }
        public static async Task AddUser(int id,string name,string lastname, string email, string password)
        {

        }


    }
}
