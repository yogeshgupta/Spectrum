/*
 *  Spectrum, A window app to download EoD bhavcopy in metastock format.  
    Copyright (C) 2011  Yogesh Gupta

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using Ionic.Zip;

namespace spectrum
{
    public partial class DD : Form
    {
        public DD()
        {
            InitializeComponent();
        }

        private delegate void DoWorkDelegate(int cnt,string Filename);

        private void DD_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            //closes the spectrum
        }

        private void button1_Click(object sender, EventArgs e)
        {          
               /* dwnlder dw = new dwnlder();
                dw.ShowDialog(); */
            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception) { }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient Client=new WebClient();
            DateTime dtps1 = dTP1.Value;
            DateTime dtps2 = dTP2.Value;
            int cnt = 0;
            string dates1 = String.Format("{0:dd}", dtps1);
            int datei1 = Convert.ToInt32(dates1);
            string dates2 = String.Format("{0:dd}", dtps2);
            int datei2 = Convert.ToInt32(dates2);
            int tot = 0;
            
                try
                {

                    tot = datei2 - datei1 + 1;
                }

                catch (Exception) { }
                if (tot < 0)
                {
                    string datesm1 = String.Format("{0:MM}", dtps1);
                    string datesm2 = String.Format("{0:MM}", dtps2);
                    int dateim1 = Convert.ToInt32(datesm1);
                    int dateim2 = Convert.ToInt32(datesm2);
                    int totm = dateim2 - dateim1;
                    if (totm < 0)
                    {
                        string datesy1 = String.Format("{0:yy}", dtps1);
                        string datesy2 = String.Format("{0:yy}", dtps2);
                        int dateiy1 = Convert.ToInt32(datesy1);
                        int dateiy2 = Convert.ToInt32(datesy2);
                        int toty = dateiy2 - dateiy1;
                        totm = totm + (toty * 12);
                    }

                    tot = tot + (totm * 31);
                }
                //  UInt32 tot = (uint)tot1;

                rCT1.Text = "";
                label4.Text = "";
                backgroundWorker1.ReportProgress(0);

                if (IsConnectedToInternet() == true) //Check for a valid net connection
                {
                    if (brsTB.Text == "")
                        MessageBox.Show("Please enter a valid dir path");
                    else
                    {
                        if (nse.Checked)
                        {
                            label4.Text = "";
                            backgroundWorker1.ReportProgress(0);
                            DateTime dtpsns1 = dtps1;
                            while (dtpsns1 <= dtps2)
                            {
                                string URL = "http://nseindia.com/content/historical/EQUITIES/" + dtpsns1.Year + "/" + dtpsns1.ToString("MMM").ToUpper() + "/cm" + dtpsns1.Day.ToString("D2") + dtpsns1.ToString("MMM").ToUpper() + dtpsns1.Year + "bhav.csv.zip";

                                string Filename = URL.Substring(URL.LastIndexOf("/") + 1, (URL.Length - URL.LastIndexOf("/") - 1));
                                string URL2 = "http://nseindia.com/archives/equities/mkt/mkt" + String.Format("{0:dd}", dtps1) + String.Format("{0:MM}", dtps1) + String.Format("{0:yyyy}", dtps1) + ".doc";
                                string Filename2 = URL2.Substring(URL2.LastIndexOf("/") + 1, (URL2.Length - URL2.LastIndexOf("/") - 1));
                                string path = folderBrowserDialog1.SelectedPath + "/temp";
                                string ext = "NSE";
                                Directory.CreateDirectory(path);
                                //create a temporary directory to store zipped bhavcopies and corresponding csv files 

                                string pathbhav = folderBrowserDialog1.SelectedPath;
                                cnt = bhavDwn(URL, Filename, Client, dtps1, cnt, path);
                                float cnt1 = cnt;
                                float perc = (cnt1 / tot) * 100;

                                int perc1 = Convert.ToInt32(perc);

                                Labelchange(cnt, Filename);

                                //   cnt = nseMkt(URL2, Filename2, Client, dtps1, cnt,path);
                                //  Labelchange(cnt, Filename2);

                                /* perc = (cnt1 / tot) * 100;
                                backgroundWorker1.ReportProgress(perc);*/

                                backgroundWorker1.ReportProgress(perc1);
                                string dirpath = path;
                                DirectoryInfo di = new DirectoryInfo(dirpath);
                                string pathcs = pathbhav + @"/csv";
                                Decompress(pathcs, Filename, path);
                                //Decompress the zip file and convert the bhavcopy into the metastock format

                                int index = Filename.IndexOf(@".");
                                string nf = Filename.Substring(0, index) + ".csv";
                                rdTxtFl(nf, pathcs, pathbhav, ext, dtpsns1);
                                //Read csv file to metastock file format

                                dtpsns1 = dtpsns1.AddDays(1);

                                if (Directory.Exists(path))
                                {
                                    Directory.Delete(path, true);
                                }		//Delete the temp directory
                            }
                            backgroundWorker1.ReportProgress(100);
                            MessageBox.Show("All NSE Bhavcopies fetched");
                        }
                        if (bse.Checked)
                        {
                            label4.Text = "";
                            backgroundWorker1.ReportProgress(0);
                            cnt = 0;
                            DateTime dtpsns1 = dtps1;
                            while (dtpsns1 <= dtps2)
                            {
                                string URL = "http://www.bseindia.com/Hisbhav/eq" + String.Format("{0:dd}", dtpsns1) + String.Format("{0:MM}", dtpsns1) + String.Format("{0:yy}", dtpsns1) + @"_csv.zip";

                                string Filename = URL.Substring(URL.LastIndexOf("/") + 1, (URL.Length - URL.LastIndexOf("/") - 1));

                                string path = folderBrowserDialog1.SelectedPath + "/temp";
                                Directory.CreateDirectory(path);
                                //create a temporary directory to store zipped bhavcopies and corresponding csv files 
                                string ext = "BSE";
                                string pathbhav = folderBrowserDialog1.SelectedPath;
                                cnt = bhavDwn(URL, Filename, Client, dtps1, cnt, path);
                                float cnt1 = cnt;

                                float perc = (cnt1 / tot) * 100;

                                int perc1 = Convert.ToInt32(perc);

                                Labelchange(cnt, Filename);


                                backgroundWorker1.ReportProgress(perc1);
                                string dirpath = path;
                                DirectoryInfo di = new DirectoryInfo(dirpath);
                                string pathcs = pathbhav + @"/csv";
                                Decompress(pathcs, Filename, path);
                                //Decompress the zip file and convert the bhavcopy into the metastock format
                                int index = Filename.IndexOf(@".");
                                string nf = Filename.Substring(0, (index - 4)) + ".csv";
                                rdTxtFl(nf.ToUpper(), pathcs, pathbhav, ext, dtpsns1);
                                //Read csv file to metastock file format

                                dtpsns1 = dtpsns1.AddDays(1);

                                if (Directory.Exists(path))
                                {
                                    Directory.Delete(path, true);
                                }		//Delete the temp directory
                            }
                            backgroundWorker1.ReportProgress(100);
                            MessageBox.Show("All BSE Bhavcopies fetched");
                        }
                    }
                }

                else if (IsConnectedToInternet() == false)
                {
                    MessageBox.Show("You are currently not connected to internet please check your internet connection again");
                }
            
            
           
        }

        private void Labelchange(int cnt,string Filename)
        {
            if (this.InvokeRequired)
            {
                DoWorkDelegate dg = new DoWorkDelegate(Labelchange);
                this.Invoke(dg,new object[]{cnt,Filename});  
            }
            else  
            {
                label4.Text = cnt + " Bhavcopy Downloaded";
                rCT1.Text += Filename + " Fetched \n\n";
            }
        }


        private static int bhavDwn(String URL,string Filename,WebClient Client, DateTime dtps1, int cnt,string path)
        {
            try
            {
                string PATH = path + "\\"+Filename;
                Client.DownloadFile(URL, PATH);
                cnt++;
            }
            catch (Exception) { }
            return cnt;
        }
        private static int nseMkt(String URL2, string Filename, WebClient Client, DateTime dtps1, int cnt,string path)
        {
            try
            {
                string PATH = path + "\\"+Filename;
                Client.DownloadFile(URL2, PATH);
                cnt++;
            }
            catch (Exception) { }
            return cnt;
        }

        public bool IsConnectedToInternet()
        {
           /* WebClient client = new WebClient();
            string host = "www.google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;*/
            try
            {
                System.Net.Sockets.TcpClient clnt=new System.Net.Sockets.TcpClient("www.google.com",80);
                clnt.Close();
                return true;
            }
            catch(System.Exception)
            {
                return false;
            }
        }

        public static void Decompress(string pathcs,string Filename,string pathtmp)
        {
            try
            {
            
                Directory.CreateDirectory(pathcs);
                string fname = pathtmp + @"/"+Filename;
                using (ZipFile zip1 = ZipFile.Read(fname))
                {
                    foreach (ZipEntry e in zip1)
                    {
                        e.Extract(pathcs, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }
            catch (Exception) { }
           
        }

        public static void rdTxtFl(string Filename,string pathcs,string pathe,string ext,DateTime dts)
        {
            try
            {
                WebClient Client = new WebClient();
                int index = Filename.IndexOf(@".");
                string nf = Filename.Substring(2,(index-2)) + ext;
                string pathSource = pathcs + "//" + Filename;
                string pathNew = pathe + "//" + nf + @".txt";
                string line;

                StreamReader sr = new StreamReader(pathSource);
                line = sr.ReadLine();
                line = sr.ReadLine();
                using (FileStream fsNew = new FileStream(pathNew, FileMode.Create, FileAccess.Write)) { }

                StreamWriter sw = new StreamWriter(pathNew);
                while (line != null)
                {
                 //   line = sr.ReadLine();
                    if (ext == "NSE")
                        line = NSEFormatLine(line, dts);
                    else if (ext == "BSE")
                        line = BSEFormatLine(line, dts);
                    if(line!="eq")
                        sw.WriteLine(line);
                    
                    line = sr.ReadLine();
                }
                if (ext == "NSE")
                {
                    string[] URL = new string[9];
                    URL[0] = "http://nseindia.com/content/indices/histdata/S&P%20CNX%20NIFTY" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[1] = "http://nseindia.com/content/indices/histdata/CNX%20NIFTY%20JUNIOR" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[2] = "http://nseindia.com/content/indices/histdata/CNX%20100" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[3] = "http://nseindia.com/content/indices/histdata/S&P%20CNX%20500" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[4] = "http://nseindia.com/content/indices/histdata/NIFTY%20MIDCAP%2050" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[5] = "http://nseindia.com/content/indices/histdata/CNX%20MIDCAP" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[6] = "http://nseindia.com/content/indices/histdata/BANK%20NIFTY" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[7] = "http://nseindia.com/content/indices/histdata/CNX%20IT" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "-" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    URL[8] = "http://nseindia.com/content/vix/histdata/hist_india_vix_" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + "_" + String.Format("{0:dd}", dts) + "-" + String.Format("{0:MM}", dts) + "-" + String.Format("{0:yyyy}", dts) + ".csv";
                    indices(URL, sw, Client, dts);
                }
                sw.Close();
                sr.Close();

            }
            catch (Exception) { }
        }

        public static void indices(string[] URL, StreamWriter sw, WebClient Client,DateTime dts)
        {
            
            for(int i=0;i<URL.Length;i++)
            {
                string readHtml = Client.DownloadString(URL[i]);
                int ch = readHtml.IndexOf("\n");
                int len = readHtml.Length;
                string gh = readHtml.Substring(ch + 1, (len - (ch + 1)));
                string[] wrds = gh.Split('"');
                if (i == 8)
                    wrds = gh.Split(',');
                string str=null;
                if (i == 0)
                {
                    str = "NSENIFTY," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                 
                }
                else if(i==1)
                {
                    str = "NIFTYJUNIOR," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                
                }
                else if (i == 2)
                {
                    str = "NSE100," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                   
                }
                else if (i == 3)
                {
                    str = "NSE500," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                   
                }
                else if (i == 4)
                {
                    str = "MIDCAP50," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                   
                }
                else if (i == 5)
                {
                    str = "NSEMIDCAP," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
               
                }
                else if (i == 6)
                {
                    str = "BANKNIFTY," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                 
                }
                else if (i == 7)
                {
                    str = "NSEIT," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[3].Trim() + "," + wrds[5].Trim() + "," + wrds[7].Trim() + "," + wrds[9].Trim() + "," + wrds[11].Trim() + "," + 0;
                    
                }
                else if (i == 8)
                {
                    str = "VIX," + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + "," + wrds[1].Trim() + "," + wrds[2].Trim() + "," + wrds[3].Trim() + "," + wrds[4].Trim() + "," + 0 + "," + 0;
                  
                }
                sw.WriteLine(str);
            }

        }

        public static string NSEFormatLine(string line, DateTime dts)
        {
            int ch=line.IndexOf(",");
            string linex = line.Substring(0, ch+1) + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts);
            string eq = line.Substring(ch + 1, 2);
                if(eq!="EQ")
                {
                   // MessageBox.Show(eq);
                    return "eq";
                }
            ch=ch+3;
            int chx=-1;
            for (int i = 0; i < 6; i++)
            {
                chx = line.IndexOf(",", chx + 1); //get the index of fourth ","
            }

            linex += line.Substring(ch, (chx+1)-ch);
            chx=-1;
            ch=-1;
            for (int i = 0; i < 8; i++)
            {
                ch = line.IndexOf(",", ch + 1);
            }
            ch = ch + 1;
            for (int i = 0; i < 9; i++)
            {
                chx = line.IndexOf(",", chx + 1);
            }
            linex += line.Substring(ch, chx-ch);
            return linex;
        }

        public static string BSEFormatLine(string line, DateTime dts)
        {
            int ch = line.IndexOf(",");
            string linex = line.Substring(0, ch + 1) + String.Format("{0:yyyy}", dts) + String.Format("{0:MM}", dts) + String.Format("{0:dd}", dts) + ",";
            
            int chx = -1;
            ch = -1;
            for (int i = 0; i < 4; i++)
            {
                ch = line.IndexOf(",", ch + 1);
            }
            ch = ch + 1;
            for (int i = 0; i < 8; i++)
            {
                chx = line.IndexOf(",", chx + 1);
            }
            linex += line.Substring(ch, chx - ch)+",";

            chx = -1;
            ch = -1;
            for (int i = 0; i < 11; i++)
            {
                ch = line.IndexOf(",", ch + 1);
            }
            ch = ch + 1;
            for (int i = 0; i < 12; i++)
            {
                chx = line.IndexOf(",", chx + 1);
            }
            linex += line.Substring(ch, chx - ch);

            return linex;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        
          //  MessageBox.Show("File download complete");
            
        }

        private void rCT1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BrwsBtn_Click(object sender, EventArgs e) 
        {
            folderBrowserDialog1.ShowDialog();	//for directory selection
            brsTB.Text = folderBrowserDialog1.SelectedPath;
        }

        private void brsTB_TextChanged(object sender, EventArgs e)
        {
            brsTB.Text = folderBrowserDialog1.SelectedPath;
        }

        private void closeFile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutSpectrumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutspec ab = new aboutspec();
            ab.Show();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abtathr athr = new abtathr();
            athr.Show();
        }

        private void dTP1_ValueChanged(object sender, EventArgs e)
        {
            dTP1.MaxDate = DateTime.Now;

        }

        private void dTP2_ValueChanged(object sender, EventArgs e)
        {
            dTP2.MaxDate = DateTime.Now;
        }

    }
}
