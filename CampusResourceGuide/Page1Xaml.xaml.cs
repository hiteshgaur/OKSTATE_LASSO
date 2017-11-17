using System;
using Xamarin.Forms;

namespace CampusResourceGuide
{
	public partial class Page1Xaml : ContentPage
	{
        

        public Page1Xaml ()
		{
            
			InitializeComponent ();
            
		}

        void SearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;

            if (String.IsNullOrEmpty(newText) && !String.IsNullOrEmpty(oldText)) {
                ViewExtensions.CancelAnimations(btnSearch);
                btnSearch.IsVisible = false;
                
                
            }
            else if (!String.IsNullOrEmpty(newText) && String.IsNullOrEmpty(oldText))
            {   
                btnSearch.IsVisible = true;
                btnSearch.Opacity = 0;
                btnSearch.FadeTo(1, 4000);
                
            }

        }

        void SearchTextCompleted(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text; //cast sender to access the properties of the Entry
            if (!String.IsNullOrEmpty(text)) { search(text);  }
        }

        async void search(string text)
        {
            await Navigation.PushAsync(new Page2Xaml(text));
        }

        async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml(txtSearch.Text));
        }


        async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
            
			await Navigation.PushAsync (new Page2Xaml (((Button)sender).Text));
		}
	}
}
