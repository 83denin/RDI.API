using Microsoft.EntityFrameworkCore.Migrations.Operations;
using RDI.BIBLIOTECA.Domain;
using RDI.BIBLIOTECA.GeladeiraContext;

namespace RDI.BIBLIOTECA.Repository
{

    public class GeladeiraRepository : IGeladeiraRepository
    {
        private readonly GeladeiraDbContext _context;

        public GeladeiraRepository(GeladeiraDbContext context)
        {
            _context = context;
        }

        public List<Item> GetAll()
        {
            return _context.Itens.ToList();
        }


        public Item GetById(int id)
        {
            return _context.Itens.Find(id);
        }

        public Item Insert(Item item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Item Update(Item item)
        {
            _context.Itens.Update(item);
            _context.SaveChanges();
            return item;

        }

        public Item Remove(Item item) 
        {
            _context.Itens.Remove(item);
            _context.SaveChanges();
            return item;
        }



    }

}
