using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Balaie_Cristian_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }

    }
}
