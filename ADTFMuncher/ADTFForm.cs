﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ADTFMuncher
{
    public partial class ADTFForm : Form
    {
        public ADTFForm()
        {
            InitializeComponent();
        }

        //create the serial connection
        private SerialPort sp;
        private NpgsqlConnection m_connPG = null;

        private System.IO.StreamWriter m_swRangeDataFile;


        private void ADTFForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtSerialPort.Text = Properties.Settings.Default.SerialPort;
                txtPostgresConn.Text = Properties.Settings.Default.PostgresConn;
                txtRunID.Text = Properties.Settings.Default.RunID;
                txtOuputDir.Text = Properties.Settings.Default.OuputDir;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ADTFForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.SerialPort = txtSerialPort.Text;
                Properties.Settings.Default.PostgresConn = txtPostgresConn.Text;
                Properties.Settings.Default.OuputDir = txtOuputDir.Text;
                Properties.Settings.Default.RunID = txtRunID.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                sp = new SerialPort(txtSerialPort.Text, 115200);     
                if (!sp.IsOpen)
                {
                    sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    sp.Open();
                }

                sp.DiscardInBuffer();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open range finder port: " + ex.Message, "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
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


                        //if a datafile is open - log the record to it
                        if (m_swRangeDataFile != null)
                        {
                            m_swRangeDataFile.WriteLine(strReceived);
                            m_swRangeDataFile.Flush();

                            int intVal = progressBar1.Value;
                            intVal = intVal + 10;
                            if (intVal > 100)
                            {
                                intVal = 0;
                            }
                            SetPBValue(progressBar1, intVal);

                        }

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
                    if (this.gbMetaControls.Controls.ContainsKey(strControlName))
                    {
                        Control ctr = this.gbMetaControls.Controls[strControlName];
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
        public static void SetPBValue(ProgressBar PB, int intValue)
        {
            PB.Invoke((MethodInvoker)delegate { PB.Value = intValue; });
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {

                FolderBrowserDialog fbd = new FolderBrowserDialog();

                string strDataDir = this.txtOuputDir.Text;
                if (strDataDir.Length > 0)
                {
                    if (Directory.Exists(strDataDir))
                    {
                        fbd.SelectedPath = strDataDir;
                    }
                }

                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtOuputDir.Text = fbd.SelectedPath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIncrementRunID_Click(object sender, EventArgs e)
        {
            try
            {

                int intNextRunNum = int.Parse(txtRunID.Text) + 1;
                txtRunID.Text = intNextRunNum.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            try
            {
                string strOutLogFile = Path.Combine(txtOuputDir.Text, "run_" + txtRunID.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".adtf");
                m_swRangeDataFile = new System.IO.StreamWriter(strOutLogFile, true);

                SetPBValue(progressBar1, 0);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStopCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_swRangeDataFile != null)
                {
                    m_swRangeDataFile.Close();
                    m_swRangeDataFile = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileBrowser = new OpenFileDialog();
                fileBrowser.Filter = "ADTF files (*.adtf)|*.adtf|All files (*.*)|*.*";
                fileBrowser.Title = "Specify a logfile to convert";
                if (txtOuputDir.Text.Length > 0)
                {
                    fileBrowser.InitialDirectory = txtOuputDir.Text;
                }

                if (fileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    string strFileName = fileBrowser.FileName;
                    timeConverter(strFileName);
                    //MessageBox.Show(fileBrowser.FileName);
                }

                fileBrowser.Dispose();
                fileBrowser = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timeConverter(string strInputFile)
        {
            try
            {

                string strOutFile = Path.Combine(Path.GetDirectoryName(strInputFile), Path.GetFileNameWithoutExtension(strInputFile) + "_subsecond.adtf");
                if (File.Exists(strOutFile))
                {
                    MessageBox.Show("An output file already exists with the name: " + strOutFile + " (delete this first before exporting)", "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //open the output file
                StreamWriter swOut = new System.IO.StreamWriter(strOutFile, false);

                //open the logfile
                StreamReader reader = File.OpenText(strInputFile);

                DateTime dtePrevious = DateTime.Now;
                int intMillisPrevious = 0;

                int intMillisRunning = 0;

                int intRecord = 1;
                while (reader.Peek() != -1)
                {

                    //Console.WriteLine(intRecord.ToString());

                    //read a line and split it up
                    String strLine = reader.ReadLine().Trim().TrimStart('{').TrimEnd('}');
                    String[] arrayLine = strLine.Split(new char[] { ',' }, StringSplitOptions.None);

                    //read the record
                    string strTime = "";
                    int intMillis = 0;
                    DateTime dteThis = DateTime.Now;
                    int intMillisStart = 0;
                    string strAllExceptTime = "";
                    foreach (string strDataValue in arrayLine)
                    {
                        String[] arrayParts = strDataValue.Split(new char[] { '|' }, StringSplitOptions.None);
                        if (arrayParts.Length == 2)
                        {
                            string strMetaID = arrayParts[0].Trim();
                            string strValue = arrayParts[1].Trim();
                            int intMetaID = int.Parse(strMetaID);

                            if (intMetaID == 13)
                            {
                                //'2017-07-28 11:42:42.846621+00'
                                dteThis = DateTime.ParseExact(strValue, "H:m:s d/M/yyyy", null); //16:56:13 5/2/2023                    
                                strTime = "'" + dteThis.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                            }
                            else if (intMetaID == 35)
                            {
                                intMillis = int.Parse(strValue);
                            }
                            if (intMetaID != 13)
                            {
                                strAllExceptTime = strAllExceptTime + "," + strDataValue;
                            }

                        }
                    }



                    if (strTime.Length > 0 && intMillis > 0)
                    {
                        if (intRecord == 1)
                        {
                            //first record
                            intMillisStart = intMillis;
                            intMillisRunning = 0;

                        }
                        else
                        {
                            TimeSpan ts = dteThis.Subtract(dtePrevious);
                            if (ts.Seconds == 0)
                            {
                                //same time as last record - need to compare millis values
                                int intMillisSpan = intMillis - intMillisPrevious;
                                intMillisRunning = intMillisRunning + intMillisSpan;

                            }
                            else
                            {
                                //time has incremented to next second
                                intMillisStart = intMillis;
                                intMillisRunning = 0;
                            }
                        }

                        //write the record
                        double dblSeconds = intMillisRunning / 1000.00; //convert to seconds
                        DateTime dteSubSecond = dteThis.AddSeconds(Math.Round(dblSeconds, 1));
                        string strTimeSubSecond = dteSubSecond.ToString("H:m:s.f d/M/yyyy");
                        string strNew = "{13|" + strTimeSubSecond + strAllExceptTime + "}";
                        swOut.WriteLine(strNew);

                        //Debug.Print(strNew);

                        dtePrevious = dteThis;
                        intMillisPrevious = intMillis;
                    }



                    intRecord += 1;
                }

                reader.Close();
                swOut.Close();

                MessageBox.Show("Convert complete!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLoadADTF_Click(object sender, EventArgs e)
        {
            try
            {

                //do checks
                int intRunID;
                if (!int.TryParse(txtRunID.Text, out intRunID))
                {
                    MessageBox.Show("Run ID not set correctly", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtPostgresConn.Text.Length == 0)
                {
                    MessageBox.Show("Postgres database connection has not been set", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //open database
                if (m_connPG != null)
                {
                    m_connPG.Close();
                }
                m_connPG = new NpgsqlConnection(txtPostgresConn.Text);
                m_connPG.Open();

                //get DT realtime data table def
                Hashtable hashTableDefs = GetTableDefs("realtime_table", "realtime_column");
                ArrayList listRealtimeDataTableColDefs = (ArrayList)hashTableDefs["dt_ts_realtime_data"];


                OpenFileDialog fileBrowser = new OpenFileDialog();
                fileBrowser.Filter = "ADTF files (*.adtf)|*.adtf|All files (*.*)|*.*";
                fileBrowser.Title = "Specify a ADTF file to load into DT database...";
                if (txtOuputDir.Text.Length > 0)
                {
                    fileBrowser.InitialDirectory = txtOuputDir.Text;
                }

                if (fileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    string strFileName = fileBrowser.FileName;
                    LoadIntoDT(strFileName, intRunID,listRealtimeDataTableColDefs);

                    //MessageBox.Show(fileBrowser.FileName);
                }

                fileBrowser.Dispose();
                fileBrowser = null;

                m_connPG.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadIntoDT(string strFileName, int intRunID, ArrayList listRealtimeDataTableColDefs)
        {
            try
            {

                string strInDateFormat = "H:m:s d/M/yyyy";
                string strOutDateFormat = "yyyy-MM-dd HH:mm:ss";

                //handle sub second date format
                if (strFileName.EndsWith("_subsecond.LOG") || strFileName.EndsWith("_subsecond.adtf"))
                {
                    strInDateFormat = "H:m:s.f d/M/yyyy";
                    strOutDateFormat = "yyyy-MM-dd HH:mm:ss.f";
                }

                StreamReader reader = File.OpenText(strFileName);
                while (reader.Peek() != -1)
                {
                    RealtimeInsertIntoDT(reader.ReadLine(), 3, intRunID, listRealtimeDataTableColDefs, strInDateFormat, strOutDateFormat);

                }
                reader.Close();
                

                MessageBox.Show("Load complete!");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RealtimeInsertIntoDT(string strReceived, int intDataChannel, int intRunID, ArrayList listColDefs,string strInDateFormat,string strOutDateFormat)
        {
            try
            {

                if (listColDefs == null)
                {
                    return;
                }
  
                //read a line and split it up
                String strLine = strReceived.Trim().TrimStart('{').TrimEnd('}');
                String[] arrayLine = strLine.Split(new char[] { ',' }, StringSplitOptions.None);

                //get a hash of all data values
                string strTime = "";
                Hashtable hashInsertData = new Hashtable();
                foreach (string strDataValue in arrayLine)
                {

                    String[] arrayParts = strDataValue.Split(new char[] { '|' }, StringSplitOptions.None);
                    if (arrayParts.Length == 2)
                    {
                        string strMetaID = arrayParts[0].Trim();
                        string strValue = arrayParts[1].Trim();
                        int intMetaID = int.Parse(strMetaID);

                        if (intMetaID == 13)
                        {
                            
                            DateTime dteThis = DateTime.ParseExact(strValue, strInDateFormat, null); //16:56:13 5/2/2023

                            //datetimes need to be inserted in the local timezone
                            //the postgres timestamptz field type is time zone aware and assumes any insert datetime is local
                            //it will store the actual datetime as utc, but whenever it is queried using sql the local time will be returned
                            //the postgres database timezone is stored against the postgres server properties and this is used to define
                            //what timezone the data is displayed in
                            strTime = "'" + dteThis.ToString(strOutDateFormat) + "'";
                        }
                        else
                        {
                            if (!hashInsertData.ContainsKey(intMetaID)) { hashInsertData.Add(intMetaID, strValue); }
                        }
                    }
                }


                if (strTime.Length > 0)
                {
                    ArrayList listSQLInserts = new ArrayList();

                    //this is a destination table
                    string strColumns = "time,data_channel,run_number";
                    string strValues = strTime + "," + intDataChannel.ToString() + "," + intRunID.ToString();

                    //go through columns and build sql 
                    foreach (Hashtable hashColDef in listColDefs)
                    {
                        int intThisMetaID = (int)hashColDef["METADATAID"];
                        if (hashInsertData.ContainsKey(intThisMetaID))
                        {
                            //the log record contains this metadata id

                            string strValue = hashInsertData[intThisMetaID].ToString();
                            string strColName = hashColDef["DESTCOL"].ToString();
                            string strType = hashColDef["DESTCOLTYPE"].ToString();

                            if (strType == "str")
                            {
                                if (strValue.Length > 0)
                                {
                                    strValue = "'" + strValue + "'";
                                }
                            }
                            else if (strType == "int")
                            {
                                int intValue;
                                if (int.TryParse(strValue, out intValue))
                                {
                                    strValue = intValue.ToString();
                                }
                                else { strValue = ""; }
                            }
                            else if (strType == "dbl")
                            {
                                double dblValue;
                                if (double.TryParse(strValue, out dblValue))
                                {
                                    strValue = dblValue.ToString();
                                }
                                else { strValue = ""; }
                            }

                            if (strValue.Length > 0)
                            {

                                strColumns = strColumns + "," + strColName;
                                strValues = strValues + "," + strValue;
                            }
                        }

                    }

                    if (strColumns != "time")
                    {

                        //build sql insert for this table
                        listSQLInserts.Add("insert into dt_ts_realtime_data (" + strColumns + ")" + " values (" + strValues + ") ON CONFLICT DO NOTHING");
                    }


                    //do the inserts for this record (time point)
                    PGInsert(listSQLInserts);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void PGInsert(ArrayList listSQLInserts)
        {
            try
            {
                foreach (string strSQL in listSQLInserts)
                {
                    NpgsqlCommand commPG = new NpgsqlCommand(strSQL, m_connPG);
                    commPG.ExecuteNonQuery();
                    commPG.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private Hashtable GetTableDefs(string strDestTableCol, string strDestColCol)
        {
            try
            {
                Hashtable hashTableDefs = new Hashtable();

                string strPreviousDestTable = "";

                ArrayList listColDefs = new ArrayList();

                //get the metadata records
                NpgsqlCommand commPG = new NpgsqlCommand("select " + strDestTableCol + "," + strDestColCol + ",expected_min_value,expected_max_value,metadata_id,dest_column_type from dt_data_config order by " + strDestTableCol, m_connPG);
                NpgsqlDataReader readerPG = commPG.ExecuteReader();
                while (readerPG.Read())
                {
                    object objDestTable = readerPG.GetValue(0);
                    object objDestColumn = readerPG.GetValue(1);
                    object objMinVal = readerPG.GetValue(2);
                    object objMaxVal = readerPG.GetValue(3);
                    object objMetaDataID = readerPG.GetValue(4);
                    object objDestColumnType = readerPG.GetValue(5);

                    if (objDestTable != null && objDestColumn != null && objMetaDataID != null && objDestColumnType != null)
                    {
                        string strDestTable = objDestTable.ToString();
                        string strDestColumn = objDestColumn.ToString();
                        string strDestColumnType = objDestColumnType.ToString();

                        if (strDestTable.Length > 0 && strDestColumn.Length > 0 && strDestColumnType.Length > 0)
                        {

                            int intMetaDataID = int.Parse(objMetaDataID.ToString());

                            Hashtable hashColumnDef = new Hashtable();
                            hashColumnDef.Add("METADATAID", intMetaDataID);
                            hashColumnDef.Add("DESTCOL", strDestColumn);
                            hashColumnDef.Add("DESTCOLTYPE", strDestColumnType);
                            hashColumnDef.Add("MINVAL", objMinVal);
                            hashColumnDef.Add("MAXVAL", objMaxVal);

                            if (strDestTable == strPreviousDestTable || strPreviousDestTable.Length == 0)
                            {
                                //same table - keep adding columns to the list of cols
                                listColDefs.Add(hashColumnDef);

                            }
                            else
                            {
                                //new table - store the previous column list against the previous table name
                                hashTableDefs.Add(strPreviousDestTable, listColDefs);

                                //create a new column def list
                                listColDefs = new ArrayList();
                                listColDefs.Add(hashColumnDef);
                            }

                            strPreviousDestTable = strDestTable;
                        }
                    }
                }
                //there will always be one last column def list - store this
                hashTableDefs.Add(strPreviousDestTable, listColDefs);

                readerPG.Close();
                commPG.Dispose();

                return hashTableDefs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {

            DateTime dteNow = DateTime.Now;
            string strParam = dteNow.Year.ToString() + "|" + dteNow.Month.ToString() + "|" + dteNow.Day.ToString() + "|" + dteNow.Hour.ToString() + "|" + dteNow.Minute.ToString() + "|" + dteNow.Second.ToString();


            //try to set range finder time
            try
            {
                sp.WriteLine("TIMESET," + strParam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not set time on range finder: " + ex.Message);
            }

        }
    }
}
