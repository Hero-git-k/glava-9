using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace AfanasevGlava9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butProcCount_Click_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();
            int processorCount = 0;
            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }
            MessageBox.Show(processorCount.ToString());
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( String.Format("Число процессоров: {0}",Environment.ProcessorCount.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(p.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Очистим список
            listBox1.Items.Clear();
            // Получим список процессов, связанных с Internet Explorer
            foreach (Process p in Process.GetProcessesByName("Yandex"))
                listBox1.Items.Add(p.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckOSVersion();
        }
        private void CheckOSVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;
            if ((version.Major == 5) && (version.Minor == 1)
            || version.Major >= 6)
            {
                MessageBox.Show("Программа может запускаться" +
                " в вашей операционной системе");
            }
            else
            {
                MessageBox.Show
                ("Эта версия операционной системы не поддерживается." +
                "\r\n Используйте Windows XP или Windows Vista");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string fileName = @"c:\windows\regedit.exe";
            // Получим информацию о свойствах файла.
            FileVersionInfo fileInfo = FileVersionInfo.GetVersionInfo(fileName);
            listBox1.Items.Add("Комментарии: " + fileInfo.Comments);
            listBox1.Items.Add("Производитель: " + fileInfo.CompanyName);
 listBox1.Items.Add("Имя файла: " + fileInfo.FileName);
            listBox1.Items.Add("Номер сборки файла: " + fileInfo.FileBuildPart);
            listBox1.Items.Add("Описание файла: " + fileInfo.FileDescription);
            listBox1.Items.Add("Номер версии файла: " + fileInfo.FileVersion);
            listBox1.Items.Add("Основная часть номера версии: " +
            fileInfo.FileMajorPart);
            listBox1.Items.Add("Вспомогательная часть номера версии: " +
            fileInfo.FileMinorPart);
            listBox1.Items.Add("Номер закрытой части файла: " +
            fileInfo.FilePrivatePart);
            listBox1.Items.Add("Авторские права: " + fileInfo.LegalCopyright);
            listBox1.Items.Add("Товарные знаки: " + fileInfo.LegalTrademarks);
            listBox1.Items.Add("Название продукта: " + fileInfo.ProductName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetProcessorArchitecture());
        }
        private string GetProcessorArchitecture()
        {
            RegistryKey environmentKey = Registry.LocalMachine; // раздел HKLM
            environmentKey = environmentKey.OpenSubKey(
            @"System\CurrentControlSet\Control\Session Manager\Environment",
            false);
            string strEnvironment =
            environmentKey.GetValue("PROCESSOR_ARCHITECTURE").ToString();
            return strEnvironment;
        }
    }
}
