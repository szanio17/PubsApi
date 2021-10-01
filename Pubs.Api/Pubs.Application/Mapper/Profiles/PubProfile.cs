using AutoMapper;
using Pubs.Application.Contracts.Pub;
using Pubs.Core.Entities.Pub;

namespace Pubs.Application.Mapper.Profiles
{
    public class PubProfile : Profile
    {
        public PubProfile()
        {
            CreateMap<PubModel, PubDto>();
        }
    }
}
