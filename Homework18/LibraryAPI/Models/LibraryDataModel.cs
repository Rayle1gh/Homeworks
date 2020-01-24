using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    public class LibraryDataModel
    {
        [MaxLength(30)]
        public string Author { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
