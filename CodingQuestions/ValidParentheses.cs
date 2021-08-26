using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingQuestions
{
    class ValidParentheses
    {
        public static bool isValid(string parentheses)
        {
            // store length of string before splitting into char
            int length = parentheses.Length;
            // split string into char array for easier looping through
            char[] splitString = parentheses.ToCharArray();
            // create Stack for keeping track of which closed parentheses should be next
            Stack stack = new Stack();
            // foreach loop goes through char in splitString, Pushes next expected closed parentheses on Stack.
            // when ch is a closed parentheses it is checked against the Popped element of Stack to verify it matches.
            foreach (char ch in splitString)
            {
                if (ch == '(')
                    stack.Push(')');
                else if (ch == '{')
                    stack.Push('}');
                else if (ch == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || (char)stack.Pop() != ch)
                    return false;
            }
            // If check needed to verify that there were no open parentheses with no closed parentheses of any type. If the number of open parentheses were greater than closed.
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
