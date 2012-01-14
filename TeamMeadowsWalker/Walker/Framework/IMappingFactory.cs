using Mapper.Teams.Walker.Framework.Builders;

namespace Mapper.Teams.Walker.Framework
{
	public interface IMappingFactory
	{
		IMappingBuilder<TSource, TTarget> Map<TSource, TTarget>();
		IBidirectionalMappingBuilder<TFirst, TSecond> CreateReversible<TFirst, TSecond>();
	}
}
