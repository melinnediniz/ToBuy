using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToBuy.App.Views;
using ToBuy.App.Data;

namespace ToBuy.App
{
    public partial class App : Application
    {
        public static DatabaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();

            MainPage = new NavigationPage(new HomePage());
        }

        private void InitializeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "ToBuy.db3");
            Context = new DatabaseContext(dbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
