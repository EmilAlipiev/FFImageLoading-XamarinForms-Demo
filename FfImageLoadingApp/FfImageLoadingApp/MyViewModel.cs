using System.Collections.Generic;

namespace FfImageLoadingApp
{
	public class MyViewModel : GalaSoft.MvvmLight.ViewModelBase
	{
		private Dictionary<string, string> _replaceMap;
		public Dictionary<string, string> ReplaceMap
		{
			get => _replaceMap;
			set { Set(() => ReplaceMap, ref _replaceMap, value); }
		}
	}
}