namespace SliderAplikacja
{
   

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Suwak_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            wynikSuwaka.Text = "Temperatura: " +
                e.NewValue.ToString("F0") + "°C";
        }

        private void Licznik_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            wynikLicznika.Text = "Liczba osób: " +
                e.NewValue.ToString("F0");
        }
    }
}
