using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7
{
    public static class Helpers
    {
        public static T? GetFirst<T>(ObservableCollection<T> list)
        {
            return list.Count > 0 ? list[0] : default;
        }
    }

}
