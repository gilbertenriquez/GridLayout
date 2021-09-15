using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridLayout2();
            //same as stacklayout change the MainPage to GridLayout if you want to run the exercise 2!
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
