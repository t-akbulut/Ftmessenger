using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using FtMsngr.Data;
using FtMsngr.iOS.Data;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace FtMsngr.iOS.Data
{
    class SQLite_iOS : ISQLite
    {
        public SQLite_iOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "PhotUpDB.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }

    }
}