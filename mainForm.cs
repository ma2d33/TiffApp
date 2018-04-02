using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using BitMiracle.LibTiff.Classic;
using System.IO;

namespace TiffApp_02
{
    public partial class mainForm : Form
    {

        public string path = "";
        
        public string  image_width = "";
        public string  image_height = "";

        public bool saveAllFlag = false;
        public bool skipAllFlag = false;

        public string export_path = @"C:\converterTifs\";

        public static string[] folderFiles;
        public int tagcount = 0;
        public string[] showtags = { "IMAGEWIDTH", "IMAGELENGTH", "COMPRESSION", "PHOTOMETRIC", "XRESOLUTION",
                                        "YRESOLUTION", "SOFTWARE","DATETIME" };

        public class TagInfo
        {
            public String tagName { get; set; }
            public String Value { get; set; }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
          
        }

        public void tiffslist()
        {
            int q = 0;
            foreach (string str in mainForm.folderFiles) // for folderFile see open folder
            {
                
                    DataGridViewRow row = (DataGridViewRow)tiffgridview.Rows[q].Clone();
                    row.Cells[0].Value = str;
                    row.Cells[1].Value = str.Remove(0, path.Length + 1);

                    tiffgridview.Rows.Add(row);
                
                
               
                    q++;
                
                
                logBox.AppendText(str+"\n");

                Dictionary<string, string> tiffTags = GetTiffTagsFromFile(str, true);
                if(tiffTags == null)
                {
                    continue;
                }
                foreach(string tagName in tiffTags.Keys)
                {
                    logBox.AppendText(tagName + ":  ");
                    logBox.AppendText(tiffTags[tagName]+"\n");
                }


                for (int i=30; i>0; i--)
                {
                    logBox.AppendText("#");
                }
                logBox.AppendText("\n");

            }
            
            //MessageBox.Show(q.ToString());
            
            
        }

        public Dictionary<string, string> GetTiffTagsFromFile(string filepath, bool showAll)
        {
            Dictionary<string, string> returnList = new Dictionary<string, string>();

            using (Tiff image = Tiff.Open(filepath, "r"))
            {
                if (image == null)
                {
                    logBox.AppendText("wrong file format"+"\n");
                    for (int i = 30; i > 0; i--)
                    {
                        logBox.AppendText("#");
                    }
                    logBox.AppendText("\n");

                    return null;
                }
                short numberofdirs = image.NumberOfDirectories();

                for (short d = 0; d < numberofdirs; ++d)
                {
                    image.SetDirectory((short)d);
                    //Debug.WriteLine(DateTime.Now.Ticks);
                    for (ushort t = ushort.MinValue; t < ushort.MaxValue; ++t)
                    {
                        TiffTag tag = (TiffTag)t;
                        
                        


                        FieldValue[] value = image.GetField(tag);
                        if (value != null)
                        {
                            if (!showAll && !showtags.Contains(tag.ToString())) {
                                continue;
                            }
                            for (int j = 0; j < value.Length; j++)
                            {
                                /*
                                if (returnList.ContainsKey(tagName)) {
                                    break;
                                }
                                */
                                try
                                {
                                    returnList.Add(tag.ToString(), value[j].ToString());
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                    }
                  //  Debug.WriteLine(DateTime.Now.Ticks);
                }
            }
            return returnList;
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            taggridview.Rows.Clear();
            allTagsGrid.Rows.Clear();
            
            if (tiffgridview.CurrentRow.Cells[0].Value != null)
            {
                string s = tiffgridview.CurrentRow.Cells[0].Value.ToString();

                Dictionary<string, string> tiffTags = GetTiffTagsFromFile(s, false);

                if (tiffTags == null)
                {
                    return;
                }

                foreach (string tagName in tiffTags.Keys)
                {
                    // compare tags with massive "show tags"
                    DataGridViewRow r = (DataGridViewRow)taggridview.Rows[taggridview.RowCount - 1].Clone();
                    r.Cells[0].Value = tagName;

                    r.Cells[1].Value = tiffTags[tagName];

                    taggridview.Rows.Add(r);
                       
                     
                                    
                }
                string str = tiffgridview.Rows[2].Cells[1].Value.ToString();
                int i = str.Length - 4;
                Debug.WriteLine(str.Substring(0,i));

                Dictionary<string, string> allTiffTags = GetTiffTagsFromFile(s, true);
                if (allTiffTags == null)
                {
                    return;
                }
                foreach (string tagName in allTiffTags.Keys)
                {
                    DataGridViewRow r = (DataGridViewRow)allTagsGrid.Rows[allTagsGrid.RowCount - 1].Clone();
                    r.Cells[0].Value = tagName;
                    r.Cells[1].Value = allTiffTags[tagName];
                    allTagsGrid.Rows.Add(r);
                }

            }

            
                
             
            

        }

        
       


        private void browsefilebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = browsetiffsdial.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                path = browsetiffsdial.SelectedPath.ToString();
                folderFiles = Directory.GetFiles(path,"*.tif");
                pathLable.Text = path;
                if (folderFiles.Length == 0 )
                {
                    MessageBox.Show("В этой папке нет файлов с расширением TIF");
                }
                else { 
                tiffslist();
                }
            }
        }

        private void taggridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            saveAllFlag = false;
            skipAllFlag = false;

           DialogResult dialog =  browsetiffsdial.ShowDialog();
           
            
            if (dialog == DialogResult.OK)
            {
                export_path = browsetiffsdial.SelectedPath.ToString();
                foreach (DataGridViewRow r in tiffgridview.SelectedRows)
                {

                    if(r.Cells[0].Value == null)
                    {
                        break;
                    }

                    string s = r.Cells[0].Value.ToString();

                    Dictionary<string, string> tiffTags = GetTiffTagsFromFile(s, false);
                    if (tiffTags == null)
                    {
                        return;
                    }

                    foreach (string tagName in tiffTags.Keys)
                    {
                        if (tagName == "IMAGEWIDTH")
                        {
                            image_width = tiffTags[tagName];
                        }
                        if (tagName == "IMAGELENGTH")
                        {
                            image_height = tiffTags[tagName];
                        }

                    }


                    string filename = r.Cells[1].Value.ToString();
                    string values = "_____" + (float.Parse(image_width) * 2.54).ToString() + "_" +
                                    (float.Parse(image_height) * 2.54).ToString() + "_";

                    if (File.Exists(export_path + "\\" + values + "__" + filename))
                    {

                        if (saveAllFlag != false)
                        {
                            File.Copy(s, export_path + "\\" + values + "__" + filename, true);

                            logBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "\n");
                            logBox.AppendText(export_path + "\\" + values + filename + "\n");
                            continue;
                        }
                        else if (skipAllFlag != false)
                        {
                            continue;
                        }
                        else
                        {

                            Form saveForm = new save_dialog_form();
                            var resoult = saveForm.ShowDialog();


                            if (resoult == DialogResult.OK)
                            {
                                MessageBox.Show("you pressed yes");
                                File.Copy(s, export_path + "\\" + values + "__" + filename, true);

                                logBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "\n");
                                logBox.AppendText(export_path + "\\" + values + filename + "\n");
                            }
                            else if (resoult == DialogResult.Yes)
                            {
                                File.Copy(s, export_path + "\\" + values + "__" + filename, true);

                                logBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "\n");
                                logBox.AppendText(export_path + "\\" + values + filename + "\n");
                                saveAllFlag = true;

                            }
                            else if (resoult == DialogResult.No)
                            {
                                MessageBox.Show("you pressed no");
                                continue;
                            }
                            else if (resoult == DialogResult.Cancel)
                            {
                                skipAllFlag = true;
                                continue;
                            }
                            saveForm.Dispose();
                        }

                        /*var result =  MessageBox.Show("File exists. Rewrite?", "FileExists", MessageBoxButtons.YesNoCancel);
                          if(result == DialogResult.Yes)
                          {
                              File.Copy(s, export_path + "\\" + values + "__" + filename, true);
                          }
                          else if ( result == DialogResult.No)
                          {
                              continue;
                          }
                          else if ( result == DialogResult.Cancel)
                          {
                              break;
                          } */
                    }
                    else
                    {


                        File.Copy(s, export_path+"\\" + values + "__" + filename, true);
                        logBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "\n");
                        logBox.AppendText(export_path + "\\" + values + filename + "\n");

                        //  File.SetAttributes(export_path, FileAttributes.Normal);
                    }

                }

                

            }
            
            
            
        }

      

        private void logPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
