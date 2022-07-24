using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoare_Quick_Sort
{
    internal class Stacks
    {
        public Stack<int> sortableStack = new Stack<int>();
        public Stack<int> intermediateStack = new Stack<int>();
        public Stack<int> sortedStack = new Stack<int>();
        public int count; //число оставшихся непроверенных элементов
        public int pivot; //опорный элемент
        public int item; //элемент, который больше опорного
        public long N_op;
    }
}
