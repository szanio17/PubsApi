using Ardalis.GuardClauses;
using AutoMapper;
using MediatR;
using Pubs.Application.Contracts.Pub;
using Pubs.Application.Request.Pub;
using Pubs.Core.Entities.Pub;
using Pubs.Core.Repositories.Pub;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubs.Application.RequestHandlers.Pub
{
    public class GetAllPubsRequestHandler : IRequestHandler<GetAllPubsRequest, IEnumerable<PubDto>>
    {
        private readonly IPubRepository _pubRepository;
        private readonly IMapper _mapper;

        public GetAllPubsRequestHandler(IPubRepository pubRepository, IMapper mapper)
        {
            Guard.Against.Null(pubRepository, nameof(pubRepository));
            Guard.Against.Null(mapper, nameof(mapper));

            _pubRepository = pubRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PubDto>> Handle(GetAllPubsRequest request, CancellationToken cancellationToken)
        {
            var pubs =  await _pubRepository.GetAllPubs();
            var pubsDto = _mapper.Map<IEnumerable<PubModel>, IEnumerable<PubDto>>(pubs);

            return pubsDto;
        }
    }
}
