using Xamarin.Forms;

namespace CampusResourceGuide
{
	public class App : Application
	{
		public App ()
		{
            var content = new Page1Xaml(); // new Page3Xaml("Meal Plans");//
            NavigationPage navPage = new NavigationPage(content);
            navPage.BarTextColor = Color.AntiqueWhite;// new Color(229, 83, 3);
            navPage.BarBackgroundColor = Color.FromHex("#e55303");
            MainPage = navPage;
            //MainPage = new NavigationPage(new Page1Xaml()) ;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

