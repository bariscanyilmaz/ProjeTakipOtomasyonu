using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Concrete.EfRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakipOtomasyonu
{
    public partial class AddStudentForm : Form
    {
        private IStudentRepository studentRepository = new EfStudentRepository();

        private Student student;
        private bool isUpdate = false;
        
        public AddStudentForm()
        {
            
            InitializeComponent();
        }
        

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            bool isSafe = true;
            var name = txtStudentName.Text;
            var schoolnumber = txtStudentSchoolNumber.Text;
            var projectName = txtStudentProjectName.Text;
            var email = txtStudentEmail.Text;
            var programmingLanguage = txtBoxProgrammingLanguage.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Ad Soyad alanını boş bırakmayınız.");
                isSafe = false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email alanını boş bırakmayınız.");
                isSafe = false;
            }

            if (string.IsNullOrWhiteSpace(schoolnumber))
            {
                MessageBox.Show("Okul numarası alanını boş bırakmayınız.");
                isSafe = false;
            }

            if (string.IsNullOrWhiteSpace(projectName))
            {
                MessageBox.Show("Proje adı alanını boş bırakmayınız.");
                isSafe = false;
            }


            var isFirstTeaching = cmbBoxOgretimDurumu.SelectedIndex;
            if (isFirstTeaching==-1)
            {
                MessageBox.Show("Öğretim durumu alanını boş bırakmayınız.");
                isSafe = false;

            }

            if (string.IsNullOrEmpty(programmingLanguage))
            {
                MessageBox.Show("Programlama dili alanını boş bırakmayınız.");
                isSafe = false;

            }

            if (isSafe)
            {
               

                if (!isUpdate)
                {
                    var student = new Student();
                    student.Period= isFirstTeaching==0?Period.FirstPeriod:Period.SecondPeriod;
                    student.Name = name;
                    student.Year = this.cmbBoxPeriodYear.Text;
                    student.SchoolNumber = schoolnumber;
                    student.ProgrammingLanguage = programmingLanguage;
                    student.Project = projectName;
                    studentRepository.AddStudent(student);

                    MessageBox.Show("Öğrenci Eklendi");
                }
                else
                {
                    student.Period = isFirstTeaching == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                    student.Year = this.cmbBoxPeriodYear.Text;
                    this.student.Name = name;
                    this.student.ProgrammingLanguage = programmingLanguage;
                    this.student.SchoolNumber = schoolnumber;
                    this.student.Project = projectName;

                    studentRepository.UpdateStudent(this.student);
                    MessageBox.Show("Öğrenci Güncellendi");
                }

                this.Close();
            }
    
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            DatePickerSetOnlyYearFormat();
            if (isUpdate)
            {
                txtStudentName.Text = student.Name;
                txtStudentProjectName.Text = student.Project;
                txtStudentSchoolNumber.Text = student.SchoolNumber;
                this.txtStudentEmail.Text = student.Email;
                this.txtBoxProgrammingLanguage.Text = student.ProgrammingLanguage;
                this.cmbBoxOgretimDurumu.SelectedIndex= (student.Period==Period.FirstPeriod?0:1);
                this.cmbBoxPeriodYear.SelectedItem = (Convert.ToInt32(this.student.Year));
            }
        }

        public void OpenInEdit(Student _student)
        {

            this.student = _student;
            this.isUpdate = true;

            this.ShowDialog();
        }

       

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatePickerSetOnlyYearFormat()
        {

            this.cmbBoxPeriodYear.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbBoxPeriodYear.SelectedIndex = this.cmbBoxPeriodYear.Items.IndexOf(DateTime.Now.Year);
        }

        private void cmbBoxPeriodYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxOgretimDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
