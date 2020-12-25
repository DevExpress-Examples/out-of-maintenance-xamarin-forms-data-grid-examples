using Xamarin.Forms;
using DevExpress.XamarinForms.DataGrid;

namespace DataGrid_EditForm
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            InitializeComponent();
        }

        private void Grid_Tap(object sender, DataGridGestureEventArgs e)
        {
            if (e.Item != null)
            {
                var editForm = new EditFormPage(grid, grid.GetItem(e.RowHandle));
                Navigation.PushAsync(editForm);
            }
        }
    }
}
