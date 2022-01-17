using System;
using System.Collections.Generic;
using System.Text;

namespace FtMsngr.Data
{
    public class Sabitler
    {
        //<!--PRIVATEs START -->

        //<!--PRIVATEs END -->


        #region REMOTE_HOST_LINKS

        static string site_adresi = "http://localhost/PROJELER/yatirimci_server/";
        public static string loginUrl = site_adresi + "/giris.php";
        public static string kurSorguUrl = site_adresi + "/kurSorgula.php";
        public static string durumSorguUrl = site_adresi + "/durumum.php";
        public static string kayitUrl = site_adresi + "/kayit.php";
        #endregion
    }
}
