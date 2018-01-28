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
	        var r = _random.Next(256);
	        var g = _random.Next(256);
	        var b = _random.Next(256);
			
	        int level = 30;
			
	        string transparentColorString = "#FFFFFF";
	        string primaryColorString = $"#{r:X2}{g:X2}{b:X2}";

			var replaceMap = new Dictionary<string, string>()
	        {
				//{ "#CCCCCC", "#009FE3" },
				{ "#FILLCOLOR10", level>=10?primaryColorString:transparentColorString },
				{ "#FILLCOLOR20", level>=20?primaryColorString:transparentColorString },
				{ "#FILLCOLOR30", level>=30?primaryColorString:transparentColorString },
				{ "#FILLCOLOR40", level>=40?primaryColorString:transparentColorString },
				{ "#FILLCOLOR50", level>=50?primaryColorString:transparentColorString },
				//{ "#TEXT", Guid.NewGuid().ToString() },
			};
	         						
			InitializeComponent();

	        myViewModel = new MyViewModel() { ReplaceMap = replaceMap };
	        BindingContext = myViewModel;

			//TODO This would actually update the Replace String
			//CachedImage.ReplaceStringMap = ReplaceMap;

	        

			//Gif.Source =  
			//    ImageSource.FromUri(new Uri("https://media.giphy.com/media/l0Hlyi4ZMJI9MpFUQ/giphy.gif"));

		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
		    //TODO This does not work. ReplaceMap does not support binding
			myViewModel.ReplaceMap = new Dictionary<string, string>()
			{
				{ "#FILLCOLOR10", "#009FE3"},
				{ "#FILLCOLOR20", "#009FE3"},
				{ "#FILLCOLOR30", "#009FE3"},
				{ "#FILLCOLOR40", "#009FE3"},
				{ "#FILLCOLOR50", "#009FE3"},
			};
			
		}
    }
}
