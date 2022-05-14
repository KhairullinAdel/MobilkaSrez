using System;
using System.Collections.Generic;
using System.Text;

namespace MobilkaSrez
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
