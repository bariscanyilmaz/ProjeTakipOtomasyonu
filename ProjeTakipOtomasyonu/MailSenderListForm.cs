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
    public partial class MailSenderListForm : Form
    {
        private IStudentRepository studentRepository = new EfStudentRepository();

        private List<Student> filteredStudents = new List<Student>();
        public List<Student> mailListStudents = new List<Student>();
        public event EventHandler SavedMailList;

        protected virtual void OnSavedMailList(EventArgs e)
        {
            SavedMailList?.Invoke(this, e);

        }

        public MailSenderListForm()
        {

            InitializeComponent();
        }

        private void MailSenderListForm_Load(object sender, EventArgs e)
        {
            DatePickerSetOnlyYearFormat();
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            this.filteredStudents = this.studentRepository.GetAll().ToList();
            this.chcBoxStudentListBox.Items.AddRange(filteredStudents.ToArray());
        }

        private void DatePickerSetOnlyYearFormat()
        {

            this.cmbEducationYearOntbPageControl.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbEducationYearOntbPageControl.SelectedIndex = this.cmbEducationYearOntbPageControl.Items.IndexOf(DateTime.Now.Year);
        }

        public void OpenList(ref List<Student> StudenMailList)
        {
            this.ShowDialog();
        }

        private void btnFilterStudentsOntbPageControl_Click(object sender, EventArgs e)
        {
            FilterStudentsOntbPageControl();
        }

        private void FilterStudentsOntbPageControl()
        {

            if (cmbOgretimDurumuOntbPageControl.SelectedIndex == -1)
            {
                MessageBox.Show("Öğretim durumunu seçiniz");
            }
            else
            {
                var selectedPeriod = (Period)cmbOgretimDurumuOntbPageControl.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                var selectedYear = (int)cmbEducationYearOntbPageControl.SelectedItem;
                this.filteredStudents = this.studentRepository.GetAll().Where(st => st.Year == selectedYear.ToString() && st.Period == selectedPeriod).ToList();
                this.chcBoxStudentListBox.Items.Clear();
                this.chcBoxStudentListBox.Items.AddRange(filteredStudents.ToArray());

            }

        }

        private void btnGetAllStudents_Click(object sender, EventArgs e)
        {
            this.filteredStudents = this.studentRepository.GetAll().ToList();
            this.chcBoxStudentListBox.Items.Clear();
            this.chcBoxStudentListBox.Items.AddRange(filteredStudents.ToArray());
        }

        private void btnClearMailSendList_Click(object sender, EventArgs e)
        {
            this.chcBoxMailSendList.Items.Clear();

        }

        private void btnAddAlltoMailSendList_Click(object sender, EventArgs e)
        {

            this.chcBoxMailSendList.Items.Clear();
            foreach (Student student in this.chcBoxStudentListBox.Items)
            {
                this.chcBoxMailSendList.Items.Add(student,true);
            } 

        }

        private void btnRemoveStudentFromMailSendList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chcBoxMailSendList.Items.Count; i++)
            {
                if (!chcBoxMailSendList.GetItemChecked(i))
                {
                    chcBoxMailSendList.Items.Remove(chcBoxMailSendList.Items[i]);
                }
            }
        }

        private void btnAddStudentToMailSendList_Click(object sender, EventArgs e)
        {
            var checkedStudents = new List<Student>();
            for (int i = 0; i < chcBoxStudentListBox.Items.Count; i++)
            {
                if (chcBoxStudentListBox.GetItemChecked(i))
                {
                    var student= (Student)chcBoxStudentListBox.Items[i];
                    checkedStudents.Add(student);
                }
            }

            this.chcBoxMailSendList.Items.Clear();
            foreach (var item in checkedStudents)
            {
                this.chcBoxMailSendList.Items.Add(item, true);
            }
            
        }

        private void btnSaveMailSendList_Click(object sender, EventArgs e)
        {
            foreach (Student item in this.chcBoxMailSendList.Items)
            {
                mailListStudents.Add(item);
            }
                
            OnSavedMailList(null);
            this.Close();
        }
    }
}
