using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FtMsngr.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
