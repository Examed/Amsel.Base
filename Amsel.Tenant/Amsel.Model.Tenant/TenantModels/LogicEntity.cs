using Amsel.Framework.Base.Interfaces;
using JsonLogic.Net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Amsel.Model.Tenant.TenantModels
{
    public abstract class LogicEntity : IGuidEntity
    {
        //[JsonConverter(typeof(GenericListTypeConverter<DataEntity>))]
        //public virtual IList<DataEntity> Data { get; set; }

        public virtual bool IsConditionsMet(IEnumerable<DataEntity> entities) => IsConditionsMet(null, entities?.ToArray());

        public virtual bool IsConditionsMet(params DataEntity[] entities) => IsConditionsMet(null, entities);

        public virtual bool IsConditionsMet(JsonLogicEvaluator evaluator, IEnumerable<DataEntity> entities) => IsConditionsMet(evaluator, entities?.ToArray());

        public virtual bool IsConditionsMet(JsonLogicEvaluator evaluator, params DataEntity[] entities)
        {
            if((Conditions == null) || !Conditions.HasValues)
                return true;

            if(evaluator == null)
                evaluator = new JsonLogicEvaluator(EvaluateOperators.Default);

            Dictionary<string, object> data = new Dictionary<string, object>();
            //if(Data != null)
            //    entities = entities?.Concat(Data).ToArray();

            if(entities != null)
                foreach(DataEntity item in entities)
                    if(item?.Id != null)
                        data.Add(item.Name, item.GetData());

            if(evaluator.Apply(Conditions, data) is bool result)
                return result;

            return false;
        }

        public virtual JToken Conditions { get; set; }

        public Guid Id { get; set; }
    }
}