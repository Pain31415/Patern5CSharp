using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public interface IObserver
    {
        void Update(string stockSymbol, decimal stockPrice);
    }
}
