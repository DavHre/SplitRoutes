using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitRoutes
{
    class WalkDetails
    {
        public int meterId;
        public string meterNo;
        public float pRead;
        public int dcLink;
        public Client clt;

        public List<WalkDetails> rtList(int pIWalkId)
        {
            List<WalkDetails> wdList = new List<WalkDetails>();
            object obj;
            ConnClass clx = new ConnClass();
            clx.OpenCon();
            SqlCommand InsCmd = clx.SysCon.CreateCommand();
            //InsCmd.CommandText = "select iWalkMeterId from _mtblWalkDetails where " +
            //"iWalkId = " + pIWalkId;
            InsCmd.CommandText = "select iWalkID,iWalkMeterID,mt.idMeter,mt.cMeterNumber,pps.iServiceConsumerID " +
            "from _mtblWalkDetails wd left join _mtblMeters mt on iWalkMeterID = mt.idMeter " +
            "left join _mtblPropertyPortionServices pps on iPropertyPortionMeterID = wd.iWalkMeterID and pps.iPropertyPortionMeterID != 0 " +
             "where iWalkID = " + pIWalkId + " order by iServiceConsumerID";
            try
            {
                SqlDataReader dr = InsCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        WalkDetails w = new WalkDetails();
                        w.meterId = Convert.ToInt32(dr[2]);
                        w.meterNo = dr[3].ToString();
                        obj = dr[4];
                        if(dr[4] == System.DBNull.Value)
                        {
                            w.dcLink = 0;
                        }
                        else
                        {
                            w.dcLink = Convert.ToInt32(obj);
                        }
                        //w.dcLink = Convert.ToInt32(dr[4]);
                        wdList.Add(w);
                    }
                    return wdList;
                }
                return null;
                //MessageBox.Show("Code count " + namn.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
