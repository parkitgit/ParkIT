using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using ParkIT.Models;
using System.Threading.Tasks;

namespace ParkIT.Services
{
    public class NotesService
    {
        private MobileServiceClient _mobileServiceClient;

        public NotesService()
        {
            _mobileServiceClient = new MobileServiceClient("https://parkitmobileapp.azurewebsites.net");
        }

        public async Task<IEnumerable<Notes>> GetNotes()
        {
            var table = _mobileServiceClient.GetTable<Notes>();
            return await table.ReadAsync();
        }

        public async Task AddNote(Notes notes)
        {
            var table = _mobileServiceClient.GetTable<Notes>();
            await table.InsertAsync(notes);
        }

        public async Task UpdateNote(Notes notes)
        {
            var table = _mobileServiceClient.GetTable<Notes>();
            await table.UpdateAsync(notes);
        }

        public async Task DeleteNote(Notes notes)
        {
            var table = _mobileServiceClient.GetTable<Notes>();
            await table.DeleteAsync(notes);
        }

    }
}
