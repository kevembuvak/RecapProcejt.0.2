using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<Type>
    {
        Type GetById(int id);
        List<Type> GetAll(Expression<Func<Type, bool>> filter = null);
        Type Get(Expression<Func<Type, bool>> filter);
        void Add(Type entity);
        void Delete(Type entity);
        void Update(Type entity);
    }
}
