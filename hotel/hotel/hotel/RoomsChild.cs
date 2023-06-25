using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace hotel
{
    public partial class RoomsChild : Form
    {
        private StreamReader fileReader;
        public RoomsChild()
        {
            InitializeComponent();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            try 
            {
                var path = "Rooms.txt";
                var record = txtAvailable.Text + "," + txtBalconey.Text + "," + txtSuites + "," + txtTotal.Text + "," +txtBeingRepaired.Text +"," + txtNeedRepair.Text;
                if (File.Exists(path))
                {
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(record);
                    sw.Close();
                }
                else 
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(record);
                    }
                    
                }

                MessageBox.Show("Rooms have been added to!" + path);
                txtAvailable.Clear();
                txtBalconey.Clear();
                txtSuites.Clear();
                txtTotal.Clear();
                txtNeedRepair.Clear();
                txtBeingRepaired.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("invalid File Name", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else 
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        fileReader = new StreamReader(input);
                        btnOpenFile.Enabled = false;
                        btnNextFile.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void btnNextFile_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();
                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    txtAvailable.Text = inputFields[0];
                    txtTotal.Text = inputFields[1];
                    txtBalconey.Text = inputFields[2];
                    txtSuites.Text = inputFields[3];
                    txtNeedRepair.Text = inputFields[4];
                    txtBeingRepaired.Text = inputFields[5];
                }

                else
                {
                    fileReader.Close();
                    btnOpenFile.Enabled = true;
                    btnNextFile.Enabled = false;

                    txtAvailable.Clear();
                    txtBalconey.Clear();
                    txtBeingRepaired.Clear();
                    txtTotal.Clear();
                    txtSuites.Clear();
                    txtNeedRepair.Clear();

                    MessageBox.Show("Records complete:");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
