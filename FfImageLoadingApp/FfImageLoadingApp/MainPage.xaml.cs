using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FfImageLoadingApp
{
    public partial class MainPage : ContentPage
    {
	    private Random _random = new Random();
	    private MyViewModel myViewModel;

	    public MainPage()
        {
	        myViewModel = new MyViewModel() { ReplaceMap = CreateRandomReplaceMap() };
	        BindingContext = myViewModel;

			InitializeComponent();	       	
		}
	    
	    private void Button_OnClicked(object sender, EventArgs e)
	    {
		    //Binding does not work. ReplaceMap does not support binding
		    myViewModel.ReplaceMap = CreateRandomReplaceMap();
	    }
	    private void Button2_OnClicked(object sender, EventArgs e)
	    {
			//Setting it directly on the control even does not work
		    CachedImage.ReplaceStringMap = CreateRandomReplaceMap();			
		}
	    private void Button3_OnClicked(object sender, EventArgs e)
	    {
			//Setting it directly on the control and then updating the Source even doesn´t work		    
			CachedImage.ReplaceStringMap = CreateRandomReplaceMap();
		    CachedImage.Source = "resource://FfImageLoadingApp.svg - Copy.svg";
		    CachedImage.Source = "resource://FfImageLoadingApp.svg.svg";
	    }

	    private Dictionary<string, string> CreateRandomReplaceMap()
	    {
		    var r = _random.Next(256);
		    var g = _random.Next(256);
		    var b = _random.Next(256);

		    string randomColor = $"#{r:X2}{g:X2}{b:X2}";

		    return new Dictionary<string, string>()
		    {
			    {"#FILLCOLOR10", randomColor},
			    {"#FILLCOLOR20", randomColor},
			    {"#FILLCOLOR30", randomColor},
			    {"#FILLCOLOR40", randomColor},
			    {"#FILLCOLOR50", randomColor},
		    };
	    }

	}
}
