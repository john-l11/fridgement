namespace fridgement.Components;

/// <summary>
/// This is the base of a modal which can be used for other modals
/// </summary>
public class ModalView : ContentView
{
	public Boolean IsOpen { get; set; }

	public ModalView(string Title, ContentView content)
	{
		Button closeButton = new Button { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "X", TextColor = Color.FromRgb(255, 0, 0) };
		closeButton.Clicked += onClose;

		Content = new VerticalStackLayout
		{
			IsVisible = IsOpen,
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = Title},
				closeButton,
				content
			}
		};
	}

	/// <summary>
	/// This function will be used as a listener for when the modal is requested to close.
	/// </summary>
	private void onClose(object sender, EventArgs e)
	{
		this.IsOpen = false;
	}
}