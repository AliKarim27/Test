using AutoMapper;
using Test.Books;

namespace Test.Web;

public class TestWebAutoMapperProfile : Profile
{
    public TestWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
