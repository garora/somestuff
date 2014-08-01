using System.Linq;
using LearningSolid.Model;

namespace LearningSolid.Queries
{
  public  class SourceServerDataQuery
    {
      private readonly ISourceDataRepository _repository;

      public SourceServerDataQuery(ISourceDataRepository repository)
      {
          _repository = repository;
      }

      public IQueryable<SourceServerData> Query()
      {
          return _repository.Get().AsQueryable();
      }
    }
}
