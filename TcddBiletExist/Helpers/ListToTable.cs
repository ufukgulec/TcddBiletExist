﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TcddBiletExist.Models;
using TcddBiletExist.Providers;
using TcddBiletExist.Services.Concrete;

namespace TcddBiletExist.Helpers
{
    public static class ListToTable
    {
        public static async Task<DataTable> CreateTableAsync<T>(List<T> items)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                //put a breakpoint here and check datatable
                return dataTable;
            }
            catch (Exception)
            {
                var log = await new LogProviderService().CreateAsync("Generic List Datatable'a çevrilirken hata aldı", LogType.Error);
                LogProvider.Default.AddLog(log);
                throw;
            }
        }
    }
}
