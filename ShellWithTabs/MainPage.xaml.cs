using ShellWithTabs.ViewModels;

namespace ShellWithTabs;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainPageViewModel vm)
	{
		this.BindingContext = vm;
		InitializeComponent();
	}

	
}

