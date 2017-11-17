using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;

namespace CampusResourceGuide
{
    public partial class Page3Xaml : ContentPage
    {
        public Page3Xaml(string resource)
        {
            InitializeComponent();
            lblResource.Text = resource;

            List<Details> resource_details = Page3Xaml.GetAllDetails();

            foreach (var item in resource_details)
            {
                if (item.name == resource)
                {
                    phone1.Text = item.phone;
                    website1.Text = item.web;
                    break;
                }
            }
        }

        void OnWebLinkTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(((Label)sender).Text));
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        void OnInsertPageButtonClicked(object sender, EventArgs e)
        {
            var page2a = Navigation.NavigationStack.FirstOrDefault(p => p.Title == "Page 2a");
            if (page2a == null)
            {
                Navigation.InsertPageBefore(new Page2aXaml(), this);
            }
        }

        void OnRemovePageButtonClicked(object sender, EventArgs e)
        {
            var page2 = Navigation.NavigationStack.FirstOrDefault(p => p.Title == "Page 2");
            if (page2 != null)
            {
                Navigation.RemovePage(page2);
            }
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            await Task.FromResult(0);
        }

        public class Details
        {

            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }

            public string web { get; set; }

            public string line1 { get; set; }
            public string line2 { get; set; }
            public string line3 { get; set; }
            public string line4 { get; set; }
        }



        public static List<Details> GetAllDetails()
        {
            List<Details> result = new List<Details>();

            result.Add(new Details() { name = "LASSO Academic Success Coaching", phone = "405-744-3309", web = "https://lasso.okstate.edu/success-coaches" });

            result.Add(new Details() { name = "LASSO Supplemental Instruction", phone = "405-744-3309", web = "https://lasso.okstate.edu/si-info" });

            result.Add(new Details() { name = "LASSO Tutoring", phone = "405-744-3309", web = "https://tutor.okstate.edu" });

            result.Add(new Details() { name = "Academic Development Center", phone = "405-744-3309", web = "https://lasso.okstate.edu/tutoring" });

            result.Add(new Details() { name = "CEAT Studnt Services", phone = "405-744-1750", web = "https://studentservices.okstate.edu/coaching" });

            result.Add(new Details() { name = "Agriculture Sciences and Natural Resources Tutoring", phone = "405-744-9464", web = "https://casnr.okstate.edu" });

            result.Add(new Details() { name = "Chemistry Tutoring", phone = "405-744-9046", web = "https://chemistry.okstate.edu" });

            result.Add(new Details() { name = "College of Arts and Sciences Success Center", phone = "405-744-5658", web = "https://cassuccess.okstate.edu" });

            result.Add(new Details() { name = "Engineering, Architecture and Technology Tutoring", phone = "405-744-5276", web = "https://studentservices.okstate.edu" });

            result.Add(new Details() { name = "Foreign Language Tutoring", phone = "405-744-9547", web = "https://languages.okstate.edu" });

            result.Add(new Details() { name = "History Tutoring", phone = "405-744-5680", web = "https://history.okstate.edu" });

            result.Add(new Details() { name = "Integrative Biology Tutoring", phone = "405-744-5555", web = "https://integrativebiology.okstate.edu" });

            result.Add(new Details() { name = "International Students and Scholars", phone = "405-744-5459", web = "https://iss.okstate.edu" });

            result.Add(new Details() { name = "Math Learning Success Center", phone = "405-744-5818", web = "https://mlscokstate.com" });

            result.Add(new Details() { name = "NOC tutoring (North Classroom Building Student Success Center)", phone = "405-744-7458", web = "https://noc.edu/stillwater-tutoring" });

            result.Add(new Details() { name = "OSU Library", phone = "405-744-9775", web = "https://library.okstate.edu" });

            result.Add(new Details() { name = "OSU Writing Center", phone = "405-744-6671", web = "https://osuwritingcenter.okstate.edu" });

            result.Add(new Details() { name = "Patricia Kain Knaub Center for Student Success (Human Sciences)", phone = "405-744-5053", web = "https://humansciences.okstate.edu" });

            result.Add(new Details() { name = "Physics Tutoring", phone = "405-744-5796", web = "https://physics.okstate.edu/helproom" });

            result.Add(new Details() { name = "Statistics Tutoring", phone = "405-744-5796", web = "https://statistics.okstate.edu" });

            result.Add(new Details() { name = "Veteran Student Academic Services", phone = "405-744-1390", web = "https://universitycollege.okstate.edu/veteran" });

            result.Add(new Details() { name = "Watson Family Student Academic Success Center (Education)", phone = "405-744-6350", web = "https://education.okstate.edu/watson" });

            result.Add(new Details() { name = "Agricultural Sciences and Natural Resources Advising", phone = "405-744-5395", web = "https://casnr.okstate.edu" });

            result.Add(new Details() { name = "Arts and Sciences Advising", phone = "405-744-5658", web = "https://cas.okstate.edu" });

            result.Add(new Details() { name = "Career Services", phone = "405-744-5253", web = "https://hireosugrads.com" });

            result.Add(new Details() { name = "Center for Veterinary Health Science Advising", phone = "405-744-6961", web = "https://cvhs.okstate.edu" });

            result.Add(new Details() { name = "Education Advising", phone = "405-744-6350", web = "https://education.okstate.edu" });

            result.Add(new Details() { name = "Engineering, Architecture and Technology Advising", phone = "405-744-5276", web = "https://studentservices.okstate.edu" });

            result.Add(new Details() { name = "Graduate College Advising", phone = "405-744-6368", web = "https://gradcollege.okstate.edu" });

            result.Add(new Details() { name = "Honors College Advising", phone = "405-744-6799", web = "https://honors.okstate.edu" });

            result.Add(new Details() { name = "Human Sciences Advising", phone = "405-744-5053", web = "https://humansciences.okstate.edu" });

            result.Add(new Details() { name = "Spears School of Business Advising", phone = "405-744-5064", web = "https://business.okstate.edu" });

            result.Add(new Details() { name = "University College Advising", phone = "405-744-5333", web = "https://uca.okstate.edu" });

            result.Add(new Details() { name = "Bursar", phone = "405-744-5993", web = "https://bursar.okstate.edu" });

            result.Add(new Details() { name = "International Students and Scholars", phone = "405-744-5459", web = "https://iss.okstate.edu" });

            result.Add(new Details() { name = "Scholarship and Financial Aid", phone = "405-744-6604", web = "https://financialaid.okstate.edu" });

            result.Add(new Details() { name = "Bursar", phone = "405-744-5993", web = "https://bursar.okstate.edu" });

            result.Add(new Details() { name = "International Students and Scholars", phone = "405-744-5459", web = "https://iss.okstate.edu" });

            result.Add(new Details() { name = "Scholarship and Financial Aid", phone = "405-744-6604", web = "https://financialaid.okstate.edu" });

            result.Add(new Details() { name = "LASSO Academic Success Coaching", phone = "405-744-3309", web = "https://lasso.okstate.edu/success-coaches" });

            result.Add(new Details() { name = "Colvin Recreation Center", phone = "405-744-5510", web = "https://wellness.okstate.edu" });

            result.Add(new Details() { name = "Center for Family Services", phone = "405-744-5975", web = "https://humansciences.okstate.edu/hdfs/extension-outreach/center-for-family-services.html" });

            result.Add(new Details() { name = "Counseling and Counseling Psychology Clinic", phone = "405-744-6980", web = "https://education.okstate.edu/cpsy/clinic" });

            result.Add(new Details() { name = "OSU School Psychology Clinic", phone = "405-744-5474", web = "https://education.okstate.edu/schoolpsychologycenter" });

            result.Add(new Details() { name = "Psychology Services Center", phone = " 405-744-5975", web = "https:// psychology.okstate.edu/osupsc" });

            result.Add(new Details() { name = "Reboot Center", phone = "405-744-6434", web = "https://ucs.okstate.edu/reboot" });

            result.Add(new Details() { name = "Seretean Wellness Center", phone = "405-744-9355", web = "https://wellness.okstate.edu" });

            result.Add(new Details() { name = "Student Counseling Center", phone = "405-744-5472", web = "https://ucs.okstate.edu" });

            result.Add(new Details() { name = "University Health Services", phone = "405-744-7665", web = "https://uhs.okstate.edu" });

            result.Add(new Details() { name = "Campus Life (Student Organizations)", phone = "405-744-5486", web = "https://campuslink.okstate.edu" });

            result.Add(new Details() { name = "Offices of Multicultural Affairs", phone = "405-744-5481", web = "https://oma.okstate.edu" });

            result.Add(new Details() { name = "International Students and Scholars", phone = "405-744-5459", web = "https://iss.okstate.edu" });

            result.Add(new Details() { name = "ABLE Tech", phone = "405-744-9748", web = "https://wellness.okstate.edu/programs/sponsored-programs" });

            result.Add(new Details() { name = "Student Disability Services", phone = "405-744-7116", web = "https://sds.okstate.edu" });

            result.Add(new Details() { name = "University Assessment and Testing", phone = "405-744-5958", web = "https://uat.okstate.edu" });

            result.Add(new Details() { name = "Meal Plans", phone = "405-744-4920", web = "https://dining.okstate.edu/meal-plan" });

            result.Add(new Details() { name = "University Dining Services", phone = "405-744-4424", web = "https://dining.okstate.edu/locations" });




            return result;
        }

    }
}
