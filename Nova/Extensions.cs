﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova
{
    static class Extensions
    {
        public static IEnumerable<IEnumerable<TSource>> Split<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> partitionBy, bool removeEmptyEntries = false, int count = -1)
        {
            int yielded = 0;
            var items = new List<TSource>();
            foreach (var item in source)
            {
                if (!partitionBy(item))
                    items.Add(item);
                else if (!removeEmptyEntries || items.Count > 0)
                {
                    yield return items.ToArray();
                    items.Clear();

                    if (count > 0 && ++yielded == count) yield break;
                }
            }

            if (items.Count > 0) yield return items.ToArray();
        }
    }
}
