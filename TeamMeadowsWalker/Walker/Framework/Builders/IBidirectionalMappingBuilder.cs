namespace OTTO.Teams.Walker.Framework.Builders
{
	public interface IBidirectionalMappingBuilder<TFirst, TSecond>
	{
		// Complete definition
		IBidirectionalMapping<TFirst, TSecond> Build();
	}
}
