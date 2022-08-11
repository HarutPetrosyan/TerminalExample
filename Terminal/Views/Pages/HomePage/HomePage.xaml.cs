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

namespace Terminal.Views.Pages.ContentPage1
{
    /// <summary>
    /// Interaction logic for ContentPage1.xaml
    /// </summary>
    public partial class ContentPage1 : Page
    {
        public ContentPage1()
        {
           
            InitializeComponent();
           
            CustomerLogoFrame.Content = new UIComponents.CustomerLogo.CustomerLogo().CustomerLogoGrid;
            CustomerContactFrame.Content = new UIComponents.CustomerContacts.CustomerContacts().CustomerContactsGrid;
            
            
            CodeActivate.Content=new UIComponents.CodeActivate.CodeActivate().CodeActivateGrid;
           
            
          

        }
      
    }
}
