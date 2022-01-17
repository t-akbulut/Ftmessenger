using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FtMsngr
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        #region Static_Privatelar
        static Data.RestService restService;
        static Data.DBService dBService;

        #endregion

        #region Public_Servisler
        public static Data.RestService RestService
        {
            get
            {
                if (restService == null)
                    restService = new Data.RestService();
                return restService;
            }
        }
        public static Data.DBService DBService
        {
            get
            {
                if (dBService == null)
                    dBService = new Data.DBService();
                return dBService;
            }
        }
        #endregion


        public App()
        {
            InitializeComponent();

            MainPage = new Views.Chat.ChatMessagePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }



    }
}

