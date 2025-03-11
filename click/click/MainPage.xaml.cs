namespace click
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"{count}";
            //else
            //    CounterBtn.Text = $"{count}";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"{count}";
            else
                CounterBtn.Text = $"{count}";
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
