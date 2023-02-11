using AutoMapper;
using PravasiPensionScheme.DTOs;
using PravasiPensionScheme.Entities;

namespace PravasiPensionScheme.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ContactDto, Contact>();
            CreateMap<Contact, ContactDto>();
            CreateMap<Contact, Contact>();
            CreateMap<Plan, PlansDto>();
            CreateMap<PlansDto,Plan>();
            CreateMap<Plan, Plan>();

            CreateMap<PlansDto, Plan>()
             .ForMember(dest => dest.Image, opt => opt.MapFrom(src =>
                 src.ImageFile == null ? null : ConvertToByteArray(src.ImageFile)));

            CreateMap<Plan, PlansDto>()
           .ForMember(dest => dest.ImageArray, opt => opt.MapFrom(src =>
               src.Image));

        }

        public byte[] ConvertToByteArray(IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                formFile.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
