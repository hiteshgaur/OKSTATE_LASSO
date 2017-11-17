using System;
using Xamarin.Forms;

namespace CampusResourceGuide
{
	public class Page1 : ContentPage
	{

		public Page1 ()
		{
          
			
            var button1 = new Button { Text = "Money", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            var button2 = new Button { Text = "Social", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            var button3 = new Button { Text = "Study", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            var button4 = new Button { Text = "Health", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            var button5 = new Button { Text = "Grades", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            var button6 = new Button { Text = "Self Exploration", VerticalOptions = LayoutOptions.CenterAndExpand };
            button1.Clicked += OnNextPageButtonClicked;

            Title = "Campus Resource Guide";
            
			Content = new StackLayout { 
				Children = {
                    new Label { Text = "LayoutOptions - Expansion", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center },
                    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
                    new Label { Text = "StartAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.StartAndExpand },
                    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
                    new Label { Text = "CenterAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.CenterAndExpand },
                    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
                    new Label { Text = "EndAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.EndAndExpand },
                    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
                    new Label { Text = "FillAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
                    new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
                    button1, button2, button3, button4, button5, button6
                }
			};
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page2 ());
		}
	}
}
