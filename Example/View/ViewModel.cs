namespace OTTO.Example.View
{
	public class ViewModel
	{
		public string BasicProperty { get; set; }
		public string SubProperty { get; set; }
		public string ConstructedProperty { get; private set; }
		public string ShouldBeProperty { get; set; }
		public int NeedsDependency { get; set; }
		public string NeedsFormatted { get; set; }
	}
}
