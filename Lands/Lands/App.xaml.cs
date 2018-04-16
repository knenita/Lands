using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lands
{
    using Views;
    using Xamarin.Forms;
    public partial class App : Application
	{
        #region Constructors 
		public App ()
		{
			InitializeComponent();

			this.MainPage = new NavigationPage( new LoginPage());
		}
        #endregion

        #region Methods
        // Este metodo se ejecuta una vez cuando la app se ejecuta
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

        // Aplicacion se duerme
		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

        //Volver a la aplicacion 
		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        #endregion

	}
}
