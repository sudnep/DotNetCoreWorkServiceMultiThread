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

        public bool DeleteData(EntityCodeMap entityCodeMap)
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                var mapToDelete = _nbdbContext.EntityCodeMaps.FirstOrDefault(x => x.Fund == entityCodeMap.Fund);
                _nbdbContext.EntityCodeMaps.Remove(mapToDelete);
                _nbdbContext.SaveChanges();
                return true;
            }
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

        public void SaveData(EntityCodeMap entityCodeMap)
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                _nbdbContext.EntityCodeMaps.Add(entityCodeMap);
                _nbdbContext.SaveChanges();
            }
        }

        public EntityCodeMap UpdateData(EntityCodeMap entityCodeMap)
        {
            using (var _nbdbContext = _contextFactory.CreateDbContext())
            {
                _nbdbContext.EntityCodeMaps.Update(entityCodeMap);
                _nbdbContext.SaveChanges();
                return entityCodeMap;
            }
        }
    }
}