using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkIT.Services;

namespace ParkIT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage : ContentPage
	{
		public NotesPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            NotesService notesService = new NotesService();
            LV.ItemsSource =  await notesService.GetNotes();
        }

        private void TapAddNote_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNotePage()); 
        }
    }
}