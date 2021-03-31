using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.Windows.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ComboBoxColumnsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DataGrid_FilterItemsPopulated(object sender, Syncfusion.UI.Xaml.Grid.GridFilterItemsPopulatedEventArgs e)
        {
            (e.ItemsSource as List<FilterElement>).Sort(new FilterElementComparer());
        }
    }
    public class FilterElementComparer : IComparer<FilterElement>
    {
        public int Compare(FilterElement x, FilterElement y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're 
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y 
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null... 
                // 
                if (y == null)
                // ...and y is null, x is greater. 
                {
                    return 1;
                }
                else
                {
                    return x.DisplayText.CompareTo(y.DisplayText);
                }
            }
        }
    }
}
