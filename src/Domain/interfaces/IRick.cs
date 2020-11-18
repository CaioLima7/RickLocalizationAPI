using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRick
    {
        RickEntity GetRickDetails(int id);
        IList<RickandMortyEntity> GetCards();
        RickHistoricEntity GetHistoric(int id);
        ICollection<NavigationEntity> GetNavigationById(int id);
        ICollection<NavigationEntity> GetNavigations();
        Tuple<IEnumerable<NavigationEntity>, int> GetNavigationsWithPagination(string sort, string order, int page, int rickId);
        Task<RickEntity> GetRickDetailsAsync(int id);
        Task<IList<RickandMortyEntity>> GetCardsAsync();
        Task<RickHistoricEntity> GetHistoricAsync(int id);
    }
}
