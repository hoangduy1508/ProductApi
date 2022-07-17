using AutoMapper;

namespace ProductApi.Profiles
{
    public class ProductProfile: Profile
    {

        public ProductProfile(){
            CreateMap<Entities.Product, Models.ProductDto>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src =>
        src.Category.Name));
            CreateMap<Models.ProductDto, Entities.Product>();
            CreateMap<Models.ProductCreationDto, Entities.Product>();
        }
    }
}
