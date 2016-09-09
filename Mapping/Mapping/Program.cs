using Mapping.Classes;
using Mapping.Classes.mapper;
using System;

namespace Mapping
{
    class Program
    {
        static void Main()
        {
            AutoMapperConfig.RegisterMappings();

            var source = new Book();
            source.Author = new Author();
            source.Author.Name = "Cassandra Clare";
            source.Title = "Shadowhunters";

            var dest = AutoMapperConfig.Mapper.Map<Book, BookViewModel>(source);

            Console.WriteLine("Bookviewmodel:  {0} wrote: {1}", dest.Author, dest.Title);
            Console.ReadKey();
        }
    }
}
