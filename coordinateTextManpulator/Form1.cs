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
        int num;
        int coordNum=0;
        string iso;
        string substr;
        string LongLat;
        List<int> indexes = new List<int> { -2 };

        


        // this is subject to change acording to the format of your txt file you import your trip stops
        string init="(";
        string fina=")";
        int distan = 16;
        string timeBefor = ",,,,,,,,";

        
        

        private int coordinateFind(string s,string start,string fini, int dis)
        {
           
            
            if (s.Contains(start) && s.Contains(fini))
            {
                place = s.IndexOf(start);
                fin = s.IndexOf(fini,place +1);
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

        private string coordinateIndexIsolate (string s)
        {
            // additin of slashes to substr in the beggining is important so that we never get the case of coordinateFind(substr) = -1 while we still have ( and ) in our string
            substr = "//"+s;
            iso = "/";
            indx = 0;
            indexes.Clear();
            indexes.Add(-1);
            while (coordinateFind(substr, init, fina, distan) !=-1)
            {
                coordNum = 0;
                ind = coordinateFind(substr,init,fina,distan);
               
                if (ind > -1)
                {
                    indx = ind - 2 + indx;
                    indexes.Add(indx);
                    iso = iso + "/" + indx.ToString() + "/";
                    substr ="//" + substr.Substring(ind + 1);
                    indx = indx + 1;
                    coordNum = coordNum + 1;
                }
                if (ind < -1)
                {
                    substr = "//" + substr.Substring(-ind + 1);
                    //-1=-2+1
                    indx = indx -ind-1;
                }
            }
            iso = iso + "/";
            return iso;
        }
        // subject to change , depends on the format your coordinates are given
        private  string  getLongLat(string  s, int plc)
        {
            LongLat = s.Substring(plc+1, distan - 1);
            return LongLat;
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

                stopsList = File.ReadAllText(@stopsFileName);
                MessageBox.Show(stopsList);
            }
        }




        private void forbiddenButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog3.ShowDialog() == DialogResult.OK)

            {

                forbiddenFileName = openFileDialog3.FileName;

                forbiddenList = File.ReadAllText(@forbiddenFileName);

                tripIndexList = coordinateIndexIsolate(forbiddenList);


                MessageBox.Show(  "      here:   " + tripIndexList + "   there      "  + forbiddenList.Substring(indexes[2]));

                

            }
        }

        private void tripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                tripFileName = openFileDialog1.FileName;

                tripList = File.ReadAllText(@tripFileName);
                MessageBox.Show(tripList);
                coordinateIndexIsolate(tripList);


            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (indexes[0] != -1)
            {
                MessageBox.Show("please import trip coordinates");
            }
            else
            {
                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "unknown.txt";
                // set filters - this can be done in properties as well
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    int i;

                    using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    {
                        sw.WriteLine("Long-Lat");
                        for (i = 2; i < indexes.Count; i = i + 2)
                        {
                            sw.WriteLine(getLongLat(forbiddenList, indexes[i]));
                        }

                    }
                }
            }
        }
    }
}
