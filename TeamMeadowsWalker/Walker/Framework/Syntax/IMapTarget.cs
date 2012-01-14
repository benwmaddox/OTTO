namespace Mapper.Teams.Walker.Framework.Syntax
{
	public interface IMapTarget<TTarget>
	{
		void To(TTarget target);
		TTarget ToNew();
	}
}
