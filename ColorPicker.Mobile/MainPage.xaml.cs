namespace ColorPicker.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = sldRed.Value;
            double green = sldGreen.Value;
            double blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);

            SetColor(color);
        }

        private void SetColor(Color color)
        {
            btnRandom.BackgroundColor = color;
            container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }
    }
}