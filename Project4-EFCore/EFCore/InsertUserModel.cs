using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class InsertUserModel
    {

        [Required]
        public string Name { get; set; }
        
        public InsertUserModel( )
        {
        }
    }
}
