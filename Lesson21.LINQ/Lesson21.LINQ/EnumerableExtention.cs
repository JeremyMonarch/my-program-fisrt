﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21.LINQ
{
    public static class EnumerableExtention
    {
        public static IEnumerable<U> OwnSelect<T, U>(this IEnumerable<T> enumerable, Func<T, U> func)
        {
            foreach(var item in enumerable)
            {
                yield return func(item);
            }
        }

        public static IEnumerable<T> OwnWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> func)
        {
            foreach(var item in enumerable)
            {
                if(func(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> OwnAppend<T>(this IEnumerable<T> enumerable, T value)
        {
            foreach (var item in enumerable)
            {
                    yield return item;
            }

            yield return value;
        }
    }
}
