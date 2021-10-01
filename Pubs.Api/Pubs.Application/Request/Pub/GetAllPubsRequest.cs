using MediatR;
using Pubs.Application.Contracts.Pub;
using System.Collections.Generic;

namespace Pubs.Application.Request.Pub
{
    public class GetAllPubsRequest : IRequest<IEnumerable<PubDto>>
    {
    }
}
