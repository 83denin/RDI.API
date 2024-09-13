

using RDI.BIBLIOTECA.Domain;

namespace RDI.BIBLIOTECA.Repository
{
    public interface IGeladeiraRepository
    {
        List<Item> GetAll();
        Item GetById(int id);
        Item Insert(Item item);
        Item Remove(Item item);
        Item Update(Item item);
    }
}
