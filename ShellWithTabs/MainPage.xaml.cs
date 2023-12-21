using ShellWithTabs.ViewModels;

namespace ShellWithTabs;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(HomePageViewModel vm)
	{
		this.BindingContext = vm;
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
	    
	}
}

