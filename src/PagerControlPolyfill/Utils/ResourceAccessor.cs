using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel.Resources;

namespace PagerControlPolyfill.Utils
{
	static class ResourceAccessor
	{
		public static string GetLocalizedStringResource(string name)
		{
			var resourceLoader = new ResourceManager().MainResourceMap;

			return resourceLoader?.GetValue("PagerControlPolyFill/Resources/" + name).ValueAsString!;
		}

		public static object? ResourceLookup(string name)
		{
			if (Application.Current.Resources.ContainsKey(name))
			{
				return Application.Current.Resources[name];
			}
			return null;
		}
	}
}
