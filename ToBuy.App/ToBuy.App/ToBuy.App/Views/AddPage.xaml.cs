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
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            try
            {
                var item = new ToBuyItem
                {
                    Name = name.Text,
                    Description = description.Text
                };

                var result = await App.Context.InsertItemAsync(item);
                if(result == 1)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "Erro ao salvar item", "OK");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}