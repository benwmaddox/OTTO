using System;
using System.Linq.Expressions;

namespace OTTO.Teams.Walker.Framework.Builders
{
	public interface IMappingBuilder<TSource, TTarget>
	{
		// Hooks
		IMappingBuilder<TSource, TTarget> BeforeMapping(Action<TSource, TTarget> beforeFunction);
		IMappingBuilder<TSource, TTarget> AfterMapping(Action<TSource, TTarget> afterFunction);
	
		// custom mapping
		IMapping<TSource, TTarget> Using(Func<TSource, TTarget> mappingFunction);

		IMappingBuilder<TSource, TTarget> For<TTargetValue>(Expression<Func<TTarget, TTargetValue>> property);


		// Property mapping
		IMappingBuilder<TSource, TTarget> UseValue(object value); // Map from constant
		IMappingBuilder<TSource, TTarget> When(Func<TSource, TTarget, bool> condition); // Only Map when condition met
		IMappingBuilder<TSource, TTarget> MapFrom<TSourceValue>(Func<TSource, TSourceValue> sourceMember); // Map from lambda on source
		IMappingBuilder<TSource, TTarget> IsNull(object value); // Replace nulls with this value
		IMappingBuilder<TSource, TTarget> IsNull(Func<TSource, object> value);
		IMappingBuilder<TSource, TTarget> With<TSouceValue, TTargetValue>(IMapping<TSouceValue, TTargetValue> mapping); // To convert apply this map
		IMappingBuilder<TSource, TTarget> With<TSouceValue, TTargetValue>(IBidirectionalMapping<TTargetValue, TSouceValue> mapping);
		IMappingBuilder<TSource, TTarget> With<TSouceValue, TTargetValue>(Func<TSouceValue, TTargetValue> map);

		// Complete definition
		IMapping<TSource, TTarget> Build();
	}
}
