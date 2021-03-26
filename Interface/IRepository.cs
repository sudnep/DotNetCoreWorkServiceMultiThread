using System.Collections.Generic;

namespace ApplicationCore
{
    public interface IRepository
    {
        List<DocTypeMap> GetDocTypeMaps();

        DocTypeMap GetDocTypeMap(string docType);

        List<EntityCodeMap> GetEntityCodeMaps();

        EntityCodeMap GetEntityCodeMap(string entityCode);
    }
}