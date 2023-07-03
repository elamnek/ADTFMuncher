using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADTFMuncher
{
    internal class ADTF
    {
        
        private SerialPort m_sp;
        private NpgsqlConnection m_connPG = null;
        private GroupBox m_gpMetaControls;

        public ADTF(string strPort,int intBaudRate,GroupBox gpMetaControls)
        {
            try
            {
                m_sp = new SerialPort(strPort, intBaudRate);
                if (!m_sp.IsOpen)
                {
                    m_sp.DataReceived += new SerialDataReceivedEventHandler(m_sp_DataReceived);
                    m_sp.Open();
                }

                m_sp.DiscardInBuffer();

                m_gpMetaControls = gpMetaControls;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open specified com port: " + ex.Message, "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

        }
        private void m_sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                SerialPort sp = (SerialPort)sender;
                string strReceived = sp.ReadLine();
                if (!strReceived.StartsWith("VMDPE"))
                {
                    if (strReceived.StartsWith("{") && strReceived.EndsWith("}\r"))
                    {
                        Debug.Write(strReceived);
                        DisplayRecord(strReceived);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DisplayRecord(string strReceived)
        {
            try
            {
                ArrayList listMetadataIDs = new ArrayList();

                //this is a data record - display each part in the textboxes
                String strRaw = strReceived.Trim().TrimStart('{').TrimEnd('}');
                String[] arrayRaw = strRaw.Split(',');
                foreach (String strPart in arrayRaw)
                {
                    String[] arrayValue = strPart.Trim().Split('|');
                    int intMetadataID = int.Parse(arrayValue[0].ToString());
                    listMetadataIDs.Add(intMetadataID);

                    String strValue = arrayValue[1].ToString();

                    //search for the matching control and write the value to it
                    string strControlName = "meta_id_" + intMetadataID.ToString();
                    if (m_gpMetaControls.Controls.ContainsKey(strControlName))
                    {
                        Control ctr = m_gpMetaControls.Controls[strControlName];
                        SetControlText(ctr, strValue);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void SetControlText(Control ctl, string text)
        {
            ctl.Invoke((MethodInvoker)delegate { ctl.Text = text; });
        }

        public void SyncClock()
        { 
            try
            {
                DateTime dteNow = DateTime.Now;
                string strParam = dteNow.Year.ToString() + "|" + dteNow.Month.ToString() + "|" + dteNow.Day.ToString() + "|" + dteNow.Hour.ToString() + "|" + dteNow.Minute.ToString() + "|" + dteNow.Second.ToString();

                m_sp.WriteLine("TIMESET," + strParam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not sync time: " + ex.Message);
            }
        }

    }
}
