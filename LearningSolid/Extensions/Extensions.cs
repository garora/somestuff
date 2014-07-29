using LearningSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid.Extensions
{
    public static class Extensions
    {
        //put common extension methods here
    }
}

namespace System.Linq
{
    public static class DataQueryExtensions
    {
        public static IQueryable<ServerData> ProcessedData1(this IQueryable<ServerData> dataQuery)
        {
            return dataQuery.Where(d => d.IsDirty == false);
        }
    }
}
