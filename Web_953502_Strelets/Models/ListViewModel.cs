using System;
using System.Collections.Generic;
using System.Linq;

namespace Web_953502_Strelets.Models
{
    public class ListViewModel<T> : List<T> where T : class
    {
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        private ListViewModel(IEnumerable<T> items, int total, int current)
            : base(items)
        {
            this.TotalPages = total;
            this.CurrentPage = current;
        }

        public static ListViewModel<T> GetModel(IEnumerable<T> items, int current, int itemsPerPage)
        {
            var list = items.Skip((current - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            var total = (int)Math.Ceiling((double) items.Count() / itemsPerPage);

            return new ListViewModel<T>(list, (int)total, current);
        }
    }
}
