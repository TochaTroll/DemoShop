using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace DemoTooooop
{
    /// <summary>
    /// Логика взаимодействия для ProductEdit.xaml
    /// </summary>
    public partial class ProductEdit : Window
    {
        private static Product _currentProduct = new Product();
        public ProductEdit(Product selectedProduct)
        {
            InitializeComponent();
            if(selectedProduct != null)
            {
                _currentProduct = selectedProduct;
            }
            DataContext = _currentProduct;
            ComboBoxCategory.ItemsSource = TradeNewEntities.GetContext().Category.ToList();       
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrEmpty(_currentProduct.ProductArticleNumber))
                error.AppendLine("Заполните артикул");
            if (string.IsNullOrEmpty(_currentProduct.ProductName))
                error.AppendLine("Заполните название");
            if (string.IsNullOrEmpty(_currentProduct.ProductDescription))
                error.AppendLine("Заполните описание");
            if (ComboBoxCategory.SelectedItem == null)
                error.AppendLine("Выберите категорию");
            if (TextBoxProductQuantityInStock.Text == "")
                error.AppendLine("Заполните количество");
            if (TextBoxProductQuantityInStock.Text == "0")
                error.AppendLine("Заполните количество");
            if (string.IsNullOrEmpty(_currentProduct.ProductUnit))
                error.AppendLine("Заполните ед. измерения");
            if (string.IsNullOrEmpty(_currentProduct.ProductProvider))
                error.AppendLine("Заполните поставщика");
            if (TextBoxProductDiscountAmount.Text == "0")
                error.AppendLine("Максимальная скидка не может быть 0");
            if (TextBoxProductSale.Text == "0")
                error.AppendLine("Cкидка не может быть 0");
            if(_currentProduct.ProductSale> _currentProduct.ProductDiscountAmount)
                error.AppendLine("Скидка не может превышать максимальную");
            if (TextBoxProductCost.Text == "0.00")
                error.AppendLine("Заполните стоимость");
            if (string.IsNullOrEmpty(_currentProduct.ProductManufacturer))
                error.AppendLine("Заполните производителя");
            if ( error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(TextBoxProductArticleNumber.IsReadOnly == false)
            {
                TradeNewEntities.GetContext().Product.Add(_currentProduct);
            }

            try
            {
                TradeNewEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButton.OK,MessageBoxImage.Information);
                this.Hide();
                ProductView productView = new ProductView();
                productView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }       
        }
        private void TextBoxProductQuantityInStock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }  
        private void TextBoxProductDiscountAmount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }
        private void TextBoxProductSale_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }
        private void TextBoxProductCost_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
