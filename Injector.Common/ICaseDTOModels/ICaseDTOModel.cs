namespace Injector.Common.ICaseDTOModels
{
    public interface ICaseDTOModel<T>
    {
        T GetDTOModel();
        void Consolidate();
        bool IsModelValid();
    }
}
