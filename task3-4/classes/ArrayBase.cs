using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    abstract class ArrayBase<T> : IBase
    {
        protected bool userInput = false;

        protected static Random rnd = new();

        protected IValueProvider<T> _valueProvider;

        protected ArrayBase(IValueProvider<T> _valueProvider, bool userInput = false)
        {
            this.userInput = userInput;

            this._valueProvider = _valueProvider;

            if (userInput)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        protected abstract void RandomInput();

        protected abstract void UserInput();

        public abstract void Print();

        public abstract void Refill(bool userInput = false);
    }
}
