using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ZhaoQi.Web.Core.EFDataAccess;
using ZhaoQi.Web.Core.Models;

namespace ZhaoQi.Web.Core.Repository
{
    public class HistoryDataRepository:IRepository<HistoryDataModel>
    {
        private ZhaoQiEntities _entitiy = new ZhaoQiEntities();
        public DbContext Entity
        {
            get
            {
                return _entitiy;
            }
            set
            {
                _entitiy = value as ZhaoQiEntities;
            }
        }

        public IQueryable<HistoryDataModel> Query
        {
            get
            {
                return _entitiy.HistoryDataEntities.AsQueryable();
            }
        }

        public int Add(IEnumerable<HistoryDataModel> models, bool isAutoSubmit = true)
        {
            _entitiy.HistoryDataEntities.AddRange(models);
            if (isAutoSubmit)
                return SubmitChanges();

            return models.Count();
        }

        public int Delete(IEnumerable<HistoryDataModel> models, bool isAutoSubmit = true)
        {
            _entitiy.HisDataEntities.RemoveRange(
                _entitiy.HisDataEntities.Where(r => models.Select(m => m.ID).ToArray().Contains(r.Id)).Select(r => r));

            if (isAutoSubmit)
                return SubmitChanges();

            return models.Count();
        }

        public int Modify(IEnumerable<HistoryDataModel> models, bool isAutoSubmit = true)
        {
            foreach (var model in models)
            {
                var entityModel =
                    _entitiy.HistoryDataEntities.Where(
                        r => r.ID == model.ID)
                        .Select(r => r)
                        .FirstOrDefault();

                if (entityModel != null)
                {
                    entityModel.Can_Temp1_1 = model.Can_Temp1_1;
                    entityModel.Can_Temp1_2 = model.Can_Temp1_2;
                    entityModel.Can_Temp2_1 = model.Can_Temp2_1;
                    entityModel.Can_Temp2_2 = model.Can_Temp2_2;
                    entityModel.Can_Temp3_1 = model.Can_Temp3_1;
                    entityModel.Can_Temp3_2 = model.Can_Temp3_2;
                    entityModel.Can_Temp4_1 = model.Can_Temp4_1;
                    entityModel.Can_Temp4_2 = model.Can_Temp4_2;
                    entityModel.Can_Flow_Dry1 = model.Can_Flow_Dry1;
                    entityModel.Can_Flow_Wet1 = model.Can_Flow_Wet1;
                    entityModel.Can_Produce1 = model.Can_Produce1;
                    entityModel.Can_Flow_Dry2 = model.Can_Flow_Dry2;
                    entityModel.Can_Flow_Wet2 = model.Can_Flow_Wet2;
                    entityModel.Can_Produce2 = model.Can_Produce2;
                    entityModel.Can_Flow_Dry3 = model.Can_Flow_Dry3;
                    entityModel.Can_Flow_Wet3 = model.Can_Flow_Wet3;
                    entityModel.Can_Produce3 = model.Can_Produce3;
                    entityModel.Can_Flow_Dry4 = model.Can_Flow_Dry4;
                    entityModel.Can_Flow_Wet4 = model.Can_Flow_Wet4;
                    entityModel.Can_Produce4 = model.Can_Produce4;
                    entityModel.Can_Pressure = model.Can_Pressure;
                    entityModel.Store_Pressure = model.Store_Pressure;
                    entityModel.Supply_Flow = model.Supply_Flow;
                    entityModel.Supply_Pressure = model.Supply_Pressure;
                    entityModel.UpdateTime = model.UpdateTime == default(DateTime) ? DateTime.Now : model.UpdateTime;
                }
            }

            if (isAutoSubmit)
                return SubmitChanges();

            return models.Count();
        }

        public int SubmitChanges()
        {
            return _entitiy.SaveChanges();
        }
    }
}
