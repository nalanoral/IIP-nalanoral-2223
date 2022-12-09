using System.Windows;

namespace WpfDatumkiezer
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

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            //  datapDate.SelectedDateFormat = datapDate.Custom;
           // datapDate.Custom = "MMMM dd, yyyy - dddd";
        }
        private void DatapDate_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //string date = datapDate.SelectedDate.ToString("dd MMMM yyyy");//

            string date = datapDate != null ? datapDate.SelectedDate.Value.ToString("dd MMMM yyyy") : null;
            lblDate.Content = " je selecteerde " + date;
        }
    }
}
