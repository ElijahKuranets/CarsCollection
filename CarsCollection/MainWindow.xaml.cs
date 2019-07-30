using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using StoreDatabase;

namespace CarsCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICollection<Product> products;
        private ListCollectionView view;
        public MainWindow()
        {
            StoreDB storeDb = new StoreDB();
            InitializeComponent();
            products = storeDb.GetProducts();

            this.DataContext = products;
            view = (ListCollectionView)CollectionViewSource.GetDefaultView(this.DataContext);
            view.CurrentChanged += new EventHandler(view_CurrentChanged);

            lstProducts.ItemsSource = products;
        }
        private void cmdNext_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToNext();
        }
        private void cmdPrev_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToPrevious();
        }
        private void lstProducts_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // view.MoveCurrentTo(lstProducts.SelectedItem);
        }
        private void view_CurrentChanged(object sender, EventArgs e)
        {
            lblPosition.Text = "Record " + (view.CurrentPosition + 1) +
                               " of " + view.Count;
            cmdPrev.IsEnabled = view.CurrentPosition > 0;
            cmdNext.IsEnabled = view.CurrentPosition < view.Count - 1;
        }
    }
}
