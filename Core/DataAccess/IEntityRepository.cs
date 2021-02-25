
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //generıc repository design pattern
    // generic constrain
    //Class: T class olmali (sadece class degil referans tipte olmali)
    //IEntity: T,IEntity veya IEntity'i implemente eden bir nesne olabilir.
    //new(): T, newlenebilmeli (T IEntity de olabilir ama IEntity bir interface oldugu icin newlenemez. IEntity olmasini istemiyorduk zaten)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func< T,bool >> filter=null);
        T Get(Expression<Func< T, bool >> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
