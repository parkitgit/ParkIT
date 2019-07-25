using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkIT.Services;
using ParkIT.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkIT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNotePage : ContentPage
	{

        private NotesService _notesService;

		public AddNotePage ()
		{
			InitializeComponent ();
            _notesService = new NotesService();
		}

        private async void TbAddNote_Clicked(object sender, EventArgs e)
        {
            var note = new Notes()
            {
                title = EntTi.Text,
                description = EntDe.Text
            };
            await _notesService.AddNote(note);
        }
    }
}