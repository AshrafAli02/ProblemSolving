using System;

namespace AbstractClassExample
{
    public class MyBook : Book
    {
        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
