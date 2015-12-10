using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace EfDemo.Data
{
    /// <summary>
    /// Example repo for using context. Note this class does not follow proper coding and error handling. 
    /// Is meant to be used as a quick demo. 
    /// </summary>
    public   class TutorialRepo
    {
        private  readonly TutorialContext _context = new TutorialContext();

        public  List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }
       
      
   
        public  void InsertNewAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

     
    }
}
