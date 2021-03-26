using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCore
{
    public class Repository : IRepository
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public Repository(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public DocTypeMap GetDocTypeMap(string docType)
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                return _nbdbContext.DocTypeMaps.Where(x => x.DocType == docType).FirstOrDefault();
            }
        }

        public List<DocTypeMap> GetDocTypeMaps()
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                return _nbdbContext.DocTypeMaps.ToList();
            }
        }

        public EntityCodeMap GetEntityCodeMap(string entityCode)
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                return _nbdbContext.EntityCodeMaps.Where(x => x.EntityCode == entityCode).FirstOrDefault();
            }
        }

        public List<EntityCodeMap> GetEntityCodeMaps()
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                return _nbdbContext.EntityCodeMaps.ToList();
            }
        }
    }
}