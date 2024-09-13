using RDI.BIBLIOTECA.Domain;
using RDI.BIBLIOTECA.Repository;

namespace RDI.BIBLIOTECA.Service
{
    public class GeladeiraService: IGeladeiraService
    {
        private readonly IGeladeiraRepository _repository;

        public GeladeiraService(IGeladeiraRepository repository)
        {
            _repository = repository;

            }

        public List<Item> GetAll() 
        {
            return _repository.GetAll();
        } 

        public Item GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Item Insert(Item item)
        {
            Item insert = _repository.Insert(item);
            return insert;

        }

        public Item Update(Item item)
        {
            Item update = _repository.Update(item);
            return update;
        }

        public Item Remove(Item item)
        {
            Item remove = _repository.Remove(item); 
            return remove;  
        }


    }
}
