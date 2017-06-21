using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coordinateTextManpulator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        // this will be the name of the file the user loads it is initiated as the bufferlist withing our file

        string tripFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\playlists\\bufferlist1.txt";
        string stopsFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\playlists\\bufferlist1.txt";
        string forbiddenFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\playlists\\bufferlist1.txt";
        // this is for loading and saving
        string tripList;
        string tripIndexList;
        string tripCoordIndex;
        string stopsList;
        string forbiddenList;
        // this is for my functions 
        int place = -1;
        int fin = -1;
        int ind;
        int indx;
        int coordNum = 0;
        string iso;
        string substr;
        string LongLat;
        List<int> indexes = new List<int> { -2 };

        //subject to change for now its for square of 150m side
        int sqrdist1 = 8;
        int sqrdist2 = 7;
        int j;
        int k;


        // this is subject to change acording to the format of your txt file you import your trip stops
        string init = "(";
        string fina = ")";
        int distan = 16;




        private int coordinateFind(string s, string start, string fini, int dis)
        {


            if (s.Contains(start) && s.Contains(fini))
            {
                place = s.IndexOf(start);
                fin = s.IndexOf(fini, place + 1);
                if (fin - place != dis)
                {
                    place = -place;
                }
            }
            else
            {
                place = -1;
            }

            return place;
        }

        private string coordinateIndexIsolate(string s)
        {
            // additin of slashes to substr in the beggining is important so that we never get the case of coordinateFind(substr) = -1 while we still have ( and ) in our string
            substr = "//" + s;
            iso = "/";
            indx = 0;
            indexes.Clear();
            indexes.Add(-1);
            while (coordinateFind(substr, init, fina, distan) != -1)
            {
                coordNum = 0;
                ind = coordinateFind(substr, init, fina, distan);

                if (ind > -1)
                {
                    indx = ind - 2 + indx;
                    indexes.Add(indx);
                    iso = iso + "/" + indx.ToString() + "/";
                    substr = "//" + substr.Substring(ind + 1);
                    indx = indx + 1;
                    coordNum = coordNum + 1;
                }
                if (ind < -1)
                {
                    substr = "//" + substr.Substring(-ind + 1);
                    //-1=-2+1
                    indx = indx - ind - 1;
                }
            }
            iso = iso + "/";
            return iso;
        }
        // subject to change , depends on the format your coordinates are given
        private string getLongLat(string s, int plc)
        {
            LongLat = s.Substring(plc + 1, distan - 1);
            return LongLat;
        }


        //subject to change for now its for square of 150m side
        private bool closeness(string s1, string s2)
        {
            
            string con1a = s1.Substring(0, 2) + s1.Substring(3, 4);
            string con1b = s1.Substring(8, 2) + s1.Substring(11, 4);
            string con2a = s2.Substring(0, 2) + s2.Substring(3, 4);
            string con2b = s2.Substring(8, 2) + s2.Substring(11, 4);

            try
            {
                j = Math.Abs(Convert.ToInt32(con1a) - Convert.ToInt32(con2a));
                k = Math.Abs(Convert.ToInt32(con1b) - Convert.ToInt32(con2b));
            }
            catch
            {
                MessageBox.Show("something went wrong trying to convert your coordinates to integers. Most probably you have your report in a different format.");
            }


            bool rtrn  = j < sqrdist1 && k < sqrdist2;
           
            
            return rtrn;
        }

        // makes sure that the coords are corectly formated
        private string coordsMakeProper(string s)
        {
            if (s == "")
            {
                MessageBox.Show("your coordinate file has an empty line");
                return s;
            }
            string str = "";
            if (s.Contains(","))
            {
                int m = s.IndexOf(",");
                int l = s.IndexOf(".");
                if (s.Substring(0, m).IndexOf(".") < 0)
                {
                    if (m == 2)
                    {
                        s = s.Substring(0, m) + "." + s.Substring(m);
                    }
                    if (m == 1)
                    {
                        s = s.Substring(0, m) + "0." + s.Substring(m);
                    }
                }
                m = s.IndexOf(",");
                if (s.Substring(m).IndexOf(".") < 0)
                {
                    if (s.Substring(m).Length == 3)
                    {
                        s = s + ".";
                    }
                    if (s.Substring(m).Length == 2)
                    {
                        s = s+"0." ;
                    }

                    m = s.IndexOf(",");
                }
                
                    m = s.IndexOf(",");
               

                while (m < 7)
                {
                    s = s.Substring(0, m) + "0" + s.Substring(m);
                    m = m + 1;
                }
                while (m > 7)
                {
                    s = s.Substring(0, m - 1) + s.Substring(m);
                    m = m - 1;
                }
                while (s.Substring(m).Length < 8)
                {
                    s = s + "0";

                }
                while (s.Substring(m).Length > 8)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                str = s;
                return str;
            }
            return "error";
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            toolTipOnAll.Active = checkBox2.Checked;
        }



        private void stopsButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)

            {

                stopsFileName = openFileDialog2.FileName;
                using (var fltxt = File.OpenText(@stopsFileName))
                {
                    string a = fltxt.ReadLine();
                    string a1 = null;
                    string a2 = null;
                    while (a != null)
                    {
                        a1 = a.Substring(0);
                        a1 = coordsMakeProper(a1);
                        a2 = a2 + a1;
                        stopsList = a;
                        a = fltxt.ReadLine();


                    }
                    stopsList = a2;
                }
            }

        }




        private void forbiddenButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog3.ShowDialog() == DialogResult.OK)

            {

                forbiddenFileName = openFileDialog3.FileName;
                using (var fltxt = File.OpenText(@forbiddenFileName))
                {
                    string a = fltxt.ReadLine();
                    string a1=null;
                    string a2=null;
                    while (a != null)
                    {
                        a1 = a.Substring(0);
                        a1 = coordsMakeProper(a1);
                        a2 = a2 + a1;
                        forbiddenList = a;
                        a = fltxt.ReadLine();
                       

                    }
                    forbiddenList = a2;
                }
            }
        }

        private void tripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                tripFileName = openFileDialog1.FileName;

                tripList = File.ReadAllText(@tripFileName);
               
                coordinateIndexIsolate(tripList);


            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            string hi = "nothing";
            string test1 ="33.2744,35.4323";
            string test2 = "33.2744,35.4323";
            if (closeness(test1, test2))
            {
                hi = "close";
            }
            if (!closeness(test1, test2))
            {
                hi = "notclose";
            }


            MessageBox.Show(hi);
                
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            if (indexes[0] != -1)
            {
                MessageBox.Show("please import trip coordinates");
            }
            else
            {//start
                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "tripcoords.txt";
                // set filters - this can be done in properties as well
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {


                    using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    {
                        sw.WriteLine("Long-Lat");
                        for (int i = 2; i < indexes.Count - 1; i = i + 2)
                        {
                            sw.WriteLine(getLongLat(tripList, indexes[i]));
                        }
                    }
                }
                SaveFileDialog savefile2 = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "stopsNearForbidden.txt";
                // set filters - this can be done in properties as well
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {


                     using (StreamWriter sw2 = new StreamWriter(savefile.FileName))
                     {
                                sw2.WriteLine("Long-Lat");
                                for (int i1 = 2; i1 < indexes.Count; i1 = i1 + 2)
                                {
                                    string h = getLongLat(tripList, indexes[i1]);
                                   // sw2.WriteLine(getLongLat(tripList, indexes[i1]));
                                    for (int ij = 0;ij< forbiddenList.Length;ij=ij+15)
                                    {
                                        
                                        
                                        if (closeness(h, forbiddenList.Substring(ij, distan - 1)))
                                        {
                                            sw2.WriteLine(getLongLat(tripList, indexes[i1]));
                                        }
                                    }
                                }
                     }
                }
                SaveFileDialog savefile3 = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "unknown.txt";
                // set filters - this can be done in properties as well
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {


                    using (StreamWriter sw3 = new StreamWriter(savefile.FileName))
                    {
                        
                        sw3.WriteLine("Long-Lat");
                        
                            
                        for (int ij = 0; ij < stopsList.Length; ij = ij + 15)
                        {
                            bool exists = false;
                            exists = false;
                            for (int i1 = 2; i1 < indexes.Count; i1 = i1 + 2)
                            {
                                string h = getLongLat(tripList, indexes[i1]);
                                if (closeness(h, stopsList.Substring(ij, distan - 1)))
                                {
                                 exists =true;
                                }
                                if (exists==false)
                                {
                                 sw3.WriteLine(stopsList.Substring(ij, distan - 1));
                                }
                                
                            }
                        }
                    }
                }
            }
                           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hi = "nothing";
            string test1 = "33.2759,35.4323";
            string test2 = "33.2744,35.4323";
            if (closeness(test1, test2))
            {
                hi = "close";
            }
            if (!closeness(test1, test2))
            {
                hi = "notclose";
            }


            MessageBox.Show(hi);
        }
    }
}


       