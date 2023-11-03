using System.Windows;
using System.Windows.Controls;


namespace SFDepedSharp.Views.components
{
    /// <summary>
    /// Interaction logic for TextBoxCustom.xaml
    /// </summary>
    public partial class TextBoxCustom : UserControl
    {
        public TextBoxCustom()
        {
            InitializeComponent();
        }


        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(TextBoxCustom));


        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string), typeof(TextBoxCustom));
    }
}
