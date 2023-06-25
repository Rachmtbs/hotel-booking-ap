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
    public partial class ClientChild : Form
    {
        private StreamReader fileReader;
        public ClientChild()
        {
            InitializeComponent();
        }

        private void btnCheckClient_Click(object sender, EventArgs e)
        {
            try
            {
                var path = "output.txt";
                var record = txtName.Text + "," + txtLast.Text + "," + txtNumber.Text + "," + txtReservation.Text;
                if (File.Exists(path))
                {
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(record);
                    sw.Close();
                }
                else 
                {
                    using(StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(record);
                    }
                }

                MessageBox.Show("Client had been added to!" + path);
                txtName.Clear();
                txtLast.Clear();
                txtNumber.Clear();
                txtReservation.Clear();

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
                        btnNext.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Try Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();
                if(inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    txtName.Text = inputFields[0];
                    txtLast.Text = inputFields[1];
                    txtNumber.Text = inputFields[2];
                    txtReservation.Text = inputFields[3];
                   
                }

                else 
                {
                    fileReader.Close();
                    btnOpenFile.Enabled = true;
                    btnNext.Enabled = false; 

                    txtName.Clear();
                    txtLast.Clear();
                    txtNumber.Clear();
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
