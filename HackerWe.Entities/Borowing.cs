using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HackerWe.Entities
{
    public class Borowing
    {
        public Guid Id { get; set; }
        public DateTime BorowingDate { get; set; }
        public DateTime DueReturningDate => BorowingDate.AddDays(14);
        public DateTime ReturningDate { get; set; }
        public int BookId { get; set; }
        
        
        private Book book;

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public int ClientId { get; set; }
        public Client Client{ get; set; }

        public Borowing()
        {
            Id= Guid.NewGuid();
        }

        public void EmailConfirm(Borowing borowing)
        {
            MailAddress from = new MailAddress("rotemdan267@gmail.com", "Rotem");
            MailAddress to = new MailAddress("rotemdan267@gmail.com");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = "You've borrowed successfully";
            mailMessage.Body =
                $"Hi {Client.FirstName}," +
                $"\nYou've borrowed {Book.Name} on {BorowingDate} and " +
                $"is requested to return it until {DueReturningDate}." +
                $"\n\nThank you for choosing \"HackerWe Library\", keep reading!";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(mailMessage);
        }

        void ReadFromFixedLength(string line)
        {
            ClientId = int.Parse(line.Substring(0, 5));
        }

        /// <summary>
        /// Writes a fixed length reperesentation of this instance
        /// </summary>
        /// <returns>The fixed length string</returns>
        /// <remarks>The example does not deal with all the fields - do it at home work</remarks>
        string WriteFixedLength()
        {
            string str;
            str = string.Format("{0:5}{1:36}",ClientId,Id);
            return str;
        }

    }
}
