using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZhaoQi.Web.Core.Models;
using ZhaoQi.Web.Core.Repository;

namespace ZhaoQi.Web.Core.Business
{
    public class BllHistoryData
    {

        public BllHistoryData()
        {
        }


        public BllHistoryData(IRepository<HistoryDataModel> entities)
        {
            _entities = entities;
        }

        private IRepository<HistoryDataModel> _entities = new HistoryDataRepository();

        public IRepository<HistoryDataModel> Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }



        public List<HistoryDataModel> Query(Hashtable filters)
        {
            if (filters == null || filters.Count == 0)
            {
                return Entities.Query.ToList();
            }

            var modelType = typeof(HistoryDataModel);
            var queryResult = Entities.Query;
            foreach (DictionaryEntry de in filters)
            {
                if (modelType.GetProperty(de.Key.ToString()) == null)
                {
                    continue;
                }
                var columnName = modelType.GetProperty(de.Key.ToString()).Name;
                var columnType = modelType.GetProperty(de.Key.ToString()).PropertyType.FullName;
                switch (columnType)
                {
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    {
                        queryResult = queryResult.Where(
                            e =>
                                Convert.ToInt64(e.GetType().GetProperty(columnName).GetValue(e, null)) ==
                                Convert.ToInt64(de.Value));
                    }break;
                    case "System.String":
                    {
                        queryResult = queryResult.Where(
                            e =>
                                e.GetType().GetProperty(columnName).GetValue(e, null).ToString().ToLower() ==
                                de.Value.ToString().ToLower());
                    }
                    break;
                    case "System.DateTime":
                    {
                        var columnPatterns = columnName.Split('@');
                        if (columnPatterns.Length == 2)
                        {
                            var suffix = columnPatterns[1];
                            switch (suffix.ToLower())
                            {
                                case "g":
                                {
                                    queryResult = queryResult.Where(
                                        e => Convert.ToDateTime(de.Value).Date >
                                             Convert.ToDateTime(e.GetType()
                                                 .GetProperty(columnName)
                                                 .GetValue(e, null)).Date);
                                }
                                    break;
                                case "ge":
                                {
                                    queryResult = queryResult.Where(
                                        e => Convert.ToDateTime(de.Value).Date >=
                                             Convert.ToDateTime(e.GetType()
                                                 .GetProperty(columnName)
                                                 .GetValue(e, null)).Date);
                                }
                                    break;
                                case "l":
                                {
                                    queryResult = queryResult.Where(
                                        e => Convert.ToDateTime(de.Value).Date <
                                             Convert.ToDateTime(e.GetType()
                                                 .GetProperty(columnName)
                                                 .GetValue(e, null)).Date);
                                }
                                    break;
                                case "le":
                                {
                                    queryResult = queryResult.Where(
                                        e => Convert.ToDateTime(de.Value).Date <=
                                             Convert.ToDateTime(e.GetType()
                                                 .GetProperty(columnName)
                                                 .GetValue(e, null)).Date);
                                }
                                    break;
                                default:
                                {
                                    queryResult = queryResult.Where(
                                        e => e.GetType()
                                            .GetProperty(columnName)
                                            .GetValue(e, null).ToString() == de.Value.ToString());
                                }
                                    break;
                            }
                        }
                        else
                        {
                            queryResult = queryResult.Where(
                                e =>
                                    Convert.ToDateTime(e.GetType().GetProperty(columnName).GetValue(e, null)).Date ==
                                    Convert.ToDateTime(de.Value).Date);
                        }
                    }
                    break;
                }

            }

            return queryResult.ToList();
        }
    }
}
