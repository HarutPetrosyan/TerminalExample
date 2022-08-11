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

namespace Terminal.Views.Contents
{
    /// <summary>
    /// Interaction logic for Content.xaml
    /// </summary>
    public partial class Content : Page
    {
        public Content()
        {
            InitializeComponent();
            contentFrame.Content = new Pages.ContentPage1.ContentPage1().ContentPage1Grid;
            ContentGridBody = contentGrid;
        }
        public static Grid ContentGridBody;
       
        
    }
}
