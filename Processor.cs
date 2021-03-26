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
        }
    }
}