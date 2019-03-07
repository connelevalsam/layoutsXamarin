using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResponsiveTele
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondaryMainPage : ContentPage
	{
		public SecondaryMainPage ()
		{
			InitializeComponent ();
            bgImg.Source = Utilities.Source("Blur.jpg", typeof(SecondaryMainPage));
        }

        private void _logIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void _signUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp(), false);
        }
    }
}