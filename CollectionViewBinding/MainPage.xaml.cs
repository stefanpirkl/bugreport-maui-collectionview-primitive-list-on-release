namespace CollectionViewBinding
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}