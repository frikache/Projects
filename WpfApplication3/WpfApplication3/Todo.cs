﻿namespace TodoProject
{
    public class Todo
    {
        public int Number;
        public string TodoStr;
        public bool Done;

        public Todo(int num, string el)
        {
            Number = num;
            TodoStr = el;
            Done = false;
        }

    }
}