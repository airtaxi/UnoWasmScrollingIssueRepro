namespace UnoWasmScrollingIssueRepro;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        var viewModels = new List<TestViewModel>();
        for (int i = 0; i < 1000; i++)
        {
            viewModels.Add(new());
        }
        TestItemRepeater.ItemsSource = viewModels;
    }
}
