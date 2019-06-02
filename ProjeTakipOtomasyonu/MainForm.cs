using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Concrete.EfRepository;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjeTakipOtomasyonu.Models;

namespace ProjeTakipOtomasyonu
{
    public partial class MainForm : Form
    {
        private INoteRepository noteRepository = new EfNoteRepository();
        private IStudentRepository studentRepository = new EfStudentRepository();
        private IWeeklyControlRepository weeklyControlRepository = new EfWeeklyControlRepository();
        private IWeeklySubItemRepository weeklyControlSubItemRepository = new EfWeeklyControlSubItemRepository();
        private ILessonRepository lessonRepository = new EfLessonRepository();
        private IScoreRepository scoreRepository = new EfScoreRepository();
        private List<Student> MailSendList = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        //private void btnWeeklyTracking_Click(object sender, EventArgs e)
        //{
        //    WeeklyTrackingForm weeklyTrackingForm = new WeeklyTrackingForm();
        //    weeklyTrackingForm.Show();
        //}

        //private void btnSendMail_Click(object sender, EventArgs e)
        //{
        //    MailSenderForm mailSenderForm = new MailSenderForm();
        //    mailSenderForm.Show();
        //}

        //private void btnAddNote_Click(object sender, EventArgs e)
        //{
        //    AddNoteForm addNoteForm = new AddNoteForm();
        //    addNoteForm.Show();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            DatePickerSetOnlyYearFormat();
            SetVizeFinalScore();
            LoadLessons();
            //AddWeeksToReport();
        }

        private void LoadLessons()
        {
            this.lstBoxLessonsOntbPageLesson.DataSource = null;
            this.lstBoxLessonsOntbPageLesson.DataSource = GetLessons();

            this.cmbLessonsOntbPageScore.SelectedIndex = -1;
            this.cmbLessonsOntbPageScore.DataSource = null;
            this.cmbLessonsOntbPageScore.DataSource = GetLessons();
        }

        private void SetVizeFinalScore()
        {

            this.cmbBoxVize.DataSource = Enumerable.Range(0, 100).ToList();
            this.cmbBoxFinal.DataSource = Enumerable.Range(0, 100).ToList();

        }

        private void dtPickerCurrentNotesTime_ValueChanged(object sender, EventArgs e)
        {
            //var dtVal = dtPickerCurrentNotesTime.Value;
            //var conditionDate = new DateTime(dtVal.Year, dtVal.Month, dtVal.Day);
            //var note = noteRepository.GetAll().FirstOrDefault(n => n.DateTime == conditionDate);
            //if (note != null)
            //{
            //    txtNote.Text = note.Content;
            //}
        }

        private void btnReadDataFromExcel_Click(object sender, EventArgs e)
        {
            var studentListForm = new StudentListForm();
            studentListForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void listBoxStudent_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxStudent.SelectedItem != null)
            {
                var addStudentForm = new AddStudentForm();
                var student = (Student)listBoxStudent.SelectedItem;
                addStudentForm.OpenInEdit(student);

            }
        }

        private void trckBarVizeFinalAgirlik_ValueChanged(object sender, EventArgs e)
        {


            this.txtBoxVizeRateOntbPageNote.Text = this.trckBarVizeFinalAgirlik.Value.ToString();
            var finalAgirlik = (this.trckBarVizeFinalAgirlik.Maximum - this.trckBarVizeFinalAgirlik.Value);
            this.txtBoxFinalRateOntbPageNote.Text = finalAgirlik.ToString();

        }

        private void btnStudentFilter_Click(object sender, EventArgs e)
        {
            var period = this.cmbOgretimDurumuOntbPageNote.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedYear = this.cmbBoxPreiodYearOntbPageNote.SelectedItem.ToString();
            this.lstBoxStudentOntbPageNote.DataSource = this.studentRepository.GetAll().Where(s => s.Period == period && s.Year == selectedYear).ToList();

            this.cmbBoxVize.SelectedItem = 0;
            this.cmbBoxFinal.SelectedItem = 0;

            this.txtBoxVizeRateOntbPageNote.Text = "0";
            this.txtBoxFinalRateOntbPageNote.Text = "0";
            this.trckBarVizeFinalAgirlik.Value = 0;
            this.txtBoxPuan.Text = "0";

        }

        private void DatePickerSetOnlyYearFormat()
        {

            this.cmbBoxPeriodYearOntbPageStudent.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbBoxPeriodYearOntbPageStudent.SelectedIndex = this.cmbBoxPeriodYearOntbPageStudent.Items.IndexOf(DateTime.Now.Year);


            this.cmbBoxPreiodYearOntbPageNote.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbBoxPreiodYearOntbPageNote.SelectedIndex = this.cmbBoxPreiodYearOntbPageNote.Items.IndexOf(DateTime.Now.Year);

            this.cmbEducationYearOntbPageControl.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbEducationYearOntbPageControl.SelectedIndex = this.cmbEducationYearOntbPageControl.Items.IndexOf(DateTime.Now.Year);

            this.cmbBoxOgretimYiliOntbPageRapor.DataSource = Enumerable.Range(1950, 100).ToList();
            this.cmbBoxOgretimYiliOntbPageRapor.SelectedIndex = this.cmbBoxOgretimYiliOntbPageRapor.Items.IndexOf(DateTime.Now.Year);
        }

        private void btnCalculateScore_Click(object sender, EventArgs e)
        {
            var finalRate = Convert.ToInt32(this.txtBoxFinalRateOntbPageNote.Text);
            var vizeRate = Convert.ToInt32(this.txtBoxVizeRateOntbPageNote.Text);

            var finalScore = (int)(((int)this.cmbBoxFinal.SelectedValue * (finalRate)) / 100);
            var vizeScore = (int)(((int)this.cmbBoxVize.SelectedValue * (vizeRate)) / 100);

            this.txtBoxPuan.Text = (finalScore + vizeScore).ToString();

        }

        private void btnFilterOntbPageStudent_Click(object sender, EventArgs e)
        {
            var period = this.cmbBoxEgitimDurumOntbPageStudent.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedYear = this.cmbBoxPeriodYearOntbPageStudent.SelectedItem.ToString();
            this.listBoxStudent.DataSource = this.studentRepository.GetAll().Where(s => s.Period == period && s.Year == selectedYear).ToList();

        }

        private void lstBoxStudentOntbPageNote_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedStudent = (Student)this.lstBoxStudentOntbPageNote.SelectedItem;
            var selectedLesson = (Lesson)this.cmbLessonsOntbPageScore.SelectedItem;

            if (selectedStudent != null)
            {
                if (selectedLesson != null)
                {
                    var result = scoreRepository.GetAll().Where(s => s.Lesson.Id == selectedLesson.Id && s.Student.Id == selectedStudent.Id);
                    var lessonScore = result.Count() > 0 ? result.FirstOrDefault() : null;
                    if (lessonScore != null)
                    {
                        this.txtBoxFinalRateOntbPageNote.Text = lessonScore.FinalRate.ToString();
                        this.txtBoxVizeRateOntbPageNote.Text = lessonScore.VizeRate.ToString();

                        this.trckBarVizeFinalAgirlik.Value = lessonScore.VizeRate;
                        this.txtBoxPuan.Text = lessonScore.TotalScore.ToString();

                        cmbBoxFinal.SelectedIndex = cmbBoxFinal.Items.IndexOf(lessonScore.FinalScore);
                        cmbBoxVize.SelectedIndex = cmbBoxVize.Items.IndexOf(lessonScore.VizeScore);
                    }
                    else
                    {
                        this.txtBoxFinalRateOntbPageNote.Text = "";
                        this.txtBoxVizeRateOntbPageNote.Text = "";

                        this.trckBarVizeFinalAgirlik.Value = 0;
                        this.txtBoxPuan.Text = "";

                        cmbBoxFinal.SelectedIndex = -1;
                        cmbBoxVize.SelectedIndex = -1;
                    }

                }

            }

        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            var student = (Student)this.lstBoxStudentOntbPageNote.SelectedItem;
            var selectedLesson = (Lesson)this.cmbLessonsOntbPageScore.SelectedItem;
            var lessonScore = scoreRepository.GetAll().FirstOrDefault(s => s.Lesson.Id == selectedLesson.Id && s.Student.Id == student.Id);

            if (lessonScore != null)
            {

                lessonScore.TotalScore = Convert.ToInt32(txtBoxPuan.Text);
                lessonScore.FinalScore = Convert.ToInt32(cmbBoxFinal.SelectedValue);
                lessonScore.VizeScore = Convert.ToInt32(cmbBoxVize.SelectedValue);

                lessonScore.FinalRate = Convert.ToInt32(txtBoxFinalRateOntbPageNote.Text);
                lessonScore.VizeRate = Convert.ToInt32(txtBoxVizeRateOntbPageNote.Text);

                scoreRepository.UpdateScore(lessonScore);
            }
            else
            {
                var newLessonScore = new Score();
                newLessonScore.Student = student;
                newLessonScore.Lesson = selectedLesson;

                newLessonScore.TotalScore = Convert.ToInt32(txtBoxPuan.Text);
                newLessonScore.FinalScore = Convert.ToInt32(cmbBoxFinal.SelectedValue);
                newLessonScore.VizeScore = Convert.ToInt32(cmbBoxVize.SelectedValue);

                newLessonScore.FinalRate = Convert.ToInt32(txtBoxFinalRateOntbPageNote.Text);
                newLessonScore.VizeRate = Convert.ToInt32(txtBoxVizeRateOntbPageNote.Text);

                scoreRepository.AddScore(newLessonScore);
            }
            student.VizeScore = (int)this.cmbBoxVize.SelectedValue;
            student.FinalScore = (int)this.cmbBoxFinal.SelectedValue;

            student.VizeRate = Convert.ToInt32(this.txtBoxVizeRateOntbPageNote.Text);
            student.FinalRate = Convert.ToInt32(this.txtBoxFinalRateOntbPageNote.Text);
            student.TotalScore = Convert.ToInt32(this.txtBoxPuan.Text);
            MessageBox.Show("Öğrenci notu güncellendi");
        }

        private void txtStudentNameOrNumberOntbPageNote_TextChanged(object sender, EventArgs e)
        {
            var query = this.txtStudentNameOrNumberOntbPageNote.Text;
            var period = cmbOgretimDurumuOntbPageNote.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var year = (int)cmbBoxPreiodYearOntbPageNote.SelectedValue;
            this.lstBoxStudentOntbPageNote.DataSource = studentRepository.GetAll().Where(s => s.Name.Contains(query) || s.SchoolNumber.Contains(query)).Where(s => s.Year == year.ToString() && s.Period == period).ToString();
        }

        private void btnAddWeekOntbPageControl_Click(object sender, EventArgs e)
        {
            var addWeeklControlFrom = new AddWeeklyControl();
            var selectedLesson =(Lesson) cmbBoxLessonsOntbPageControl.SelectedItem;
            addWeeklControlFrom.OpenWithLesson(selectedLesson);
        }

        private void btnEditWeekOntbPageControl_Click(object sender, EventArgs e)
        {
            var selectedWeek = (WeeklyControl)this.listBoxWeeksOntbPageControl.SelectedItem;
            if (selectedWeek != null)
            {
                var addWeeklControlFrom = new AddWeeklyControl();
                addWeeklControlFrom.OpenInEdit(selectedWeek);

            }
            else
            {
                MessageBox.Show("Önce Hafta seçiniz");
            }

        }

        private void btnUpdateWeeksOntbPageControl_Click(object sender, EventArgs e)
        {
            UpdateWeekList();
        }

        private void btnDeleteWeekOntbPage_Click(object sender, EventArgs e)
        {
            var selectedWeek = (WeeklyControl)this.listBoxWeeksOntbPageControl.SelectedItem;
            if (selectedWeek != null)
            {
                weeklyControlRepository.DeleteWeeklyControl(selectedWeek.Id);
                MessageBox.Show("Hafta Silindi");
                UpdateWeekList();
            }
            else
            {
                MessageBox.Show("Önce Hafta seçiniz");
            }
        }

        private void UpdateWeekList()
        {
            var selectedLesson = (Lesson)this.cmbBoxLessonsOntbPageControl.SelectedItem;
            if (selectedLesson != null)
            {
                this.listBoxWeeksOntbPageControl.DataSource = null;
                this.listBoxWeeksOntbPageControl.DataSource = this.weeklyControlRepository.GetAll().Where(l => l.Lessson.Id == selectedLesson.Id).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen Önce ders seçiniz.");
            }

        }

        private void btnFilterStudentsOntbPageControl_Click(object sender, EventArgs e)
        {
            FilterStudentsOntbPageControl();

        }

        private void btnAddStudentsToWeekControlOntbPageControl_Click(object sender, EventArgs e)
        {
            var selectedWeek = (WeeklyControl)this.listBoxWeeksOntbPageControl.SelectedItem;

            if (selectedWeek != null)
            {
                var educationYear = (int)this.cmbEducationYearOntbPageControl.SelectedItem;
                var selectedPeriod = cmbOgretimDurumuOntbPageControl.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                var students = studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == educationYear.ToString()).ToList();

                if (selectedWeek.WeeklyControlSubItem != null)
                {
                    foreach (var item in selectedWeek.WeeklyControlSubItem)
                    {
                        foreach (var student in students.ToList())
                        {
                            if (item.Student.Id == student.Id)
                                students.Remove(student);
                        }
                    }
                }

                foreach (var student in students)
                {
                    var weeklyControlSubItem = new WeeklyControlSubItem();

                    weeklyControlSubItem.IsControl = false;
                    weeklyControlSubItem.Student = student;
                    weeklyControlSubItem.WeeklyControl = selectedWeek;
                    weeklyControlSubItemRepository.AddWeeklyControlSubItem(weeklyControlSubItem);

                }


                FilterStudentsOntbPageControl();
                MessageBox.Show("Seçili haftaya öğrenciler aktarıldı.");
            }
            else
            {
                MessageBox.Show("Önce hafta seçiniz");
            }


        }

        private void btnAddNoteOntbPageControl_Click(object sender, EventArgs e)
        {
            var selectedSubItem = (WeeklyControlSubItem)this.chcBoxWeeklyControlSubItemsOntbPageControl.SelectedItem;
            if (selectedSubItem != null)
            {
                var addNoteForm = new AddNoteForm();
                addNoteForm.Open(selectedSubItem);
            }
            else
            {
                MessageBox.Show("not eklemek için öğrenci seçiniz.");
            }
        }

        private void btnUpdateStudentsWeekControlOntbPageControl_Click(object sender, EventArgs e)
        {
            var students = new List<WeeklyControlSubItem>();
            for (int i = 0; i < chcBoxWeeklyControlSubItemsOntbPageControl.Items.Count; i++)
            {
                var subItem = (WeeklyControlSubItem)chcBoxWeeklyControlSubItemsOntbPageControl.Items[i];
                subItem.IsControl = chcBoxWeeklyControlSubItemsOntbPageControl.GetItemCheckState(i) == CheckState.Checked ? true : false;
                weeklyControlSubItemRepository.UpdateWeeklyControlSubItem(subItem);
            }
            MessageBox.Show("Güncellendi");

        }

        private void FilterStudentsOntbPageControl()
        {
            var selectedWeek = (WeeklyControl)this.listBoxWeeksOntbPageControl.SelectedItem;

            if (selectedWeek != null)
            {
                var educationYear = (int)this.cmbEducationYearOntbPageControl.SelectedItem;
                if (cmbOgretimDurumuOntbPageControl.SelectedIndex == -1)
                {
                    MessageBox.Show("Öğretim durumunu seçiniz");
                }
                else
                {
                    var selectedPeriod = cmbOgretimDurumuOntbPageControl.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                    var subItems = weeklyControlSubItemRepository.GetAll().Where(c => c.WeeklyControl.Id == selectedWeek.Id && c.Student.Period == selectedPeriod && c.Student.Year == educationYear.ToString()).ToArray();
                    this.chcBoxWeeklyControlSubItemsOntbPageControl.Items.Clear();
                    if (subItems.Length > 0)
                    {
                        foreach (var item in subItems)
                        {
                            this.chcBoxWeeklyControlSubItemsOntbPageControl.Items.Add(item, item.IsControl);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seçili haftaya ait öğrenci bulunmamaktadır.");
                    }
                }


            }
            else
            {
                MessageBox.Show("Önce hafta seçiniz");
            }
        }

        Font titleFont = new Font("Verdana", 12, FontStyle.Bold);
        Font bodyFont = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);

        private string raporTitle = "";
        private string raporContent = "";
        
        private List<ScoreViewModel> Scores;
        string[] Headers;// = { "Okul Numarası", "Adı Soyadı", "Puan" };
        string[,] Data;// = new string[Scores.Count, 3];

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(raporTitle, titleFont, brush, e.MarginBounds.Top, e.MarginBounds.Left);
         

            using (Font header_font = new Font("Times New Roman", 16, FontStyle.Bold))
            {
                using (Font body_font = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 20;

                    // See how wide the columns must be.
                    int[] column_widths = FindColumnWidths(
                        e.Graphics, header_font, body_font, Headers, Data);

                    // Start at the left margin.
                    int x = e.MarginBounds.Left;

                    // Print by columns.
                    for (int col = 0; col < Headers.Length; col++)
                    {
                        // Print the header.
                        int y = e.MarginBounds.Top + 30;
                        e.Graphics.DrawString(Headers[col],
                            header_font, Brushes.Black, x, y);
                        y += (int)(line_spacing * 1.5);

                        // Print the items in the column.
                        for (int row = 0; row <= Data.GetUpperBound(0); row++)
                        {
                            e.Graphics.DrawString(Data[row, col],
                                body_font, Brushes.Black, x, y);
                            y += line_spacing;
                        }

                        // Move to the next column.
                        x += column_widths[col];
                    } // Looping over columns
                } // using body_font
            } // using header_font

            //DrawGrid(e, y)
            e.HasMorePages = false;
        }

        private void btnCreateVizeRapor_Click(object sender, EventArgs e)
        {

            var selectedReportType = cmbReportType.SelectedIndex;
            if (selectedReportType != -1)
            {
                var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
                var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;
                var selectedLesson = (Lesson)cmbLessonsOntbPageScore.SelectedItem;
                this.raporTitle = $"{selectedYear.ToString()}  {cmbBoxOgrenimDurumuOntbPageRapor.SelectedItem.ToString()}  {selectedLesson.Name}";
                //var students = studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == selectedYear.ToString()).ToList();
                
                switch (selectedReportType)
                {
                    case 0:

                        raporTitle += " Vize Notları";
                        var vizeScores = scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.VizeScore
                               }).ToList();
                        Scores = vizeScores;
                        //var scoreReport = new ScoreReportForm();
                        //scoreReport.OpenGrid(scores);
                        //foreach (var score in scores)
                        //{
                        //    raporContent += score.Student.SchoolNumber+ "                    " + score.Student.Name + "                " + score.VizeScore+ "\n";
                        //}
                        break;

                    case 1:
                        raporTitle += " Final Notları";
                        var finalScores= scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.FinalScore
                               }).ToList();
                        Scores = finalScores;
                        break;

                    case 2:
                        raporTitle += " Genel Notları";
                        var totalScores = scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.TotalScore
                               }).ToList();
                        Scores = totalScores;
                        break;
                    default:
                        break;
                }
                Headers = new string[] { "Okul Numarası", "Adı Soyadı", "Puan" };
                Data = new string[Scores.Count(), Headers.Count()];
                for (int x = 0; x < Scores.Count; x++)
                {
                    var score = Scores[x];
                    Data[x, 0] = score.StudentNumber;
                    Data[x, 1] = score.Name;
                    Data[x, 2] = score.Score.ToString();
                }
                this.printPreviewDialogReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Raport türünü seçiniz.");
            }

        }

        private void btnCreateFinalRapor_Click(object sender, EventArgs e)
        {
            this.raporContent = "";

            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;

            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;
            this.raporTitle = $"{selectedYear.ToString()}  {cmbBoxOgrenimDurumuOntbPageRapor.SelectedItem.ToString()} Final Notları";
            var students = studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == selectedYear.ToString()).ToList();

            foreach (var student in students)
            {
                raporContent += student.SchoolNumber + "                    " + student.Name + "                " + student.VizeScore + "\n";
            }
            this.printPreviewDialogReport.ShowDialog();
        }

        private void btnControlWeekRapor_Click(object sender, EventArgs e)
        {
            this.raporContent = "";

            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedWeek = (WeeklyControl)cmbBoxControlWeekOntbPageRapor.SelectedItem;
            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;

            this.raporTitle = $"{selectedYear.ToString()}  {cmbBoxOgrenimDurumuOntbPageRapor.SelectedItem.ToString()} {selectedWeek.WeekName}";
            var subItems = selectedWeek.WeeklyControlSubItem.ToArray(); 
            
            Headers = new string[] { "Okul Numarası", "Adı Soyadı", "Proje Adı", "Kontrol Durumu" };
            Data = new string[subItems.Count(), Headers.Count()];
            for (int i = 0; i < subItems.Count(); i++)
            {
                Data[i, 0] = subItems[i].Student.SchoolNumber;
                Data[i, 1] = subItems[i].Student.Name;
                Data[i, 2] = subItems[i].Student.Project;
                Data[i, 3] = subItems[i].IsControl ? "Tamamlandı" : "Tamamlamadı";
            }

            this.printPreviewDialogReport.ShowDialog();
        }

        private void AddWeeksToReport()
        {
            var selectedLesson = (Lesson)this.cmbBoxLessonsOntbPageReport.SelectedItem;
            if (selectedLesson != null)
            {
                var weeks = weeklyControlRepository.GetAll().Where(w => w.Lessson.Id == selectedLesson.Id).ToArray();
                cmbBoxControlWeekOntbPageRapor.Items.Clear();
                cmbBoxControlWeekOntbPageRapor.Items.AddRange(weeks);
            }
            else
            {
                MessageBox.Show("Lütfen ders seçiniz");
            }

        }

        private void btnMailSend_Click(object sender, EventArgs e)
        {
            MailSend();
        }

        private void MailSend()
        {
            var isSafe = true;
            var mailObject = txtMailObject.Text;
            var mailContent = rchTxtMailContent.Text;


            if (!(MailSendList.Count > 0))
            {
                MessageBox.Show("Gönderilenler listesi boş olamaz");
                isSafe = false;
            }


            if (string.IsNullOrWhiteSpace(mailContent))
            {
                MessageBox.Show("Mail İçeriğini boş bırakmayınız");
                isSafe = false;
            }

            if (string.IsNullOrWhiteSpace(mailObject))
            {
                MessageBox.Show("Mail konusunu boş bırakmayınız");
                isSafe = false;
            }

            if (isSafe)
            {

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    var userMail = ConfigurationManager.AppSettings["mail"].ToString();
                    var userPassword = ConfigurationManager.AppSettings["mailPassword"].ToString();

                    mail.From = new MailAddress(userMail);
                    foreach (var item in MailSendList)
                    {
                        mail.To.Add(item.Email);
                    }

                    mail.Subject = mailObject;
                    mail.Body = mailContent;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(userMail, userPassword);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnRefreshOntbPageMail_Click(object sender, EventArgs e)
        {

        }

        public void ExportVizeReportToExcel(List<ScoreViewModel> studentList, int reportType)
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "C1").Font.Bold = true;
                oSheet.get_Range("A1", "C1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[studentList.Count, 3];

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "Okul Numarası";
                oSheet.Cells[1, 2] = "Adı Soyadı";
                switch (reportType)
                {
                    case 0:
                        oSheet.Cells[1, 3] = "Vize Not";

                        break;
                    case 1:
                        oSheet.Cells[1, 3] = "Final Not";

                        break;
                    case 2:
                        oSheet.Cells[1, 3] = "Genel Not";

                        break;

                    default:
                        break;
                }

                for (int i = 0; i < studentList.Count; i++)
                {
                    saNames[i, 0] = studentList[i].StudentNumber.ToString();
                    saNames[i, 1] = studentList[i].Name.ToString();
                    saNames[i, 2] = studentList[i].Score.ToString();
                }




                //Fill A2:B6 with an array of values (First and Last Names).
                string arrange2 = "C" + (studentList.Count + 1).ToString();
                oSheet.get_Range("A2", arrange2).Value2 = saNames;

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                oXL.Visible = true;
                oXL.UserControl = false;
                //string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{fileName}.xlsx";
                /*oWB.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                //oWB.Close();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVizeReportToExcel_Click(object sender, EventArgs e)
        {
            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;
            var fileName = $"{selectedYear.ToString()}  {cmbBoxOgrenimDurumuOntbPageRapor.SelectedItem.ToString()} Vize Notları";
            var students = studentRepository.GetAll().Where(s => s.Period == selectedPeriod && s.Year == selectedYear.ToString()).ToList();
            var selectedLesson = (Lesson)cmbBoxLessonsOntbPageReport.SelectedItem;
            var selectedReportType = cmbReportType.SelectedIndex;
            if (selectedReportType != -1)
            {
                  switch (selectedReportType)
                {
                    case 0:

                        raporTitle += " Vize Notları";
                        var vizeScores = scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.VizeScore
                               }).ToList();
                        Scores = vizeScores;
                       
                        break;

                    case 1:
                        raporTitle += " Final Notları";
                        var finalScores= scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.FinalScore
                               }).ToList();
                        Scores = finalScores;
                        break;

                    case 2:
                        raporTitle += " Genel Notları";
                        var totalScores = scoreRepository.GetAll()
                        .Where(s => s.Lesson.Id == selectedLesson.Id &&
                               s.Student.Year == selectedYear.ToString() &&
                               s.Student.Period == selectedPeriod).Select(r => new ScoreViewModel
                               {
                                   StudentNumber = r.Student.SchoolNumber,
                                   Name = r.Student.Name,
                                   Score = r.TotalScore
                               }).ToList();
                        Scores = totalScores;
                        break;
                    default:
                        break;
                }

                ExportVizeReportToExcel(Scores, selectedReportType);
            }
            else
            {
                MessageBox.Show("Lütfen Rapor Türü Seçinz");
            }


        }

        private void btnMailToList_Click(object sender, EventArgs e)
        {
            var mailSenderList = new MailSenderListForm();
            mailSenderList.SavedMailList += new EventHandler(SavedMailList);
            mailSenderList.ShowDialog();
        }

        private void SavedMailList(object sender, EventArgs e)
        {
            MailSenderListForm fc = sender as MailSenderListForm;
            if (fc != null)
            {
                this.cmbBoxMailTo.Items.Clear();
                MailSendList = fc.mailListStudents;
                this.cmbBoxMailTo.Items.AddRange(fc.mailListStudents.ToArray());
            }
        }
        private void btnControlWeekToExcel_Click(object sender, EventArgs e)
        {
            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedWeek = (WeeklyControl)cmbBoxControlWeekOntbPageRapor.SelectedItem;
            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;

            var subItems = selectedWeek.WeeklyControlSubItem;

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[subItems.Count, 4];

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "Okul Numarası";
                oSheet.Cells[1, 2] = "Adı Soyadı";

                oSheet.Cells[1, 3] = "Proje Adı";
                oSheet.Cells[1, 4] = "Kontorl Durumu";
                for (int i = 0; i < subItems.Count; i++)
                {
                    saNames[i, 0] = subItems[i].Student.SchoolNumber.ToString();
                    saNames[i, 1] = subItems[i].Student.Name.ToString();
                    saNames[i, 2] = subItems[i].Student.Project;
                    saNames[i, 3] = subItems[i].IsControl ? "Tamamlandı" : "Tamamlanmadı";
                }

                //Fill A2:B6 with an array of values (First and Last Names).
                string arrange2 = "D" + (subItems.Count + 1).ToString();
                oSheet.get_Range("A2", arrange2).Value2 = saNames;

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                oXL.Visible = true;
                oXL.UserControl = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshWeeksOntbPageRapor_Click(object sender, EventArgs e)
        {
            AddWeeksToReport();
        }

        private void btnAddLessonOntbPageLessons_Click(object sender, EventArgs e)
        {
            var lessonName = txtLessonNameOntbPageLesson.Text;
            if (!string.IsNullOrWhiteSpace(lessonName))
            {
                var lesson = new Lesson();
                lesson.Name = lessonName;
                lessonRepository.AddLesson(lesson);
                RefreshLessonsOntbPageLesson();
            }
        }

        public List<Lesson> GetLessons()
        {
            return lessonRepository.GetAll().ToList();
        }

        public void RefreshLessonsOntbPageControl()
        {
            this.cmbBoxLessonsOntbPageControl.DataSource = null;
            this.cmbBoxLessonsOntbPageControl.DataSource = GetLessons();
        }

        public void RefreshLessonsOntbPageLesson()
        {
            this.lstBoxLessonsOntbPageLesson.DataSource = null;
            lstBoxLessonsOntbPageLesson.DataSource = GetLessons();
        }

        private void btnRefreshLessonsOntbPageControl_Click(object sender, EventArgs e)
        {
            RefreshLessonsOntbPageControl();
        }

        private void btnCreateNoteReportOntbPageRapor_Click(object sender, EventArgs e)
        {

            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedWeek = (WeeklyControl)cmbBoxControlWeekOntbPageRapor.SelectedItem;
            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;
            var selectedLesson =(Lesson) cmbBoxLessonsOntbPageReport.SelectedItem;
            this.raporTitle = $"{selectedYear.ToString()}  {cmbBoxOgrenimDurumuOntbPageRapor.SelectedItem.ToString()} {selectedWeek.WeekName} Not";
            var subItems = selectedWeek.WeeklyControlSubItem.ToArray(); 
            Headers = new string[] { "Okul Numarası", "Adı Soyadı", "Proje Adı", "Not" };
            Data = new string[subItems.Count(), Headers.Count()];
            for (int i = 0; i < subItems.Count(); i++)
            {
                Data[i, 0] = subItems[i].Student.SchoolNumber;
                Data[i, 1] = subItems[i].Student.Name;
                Data[i, 2] = subItems[i].Student.Project;
                Data[i, 3] = subItems[i].Note;
            }

            this.printPreviewDialogReport.ShowDialog();
        }

        private void btnNoteReportToExcelOntbPageReport_Click(object sender, EventArgs e)
        {

            var selectedPeriod = cmbBoxOgrenimDurumuOntbPageRapor.SelectedIndex == 0 ? Period.FirstPeriod : Period.SecondPeriod;
            var selectedWeek = (WeeklyControl)cmbBoxControlWeekOntbPageRapor.SelectedItem;
            var selectedYear = (int)cmbBoxOgretimYiliOntbPageRapor.SelectedItem;

            var subItems = selectedWeek.WeeklyControlSubItem;

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[subItems.Count, 4];

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "Okul Numarası";
                oSheet.Cells[1, 2] = "Adı Soyadı";

                oSheet.Cells[1, 3] = "Proje Adı";
                oSheet.Cells[1, 4] = "Not";
                for (int i = 0; i < subItems.Count; i++)
                {
                    saNames[i, 0] = subItems[i].Student.SchoolNumber.ToString();
                    saNames[i, 1] = subItems[i].Student.Name.ToString();
                    saNames[i, 2] = subItems[i].Student.Project;
                    saNames[i, 3] = subItems[i].Note;
                }

                //Fill A2:B6 with an array of values (First and Last Names).
                string arrange2 = "D" + (subItems.Count + 1).ToString();
                oSheet.get_Range("A2", arrange2).Value2 = saNames;

                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                oXL.Visible = true;
                oXL.UserControl = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnAddOrEditLessonsStudentOntbPageLesson_Click(object sender, EventArgs e)
        {
            var selectedLesson = (Lesson)this.lstBoxLessonsOntbPageLesson.SelectedItem;
            var lessonstudents = new LessonStudents();
            lessonstudents.Open(selectedLesson);
        }

        private void btnRefreshLessonsOntbPageScore_Click(object sender, EventArgs e)
        {
            this.cmbLessonsOntbPageScore.SelectedIndex = -1;
            this.cmbLessonsOntbPageScore.DataSource = null;
            this.cmbLessonsOntbPageScore.DataSource = GetLessons();
        }

        private void cmbLessonsOntbPageScore_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedStudent = (Student)this.lstBoxStudentOntbPageNote.SelectedItem;
            var selectedLesson = (Lesson)this.cmbLessonsOntbPageScore.SelectedItem;

            if (selectedStudent != null)
            {
                if (selectedLesson!=null)
                {
                    var result = scoreRepository.GetAll().Where(s => s.Lesson.Id == selectedLesson.Id && s.Student.Id == selectedStudent.Id);
                    var lessonScore = result.Count() > 0 ? result.FirstOrDefault() : null;
                    if (lessonScore != null)
                    {
                        this.txtBoxFinalRateOntbPageNote.Text = lessonScore.FinalRate.ToString();
                        this.txtBoxVizeRateOntbPageNote.Text = lessonScore.VizeRate.ToString();

                        this.trckBarVizeFinalAgirlik.Value = lessonScore.VizeRate;
                        this.txtBoxPuan.Text = lessonScore.TotalScore.ToString();

                        cmbBoxFinal.SelectedIndex = cmbBoxFinal.Items.IndexOf(lessonScore.FinalScore);
                        cmbBoxVize.SelectedIndex = cmbBoxVize.Items.IndexOf(lessonScore.VizeScore);
                    }
                    else
                    {
                        this.txtBoxFinalRateOntbPageNote.Text = "";
                        this.txtBoxVizeRateOntbPageNote.Text = "";

                        this.trckBarVizeFinalAgirlik.Value = 0;
                        this.txtBoxPuan.Text = "";

                        cmbBoxFinal.SelectedIndex = -1;
                        cmbBoxVize.SelectedIndex = -1;
                    }

                }
                
            }
        }

        private void btnRefreshLessonsOntbPageReport_Click(object sender, EventArgs e)
        {
            this.cmbBoxLessonsOntbPageReport.DataSource = GetLessons();
        }

        private int[] FindColumnWidths(Graphics gr, Font header_font, Font body_font, string[] headers, string[,] values)
        {
            // Make room for the widths.
            int[] widths = new int[headers.Length];

            // Find the width for each column.
            for (int col = 0; col < widths.Length; col++)
            {
                // Check the column header.
                widths[col] = (int)gr.MeasureString(headers[col], header_font).Width;

                // Check the items.
                for (int row = 0; row <= values.GetUpperBound(0); row++)
                {
                    int value_width = (int)gr.MeasureString(values[row, col], body_font).Width;
                    if (widths[col] < value_width) widths[col] = value_width;
                }

                // Add some extra space.
                widths[col] += 20;
            }

            return widths;
        }

        private void btnDeleteLessonsOntbPageLessons_Click(object sender, EventArgs e)
        {
            var selectedLesson = (Lesson)lstBoxLessonsOntbPageLesson.SelectedItem;
            lessonRepository.DeleteLesson(selectedLesson.Id);
            RefreshLessonsOntbPageLesson();
        }

        private void btnRefreshLessonsOntbPageLessons_Click(object sender, EventArgs e)
        {
            lstBoxLessonsOntbPageLesson.DataSource =GetLessons();
        }

        private void btnEditLessonOntbPageLesson_Click(object sender, EventArgs e)
        {
            var selectedLesson =(Lesson) lstBoxLessonsOntbPageLesson.SelectedItem;
            var lessonname = txtLessonNameOntbPageLesson.Text;
            selectedLesson.Name = lessonname;
            lessonRepository.UpdateLesson(selectedLesson);
            RefreshLessonsOntbPageLesson();
        }
    }
}
