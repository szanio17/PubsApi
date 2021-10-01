using Pubs.Core.Entities.Pub;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pubs.Core.Repositories.Pub
{
    public interface IPubRepository
    {
        Task<PubModel> GetPubById(int id);
        Task<IEnumerable<PubModel>> GetAllPubs();
    }
}
