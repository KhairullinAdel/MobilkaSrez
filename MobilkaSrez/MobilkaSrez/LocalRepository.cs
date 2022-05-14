using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using MobilkaSrez.Models;

namespace MobilkaSrez
{
    public class LocalRepository
    {
        SQLiteConnection database;

        public LocalRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<MyUser>();
            database.CreateTable<MyItem>();
        }

        public void AddUser(MyUser user)
        {
            database.Insert(user);
        }
        public bool UserIsCorrect(MyUser user)
        {
            return database.Get<MyUser>(x => x.Login == user.Login && 
                                                x.Password == user.Password) != null;
        }

        public void AddSomeThing(MyItem item)
        {
            database.Insert(item);
        }
        
        public List<MyItem> GetAllItems()
        {
            return database.Table<MyItem>().ToList();
        }
    }
}

