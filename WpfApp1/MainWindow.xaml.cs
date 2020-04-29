using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.Configuration;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string pathIni = ConfigurationManager.AppSettings["WinCCIniPath"].ToString();
        private string pathExe = ConfigurationManager.AppSettings["WinCCExePath"].ToString();
        private string Disk1 = ConfigurationManager.AppSettings["终端1组态文件位置"].ToString();
        private string Disk2 = ConfigurationManager.AppSettings["终端2组态文件位置"].ToString();
        private string Disk3 = ConfigurationManager.AppSettings["终端3组态文件位置"].ToString();
        private string Disk4 = ConfigurationManager.AppSettings["终端4组态文件位置"].ToString();
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool closeProc(string ProcName) //关闭相应的程序进程
        {
            bool result = false;
            System.Collections.ArrayList procList = new System.Collections.ArrayList();
            string tempName = "";

            foreach (System.Diagnostics.Process thisProc in System.Diagnostics.Process.GetProcesses())
            {
                tempName = thisProc.ProcessName;
                procList.Add(tempName);
                if (tempName == ProcName)
                {
                    if (!thisProc.CloseMainWindow())
                        thisProc.Kill(); //当发送关闭窗口命令无效时强行结束进程     
                    result = true;
                }
            }
            return result;
        }



        private void Button_画面一(object sender, RoutedEventArgs e)
        {
            string path4 = @"HmiRTm";
            closeProc(path4);
            System.Threading.Thread.Sleep(1000);
            if (!File.Exists(pathIni))
            {
                using (File.Create(pathIni)) { };
            }

            Enfon画面选择.IniFileHelper.SetValue("configuration", "LoadConfigfile", Disk1, pathIni);
            string path3 = pathExe;
            System.Diagnostics.Process.Start(path3);


        }

        private void Button_画面二(object sender, RoutedEventArgs e)
        {
            string path4 = @"HmiRTm";
            closeProc(path4);
            System.Threading.Thread.Sleep(1000);
            if (!File.Exists(pathIni))
            {
                using (File.Create(pathIni)) { };
            }

            Enfon画面选择.IniFileHelper.SetValue("configuration", "LoadConfigfile", Disk2, pathIni);
            string path3 = pathExe;
            System.Diagnostics.Process.Start(path3);
        }

        private void Button_画面三(object sender, RoutedEventArgs e)
        {
            string path4 = @"HmiRTm";
            closeProc(path4);
            System.Threading.Thread.Sleep(1000);
            if (!File.Exists(pathIni))
            {
                using (File.Create(pathIni)) { };
            }

            Enfon画面选择.IniFileHelper.SetValue("configuration", "LoadConfigfile", Disk3, pathIni);
            string path3 = pathExe;
            System.Diagnostics.Process.Start(path3);
        }
        private string local;
        private void readIniFile()
        {
            if (File.Exists(pathIni))
            {
                local= Enfon画面选择.IniFileHelper.GetValue("configuration", "LoadConfigfile", pathIni);
            }
            else
            {
                MessageBox.Show("文件加载失败，请确认是否存在此文件：" + pathIni);
            }
        }


      

     /*   private void Button_Click(object sender, RoutedEventArgs e)  //文件复制备份
        {
            string path4 = @"HmiRTm";  //需要关闭进程的名字，如果不知道进程的名称，可以通过closeProc里面的list去查找
            closeProc(path4);  //关闭进程
            System.Threading.Thread.Sleep(1000);
            string path1 = Disk1;
            string path2 = pathIni;
            readIniFile();
            FileInfo fi1 = new FileInfo(path1);
            FileInfo fi2 = new FileInfo(path2);

            try
            {
                // Create the source file.
                // using (FileStream fs = fi1.Create()) { }

                //Ensure that the target file does not exist.
                if (File.Exists(path2))
                {
                    fi2.Delete();
                }

                //Copy the file.f
                // fi1.CopyTo(path2);
                File.Copy(path1, path2, true);
                Console.WriteLine("{0} was copied to {1}.", path1, path2);
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }



            string path3 = pathExe;
            System.Diagnostics.Process.Start(path3);

        } */
    }
}
