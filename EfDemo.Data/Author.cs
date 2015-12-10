using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfDemo.Data
{
    public class Author
    {
        public int Id { get; set; }

        [StringLength(45), Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
