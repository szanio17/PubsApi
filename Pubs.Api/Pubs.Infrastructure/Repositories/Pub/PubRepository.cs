using Pubs.Core.Entities.Pub;
using Pubs.Core.Repositories.Pub;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pubs.Infrastructure.Repositories.Pub
{
    public class PubRepository : IPubRepository
    {
        private readonly IReadOnlyCollection<PubModel> _pubs;

        public PubRepository()
        {
            _pubs = InitPubs();
        }

        public async Task<IEnumerable<PubModel>> GetAllPubs()
        {
            return _pubs;
        }

        public async Task<PubModel> GetPubById(int id)
        {
            return _pubs.FirstOrDefault(p => p.Id == id);
        }

        private IReadOnlyCollection<PubModel> InitPubs()
        {
            return new List<PubModel>
            {
                new PubModel(1, "Pod padakem", 50, "8-22", "Trinec 1"),
                new PubModel(2, "Destiny", 30, "14-24", "Trinec 2"),
                new PubModel(1, "Vidle's Pub", 150, "8-23", "Trinec 3"),
            }.AsReadOnly();
        }
    }
}
