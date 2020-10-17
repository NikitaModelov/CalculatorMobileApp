using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton : ContentView
    {
        public static readonly BindableProperty CustomButtonContentProperty = BindableProperty.Create(
            "ButtonContent",
            typeof(string),
            typeof(CustomButton),
            string.Empty);

        public static readonly BindableProperty CustomButtonColorTextProperty = BindableProperty.Create(
            "ContentColor",
            typeof(Color),
            typeof(CustomButton));

        public string ButtonContent
        {
            get => (string)GetValue(CustomButton.CustomButtonContentProperty);
            set => SetValue(CustomButton.CustomButtonContentProperty, value);
        }

        public Color ContentColor
        {
            get => (Color)GetValue(CustomButtonColorTextProperty);
            set => SetValue(CustomButtonColorTextProperty, value);
        }

        public CustomButton()
        {
            InitializeComponent();
        }
    }
}