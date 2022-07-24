using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoare_Quick_Sort
{
    internal class Sorting
    {
        private int N = 1000;
        Random random = new Random();

        public Sorting(int N) 
        { 
            this.N = N;
        }

        public long Hoare()
        {
            Stacks stacks = new Stacks();
            //заполняем стек значениями
            //Console.Write("sortableStack: ");
            for (int i = 0; i < N; i++)
            {
                stacks.sortableStack.Push(random.Next(1000));
                //Console.Write(stacks.sortableStack.Peek() + " ");
            }
            //Console.WriteLine();
            
            //пока есть что сортировать
            while (stacks.sortableStack.Count > 0)
            {
                stacks.N_op = stacks.N_op + 6;
                stacks.pivot = stacks.sortableStack.Pop();
                
                /*перемещаем элементы во временный стек, чтобы сравнивать 
                 с первого элемента сортируемого стека*/
                while (stacks.sortableStack.Count > 0)
                {
                    stacks.intermediateStack.Push(stacks.sortableStack.Pop());
                    stacks.N_op += 4;
                }

                //перемещаем элементы обратно
                while (stacks.intermediateStack.Count > 0)
                {
                    stacks.N_op += 2;
                    if (stacks.pivot >= stacks.intermediateStack.Peek())
                    {
                        stacks.N_op += 4;
                        stacks.sortableStack.Push(stacks.intermediateStack.Pop());
                    }
                    else
                    {
                        stacks.N_op += 4;
                        //меняем pivot и item элементы местами
                        stacks.item = stacks.intermediateStack.Pop();
                        stacks.sortableStack.Push(stacks.pivot);
                        stacks.pivot = stacks.item;
                    }
                }
                //помещаем самый большой текущий элемент в отсортированный стек
                stacks.sortedStack.Push(stacks.pivot);
            }

            /*Console.Write("\nsortedStack: ");
            while(stacks.sortedStack.Count > 0)
            {
                Console.Write(stacks.sortedStack.Pop() + " ");
            }*/

            return stacks.N_op;
        }
    }
}
