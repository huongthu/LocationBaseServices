using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class FindResult
    {
        public int Cost { get; set; }
        public dynamic Result { get; set; }
    }

    class COST
    {
        public static int PAGING_CELL_COST = 1;
        public static int PHONE_TO_VLR_COST = 2;
        public static int PAGING_VLR_COST = 3;
        public static int PHONE_TO_HLR_COST = 4;
        public static int HLR_TO_VLR_COST = 2;
    }

    public static class Assist
    {
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
