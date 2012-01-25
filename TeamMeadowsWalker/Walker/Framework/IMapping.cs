using OTTO.Teams.Walker.Framework.Syntax;

namespace OTTO.Teams.Walker.Framework
{
	public interface IMapping<TSource, TTarget>
	{
		IBidirectionalMapping<TSource, TTarget> JoinToReverse(IMapping<TTarget, TSource> reverse); // This might be an internal method
		IMapTarget<TTarget> Map(TSource source);
	}
}
