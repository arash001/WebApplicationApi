using AutoMapper;
using WebApplicationApi.ViewModel;

namespace WebApplicationApi.Model
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PutDataRequest, PutDataRequestDto>();
            CreateMap<PutDataRequestDto,PutDataRequest > ();
            CreateMap<FixtureDto, Fixture> ();
            CreateMap<Fixture, FixtureDto> ();
            CreateMap<FixturesDto, Fixtures> ();
            CreateMap<Fixtures, Fixtures> ();
        }
    }
}
