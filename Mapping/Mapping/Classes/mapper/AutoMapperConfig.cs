using AutoMapper;

namespace Mapping.Classes.mapper
{
    public static class AutoMapperConfig
    {

        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            Mapper = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<Book, BookViewModel>()
                 .ForMember(BookViewModel => BookViewModel.Author,
                 opts => opts.MapFrom(src => src.Author.Name))
                 ;
             }).CreateMapper();
        }

    }
}
