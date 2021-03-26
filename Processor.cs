using System;

namespace ApplicationCore
{
    public class Processor : IProcessor
    {
        private readonly IRepository _repository;

        public Processor(IRepository repository)
        {
            _repository = repository;
        }

        public void Execute(string entitycode)
        {
            var map = _repository.GetDocTypeMap(entitycode);

            Console.WriteLine(map.DestinationFolderName);

            // save data to database
            var newMap = new EntityCodeMap() { EntityCode = "Test", Fund = "Test", FundManager = "Test", CreatedBy = "s", ModifiedBy = "d" };

            _repository.SaveData(newMap);
            Console.WriteLine("data saved");
            // after doing processing save data back to database
            newMap.IsActive = false;
            _repository.UpdateData(newMap);
            Console.WriteLine("data updated");
            //then delete data
            _repository.DeleteData(newMap);
            Console.WriteLine("deleted");
        }
    }
}