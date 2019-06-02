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
    public partial class AddNoteForm : Form
    {
        private EfWeeklyControlSubItemRepository subItemRepository  = new EfWeeklyControlSubItemRepository();

        public WeeklyControlSubItem WeeklyControlSubItem { get; set; }

        public void Open( WeeklyControlSubItem weeklyControlSubItem)
        {
            WeeklyControlSubItem = weeklyControlSubItem;
            this.txtStudentInfo.Text = weeklyControlSubItem.Student.ToString();
            this.rchBoxContentNewNote.Text = weeklyControlSubItem.Note;
            this.ShowDialog();
        }

        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void btnSaveNewNote_Click(object sender, EventArgs e)
        {
            var content = rchBoxContentNewNote.Text;
            WeeklyControlSubItem.Note = content;
            subItemRepository.UpdateWeeklyControlSubItem(WeeklyControlSubItem);
            MessageBox.Show("Not kkaydedildi");
            this.Close();
        }
    }
}
