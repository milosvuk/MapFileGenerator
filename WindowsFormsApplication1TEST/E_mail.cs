using System.ComponentModel;
using System.Net.Mail;
using System;
using System.Collections;
using System.Data;
using System.Net;
using System.Net.NetworkInformation;

class E_mail
{


    public static void sendEmail()
    {
               
        MailAddress SendFrom = new MailAddress("d@keyworld.net");
        MailAddress SendTo = new MailAddress("dv89@pt.com");
        MailAddress SendCC = new MailAddress("d68@keyworld.net");


        MailMessage MyMessage = new MailMessage(SendFrom, SendTo);

        MailMessage MyMessage2 = new MailMessage(SendFrom, SendFrom);

        MyMessage.Subject = "Test at " + DateTime.Now.ToLongTimeString();
        MyMessage.Body = "\n\n" + "Test at " + DateTime.Now.ToLongTimeString();

        MyMessage2.Subject = "Test at " + DateTime.Now.ToLongTimeString();
        MyMessage2.Body = "\n\n" + "Test at " + DateTime.Now.ToLongTimeString();


        string MailServer = @"smtp.nextweb.net.mt";
        SmtpClient emailClient = new SmtpClient(MailServer, 25);

        emailClient.Send(MyMessage);

        SmtpClient emailClient2 = new SmtpClient(MailServer, 25);

        emailClient2.Send(MyMessage2);

    }

    //
           //SmtpMail oMail = new SmtpMail("TryIt");
           // SmtpClient oSmtp = new SmtpClient();
        
           // // Set sender email address, please change it to yours
           // oMail.From = "test@emailarchitect.net";

           // // Set recipient email address, please change it to yours
           // oMail.To = "support@emailarchitect.net";
            
           // // Set email subject
           // oMail.Subject = "test html email with attachment";
            
           // // Set Html body
           // oMail.HtmlBody = "<font size=\"5\">This is</font> <font color=\"red\"><b>a test</b></font>";

           // // Your SMTP server address
           // SmtpServer oServer = new SmtpServer("smtp.emailarchitect.net");
            
           // // User and password for ESMTP authentication, if your server doesn't require
           // // User authentication, please remove the following codes.            
           // oServer.User = "test@emailarchitect.net";
           // oServer.Password = "testpassword";

           // // If your smtp server requires SSL connection, please add this line
           // // oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

           // try
           // {
           //     // Add attachment from local disk
           //     oMail.AddAttachment( "d:\\test.pdf" );
                
           //     // Add attachment from remote website
           //     oMail.AddAttachment( "http://www.emailarchitect.net/webapp/img/logo.jpg" );

           //     Console.WriteLine("start to send email with attachment ...");
           //     oSmtp.SendMail(oServer, oMail);

    


   public  static void SendEmail(string host, int port, string username, string password, string from, string to, string subject, string body, string attachedFile)
    {
        //A MailMessage object must be disposed!
        using (MailMessage message = new MailMessage())
        {
            message.From = new MailAddress(from);
            message.To.Add(to);
            message.Subject = subject;
            message.Body = body;

            message.Attachments.Add(new Attachment(attachedFile));
            
            SmtpClient client = new SmtpClient(host, port);
            //if your SMTP server requires a password,
            //the following line is important
            client.Credentials = new NetworkCredential(username, password);
            client.EnableSsl = true;
            //this send is synchronous. You can also choose
            //to send asynchronously
            client.Send(message);
        }
    }

  public static void SendEmail_MECMatch(ArrayList ListToSend)
  {
      string username = @"info@mecmatch.com";
      string fromEmail = @"info@mecmatch.com";
      string pwd = @"Dj2018???";
     

      MailMessage message = new MailMessage();
      message.From = new MailAddress("info@mecmatch.com");

      for (int i = 0; i < ListToSend.Count; i++)
      {
          string recipient = ListToSend[i].ToString();
          message.To.Add(new MailAddress(recipient));
      }

      message.Subject = "Info";
      message.Body = "The test from MECMatch";
      message.From = new MailAddress(fromEmail);
      string host = "smtp.office365.com"; //"relay-hosting.secureserver.net";
      //string host = "smtpout.secureserver.net";

      int port = 587; // 3535;// 25;

      // MessageBox.Show(res);
      // erver name: smtp.office365.com
      //Port: 587

      SmtpClient client = new SmtpClient();
      client.Host = host;
      client.Port = port;
      client.UseDefaultCredentials = false;
      client.EnableSsl = true;
      client.Credentials = new System.Net.NetworkCredential(username, pwd);

      client.Send(message);
  }

  public static string SendEmailFromGoDaddy(string subject, string body, string sender, string recipient, bool isHTML, string smtpUsername, string smtpPassword)
  {
      string msg = null;

      try
      {
          MailMessage mailMsg = new MailMessage(sender, recipient);
          mailMsg.Subject = subject;
          mailMsg.Body = msg + "    " + DateTime.Now.ToString();
          mailMsg.IsBodyHtml = isHTML;

          SmtpClient smtp = new SmtpClient();
          smtp.Host = "relay-hosting.secureserver.net";
          smtp.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);

          smtp.Send(mailMsg);
      }

      catch (Exception ex)
      {
          msg = ex.Message;
      }

      return msg;   // If msg == null then the e-mail was sent without errors
  } 

    public static void SendEmaiToMoreUsers(string _body, ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom )
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;

     
        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = host;
        SMTPClientObj.Port = port;
        SMTPClientObj.EnableSsl = ssl;

         


        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();
            try
            {
                SMTPClientObj.Send(emailfrom, emailRecipient, "Info", _body);
            }
            catch (Exception ex)
            {
                //ErrorLog.Save(
            }
        }

        
    }


    public static void SendEmaiMyZohoCom465(ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom)
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;


        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = "smtp.zoho.com";
        SMTPClientObj.Port = 465;
        SMTPClientObj.EnableSsl = ssl;




        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();
            try
            {
                SMTPClientObj.Send(emailfrom, emailRecipient, "Info", "Test");
            }
            catch (Exception ex)
            {
                //ErrorLog.Save(
            }
        }


    }

    public static void SendEmaiMyZohoEU465(ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom)
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;


        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = "smtp.zoho.eu";
        SMTPClientObj.Port = 465;
        SMTPClientObj.EnableSsl = ssl;




        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();
            try
            {
                SMTPClientObj.Send(emailfrom, emailRecipient, "Info", "Test");
            }
            catch (Exception ex)
            {
                //ErrorLog.Save(
            }
        }


    }

    public static void SendEmaiMyZohoCom587(ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom)
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;


        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = "smtp.zoho.com";
        SMTPClientObj.Port = 587;
        SMTPClientObj.EnableSsl = ssl;




        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();
            try
            {
                SMTPClientObj.Send(emailfrom, emailRecipient, "Info", "Test");
            }
            catch (Exception ex)
            {
                //ErrorLog.Save(
            }
        }


    }

    public static void SendEmaiMyZohoEU587(ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom)
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;


        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = "smtp.zoho.eu";
        SMTPClientObj.Port = 587;
        SMTPClientObj.EnableSsl = ssl;




        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();
            try
            {
                SMTPClientObj.Send(emailfrom, emailRecipient, "Info", "Test");
            }
            catch (Exception ex)
            {
                //ErrorLog.Save(
            }
        }


    }


    public static void SendEmaiToMoreUsersWithAttachment(string _body, ArrayList ListToSend, string username, string password, string host, int port, bool ssl, string emailfrom, string filenametoattach)
    {

        SmtpClient SMTPClientObj = new SmtpClient();

        SMTPClientObj.UseDefaultCredentials = false;


        SMTPClientObj.Credentials = new System.Net.NetworkCredential(username, password);


        SMTPClientObj.Host = host;
        SMTPClientObj.Port = port;
        SMTPClientObj.EnableSsl = ssl;

        


        for (int i = 0; i < ListToSend.Count; i++)
        {
            string emailRecipient = ListToSend[i].ToString();

            MailMessage message = new MailMessage();
            message.From = new MailAddress(emailfrom);
            message.To.Add(emailRecipient);
            message.Subject = "Process done" + DateTime.Now.ToShortDateString();
            message.Body = _body;

            message.Attachments.Add(new Attachment(filenametoattach));

            SMTPClientObj.Send(message);
            //SMTPClientObj.Send(emailfrom, emailRecipient, "Info", _body);
        }

       // SMTPClientObj.

    }




}



