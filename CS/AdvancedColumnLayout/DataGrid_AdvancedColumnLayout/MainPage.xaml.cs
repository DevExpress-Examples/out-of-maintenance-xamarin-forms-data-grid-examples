using Xamarin.Forms;

namespace DataGrid_AdvancedColumnLayout {
    public partial class MainPage : ContentPage {
        public MainPage() {
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            InitializeComponent();
            BindingContext = new EmployeesRepository();
        }

    }
}
