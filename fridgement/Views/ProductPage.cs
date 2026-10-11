using fridgement.Interface;

namespace fridgement.Views;

public class ProductPage : ContentPage
{
	// we need to make a web request to the backend database before the page renders
	// once I discover how to use redis then I should be able to render the data more
	// faster

	// TODO: learn how to use redis then make a fetch statement to the server for
	//  the data
	
	/// <summary>
	/// This function will be used to fetch all the products that are stored the database
	/// </summary>
	/// <returns>This function will return the array of products to be displayed</returns>
	/// <exception cref="NotImplementedException">Im just stubbing shit, leave me alone.</exception>
	public List<Product> FetchProducts()
	{
		// we are going to use data streaming to allow for sorting and searching
		throw new NotImplementedException();
	}

	public ProductPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label {
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Text = "Welcome to .NET MAUI!",
				},
			}
		};
	}
}