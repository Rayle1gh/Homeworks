using LibraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Data
{
    interface ILibraryDataStore
    {
        List<LibraryModel> libraryModels { get; set; }
    }
}
