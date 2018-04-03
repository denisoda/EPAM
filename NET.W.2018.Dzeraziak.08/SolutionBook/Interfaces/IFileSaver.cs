using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBook.Interfaces
{
    internal interface IFileSaver<in T>
    {
        void SaveToFile(T file);
    }
}
