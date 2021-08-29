using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Domain.ShelfAgg;



namespace LibraryManagement.Application.Contract.User
{
    public class UserShelvesViewModel
    {
        List<LibraryManagement.Domain.ShelfAgg.Shelf> shelves { get; set; }

    }
}
