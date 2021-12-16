namespace Injector.Common.ICaseDTOModels
{
    public interface ICaseDTOModel<T>
    {
        T GetDTOModel();
        void SetDTOModel(T dtoModel);
        void Consolidate();
        bool IsModelValid();
    }
}
