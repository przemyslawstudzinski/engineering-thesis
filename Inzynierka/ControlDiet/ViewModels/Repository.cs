﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationToSupportAndControlDiet.Models;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;

namespace ApplicationToSupportAndControlDiet.ViewModels
{
    public class Repository<T> where T : class
    {
        private static SQLiteConnection connectionToDatabase { set; get; }

        public Repository()
        {
            connectionToDatabase = DatabaseConnection.GetConnection();
        }

        public int Save(T item)
        {
            connectionToDatabase.InsertWithChildren(item, recursive: true);
            return 1;
        }

        public int SaveOneOrReplace(T item)
        {
            return connectionToDatabase.InsertOrReplace(item);
        }

        public int Delete(T item)
        {
            connectionToDatabase.Delete(item, recursive: true);
            return 1;
        }

        public int Update(T item)
        {
            connectionToDatabase.InsertOrReplaceWithChildren(item, recursive: true);
            return 1;
        }

        public List<T> FindAll()
        {
            List<T> items = connectionToDatabase.GetAllWithChildren<T>().ToList();
            return items;
        }

        public Day FindDayByDate(DateTime dateTime)
        {
            List<Day> list = connectionToDatabase.GetAllWithChildren<Day>(recursive: true)
                .Where(item => item.Date.Date == dateTime.Date).ToList();
            if (list.Count != 0)
            {
                return list[0];
            }
            return null;
        }

        public Day FindDay(Day day)
        {
            List<Day> list = connectionToDatabase.GetAllWithChildren<Day>(recursive: true)
                .Where(x => x.Id == day.Id).ToList();
            if (list.Count != 0)
            {
                return list[0];
            }
            return null;
        }

        public User FindUser() {
            User user = connectionToDatabase.Table<User>().FirstOrDefault();
            return user;
        }
    }
}
