using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDI.BIBLIOTECA.Domain;

namespace RDI.BIBLIOTECA.Service
{
    public interface IGeladeiraService
    {
        List<Item> GetAll();
        Item GetById(int id);
        Item Insert(Item item);
        Item Remove(Item item);
        Item Update(Item item);
    }
}
