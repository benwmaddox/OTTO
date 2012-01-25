namespace OTTO.Teams.Walker.Framework
{
	public interface IBidirectionalMapping<TSource, TTarget> : IMapping<TSource, TTarget>
	// TODO  It wouldn't let me write ": IMapping<TSource, TTarget>, IMapping<TTarget, TSource>"
	{
		IBidirectionalMapping<TTarget, TSource> Reverse { get; } // TODO can't make this an implicit conversion, becuase implicit conversion to interface is not allowed
	}
}
