using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public interface IRepository
    {
        abstract void Add(CardLine item);
        abstract CardLine? GetById(int id);
        abstract List<CardLine> Get();
        public abstract void Update(int id, decimal quantity);
        public abstract CardLine Delete(int id);
    }
}
