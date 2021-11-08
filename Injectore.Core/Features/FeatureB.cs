using Injector.Core.Steps.BSteps;
using Injector.Common.DTOModels;
using Injector.Common.IABases;
using Injector.Common.IFeatures;
 using Microsoft.Extensions.DependencyInjection;

namespace Injector.Core.Features
{
    public class FeatureB : ABaseFeature, IFeatureB
    {
        private IABaseStep<DTOModelB> _createStep1;
        private IABaseStep<DTOModelB> _createStep2;
        private IABaseStep<DTOModelB> _createStep3;

        public FeatureB(ServiceProvider service) : base(service) { }

        public bool CreatePost(DTOModelB dtoModelB)
        {
            _createStep1 = new CreateStep1B();
            _createStep2 = new CreateStep2B();
            _createStep3 = new CreateStep3B();

            // chain definition
            _createStep1.SetNextStep(_createStep2);
            _createStep2.SetNextStep(_createStep3);

            _createStep1.Execute(dtoModelB);

            if (dtoModelB.Id != 0)
            {
                return true;
            }

            return false;
        }

        public DTOModelB DeleteGet(DTOModelB dtoModelB)
        {
            // chain definition

            return dtoModelB;
        }

        public bool DeletePost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB EditGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB DetailsGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelB ListGet(DTOModelB dtoModelB)
        {
            throw new System.NotImplementedException();
        }
    }
}
