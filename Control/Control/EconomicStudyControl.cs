using System.Linq;
using Control;
using Control.Repositories;
using Model;

namespace Control {
    public class EconomicStudyControl : SQLRepository<EconomicStudy>, IEconomicStudyRepository {

        public EconomicStudyControl (AppDbContext context) : base (context) {

        }
    }
}