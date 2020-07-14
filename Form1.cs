using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nameFile, pathFile;
        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listFile.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                nameFile = file.FileName;
                pathFile = file.Path;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Multiselect = true, ValidateNames = true, Filter = "MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                        
                    }
                    listFile.DataSource = files;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
            cbMain.Items.Add("Static");
            cbMain.Items.Add("Pan");
            cbMain.Items.Add("Tilt");
            cbMain.Items.Add("Dolly");
            cbMain.Items.Add("Truck");
            cbMain.Items.Add("Pedestal");
            cbMain.Items.Add("Zoom");
            cbMain.Items.Add("Roll");
            cbSub1.Enabled = false;
            cbSub2.Enabled = false;
            cbSub3.Enabled = false;
            cbSub4.Enabled = false;
            cbSub5.Enabled = false;
            cbSub6.Enabled = false;
        }

        private void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSub1.Items.Clear();
            cbSub2.Items.Clear();
            cbSub3.Items.Clear();
            cbSub4.Items.Clear();
            cbSub5.Items.Clear();
            cbSub6.Items.Clear();
            cbSub1.Enabled = true;
            cbSub2.Enabled = true;
            cbSub3.Enabled = true;
            cbSub4.Enabled = true;
            cbSub5.Enabled = true;
            cbSub6.Enabled = true;
            if (cbMain.SelectedItem.ToString() == "Static")
            {
                cbSub1.Items.Add("Handheld");
                cbSub1.Items.Add("Tripod");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("InCar");
                cbSub3.Items.Add("CarRig");
                cbSub3.Items.Add("");
                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem.ToString() == "Pan")
            {
                cbSub1.Items.Add("LeftToRight");
                cbSub1.Items.Add("RightToLeft");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithTruck");
                cbSub4.Items.Add("WithDolly");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("Tripod");
                cbSub6.Items.Add("");

                cbSub6.Items.Add("Parallax");
                cbSub6.Items.Add("Diagonal");
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem.ToString() == "Tilt")
            {
                cbSub1.Items.Add("Up");
                cbSub1.Items.Add("Down");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithDolly");
                cbSub4.Items.Add("WithPedestal");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("Tripod");
                cbSub5.Items.Add("");

                cbSub6.Items.Add("Diagonal");
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem.ToString() == "Dolly")
            {
                cbSub1.Items.Add("Forwards");
                cbSub1.Items.Add("Backwards");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithPan");
                cbSub4.Items.Add("WithTilt");
                cbSub4.Items.Add("Car-rig");
                cbSub4.Items.Add("In-car");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Gimbal");
                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("");
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem.ToString() == "Truck")
            {
                cbSub1.Items.Add("LeftToRight");
                cbSub1.Items.Add("RightToLeft");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithPan");
                cbSub4.Items.Add("InCar");
                cbSub4.Items.Add("CarRig");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Gimbal");
                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("");

                cbSub6.Items.Add("Parallax");
            }
            if (cbMain.SelectedItem.ToString() == "Pedestal")
            {
                cbSub1.Items.Add("Up");
                cbSub1.Items.Add("Down");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithTilt");
                cbSub4.Items.Add("");

                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem.ToString() == "Zoom")
            {
                cbSub1.Items.Add("In");
                cbSub1.Items.Add("Out");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");


                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem.ToString() == "Roll")
            {
                cbSub1.Items.Add("Clockwise");
                cbSub1.Items.Add("Counter-Clockwise");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");
                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string output;
            if (txtDrive.Text != string.Empty)
            {
                output = txtDrive.Text + ":/My Drive/VideoByCategory/";
            }
            else
            {
                output = "C:/video/";
            }
            String filePath = pathFile;
            
            string nameFileNew = cbMain.Text+"_" + cbSub1.Text + "_" + cbSub2.Text + "_" + cbSub3.Text + "_" + cbSub4.Text + "_" + cbSub5.Text + "_" + cbSub6.Text + "_"+nameFile+".mp4";

            bool exist = Directory.Exists(output + cbMain.SelectedItem.ToString());
            if (!exist)
            {
                Directory.CreateDirectory(output + cbMain.SelectedItem.ToString());
            }
            if (File.Exists(filePath))
            {
                string newFilename = output+cbMain.SelectedItem.ToString()+"/"+nameFileNew;
                if (newFilename != String.Empty)
                {
                    File.Move(filePath, newFilename);
                    cbSub1.Items.Clear();
                    cbSub2.Items.Clear();
                    cbSub3.Items.Clear();
                    cbSub4.Items.Clear();
                    cbSub5.Items.Clear();
                    cbSub6.Items.Clear();
                    //cbMain.Items.Clear();
                }
            }
        }
    }
}
