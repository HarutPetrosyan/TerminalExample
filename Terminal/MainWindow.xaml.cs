using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using Terminal.Models.API.BillValidator;

namespace Terminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            content.Content = new Views.Contents.Content().contentGrid;
            footer.Content = new Views.Footers.Footer().footerGrid;
            header.Content=new Views.Headers.Header().headerGrid;
            MainWindowcontentBody = content;


            //this.WindowState = WindowState.Maximized;
            // this.WindowStyle = WindowStyle.None;




            




            //InCommingSocket Socket = new InCommingSocket();
            //Socket.BillValidatorSocketRun();
            //InitializeBillValidator();

            new Models.Loadings.Loadings();
            WaitPage = WaitFrame;
            WaitTransform = WaitGridRotateTransform;
            WaitGrid = WaitTransformGrid;

           new Terminal.Models.Wait.WaitPageAnimation();
        }


        public static Frame WaitPage;

        public static Grid WaitGrid;
        public static RotateTransform WaitTransform;


        public static Frame MainWindowcontentBody;

        private async void InitializeBillValidator()
        {

            await Task.Factory.StartNew(() => { 
            
             while (InCommingSocket.BillValidatorSocket.State != System.Net.WebSockets.WebSocketState.Open)
            {
                 Task.Delay(100);
            }
            new Commands().Start();

             Task.Delay(5000);
            new Commands().StopListening();
            
            
            });
           
        }
    }
}
