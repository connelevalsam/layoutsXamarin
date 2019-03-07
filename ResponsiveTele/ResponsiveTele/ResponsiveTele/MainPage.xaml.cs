using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResponsiveTele
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = Utilities.Source("Med_Logo.png", typeof(MainPage));

            /** hide the toolbar for this page as it is the mainpage **/
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromSeconds(2), delegate
            {
                Navigation.PushAsync(new SecondaryMainPage());
                Navigation.RemovePage(this);
                return true;
            });
        }
    }
}
