using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IUndervisningskategoriList
    {
        List<Undervisningskategori> GetUndervisningskategorier();
        void AddUndervisningskategori(Undervisningskategori undervisningskategori);
        void RemoveUndervisningskategori(Undervisningskategori undervisningskategori);
        void UpdateUndervisningskategori(Undervisningskategori oldUndervisningskategori, Undervisningskategori newUndervisningskategori);
    }
}
