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
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OP01(object sender, RoutedEventArgs e)
        {
 
            string path1 = @"D:\test\OP01\HmiRTm.ini";
            string path2 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTm.ini";
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



            string path3 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTM.exe";
            System.Diagnostics.Process.Start(path3);

        }

        private void Button_入库端(object sender, RoutedEventArgs e)
        {
            string path1 = @"D:\test\OP02\HmiRTm.ini";
            string path2 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTm.ini";
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
       
            string path3 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTM.exe";
            System.Diagnostics.Process.Start(path3);
        }

        private void Button_出库端(object sender, RoutedEventArgs e)
        {
            string path1 = @"D:\test\OP03\HmiRTm.ini";
            string path2 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTm.ini";
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
              
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }



            string path3 = @"C:\Program Files (x86)\Siemens\Automation\WinCC RT Advanced\HmiRTM.exe";
            System.Diagnostics.Process.Start(path3);
        }

       
    }
}
