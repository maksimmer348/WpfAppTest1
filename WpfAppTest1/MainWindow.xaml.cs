using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTest1;
/// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         Button btn = new Button();
         btn.Width = 10;
         btn.Height = 10;
         btn.Content = "Button1";
         btn.HorizontalAlignment = HorizontalAlignment.Left;
         btn.Background = (Brush)TypeDescriptor
             .GetConverter(typeof(Brush)).ConvertFromInvariantString("Red");
             //new SolidColorBrush(Colors.Red);
         layoutGrid.Children.Add(btn);
         
         Binding binding = new Binding();
 
        // binding.ElementName = "myTextBox"; // элемент-источник
         //binding.Path = new PropertyPath("Text"); // свойство элемента-источника
             //myTextBlock.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            string text = tBoxName.Text;

            if (text != "")
            {
                MessageBox.Show(text);
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
            if (((SolidColorBrush) this.Resources["RedColor"]).Color == Colors.Blue)
            {
                this.Resources["RedColor"] = new SolidColorBrush(Colors.Red);
            }
            else
            {
                this.Resources["RedColor"] = new SolidColorBrush(Colors.Blue);
            }

            ((Phone)this.Resources["MyPhone"]).Name = "Sony";
        }
        BindingExpression bindingExpression;
        private void LeftBtn_OnClick(object sender, RoutedEventArgs e)
        {
            bindingExpression = BindingOperations.GetBindingExpression(tBoxName, TextBox.TextProperty);
            bindingExpression.UpdateSource();
            rightBtn.Content = "ll";
        
        }
    }


