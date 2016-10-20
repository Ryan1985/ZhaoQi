using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ZhaoQi.Web.Core.Models;

namespace ZhaoQi.Web.Core.Repository
{
    public interface IRepository<T> where T:class
    {
        DbContext Entity { get; set; }
        IQueryable<T> Query { get; }
        IEnumerable<T> QueryBySql(string sql);
        int Add(IEnumerable<T> models, bool isAutoSubmit = false);
        int Delete(IEnumerable<T> models, bool isAutoSubmit = false);
        int Modify(IEnumerable<T> models, bool isAutoSubmit = false);
        int SubmitChanges();
    }
}
