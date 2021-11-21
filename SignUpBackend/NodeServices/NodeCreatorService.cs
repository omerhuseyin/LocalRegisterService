using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace SignUpBackend
{

    public static class NodeCreatorService
    {

        static string localMail = "mails.txt";

        static string localPass = "passwords.txt";

        static bool isReadOnlyMail = IsMailFileReadOnly(localMail);

        static bool isReadOnlyPass = IsPassFileReadOnly(localPass);

        public static bool IsMailReadOnly { get; set; }

        public static bool IsPassReadOnly { get; set; }


        public static bool IsMailFileReadOnly(string localMail)
        {
            FileInfo mInfo = new FileInfo(localMail);

            return mInfo.IsReadOnly;
        }

        public static void SetMailFileReadAccess(string localMail, bool SetReadOnlyMail)
        {
            FileInfo mInfo = new FileInfo(localMail);

            mInfo.IsReadOnly = SetReadOnlyMail;
        }

        public static bool IsPassFileReadOnly(string localPass)
        {
            FileInfo pInfo = new FileInfo(localPass);

            return pInfo.IsReadOnly;
        }

        public static void SetPassFileReadAccess(string localPass, bool SetReadOnlyPass)
        {
            FileInfo mInfo = new FileInfo(localPass);

            mInfo.IsReadOnly = SetReadOnlyPass;
        }

        public static void AddEmailNode(string message)
        {
            string mailPath = @"mails.txt";

            using (StreamWriter writer = new StreamWriter(mailPath, true))
            {

                if (isReadOnlyMail == false)
                {
                    writer.WriteLine($"{message}");

                    SetMailFileReadAccess(localMail, true);
                }

                else if (isReadOnlyMail == true)
                {
                    SetMailFileReadAccess(localMail, false);

                    writer.WriteLine($"{message}");
                }
            }
        }

        public static void AddPassNode(string message)
        {
            string passPath = @"passwords.txt";

            using (StreamWriter writer = new StreamWriter(passPath, true))
            {
                if (isReadOnlyPass == false)
                {
                    writer.WriteLine($"{message}");

                    SetPassFileReadAccess(localPass, true);
                }

                else if (isReadOnlyPass == true)
                {
                    SetPassFileReadAccess(localPass, false);

                    writer.WriteLine($"{message}");
                }
            }
        }


    }
}