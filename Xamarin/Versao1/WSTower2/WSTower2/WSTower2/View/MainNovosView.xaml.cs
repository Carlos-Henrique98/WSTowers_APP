using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTower2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTower2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainNovosView : ContentPage
    {
        public IList<Estadio> Estadios { get; private set; }
        public MainNovosView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            Estadios = new List<Estadio>
            {
                new Estadio
                {
                    Nome = "Estadio 1",
                    Local = "Local 1",
                    Capacidade = 5000,
                    Proprietario = "Teste",
                    Descricao = "Teste Estadio"
                },

                new Estadio
                {
                    Nome = "Estadio 2",
                    Local = "Local 2",
                    Capacidade = 7000,
                    Proprietario = "Teste 2",
                    Descricao = "Teste Estadio 2"
                }
            };

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estadio selectedItem = e.SelectedItem as Estadio;
            Navigation.PushAsync(new EstadioInfoView(selectedItem));
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Estadio tappedItem = e.Item as Estadio;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}