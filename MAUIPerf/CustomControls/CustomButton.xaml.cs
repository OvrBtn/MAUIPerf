namespace MAUIPerf
{
    public partial class CustomButton : ContentView
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(Command), typeof(CustomButton));
        public Command Command
        {
            get => (Command)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(CustomButton));
        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomButton), 20);
        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        new public static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(CustomButton), Colors.Transparent);
        new public Color BackgroundColor
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        new public static readonly BindableProperty ShadowProperty = BindableProperty.Create(nameof(Shadow), typeof(Shadow), typeof(CustomButton), new Shadow() { Radius = 0 });
        new public Shadow Shadow
        {
            get => (Shadow)GetValue(ShadowProperty);
            set => SetValue(ShadowProperty, value);
        }

        public event Action OnClick;

        public CustomButton()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Command?.Execute(CommandParameter);
            OnClick?.Invoke();
        }
    }
}
