using Xamarin.Forms;

namespace DataGridView_PullToRefresh
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            InitializeComponent();
        }
    }
}
