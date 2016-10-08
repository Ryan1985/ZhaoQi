using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ZhaoQi.Web.Core.EFDataAccess;
using ZhaoQi.Web.Core.Models;
using ZhaoQi.Web.Core.Repository;

namespace ZhaoQi.Web.Core.Business
{
    public class BllRealData
    {

        public BllRealData() { }

        public BllRealData(IRepository<RealDataModel> entities)
        {
            _entities = entities;
        }



        private IRepository<RealDataModel> _entities = new RealDataRepository();

        public IRepository<RealDataModel> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }


        public string Add(List<RealDataModel> list)
        {
            var result = Entities.Add(list,true);
            if (result < 0)
            {
                return "新增失败";
            }
            return string.Empty;
        }


        public List<RealDataModel> Query(Hashtable filters)
        {
            if (filters == null || filters.Count == 0)
            {
                return Entities.Query.ToList();
            }

            var modelType = typeof(RealDataModel);
            var queryResult = Entities.Query;
            foreach (DictionaryEntry de in filters)
            {
                if (modelType.GetProperty(de.Key.ToString()) == null)
                {
                    continue;
                }
                var columnName = modelType.GetProperty(de.Key.ToString()).Name;
                switch (columnName)
                {
                    case "Id":
                    {
                        queryResult = Entities.Query.Where(
                            e => e.Id.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                    }break;
                    case "Tag":
                    {
                        queryResult = Entities.Query.Where(
                            e => e.Tag.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                    } break;
                    case "ProjectId":
                        {
                            queryResult = Entities.Query.Where(
                                 e => e.ProjectId.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                        } break;
                    case "TagUnit":
                        {
                            queryResult = Entities.Query.Where(
                                 e => e.TagUnit.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                        } break;
                    default: continue;
                }
            }

            return queryResult.ToList();
        }


        


    }
}
