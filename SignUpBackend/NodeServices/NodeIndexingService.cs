using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpBackend.NodeServices
{
    class NodeIndexingService
    {
        public static List<string> ListMailAdress = new List<string>();

        public static List<string> ListPasswords = new List<string>();

        public static string[] mails = File.ReadAllLines("paths/mails.txt");

        public static string[] passw = File.ReadAllLines("paths/passwords.txt");

        public static void GetAccountStatus()
        {
            foreach (var TransferMail in mails)

                ListMailAdress.Add(TransferMail);

            foreach (var TransferPasswords in passw)

                ListPasswords.Add(TransferPasswords);
        }
    }
}
