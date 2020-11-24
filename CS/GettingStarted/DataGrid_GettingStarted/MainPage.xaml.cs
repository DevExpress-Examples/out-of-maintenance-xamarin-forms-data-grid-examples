using Xamarin.Forms;
using DevExpress.XamarinForms.DataGrid;

namespace DataGrid_GettingStarted {
    public partial class MainPage : ContentPage {
        int count;

        public MainPage() {
            InitializeComponent();
        }

        void grid_CalculateCustomSummary(System.Object sender, DevExpress.XamarinForms.DataGrid.CustomSummaryEventArgs e) {
            if (e.FieldName.ToString() == "Shipped")
                if (e.IsTotalSummary) {
                    if (e.SummaryProcess == CustomSummaryProcess.Start) {
                        count = 0;
                    }
                    if (e.SummaryProcess == CustomSummaryProcess.Calculate) {
                        if (!(bool)e.FieldValue)
                            count++;
                        e.TotalValue = count;
                    }
                }
        }
    }
}
