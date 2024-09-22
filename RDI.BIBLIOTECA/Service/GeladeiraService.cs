using RDI.BIBLIOTECA.Domain;
using RDI.BIBLIOTECA.Repository;

namespace RDI.BIBLIOTECA.Service
{
    public class GeladeiraService : IGeladeiraService
    {
        private readonly IGeladeiraRepository _repository;

        public GeladeiraService(IGeladeiraRepository repository)
        {
            _repository = repository;
        }

        // Método para obter todos os itens
        public List<Item> GetAll()
        {
            return _repository.GetAll();
        }

        // Método para obter um item por ID
        public Item GetById(int id)
        {
            return _repository.GetById(id);
        }

        // Método para inserir um item
        public Item Insert(Item item)
        {
            // Validação do andar
            if (item.Andar < 1 || item.Andar > 4)
            {
                throw new ArgumentException("O andar deve ser entre 1 e 4.");
            }

            try
            {
                return _repository.Insert(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting item: {ex.Message}");
                throw;
            }
        }

        // Método para atualizar um item
        public Item Update(Item item)
        {
            // Validação do andar
            if (item.Andar < 1 || item.Andar > 4)
            {
                throw new ArgumentException("O andar deve ser entre 1 e 4.");
            }

            try
            {
                return _repository.Update(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating item: {ex.Message}");
                throw;
            }
        }

        // Método para remover um item
        public Item Remove(Item item)
        {
            try
            {
                return _repository.Remove(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing item: {ex.Message}");
                throw;
            }
        }
    }
}
