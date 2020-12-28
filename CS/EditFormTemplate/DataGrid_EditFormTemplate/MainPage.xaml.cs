using Xamarin.Forms;
using DevExpress.XamarinForms.DataGrid;

namespace DataGrid_EditFormTemplate {
    public partial class MainPage : ContentPage {
        public MainPage() {
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            InitializeComponent();
        }

        private void DataGridView_DoubleTap(object sender, DataGridGestureEventArgs e) {
            if (e.Item != null) {
                var editForm = new EditFormPage(grid, grid.GetItem(e.RowHandle),
                                (DataTemplate)Resources["CustomEditFormContent"]);
                Navigation.PushAsync(editForm);
            }
        }
    }
}
