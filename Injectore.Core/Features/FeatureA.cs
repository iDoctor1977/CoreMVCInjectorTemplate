using System;
using Injector.Core.Steps.ASteps;
using Injector.Common.DTOModels;
using Injector.Common.IABases;
using Injector.Common.IFeatures;
using Injector.Common.IStores;
using Injector.Core.CaseDTOModels;

namespace Injector.Core.Features
{
    public class FeatureA : ABaseFeature, IFeatureA
    {
        private IABaseStep<DTOModelA> _createStep1;
        private IABaseStep<DTOModelA> _createStep2;
        private IABaseStep<DTOModelA> _createStep3;

        private IABaseStep<DTOModelA> _deleteStep1;
        private IABaseStep<DTOModelA> _deleteStep2;

        private static IFeatureA FeatureAInstance { get; set; }

        #region CONSTRUCTOR

        private FeatureA() { }

        private FeatureA(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        #region SINGLETON

        public static IFeatureA Instance()
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA();
            }

            return FeatureAInstance;
        }

        public static IFeatureA Instance(ICoreStore coreStore)
        {
            if (FeatureAInstance == null)
            {
                FeatureAInstance = new FeatureA(coreStore);
            }

            return FeatureAInstance;
        }

        #endregion

        public bool CreatePost(DTOModelA dtoModelA)
        {
            _createStep1 = new CreateStep1A();
            _createStep2 = new CreateStep2A();
            _createStep3 = new CreateStep3A(); ;

            // chain definition
            _createStep1.SetNextStep(_createStep2);
            _createStep2.SetNextStep(_createStep3);

            CaseDTOModelA caseDTOModelsA = new CaseDTOModelA(dtoModelA);
            caseDTOModelsA.consolidate();

            dtoModelA = _createStep1.Execute(dtoModelA);

            if (dtoModelA.Id != 0)
            {
                return true;
            }

            return false;
        }

        public DTOModelA DeleteGet(DTOModelA dtoModelA)
        {
            _deleteStep1 = new DeleteStep1A();
            _deleteStep2 = new DeleteStep2A();

            _deleteStep1.SetNextStep(_deleteStep2);

            dtoModelA = _deleteStep1.Execute(dtoModelA);

            return dtoModelA;
        }

        public bool DeletePost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA EditGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public bool EditPost(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA DetailsGet(DTOModelA dtoModelA)
        {
            throw new System.NotImplementedException();
        }

        public DTOModelA ListGet(DTOModelA dtoModelA)
        {
            throw new NotImplementedException();
        }
    }
}
