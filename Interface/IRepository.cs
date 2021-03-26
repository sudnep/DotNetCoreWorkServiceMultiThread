using System.Collections.Generic;

namespace ApplicationCore
{
    public interface IRepository
    {
        List<DocTypeMap> GetDocTypeMaps();

        DocTypeMap GetDocTypeMap(string docType);

        List<EntityCodeMap> GetEntityCodeMaps();

        EntityCodeMap GetEntityCodeMap(string entityCode);

        void SaveData(EntityCodeMap entityCodeMap);

        EntityCodeMap UpdateData(EntityCodeMap entityCodeMap);

        bool DeleteData(EntityCodeMap entityCodeMap);
    }
}