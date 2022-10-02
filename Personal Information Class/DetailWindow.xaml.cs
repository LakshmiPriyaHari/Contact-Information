using System.Windows;

namespace Personal_Information_Class
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        VM vm;
        public DetailWindow()
        {
            InitializeComponent();
            vm = VM.Instance;
            DataContext = vm;
        }
    }
}