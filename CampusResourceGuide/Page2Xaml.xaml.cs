using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using CampusResourceGuide;
namespace CampusResourceGuide
{
	public partial class Page2Xaml : ContentPage
	{
        

        public Page2Xaml (string category)
		{
			InitializeComponent ();
            lblCategory.Text = category;

            switch (category)
            {
                case "Grades/Academics":
                    gridGrades.IsVisible = true;
                    break;
                case "Majors/Careers":
                    gridCareers.IsVisible = true;
                    break;
                case "Finances":
                    gridFinances.IsVisible = true;
                    break;
                case "Social/Cultural":
                    gridSocial.IsVisible = true;
                    break;
                case "Health/Wellness":
                    gridHealth.IsVisible = true;
                    break;
                case "Diversity":
                    gridDiversity.IsVisible = true;
                    break;
                case "Disability Services":
                    gridDisability.IsVisible = true;
                    break;
                case "Food":
                    gridFood.IsVisible = true;
                    break;
                default:
                    if (!string.IsNullOrEmpty(category))
                    {
                        List<Page3Xaml.Details> details =  Page3Xaml.GetAllDetails();


                        this.BindingContext = details.Where(w=>w.name.ToLower().Contains(category.ToLower())).Select(w=>w.name).Distinct().ToArray();
                        listSearch.ItemsSource = details.Where(w => w.name.ToLower().Contains(category.ToLower())).Select(w => w.name).Distinct().ToArray(); 
                        gridSearch.IsVisible = true;
                    }
                    break;

            }

            //listView.ItemsSource = CampusResourceGuide.DataSource.GetList();
        }

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //    {
        //        return;
        //    }

        //    // Deselect row
        //    listView.SelectedItem = null;

        //    await Navigation.PushModalAsync(new Page3Xaml());
        //}

        async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page3Xaml (((Button)sender).Text));
		}

		async void OnPreviousPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}
