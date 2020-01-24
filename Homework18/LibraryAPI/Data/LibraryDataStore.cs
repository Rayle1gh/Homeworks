using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Models;
using Newtonsoft.Json;

namespace LibraryAPI.Data
{
    public class LibraryDataStore : ILibraryDataStore
    {
        public List<LibraryModel> libraryModels { get; set; }
        private static LibraryDataStore dataStore;
        private LibraryDataStore()
        {
            libraryModels = new List<LibraryModel>()
            {
                new LibraryModel(){Id =1, Author = "Pushkin", Title = "Capitan's dauther", Description = "LaLaLa"},
                new LibraryModel(){Id =2, Author = "Chukovsky", Title = "Moidodyr", Description = "Lololo"},
                new LibraryModel(){Id =3, Author = "Tolstoy", Title = "War and Peace", Description = "LeLeLe"},
            };
        }
        public bool Add(LibraryDataModel dataModel)
        {
            try
            {
                libraryModels.Add(new LibraryModel()
                {
                    Id = libraryModels.Count + 1,
                    Description = dataModel.Description,
                    Author = dataModel.Author,
                    Title = dataModel.Title
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static LibraryDataStore GetInstance()
        {
            if (dataStore == null)
                dataStore = new LibraryDataStore();
            return dataStore;
        }
        public LibraryModel GetBook(int id)
        {
            return libraryModels.Where(c => c.Id == id).FirstOrDefault();
        }
        public List<LibraryModel> GetBooksList()
        {
            return libraryModels;
        }
        public void Remove(int id)
        {
            libraryModels.Remove(libraryModels.Where(c => c.Id == id).FirstOrDefault());
            Console.WriteLine(JsonConvert.SerializeObject(libraryModels, Formatting.Indented));
        }
        public void Replace(int id, LibraryDataModel dataModel)
        {
            int index = libraryModels.IndexOf(libraryModels.Where(c => c.Id == id).FirstOrDefault());
            libraryModels[index].Author = dataModel.Author;
            libraryModels[index].Description = dataModel.Description;
            libraryModels[index].Title = dataModel.Title;
        }
    }
}
