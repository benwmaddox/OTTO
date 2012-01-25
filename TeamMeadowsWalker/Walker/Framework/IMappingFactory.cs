using OTTO.Teams.Walker.Framework.Builders;

namespace OTTO.Teams.Walker.Framework
{
	public interface IMappingFactory
	{
		IMappingBuilder<TSource, TTarget> Map<TSource, TTarget>();
		IBidirectionalMappingBuilder<TFirst, TSecond> CreateReversible<TFirst, TSecond>();
	}
}
