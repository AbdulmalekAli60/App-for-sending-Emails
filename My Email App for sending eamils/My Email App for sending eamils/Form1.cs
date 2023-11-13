
using System.Net.Mail;

namespace My_Email_App_for_sending_eamils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sender email");
                mail.To.Add(textBox1.Text);
                mail.Subject = textBox2.Text;
                mail.Body = textBox3.Text;

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("the email for the sender email", "security key");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                MessageBox.Show("Message sent successfully");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}