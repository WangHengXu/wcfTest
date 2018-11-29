using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
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
using WcfService;

namespace WpfUPAddDwon
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = ClientSteta._clientStr;
        }
        private ServiceHost serviceHost;

        public void StartFileSrvice()
        {
            serviceHost = new ServiceHost(typeof(FileService));
            // Open the host and start listening for incoming messages.
            serviceHost.Open();
            MessageBox.Show("服务启动");
            // Keep the service running until Enter key is pressed.
        }
        public void EndFileService()
        {
            serviceHost.Close();
        }

        private void btnStartService_Click(object sender, RoutedEventArgs e)
        {
            StartFileSrvice();
        }

        private void btnEndService_Click(object sender, RoutedEventArgs e)
        {
            EndFileService();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            EndFileService();
        }
    }
}
