namespace PagerControlPolyfill
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "This is part of the WinUI API, must not change.")]
	public record PagerControlSelectedIndexChangedEventArgs(int NewPageIndex, int PreviousPageIndex) {}
}
