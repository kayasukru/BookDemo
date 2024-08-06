using BookDemo.Models;

namespace BookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){Id=1,Title="Yalan", Price=150},
                new Book(){Id=2, Title="Gerçek", Price=200},
                new Book(){Id=3, Title="Hayal", Price=250}
            };
        }
    }
}
