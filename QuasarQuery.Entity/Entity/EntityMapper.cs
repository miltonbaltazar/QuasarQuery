using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;

namespace QuasarQuery.Entity
{
    public class EntityMapper<T>
    {
        IDataReader dr;
        T obj;

        public EntityMapper(IDataReader dr, T obj)
        {
            this.dr = dr;
            this.obj = obj;
        }
        public T FillEntity()
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                try
                {
                    if (!dr.IsDBNull(i))
                    {
                        obj.GetType().GetProperty(dr.GetName(i), BindingFlags.Instance | BindingFlags.Public).SetValue(obj, dr.GetValue(i), null);
                    }
                }
                catch (NullReferenceException ex)
                {
                    continue;
                }
            }

            return obj;
        }
    }
}
