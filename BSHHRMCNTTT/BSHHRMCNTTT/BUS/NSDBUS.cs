using BSHHRMCNTTT.DAO;
using BSHHRMCNTTT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHHRMCNTTT.BUS
{
    class NSDBUS
    {
        private static readonly NSDDAO nsd = new NSDDAO();
        #region [NSD_LKE]
        public static DataTable NSD_LKE()
        {
            return nsd.NSD_LKE();
        }
        #endregion
        #region [NSD_LKE_ID]
        public static string NSD_LKE_ID(string Filter1, string Filter2)
        {
            NSDInfo nsdinfo = new NSDInfo();
            DataTable dt = new DataTable();
            dt= nsd.NSD_LKE_ID(Filter1, Filter2);
            foreach (DataRow dr in dt.Rows)
            {
                nsdinfo.KeyCode = dr["KeyCode"].ToString();
            }

            return nsdinfo.KeyCode;
        }
        #endregion
        #region[NSD_NH]
        public static void NSD_NH(NSDInfo nsdinfo)
        {
            nsd.NSD_NH(nsdinfo);
        }
        #endregion
        #region [NSD_SUA]
        public static void NSD_SUA(NSDInfo obj)
        {
            nsd.NSD_SUA(obj) ;
        }
        #endregion
        #region [DMK]
        public static void NSD_DMK(NSDInfo nsdinfo)
        {
            nsd.NSD_DMK(nsdinfo);
        }
        #endregion
        #region [NSD_XOA]
        public static void NSD_XOA(NSDInfo nsdinfo)
        {
            nsd.NSD_XOA(nsdinfo);
        }
        #endregion
    }
}
