using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToBuy.App.Models;

namespace ToBuy.App.Data
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection Connection { get; set; }
        public DatabaseContext(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<ToBuyItem>().Wait();
        }

        public async Task<int> InsertItemAsync(ToBuyItem item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<List<ToBuyItem>> GetItemsAsync()
        {
            return await Connection.Table<ToBuyItem>().ToListAsync();
        }

        public async Task<int> DeleteItemAsync(ToBuyItem item)
        {
            return await Connection.DeleteAsync(item);
        }
    }
}
