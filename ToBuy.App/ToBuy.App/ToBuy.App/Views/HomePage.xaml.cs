using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBuy.App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToBuy.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItems();
        }

        private async void LoadItems()
        {
            var items = await App.Context.GetItemsAsync();
            itemList.ItemsSource = items;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if(await DisplayAlert("Confirmação", "Quer mesmo excluir esse item?", "Sim", "Não"))
            {
                var item = (ToBuyItem)(sender as MenuItem).CommandParameter;
                var result = await App.Context.DeleteItemAsync(item);
                if (result == 1)
                {
                    LoadItems();
                }
            }
        }
    }
}