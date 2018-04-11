using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace FactoryPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Component> listItems = new List<Component>();

        public MainWindow()
        {
            InitializeComponent();

            AddedComponents.DataContext = listItems;
        }

        public void MakeNewComponent()
        {
            //Component c = new Component(); take in numbers from UI
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightAmount.Text = HeightSlider.Value.ToString();
            WidthAmount.Text = WidthSlider.Value.ToString();
            XAmount.Text = XSlider.Value.ToString();
            YAmount.Text = YSlider.Value.ToString();
        }

        private void AddComponenet_Click(object sender, RoutedEventArgs e)
        {
            Component c = new Component(HeightSlider.Value, WidthSlider.Value, XSlider.Value, YSlider.Value);
            listItems.Add(c);
            ListBoxItem itm = new ListBoxItem();
            itm.Content = c.ToString();
            AddedComponents.Items.Add(itm);
        }
    }
}
