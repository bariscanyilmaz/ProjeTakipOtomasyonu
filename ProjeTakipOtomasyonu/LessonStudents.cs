using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Concrete.EfRepository;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
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
    public partial class LessonStudents : Form
    {
        private IStudentRepository studentRepository=new EfStudentRepository();
        private ILessonRepository lessonRepository=new EfLessonRepository();
        public Lesson Lesson { get; set; }
        public LessonStudents()
        {
            InitializeComponent();
        }



        private void btnFilterStudents_Click(object sender, EventArgs e)
        {
            var selectedYear = this.cmbEducationYear.SelectedItem.ToString();
            var selectedPeriod = this.cmbOgretimDurumu.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;

            var students = studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == selectedYear).ToArray();
            this.chcBoxStudentListBox.Items.Clear();
            this.chcBoxStudentListBox.Items.AddRange(students);

        }

        private void LessonStudents_Load(object sender, EventArgs e)
        {
            LoadEducationYear();
        }

        private void LoadEducationYear()
        {
            this.cmbEducationYear.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbEducationYear.SelectedIndex = this.cmbEducationYear.Items.IndexOf(DateTime.Now.Year);
        }

        private void btnGetAllStudents_Click(object sender, EventArgs e)
        {
            var selectedYear = this.cmbEducationYear.SelectedItem.ToString();
            var selectedPeriod = this.cmbOgretimDurumu.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;

            var students= studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == selectedYear).ToArray();
            this.chcBoxStudentListBox.Items.Clear();
            this.chcBoxStudentListBox.Items.AddRange(students);

        }

        private void btnAddAlltoLessonStudents_Click(object sender, EventArgs e)
        {
            this.chcBoxLessonStudentList.Items.Clear();
            foreach (var student in chcBoxStudentListBox.Items)
            {
                this.chcBoxLessonStudentList.Items.Add(student, true);
            } 
        }

        private void btnAddStudentToLessonStudents_Click(object sender, EventArgs e)
        {
            this.chcBoxLessonStudentList.Items.Clear();

            for (int i = 0; i < this.chcBoxStudentListBox.Items.Count; i++)
            {
                var student =(Student) this.chcBoxStudentListBox.Items[i];
                if(this.chcBoxStudentListBox.GetItemChecked(i))
                    this.chcBoxLessonStudentList.Items.Add(student,true);
            }
        }

        private void btnClearLessonStudentList_Click(object sender, EventArgs e)
        {
            this.chcBoxLessonStudentList.Items.Clear();
        }

        private void btnRemoveStudentFromLessonStudentList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.chcBoxLessonStudentList.Items.Count; i++)
            {
                if (!this.chcBoxLessonStudentList.GetItemChecked(i))
                {
                    this.chcBoxLessonStudentList.Items.RemoveAt(i);
                }
                    
            }
        }

        private void btnSaveLessonStudentList_Click(object sender, EventArgs e)
        {

        }

        public void Open(Lesson lesson)
        {
            this.Lesson = lesson;
            this.lblLessonName.Text = lesson.Name;
            this.ShowDialog();
        }
    }
}
