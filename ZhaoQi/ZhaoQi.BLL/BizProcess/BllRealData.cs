using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZhaoQi.BLL.DataAccess;
using ZhaoQi.Model;

namespace ZhaoQi.BLL.BizProcess
{
    public class BllRealData
    {
        private ZhaoQiEntity _entities = new ZhaoQiEntity();

        public ZhaoQiEntity Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }


        public string Add(List<RealDataModel> list)
        {
            _entities.RealDataEntity.AddRange(list);
            var result = _entities.SaveChanges();
            if (result < 0)
            {
                return "新增失败";
            }
            return string.Empty;
        }


        public List<RealDataModel> Query(Hashtable filters)
        {
            if (filters.Count == 0)
            {
                return _entities.RealDataEntity.ToList();
            }

            var modelType = typeof(RealDataModel);
            var queryResult = _entities.RealDataEntity.AsQueryable();
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
                        queryResult = _entities.RealDataEntity.Where(
                            e => e.Id.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                    }break;
                    case "Tag":
                    {
                       queryResult = _entities.RealDataEntity.Where(
                            e => e.Tag.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                    } break;
                    case "ProjectId":
                        {
                            queryResult = _entities.RealDataEntity.Where(
                                 e => e.ProjectId.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                        } break;
                    case "TagUnit":
                        {
                            queryResult = _entities.RealDataEntity.Where(
                                 e => e.TagUnit.Equals(de.Value.ToString(), StringComparison.CurrentCultureIgnoreCase));
                        } break;
                    default: continue;
                }
            }

            return queryResult.ToList();
        }


        


    }
}
