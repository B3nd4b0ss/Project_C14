using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.IconPacks;


namespace Project_C14.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuButton.xaml
    /// </summary>
    public partial class TopMenubutton : UserControl
    {
        public TopMenubutton()
        {
            InitializeComponent();
        }

        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(TopMenubutton));


        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(TopMenubutton));
    }
}
