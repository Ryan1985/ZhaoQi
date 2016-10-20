using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
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

            var modelType = typeof (HistoryDataModel);

            var sbSql = new StringBuilder(@"SELECT * 
FROM ZHANGLI.HistoryData WITH(NOLOCK)
WHERE 1=1 ");
            foreach (DictionaryEntry de in filters)
            {
                var columnName = de.Key.ToString();
                var suffix = string.Empty;
                var columnPattern = de.Key.ToString().Split('@');
                if (columnPattern.Length == 2)
                {
                    columnName = columnPattern[0];
                    suffix = columnPattern[1];
                }

                if (modelType.GetProperty(columnName) == null)
                {
                    continue;
                }

                var columnType = modelType.GetProperty(columnName).PropertyType.FullName;

                switch (columnType)
                {
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    {


                        sbSql.AppendFormat(" AND {0} = {1}", columnName, de.Key);

                    }
                        break;
                    case "System.String":
                    {

                        sbSql.AppendFormat(" AND {0} = '{1}'", columnName, de.Key);
                    }
                        break;
                    case "System.DateTime":
                    {

                        switch (suffix.ToLower())
                        {
                            case "g":
                                {

                                    sbSql.AppendFormat(" AND {0} > '{1}'", columnName, de.Value);

                            }
                                break;
                            case "ge":
                                {
                                    sbSql.AppendFormat(" AND {0} >= '{1}'", columnName, de.Value);
                            }
                                break;
                            case "l":
                                {
                                    sbSql.AppendFormat(" AND {0} < '{1}'", columnName, de.Value);
                            }
                                break;
                            case "le":
                                {
                                    sbSql.AppendFormat(" AND {0} <= '{1}'", columnName, de.Value);
                            }
                                break;
                            default:
                                {
                                    sbSql.AppendFormat(" AND {0} = '{1}'", columnName, de.Value);
                            }
                                break;
                        }
                    }
                        break;
                }
            }

            return Entities.QueryBySql(sbSql.ToString()).ToList();
        }

    }
}
