using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Todo.Shared.Extensions
{
    public static class BindingListExtensions
    {
        /// <summary>
        /// Adds all the data to a binding list
        /// </summary>
        public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
        {
            if (list == null || data == null)
            {
                return;
            }

            foreach (T t in data)
            {
                list.Add(t);
            }
        }
    }
}
