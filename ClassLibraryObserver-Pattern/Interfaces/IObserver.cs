using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public interface IObserver
    {
        void Update(Dictionary<string, int> intelligence);
    }
}
