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

namespace hotel
{
    public partial class OccupanciesChild : Form
    {
        private StreamReader fileReader;
        public OccupanciesChild()
        {
            InitializeComponent();
        }

        private void btnAddOccupancies_Click(object sender, EventArgs e)
        {
            try 
            {
                var path = "NewOccupany.txt";
                var record = txtCleintId.Text + "," + txtReservation.Text + "," + txtCheckIn.Text + "," + txtCancled.Text;

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
                MessageBox.Show("Occupencies have been updated to NewOccupancy" + path);

                txtCancled.Clear();
                txtCheckIn.Clear();
                txtCleintId.Clear();
                txtReservation.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;
            using (var fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if(result == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("invalid File Name", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        fileReader = new StreamReader(input);
                        btnNextRecord.Enabled = false;
                        btnOpen.Enabled = true;
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();
                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    txtReservation.Text = inputFields[0];
                    txtCleintId.Text = inputFields[1];
                    txtCheckIn.Text = inputFields[2];
                    txtCancled.Text = inputFields[3];
                    
                }

                else
                {
                    fileReader.Close();
                    btnNextRecord.Enabled = true;
                    btnOpen.Enabled = false;

                    txtCleintId.Clear();
                    txtCheckIn.Clear();
                    txtCancled.Clear();
                    txtReservation.Clear();

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
