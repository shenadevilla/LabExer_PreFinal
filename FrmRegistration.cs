using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile_DEVILLA
{
    public partial class FrmRegistration : Form
    {
        public static string SetStudentNo;
        public static string SetFileName;
        public static string SetLastname;
        public static string SetAge;
        public static string SetContactNo;
        public static string SetMI;
        public static string SetProgram;
        public static string SetGender;
        public static string SetDateTimePicker;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getInput0= txtStudentNo.Text;
            string getInput1= txtFileName.Text;
            string getInput2= txtLastName.Text;
            string getInput3= txtAge.Text;
            string getInput4= txtContactNo.Text;
            string getInput5 = txtMI.Text;
            string getInput6 = cbProgram.Text;
            string getInput7 = cbGender.Text;
            string getInput8 = datetimepicker.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput0 + ".txt")))
            {
                outputFile.WriteLine("Student No.: " +  getInput0);
                Console.WriteLine(getInput0);
                outputFile.WriteLine("File Name: " +  getInput1);
                Console.WriteLine(getInput1);
                outputFile.WriteLine("Last Name: " + getInput2);
                Console.WriteLine(getInput2);
                outputFile.WriteLine("Age: " + getInput3);
                Console.WriteLine(getInput3);
                outputFile.WriteLine("Contact N0.: " + getInput4);
                Console.WriteLine(getInput4);
                outputFile.WriteLine("M.I.: " + getInput5);
                Console.WriteLine(getInput5);
                outputFile.WriteLine("Program: " + getInput6);
                Console.WriteLine(getInput6);
                outputFile.WriteLine("gender: " + getInput7);
                Console.WriteLine(getInput7);
                outputFile.WriteLine("Date Time Picker: " + getInput8);
                Console.WriteLine(getInput8);

                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
