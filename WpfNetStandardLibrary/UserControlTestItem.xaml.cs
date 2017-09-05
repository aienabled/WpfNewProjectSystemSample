namespace Sample.Library
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControlTestItem : UserControl
    {
        public static readonly DependencyProperty TestTextProperty =
            DependencyProperty.Register(
                nameof(TestText),
                typeof(string),
                typeof(UserControlTestItem),
                new PropertyMetadata(default(string)));

        public UserControlTestItem()
        {
            this.InitializeComponent();
        }

        public string TestText
        {
            get => (string)this.GetValue(TestTextProperty);
            set => this.SetValue(TestTextProperty, value);
        }
    }
}