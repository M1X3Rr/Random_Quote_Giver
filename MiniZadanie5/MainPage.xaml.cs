
namespace MiniZadanie5
{
    public partial class MainPage : ContentPage
    {
        private Quotes quotes = new Quotes();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLabel.Text = String.Format("Value is {0:F2}", e.NewValue);
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            UpdateCitationLabel(CitationLabel);

            NextButton.Text = "Next";
        }

        private void UpdateCitationLabel(Label label)
        {
            string randomQuote = quotes.GetRandomQuote();

            label.Text = randomQuote;
        }
    }

}
