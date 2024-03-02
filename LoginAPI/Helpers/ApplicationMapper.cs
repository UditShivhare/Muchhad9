using AutoMapper;
using LoginAPI.Data;
using LoginAPI.Models;

namespace LoginAPI.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
