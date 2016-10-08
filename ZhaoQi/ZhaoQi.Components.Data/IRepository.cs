using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZhaoQi.Components.Tools;

namespace ZhaoQi.Components.Data
{
    public interface IRepository<T> where T : class
    {
        T FindBy(string id);
        IQueryable<T> Query { get; }
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        int Commit();
    }
}
