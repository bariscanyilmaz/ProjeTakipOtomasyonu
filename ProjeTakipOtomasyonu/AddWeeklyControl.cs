using ProjeTakipOtomasyonu.Dal.Abstract;
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
    public partial class AddWeeklyControl : Form
    {
        private IWeeklyControlRepository weeklyControlRepository = new EfWeeklyControlRepository();
        private WeeklyControl control;
        private Lesson lesson;
        bool isUpdate;

        public AddWeeklyControl()
        {
            InitializeComponent();
        }

        private void btnSaveWeek_Click(object sender, EventArgs e)
        {
            var weekName = txtWeekName.Text;

            if (string.IsNullOrWhiteSpace(weekName))
            {
                MessageBox.Show("Hafta Adını boş bırakmayınız");
            }
            else
            {
                if (!isUpdate)
                {
                    control = new WeeklyControl();
                    control.WeekName = weekName;
                    control.Lessson = lesson;
                    weeklyControlRepository.AddWeeklyControl(control);
                    MessageBox.Show("Kaydedildi");
                }
                else
                {
                    if (control!=null)
                    {
                        control.WeekName = weekName;
                        weeklyControlRepository.UpdateWeeklyControl(control);
                        MessageBox.Show("Güncellendi");
                    }
                }
                
            }


        } 

        public void OpenInEdit(WeeklyControl weeklyControl)
        {
            this.control = weeklyControl;
            this.isUpdate = true;
            txtWeekName.Text = control.WeekName;
            this.btnSaveWeek.Text = "Güncelle";
            this.ShowDialog();
        }

        public void OpenWithLesson(Lesson lesson)
        {
            this.lesson = lesson;
            this.ShowDialog();
        }
    }
}
