
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Personal_Information_Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly VM vm;
        //create instance of detail window
        DetailWindow dw;
        public MainWindow()
        {
            InitializeComponent();
            vm = VM.Instance;
            DataContext = vm;
            MainGrid.Background = new LinearGradientBrush(Colors.LightPink, Colors.Bisque, 60);
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if detail window(dw) is null we are going to create one , then we will listen to clodes event and then show (dw.show())
            if (dw == null)
            {
                dw = new DetailWindow();
                dw.Background = new LinearGradientBrush(Colors.LightBlue, Colors.Bisque, 60);
                dw.Owner = this;
                //when detail window closes and re-ini dw to null so we will listem to events
                dw.Closed += Dw_Closed;
                dw.Show();
            }
        }
        private void Dw_Closed(object? sender, System.EventArgs e)
        {
            dw = null;
        }
    }
}
