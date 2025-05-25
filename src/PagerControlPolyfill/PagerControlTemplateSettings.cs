using Microsoft.UI.Xaml;
using System.Collections.Generic;

namespace PagerControlPolyfill
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "This is part of the WinUI API, must not change.")]
	public class PagerControlTemplateSettings : DependencyObject
	{
		public IList<object> Pages
		{
			get { return (IList<object>)GetValue(PagesProperty); }
			set { SetValue(PagesProperty, value); }
		}
		public static readonly DependencyProperty PagesProperty =
			DependencyProperty.Register("Pages", typeof(IList<object>), typeof(PagerControlTemplateSettings), new PropertyMetadata(new List<object>()));

		public IList<object> NumberPanelItems
		{
			get { return (IList<object>)GetValue(NumberPanelItemsProperty); }
			set { SetValue(NumberPanelItemsProperty, value); }
		}
		public static readonly DependencyProperty NumberPanelItemsProperty =
			DependencyProperty.Register("NumberPanelItems", typeof(IList<object>), typeof(PagerControlTemplateSettings), new PropertyMetadata(new List<object>()));
	}
}
