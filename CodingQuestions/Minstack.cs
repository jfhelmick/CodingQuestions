using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingQuestions
{
    public class Minstack
    {
        //Create Stack and holder for the minimum value.
        public Stack stack;
        private int min;

        //Constructor
        public Minstack()
        {
            stack = new Stack();
        }


        //Push method
        public void push(int val)
        {
            //If this is the first int in stack set min = val and Push val on stack
            if (stack.Count == 0)
            {
                min = val;
                stack.Push(val);
                return;
            }
            //If val is the new min Push placeholder val and set min = val
            if (val < min)
            {
                stack.Push(2 * val - min);
                min = val;
            }
            //If val is not the new min Push val
            else
                stack.Push(val);
        }

        //Pop method
        public void pop()
        {
            //Pop from stack and store value into popped
            int popped = (int)stack.Pop();
            //If popped was less than our stored min value set min to what will now be the new min value after pop
            if (popped < min)
            {
                min = 2 * min - popped;
            }
        }

        //Top method
        public int top()
        {
            //set top to top of stack
            int top = (int)stack.Peek();
            //If top is less than min, actual min value is contained in min so return min. Else return top value.
            if (top < min)
                return min;
            else
                return top;
        }

        //getMin method
        public int getMin()
        {
            //simply return min value
            return min;
        }
    }
}
