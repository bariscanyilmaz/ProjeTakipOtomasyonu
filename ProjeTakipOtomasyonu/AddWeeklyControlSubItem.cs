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
    public partial class AddWeeklyControlSubItem : Form
    {
        private IStudentRepository studentRepository = new EfStudentRepository();
        private IWeeklySubItemRepository weeklySubItemRepository = new EfWeeklyControlSubItemRepository();
        

        public AddWeeklyControlSubItem()
        {
            InitializeComponent();
        }

        private void AddWeeklyControl_Load(object sender, EventArgs e)
        {
            //txtWeeklyControlName.Text = weeklyControl.WeekName;
            
            var items = checkedListBox1.Items;
            var isFirst = chcBoxFirstTeaching.Checked;

            var studentList = studentRepository.GetAll().Where(s=>s.Period==Period.FirstPeriod).ToList();

            foreach (var student in studentList)
            {
                items.Add(student);
            }
            
        }

        private void btnSaveWeeklyControl_Click(object sender, EventArgs e)
        {
            WeeklyControl weeklyControl = new WeeklyControl();
            weeklyControl.WeekName = txtWeeklyControlName.Text;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState checkState = checkedListBox1.GetItemCheckState(i);
                var student = checkedListBox1.Items[i];
                var subItem = new WeeklyControlSubItem();

                subItem.Student = (Student)student;
                subItem.WeeklyControl = weeklyControl;
                

                if (checkState == CheckState.Checked)
                {  
                    subItem.IsControl = true;
                }
                else
                {
                    subItem.IsControl = false;
                }
                weeklySubItemRepository.AddWeeklyControlSubItem(subItem);

            }

            MessageBox.Show("Kaydedildi");

        }

        public void OpenWithWeeklyControl(WeeklyControl control)
        {
            
        }

    }
}
