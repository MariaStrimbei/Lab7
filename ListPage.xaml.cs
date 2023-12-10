using Strimbei_Maria_Lab7.Models;
namespace Strimbei_Maria_Lab7;
public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var selectedProduct = (Product)listView.SelectedItem;

        if (selectedProduct != null)
        {
            var shopList = (ShopList)BindingContext;

            await App.Database.DeleteProductAsync(selectedProduct);

            
            listView.ItemsSource = await App.Database.GetListProductsAsync(shopList.ID);
        }
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var shopl = (ShopList)BindingContext;

        listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
    }
}
