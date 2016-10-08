using System.Collections.Generic;
using ZhaoQi.Web.Core.Models;
using ZhaoQi.Web.Core.Repository;

namespace ZhaoQi.Web.Core.Business
{
    public class BllExecute
    {

               public BllExecute()
        {
        }

               public BllExecute(IRepository<ExecuteModel> entities)
        {
            _entities = entities;
        }



               private IRepository<ExecuteModel> _entities = new HisDataRepository();

               public IRepository<ExecuteModel> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }






    }
}
