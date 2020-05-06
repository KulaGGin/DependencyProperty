using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace DependencyPropertyTutorial {
    /// <summary>  
    /// Interaction logic for CustomButtonControl.xaml  
    /// </summary>  
    public partial class CustomButtonControl : UserControl {
        public CustomButtonControl() {
            InitializeComponent();
        }
        public static readonly DependencyProperty btnDependencyProperty = DependencyProperty.Register("SetBackground", typeof(SolidColorBrush), typeof(CustomButtonControl), new PropertyMetadata(new SolidColorBrush(Colors.HotPink), new PropertyChangedCallback(OnSetColorChanged)));
        public SolidColorBrush SetBackground {
            set {
                SetValue(btnDependencyProperty, value);
            }
            get {
                return (SolidColorBrush)GetValue(btnDependencyProperty);
            }
        }
        private void btnCustom_Click(object sender, RoutedEventArgs e) {
            this.SetBackground = new SolidColorBrush(Colors.IndianRed);
        }
        private static void OnSetColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            CustomButtonControl mycontrol = d as CustomButtonControl;
            mycontrol.callmyInstanceMethod(e);
        }
        private void callmyInstanceMethod(DependencyPropertyChangedEventArgs e) {
            btnCustom.Background = (SolidColorBrush)e.NewValue;
        }
    }
}