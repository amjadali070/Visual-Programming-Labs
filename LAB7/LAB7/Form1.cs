using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class Form1 : Form
    {
        int count = 0;
        int size = 10;
        StudentClass[] students = new StudentClass[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentClass std = new StudentClass();
            if(txtStudent.Text != "Enter Student Name" && txtStudent.Text.Trim() != "")
            {
                std.FirstName = txtStudent.Text;
                addStudent(std);
                MessageBox.Show("Record Added");
                txtStudent.Text = "Enter Student Name";
                ShowStudents();
                return;
            }
            MessageBox.Show("Not Valid!");

        }
        private void addStudent(StudentClass std)
        {
            if (count != size)
            {
                students[count] = std;
                count++;
                return;
            }
            StudentClass[] stds = new StudentClass[size + 10];
            for (int i = 0; i < count; i++)
            {

                stds[i] = students[i];

            }
            students = stds;
            size += 10;
        }
        private void ShowStudents()
        {
            this.lblStudents.Text = "";
            for (int i = 0; i < count;i++)
            {

                this.lblStudents.Text += students[i].FirstName + "\n";

            }
        }

        private void txtStudent_Enter(object sender, EventArgs e)
        {
            if(txtStudent.Text != "Enter Student Name" && txtStudent.Text.Trim() != "")
            {
                return;
            }
            txtStudent.Text = "";
        }

        private void txtStudent_Leave(object sender, EventArgs e)
        {
            if (txtStudent.Text != "Enter Student Name" && txtStudent.Text.Trim() != "")
            {
                return;
            }
            txtStudent.Text = "Enter Student Name";
        }
    }
}
