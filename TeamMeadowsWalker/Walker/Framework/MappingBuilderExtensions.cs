using System;
using OTTO.Teams.Walker.Framework.Builders;

namespace OTTO.Teams.Walker.Framework
{
	public static class MappingBuilderExtensions
	{
		public static IMappingBuilder<TSource, TTarget> InheritFrom<TSource, TTarget, TSourceBase, TTargetBase>(IMapping<TSource, TTarget> mapping, IMapping<TSourceBase, TTargetBase> parent)
			where TSource : TSourceBase
			where TTarget : TTargetBase
		{
			throw new NotImplementedException();
		}
	}
}
