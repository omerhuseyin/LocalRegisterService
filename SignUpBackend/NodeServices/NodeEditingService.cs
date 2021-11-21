using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpBackend.NodeServices
{
    class NodeEditingService
    {
        public static void MailUpdater(string newMail, string mailPath, int mailIndex)
        {
            try
            {
                mailPath = "paths/mails.txt";

                string[] arrLine = File.ReadAllLines(mailPath);

                arrLine[mailIndex - 1] = newMail;

                File.WriteAllLines(mailPath, arrLine);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"MailUpdatingError\n{ex}");

                return;
            }
        }

        public static void PasswordUpdater(string newPassword, string passPath, int passIndex)
        {
            try
            {
                passPath = "paths/passwords.txt";

                string[] arrLine = File.ReadAllLines(passPath);

                arrLine[passIndex - 1] = newPassword;

                File.WriteAllLines(passPath, arrLine);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"UpdatingError\n{ex}");

                return;
            }
        }

    }
}
