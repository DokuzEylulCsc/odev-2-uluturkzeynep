﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyInformationSystem
{
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }
       
        University u = new University();
        private void button1_Click(object sender, EventArgs e)
        {
            u.addFaculty(new Faculty(textBox1.Text, textBox2.Text));
            listBox1.Items.Clear();
            foreach (Faculty faculties in University.getFaculties)
            {
                listBox1.Items.Add(faculties.ToString());
            }
            
            DepartmentForm d = new DepartmentForm();
            d.Show();
        }
        
        private void FacultyForm_Load(object sender, EventArgs e)
        {
           
        
        }
    }
}
