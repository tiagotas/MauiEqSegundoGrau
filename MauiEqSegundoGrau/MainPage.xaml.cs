namespace MauiEqSegundoGrau
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            double delta = (b * b) - (4 * a * c);

            double x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a); ;

            string msg = $"O resultado é {x1} e {x2}";

            DisplayAlert("Resultado", msg, "Fechar");


        }
    }

}
