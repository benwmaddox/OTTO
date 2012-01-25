using OTTO.Example.Domain;
using OTTO.Example.View;
using OTTO.Teams.Walker.Framework;

namespace OTTO.Teams.Walker
{
	public interface IModelMapper
	{
		ViewModel ToView(Model model);
		Model ToDomain(ViewModel viewModel);
	}

	// This class is configured as a singleton in the IOC container
	public class ModelMapper : IModelMapper
	{
		IBidirectionalMapping<Model, ViewModel> modelMapping;

		public ModelMapper(IMappingFactory mappingFactory)
		{
			modelMapping = mappingFactory.CreateReversible<Model, ViewModel>()
				//.For(x => x.BasicProperty).MapFrom(x => x.BasicProperty)
				.Build();
		}


		public ViewModel ToView(Model model)
		{
			throw new System.NotImplementedException();
		}

		public Model ToDomain(ViewModel viewModel)
		{
			throw new System.NotImplementedException();
		}
	}
}
