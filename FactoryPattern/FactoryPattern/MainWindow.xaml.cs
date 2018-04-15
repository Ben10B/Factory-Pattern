using GUIWriterLibrary;
using GUIWriterLibrary.Models;
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightAmount.Text = HeightSlider.Value.ToString();
            WidthAmount.Text = WidthSlider.Value.ToString();
            XAmount.Text = XSlider.Value.ToString();
            YAmount.Text = YSlider.Value.ToString();
        }

        private void AddComponenet_Click(object sender, RoutedEventArgs e)
        {
            Component c = new Component((GUIType)TypeEntry.SelectedIndex, TextEntry.Text, HeightSlider.Value, WidthSlider.Value, XSlider.Value, YSlider.Value);
            listItems.Add(c);
            ListBoxItem itm = new ListBoxItem();
            itm.Content = c.ToString();
            AddedComponents.Items.Add(itm);
        }

        private void RemoveComponenet_Click(object sender, RoutedEventArgs e)
        {
            if(AddedComponents.Items.Count >= 1)
            {
                AddedComponents.Items.RemoveAt(listItems.Count() - 1);
                listItems.RemoveAt(listItems.Count() - 1);
            }
        }

        private void CreateWPF_Click(object sender, RoutedEventArgs e)
        {
            CSharpFactory wpf = new CSharpFactory();
            wpf.createGUI(listItems);
            Reset();
        }

        private void CreateHTML_Click(object sender, RoutedEventArgs e)
        {
            HTMLFactory html = new HTMLFactory();
            html.createGUI(listItems);
            Reset();
        }

        private void Reset()
        {
            AddedComponents.Items.Clear();
            listItems.Clear();
            TextEntry.Text = "";
            HeightSlider.Value = 0;
            WidthSlider.Value = 0;
            XSlider.Value = 0;
            YSlider.Value = 0;
        }
    }
}
