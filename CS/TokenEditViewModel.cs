namespace TokenEdits_GetStarted {
    public class TokenEditViewModel {
        public TokenEditViewModel() {
            ItemsSource = new List<ColorInfo> {
                new ColorInfo("Black","#000000"),
                new ColorInfo("Gray", "#e5e5e5"),
                new ColorInfo("Blue", "#1861ad"),
                new ColorInfo("Green", "#148f42"),
                new ColorInfo("Red", "#df3f3f"),
                new ColorInfo("Pink", "#f193f0")
        };
        }
        public IList<ColorInfo> ItemsSource { get; }
    }

    public class ColorInfo {
        public string ColorName { get; init; }
        public ImageSource Icon { get; init; }
        public ColorInfo(string name, string color) {
            ColorName = name;
            Icon = new FileImageSource() {
                File = "circle_" + name.ToLower(),
            };
        }
    }
}
