namespace MauiSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class ViewModel
    {
        public List<string> items = new();

        public ViewModel()
        {
            GenerateItems();
        }

        public List<string> Items
        {
            get => items;
        }

        void GenerateItems()
        {
            for (int i = 0; i < 1000; i++)
            {
                Items.Add("Label " + i.ToString());
            }
        }
    }
}


