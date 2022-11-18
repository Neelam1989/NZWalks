using AutoMapper;

namespace NZWalksAPI.Profiles
{
    public class RegionProfiles : Profile
    {
        public RegionProfiles()
        {
            CreateMap<Model.Domain.Region, Model.DTO.Region>().ReverseMap();
        }
    }
}
