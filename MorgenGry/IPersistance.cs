using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    interface IPersistance
    {
        void Save();

        void Save(string fileName);

        void Load();

        void Load(string fileName);
    }
}
