using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class CustomerChild : Form
    {
        public CustomerChild()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            BasicRoom b = new BasicRoom();
            Suite s = new Suite();
            b.FullName = txtFullName.Text;
            b.RoomNumber = int.Parse(txtRoomNumber.Text);
            b.Amenities = txtAmenities.Text;
            s.FullName = txtFullName.Text;
            s.Amenities = txtAmenities.Text;
            s.RoomNumber = int.Parse(txtRoomNumber.Text);
            AddRoomsToListBook(b);
            AddRoomsToListBook(s);
            txtFullName.Clear();
            txtRoomNumber.Clear();
            txtAmenities.Clear();
        }
          

        private void AddRoomsToListBook(Rooms b )
        {
            listBox1.Items.Add(b.FullName + "" + b.RoomNumber + " " + b.Amenities);
        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(txtCustomer.Text + "" + txtRoom.Text);
            
            txtCustomer.Clear();
            txtRoom.Clear();

           
        }
         
        public class Stack 
        {
            public List<int> stackValues;
            public void Push (int val)
            {
                stackValues.Add(val);
            }
            public int Pop()
            {
                if (stackValues.Count <= 0) return -100;

                int tmp = stackValues[stackValues.Count - 1];
                stackValues.RemoveAt(stackValues.Count - 1);
                return tmp;
            }

            public int Peek() 
            {
                if (stackValues.Count <= 0) return -100;

                int tmp = stackValues[stackValues.Count - 1];
                stackValues.RemoveAt(stackValues.Count - 1);
                return tmp;
            }

            public int GetCount()
            {
                return stackValues.Count();
            }

                
            
            
        }

        private void btnPrizeValue_Click(object sender, EventArgs e)
        {
            Stack <int>stack = new Stack<int>();

            stack.Push(100);
            stack.Push(50);
            stack.Push(25);
            stack.Push(15);
            stack.Push(10);
            stack.Push(5);
            MessageBox.Show($"Door prize is {stack.Count}!");
            listBox3.Items.Add(txtPrizeValue.Text + "" + stack);
            while (stack.Count > 0)
            {
                MessageBox.Show($"Door prize is {stack.Count}!");
            }
            stack.Pop();


        }
    }
}
