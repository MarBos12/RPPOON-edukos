using System;

namespace EmailBuilderExample
{
    public class Mail
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Recipient { get; set; }
        public string Attachments { get; set; }
    }

    public interface IMailConstructor
    {
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        IMailConstructor AddRecipient(string recipient);
        IMailConstructor AddAttachments(string attachments);
        Mail Construct();
    }

    public class MailConstructor : IMailConstructor
    {
        private Mail mail;

        public MailConstructor()
        {
            mail = new Mail();
        }

        public IMailConstructor AddSubject(string subject)
        {
            mail.Subject = subject;
            return this;
        }

        public IMailConstructor AddContent(string content)
        {
            mail.Content = content;
            return this;
        }

        public IMailConstructor AddRecipient(string recipient)
        {
            mail.Recipient = recipient;
            return this;
        }

        public IMailConstructor AddAttachments(string attachments)
        {
            mail.Attachments = attachments;
            return this;
        }

        public Mail Construct()
        {
            return mail;
        }
    }

    public class SMTP
    {
        private readonly IMailConstructor mailConstructor;

        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }

        public void SendNoReplyMail()
        {
            Mail mail = mailConstructor
                .AddSubject("")
                .AddContent("")
                .AddRecipient("")
                .Construct();
            Console.WriteLine($"Sending mail to: {mail.Recipient}, Subject: {mail.Subject}, Content: {mail.Content}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMailConstructor mailConstructor = new MailConstructor();
            SMTP smtp = new SMTP(mailConstructor);

            smtp.SendNoReplyMail();
        }
    }
}


