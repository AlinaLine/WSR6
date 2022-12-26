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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Product _currentProduct = new Product();
       
        public AddEditPage(Product selectedProduct)
        {
            InitializeComponent();
            if (selectedProduct != null)
                _currentProduct = selectedProduct;

            DataContext = _currentProduct;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //проверка на ошибки, перед сохранением

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentProduct.ProductArticleNumber))
                errors.AppendLine("Укажите айди!");
            if (string.IsNullOrWhiteSpace(_currentProduct.ProductName))
                errors.AppendLine("Укажите наименование!");
            if (string.IsNullOrWhiteSpace(_currentProduct.ProductDescription))
                errors.AppendLine("Укажите описание!");
            if (string.IsNullOrWhiteSpace(_currentProduct.ProductPhoto))
                errors.AppendLine("Укажите путь к фото!");
            if (string.IsNullOrWhiteSpace(_currentProduct.ProductManufacturer))
                errors.AppendLine("Укажите производителя!");  


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                demEntities.GetContext().Product.Add(_currentProduct);
                demEntities.GetContext().SaveChanges();
                MessageBox.Show("Сохранено!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void TxBox_ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Description_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Category_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Manufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Discount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Stock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxBox_Status_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBox_Image_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
