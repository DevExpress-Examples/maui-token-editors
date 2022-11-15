using System.Collections.ObjectModel;

namespace TokenEdits_GetStarted {
    public partial class MainPage : ContentPage {
        readonly ObservableCollection<string> itemsSource = new ObservableCollection<string> {
                "Apple",
                "ASUS",
                "BlackBerry",
                "Google",
                "HUAWEI",
                "LG",
                "Motorola",
                "Nokia",
                "OnePlus",
                "Panasonic",
                "SAMSUNG",
                "Sony",
                "Xiaomi",
                "ZTE"
        };
        void AsyncItemsSourceProvider_ItemsRequested(System.Object sender, DevExpress.Maui.Editors.ItemsRequestEventArgs e) {
            e.Request = () => this.itemsSource.Where(i => i.Contains(e.Text, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
        public MainPage() {
            InitializeComponent();
        }
    }
}
