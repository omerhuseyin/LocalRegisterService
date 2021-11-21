using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpBackend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListMailAdress = new List<string>();
        
        List<string> ListPasswords = new List<string>();

        string[] mails = File.ReadAllLines("mails.txt");
        
        string[] passw = File.ReadAllLines("passwords.txt");

        string loginMail = string.Empty;
        
        string loginPass = string.Empty;
        
        int loginMailIndex = 0;
        
        int loginPassIndex = 0;

        private void GetMailsAndPassword()
        {
            foreach (var TransferMail in mails)
        
                ListMailAdress.Add(TransferMail);


            foreach (var TransferPasswords in passw)
                
                ListPasswords.Add(TransferPasswords);

            foreach (var Transferred in ListMailAdress)

                listBox1.Items.Add(Transferred);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginMail = textBox3.Text;
            
            loginPass = textBox4.Text;
            
            loginMailIndex = ListMailAdress.IndexOf($"{loginMail}");
            
            loginPassIndex = ListPasswords.IndexOf($"{loginPass}");

            if (loginMailIndex == -1 || loginPassIndex == -1)
            
                MessageBox.Show("Account Not Found");
            
            else if (loginMail == ListMailAdress[loginMailIndex] &&  loginPass == ListPasswords[loginMailIndex])
                
                MessageBox.Show("Login Successfully!");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetMailsAndPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NodeCreatorService.AddEmailNode(textBox1.Text);

            NodeCreatorService.AddPassNode(textBox2.Text);
        }

    }
}
