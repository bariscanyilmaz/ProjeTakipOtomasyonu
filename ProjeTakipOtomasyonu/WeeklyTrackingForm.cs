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
    public partial class WeeklyTrackingForm : Form
    {
        private IWeeklyControlRepository weeklyControlRepository = new EfWeeklyControlRepository();
        private WeeklyControl selectedWeek;
        public WeeklyTrackingForm()
        {
            InitializeComponent();
        }

        private void listBoxWeek_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedWeek =(WeeklyControl)listBoxWeek.SelectedItem;
            var addWeeklycontrolsubitem = new AddWeeklyControlSubItem();
            addWeeklycontrolsubitem.OpenWithWeeklyControl(selectedWeek);
        }

        private void btnAddKontrolHafta_Click(object sender, EventArgs e)
        {
            var addWeeklycontrolsubitem = new AddWeeklyControlSubItem();
            addWeeklycontrolsubitem.ShowDialog();


        }

        private void WeeklyTrackingForm_Load(object sender, EventArgs e)
        {
            var controlList= weeklyControlRepository.GetAll().ToList();
            if (controlList.Count > 0)
            {
                listBoxWeek.DataSource = controlList;
            }
            
        }

        private void listBoxWeek_SelectedValueChanged(object sender, EventArgs e)
        {
            chcListBoxSubItems.Items.Clear();
            var item = (WeeklyControl)listBoxWeek.SelectedItem;
            if (item.WeeklyControlSubItem != null)
            {
                foreach (var subItem in item.WeeklyControlSubItem)
                {
                    chcListBoxSubItems.Items.Add(subItem,subItem.IsControl);
                }
            }
            
        }
    }
}
