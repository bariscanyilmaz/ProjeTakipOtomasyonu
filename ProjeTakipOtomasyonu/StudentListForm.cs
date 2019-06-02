using Microsoft.Office.Interop.Excel;
using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Concrete.EfRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakipOtomasyonu
{
    public partial class StudentListForm : Form
    {
        private IStudentRepository studentRepository = new EfStudentRepository();
        private string filePath;
        private List<Student> students = new List<Student>();

        public StudentListForm()
        {
           
            InitializeComponent();
        }

        private void DatePickerSetOnlyYearFormat()
        {
            
            this.cmbBoxPeriodYear.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbBoxPeriodYear.SelectedIndex = this.cmbBoxPeriodYear.Items.IndexOf(DateTime.Now.Year);
        }

        private void SelectFile()
        {
            this.openFileDialog1 = new OpenFileDialog();
            this.openFileDialog1.Filter= "Excel Files|*.xls;*.xlsx;*.xlsm";


            this.openFileDialog1.FilterIndex = 1;
            this.openFileDialog1.Multiselect = false;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = this.openFileDialog1.FileName;
                var fileNameArr= this.filePath.Split('\\');
                this.label1.Text = fileNameArr[fileNameArr.Length-1];
            }
        }


        private void StudentListForm_Load(object sender, EventArgs e)
        {
            DatePickerSetOnlyYearFormat();
        }

        private void chcIsFirstTeaching_CheckedChanged(object sender, EventArgs e)
        {
            //var isFirstTeaching = chcIsFirstTeaching.Checked;
            //var studentList = studentRepository.GetAll().Where(c => c.IsFirstTeaching == isFirstTeaching).ToList();
            //listBoxStudent.DataSource = studentList;
        }

        private void txtNameOrNumber_TextChanged(object sender, EventArgs e)
        {

            //listBoxStudent.DataSource = null;
            //var queryText = txtNameOrNumber.Text;
            //var studentList = studentRepository.GetAll().Where(s => s.Name.Contains(queryText) || s.SchoolNumber.Contains(queryText)).ToList();
            //listBoxStudent.DataSource = studentList;

        }

        private void listBoxStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var student = (listBoxStudent.SelectedItem);
            //var studentAddForm = new AddStudentForm();
            //studentAddForm.OpenInEdit((Student)student);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listBoxStudent.DataSource = null;
            //var isFirstTeaching = chcIsFirstTeaching.Checked;
            //var studentList = studentRepository.GetAll().Where(c => c.IsFirstTeaching == isFirstTeaching).ToList();
            //listBoxStudent.DataSource = studentList;
        }

        private void btnStudentSrc_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void AddStudentsFromExcel()
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            var xlWorkBook = xlApp.Workbooks.Open(this.filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            var xlWorkSheet = (Worksheet)xlWorkBook.Sheets[1];

            Range xlRange = xlWorkSheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                var student = new Student();

                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                    {
                        student.SchoolNumber = xlRange.Cells[i, j].Value2.ToString();
                    }
                    else if (j == 2)
                    {
                        student.Name = xlRange.Cells[i, j].Value2.ToString();
                    }
                    else if (j == 3)
                    {
                        student.Project = xlRange.Cells[i, j].Value2.ToString();
                    }
                    else if (j == 4)
                    {
                        student.Project = xlRange.Cells[i, j].Value2.ToString();
                    }
                }

                this.students.Add(student);
            }
            this.listBox1.DataSource = students;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorkSheet);

            //close and release
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show($"Kayıtlar {this.label1.Text} dosyasından aktarıldı.");
            // studentAddForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (this.filePath!=null)
            {
                AddStudentsFromExcel();
            }
            else
            {
                MessageBox.Show("Dosya kaynağı daha seçilmedi");
            }

            if (students.Count>0)
            {
                this.btnSaveStudents.Enabled = true;
            }

        }

        private void btnSaveStudents_Click(object sender, EventArgs e)
        {
            

            if (this.comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Öğretim Durumunu seçiniz.");
            }
            else
            {
                MessageBox.Show(this.comboBox1.SelectedIndex.ToString());

                foreach (var student in students)
                {
                    student.Year = this.cmbBoxPeriodYear.Text;
                    student.Period = this.comboBox1.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                    student.Email = student.SchoolNumber + "@ogr.uludag.edu.tr";
                    studentRepository.AddStudent(student);
                }
            }
        }
    }
}
