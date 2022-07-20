using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitRoutes
{
    class MeterReadingDetails
    {
        public int getReading(int pMeterId,int pMaxPer)
        {
            int currReading = 0;
            ConnClass clx = new ConnClass();
            clx.OpenCon();
            SqlCommand InsCmd = clx.SysCon.CreateCommand();
            InsCmd.CommandTimeout = 300;
            InsCmd.CommandText = "select fCurrentReading from _mtblMeterReadingDetails " +
            "where iMeterReadingsMeterID = " +  pMeterId + " and iBillingPeriodID = " + pMaxPer;
            try
            {
                SqlDataReader dr = InsCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        currReading = Convert.ToInt32(dr[0]);
                    }
                    clx.CloseCon();
                    return currReading;
                }
                else
                {
                    return -1;
                }
                //MessageBox.Show("Code count " + namn.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                clx.CloseCon();
                return -1;
            }
        }

        public int getMaxPer(int pMeterId)
        {
            int maxPer = 0;
            ConnClass clx = new ConnClass();
            clx.OpenCon();
            SqlCommand InsCmd = clx.SysCon.CreateCommand();
            InsCmd.CommandTimeout = 300;
            InsCmd.CommandText = "select max(iBillingPeriodID) from _mtblMeterReadingDetails " +
            "where iMeterReadingsMeterID = " + pMeterId ;
            try
            {
                SqlDataReader dr = InsCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        maxPer = Convert.ToInt32(dr[0]);
                    }
                    clx.CloseCon();
                    return maxPer;
                }
                else
                {
                    return -1;
                }
                //MessageBox.Show("Code count " + namn.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                clx.CloseCon();
                return -1;
            }
        }
    
    }
}
