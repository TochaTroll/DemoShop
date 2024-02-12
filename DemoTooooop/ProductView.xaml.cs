using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoTooooop
{
    /// <summary>
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public ProductView()
        {
            InitializeComponent();
            VisibilityContent();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            TradeNewEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(x=>x.Reload());
            ListBoxProduct.ItemsSource = TradeNewEntities.GetContext().Product.ToList();
            TextBlockUserFullName.Text = SessionData.CurrentUser.UserFullName;
            TextBlockUserRole.Text = SessionData.CurrentUser.Role.RoleName;
            TextBockNowCountProduct.Text = TradeNewEntities.GetContext().Product.Count().ToString() + "-";
            TextBockCountProduct.Text = TradeNewEntities.GetContext().Product.Count().ToString();
        }
        private void UpdateProduct()
        {
            var currentProduct = TradeNewEntities.GetContext().Product.ToList();

            //поиск по названию
            currentProduct = currentProduct.Where(x=>x.ProductName.ToLower().Contains(TextBoxSearhName.Text.ToLower())).ToList();

            // сортировка по цене
            if(ComboBoxCost.SelectedIndex != 0)
            {          
                if (ComboBoxCost.SelectedIndex == 1)
                {
                    currentProduct = currentProduct.OrderBy(x=>x.ProductCost).ToList();
                }

                if (ComboBoxCost.SelectedIndex == 2)
                {
                    currentProduct = currentProduct.OrderByDescending(x => x.ProductCost).ToList();
                }
            }
            // филтрация по скидке
            if(ComboBoxSale.SelectedIndex!= 0)
            {
                if(ComboBoxSale.SelectedIndex == 1)
                {
                    currentProduct = currentProduct.Where(x=>x.ProductSale<10).ToList();
                }
                if (ComboBoxSale.SelectedIndex == 2)
                {
                    currentProduct = currentProduct.Where(x => x.ProductSale >= 10 && x.ProductSale < 15).ToList();
                }
                if (ComboBoxSale.SelectedIndex == 3)
                {
                    currentProduct = currentProduct.Where(x => x.ProductSale >= 15).ToList();
                }
            }
            ListBoxProduct.ItemsSource = currentProduct;
            TextBockNowCountProduct.Text = currentProduct.Count.ToString() + "-";
        }
        private void VisibilityContent()
        {
            if (SessionData.CurrentUser.UserRole == 3)
            {
                ButtonAddProduct.Visibility = Visibility.Visible;
                ButtonRemoveProduct.Visibility = Visibility.Visible;
                ButtonEditProduct.Visibility = Visibility.Visible;
            }
            else
            {
                ButtonEditProduct.Visibility = Visibility.Hidden;
                ButtonRemoveProduct.Visibility = Visibility.Hidden;
                ButtonAddProduct.Visibility = Visibility.Hidden;
            }
        }
        private void TextBoxSearhName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateProduct();
        }
        private void ComboBoxCost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }
        private void ComboBoxSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }
        private void ButtonRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            var productRemoving = ListBoxProduct.SelectedItems.Cast<Product>().ToList();
            if (ListBoxProduct.SelectedItem != null)
            {
                if (MessageBox.Show("Вы точно хоите удалить выбранный товар", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        TradeNewEntities.GetContext().Product.RemoveRange(productRemoving);
                        TradeNewEntities.GetContext().SaveChanges();
                        MessageBox.Show("Товар успешно удален", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                        ListBoxProduct.ItemsSource = TradeNewEntities.GetContext().Product.ToList();
                        TextBockNowCountProduct.Text = TradeNewEntities.GetContext().Product.Count().ToString() + "-";
                        TextBockCountProduct.Text = TradeNewEntities.GetContext().Product.Count().ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else MessageBox.Show("Выберите товар", "Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
        }     
        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            this.Hide();
            ProductEdit productEdit = new ProductEdit(product);
            productEdit.Show();
        }
        private void ButtonEditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxProduct.SelectedItem != null)
            {
                this.Hide();
                ProductEdit productEdit = new ProductEdit(ListBoxProduct.SelectedItem as Product);
                productEdit.TextBoxProductArticleNumber.IsReadOnly = true;
                productEdit.Show();
            }
            else MessageBox.Show("Выберите товар", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ButtonMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
