using Xamarin.Forms;

namespace DataGrid_AdvancedColumnLayout {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new EmployeesRepository();
        }

    }
}
