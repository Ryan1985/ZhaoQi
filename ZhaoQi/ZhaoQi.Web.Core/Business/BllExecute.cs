using System.Collections.Generic;
using System.Linq;
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



        private IRepository<ExecuteModel> _entities = new ExecuteRepository();

        public IRepository<ExecuteModel> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }


        public int Excute(IEnumerable<ExecuteModel> models)
        {
            var existedModelList = _entities.Query.Select(e =>new{ modelId = e.ProjectId+"_"+e.Tag,e.Id}).ToArray();
            var updateList = new List<ExecuteModel>();
            var insertList = new List<ExecuteModel>();
            foreach (var model in models)
            {
                model.Flag = "1";
                var existedId =
                    existedModelList.Where(
                        e =>
                            e.modelId.Equals(model.ProjectId + "_" + model.Tag,
                                System.StringComparison.CurrentCultureIgnoreCase))
                        .Select(e => e.Id).FirstOrDefault();

                if (existedId == 0)
                {
                    insertList.Add(model);
                }
                else
                {
                    model.Id = existedId;
                    updateList.Add(model);
                }
            }

            if (updateList.Any())
            {
                _entities.Modify(updateList);
            }

            if (insertList.Any())
            {
                _entities.Add(insertList);
            }

            if (updateList.Any() || insertList.Any())
            {
                return _entities.SubmitChanges();
            }
            return 0;
        }




        public IEnumerable<ExecuteModel> Query()
        {
            return Entities.Query.ToList();
        }
    }
}
