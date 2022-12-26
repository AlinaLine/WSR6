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

using WSR6.Entities;

namespace WSR6.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            DGridProduct.ItemsSource = demEntities.GetContext().Product.ToList();
        }

     
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = DGridProduct.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {productsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    demEntities.GetContext().Product.RemoveRange(productsForRemoving);
                    demEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено!");
                    DGridProduct.ItemsSource = demEntities.GetContext().Product.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                demEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridProduct.ItemsSource = demEntities.GetContext().Product.ToList();
            }

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
           Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Product));
        }

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }
    }
}
