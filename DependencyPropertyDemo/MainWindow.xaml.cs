using System.Windows;


namespace WpfApplication1 {
    /// <summary>  
    /// Interaction logic for DependencyPropertyDemo.xaml  
    /// </summary>  
    public partial class DependencyPropertyDemo : Window {
        public DependencyPropertyDemo() {
            InitializeComponent();
        }
        private void MyButton_Click(object sender, RoutedEventArgs e) {
            CarDependencyClass dpSample = TryFindResource("carDependencyClass") as CarDependencyClass;
            MessageBox.Show(dpSample.MyCar);
        }
    }
    public class CarDependencyClass : DependencyObject {
        //Register Dependency Property  
        public static readonly DependencyProperty CarDependencyProperty = DependencyProperty.Register("MyProperty", typeof(string), typeof(CarDependencyClass));
        public string MyCar {
            get {
                return (string)GetValue(CarDependencyProperty);
            }
            set {
                SetValue(CarDependencyProperty, value);
            }
        }
    }
}