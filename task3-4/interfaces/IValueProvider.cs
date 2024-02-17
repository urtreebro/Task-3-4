using System;
using System.Collections.Generic;

namespace task3_4
{
    interface IValueProvider<T>  
    {
        T GetRandomValue();

        T GetUserValue();
    }    
}
