using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Plugin.LocalNotifications;

namespace demobm
{
    public partial class MainPage : ContentPage
    {
        const int _SAMPLE_ID = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Beer me!", "Beer buddy {USER} is waiting for you!", _SAMPLE_ID, DateTime.Now.AddSeconds(3));

            count++;
            //((Button)sender).Text = $"You clicked {count} times.";
            ((Button)sender).Text = $"Beer me! signal sent!";
        }
    }
}
