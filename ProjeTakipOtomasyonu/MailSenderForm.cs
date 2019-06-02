using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Concrete.EfRepository;
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

namespace ProjeTakipOtomasyonu
{
    public partial class MailSenderForm : Form
    {
        public MailSenderForm()
        {
            InitializeComponent();
        }

        private IStudentRepository studentRepository = new EfStudentRepository();

        private void btnMailSend_Click(object sender, EventArgs e)
        {
            var isSafe = true;
            var target=(Student)cmbBoxMailTo.SelectedItem;
            var mailObject = txtMailObject.Text;
            var mailContent = rchTxtMailContent.Text;



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

                    mail.From = new MailAddress("221703001@ogr.uludag.edu.tr");
                    mail.To.Add(target.Email);
                    mail.Subject = mailObject;
                    mail.Body = mailContent;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("221703001@ogr.uludag.edu.tr", "Y!m@z13ar$C@n");
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

        private void MailSenderForm_Load(object sender, EventArgs e)
        {
            cmbBoxMailTo.DataSource=studentRepository.GetAll().ToList();

        }
    }
}
