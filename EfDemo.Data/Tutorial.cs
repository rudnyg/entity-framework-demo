using System;
using System.ComponentModel.DataAnnotations;

namespace EfDemo.Data
{
    public class Tutorial
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public Author Author { get; set; } //Used for navigation
        public int AuthorId { get; set; }  //Foreign Key 

        public override string ToString()
        {
            return Title; 
        }
    }
}
