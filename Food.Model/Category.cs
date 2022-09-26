using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Food.Model
{
    
    
    public class Category
    {  [Key]
        public int Id { get; set; }
        [Required]
        public string category_Name { get; set; }


    }
}
