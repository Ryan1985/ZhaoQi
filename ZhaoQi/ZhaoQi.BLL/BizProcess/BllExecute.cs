using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using ZhaoQi.BLL.DataAccess;
using ZhaoQi.Model;

namespace ZhaoQi.BLL.BizProcess
{
    public class BllExecute
    {

        private ZhaoQiEntity _entities = new ZhaoQiEntity();

        public ZhaoQiEntity Entities
        {
            get { return _entities; }
            set { _entities = value; }
        }


        public string Add(List<ExecuteModel> list)
        {
            _entities.ExecuteEntity.AddRange(list);
            var result = _entities.SaveChanges();
            if (result < 0)
            {
                return "新增失败";
            }
            return string.Empty;
        }







    }
}
