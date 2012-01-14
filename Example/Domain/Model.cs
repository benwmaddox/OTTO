namespace Mapper.Example.Domain
{
	public class Model
	{
		public Model(string constructedProperty)
		{
			ConstructedProperty = constructedProperty;
		}

		public string BasicProperty { get; set; }
		public SubModel Sub { get; set; }
		public string ConstructedProperty { get; private set; }
		
		public string GetShouldBeProperty ()
		{
			return null;
		}
		public void SetShouldBeProperty(string value)
		{
		}

		public CodeValue NeedsDependency { get; set; }
		public decimal NeedsFormatted { get; set; }
	}
}
