using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IFagenhetList
    {
        List<Fagenhet> GetFagenheter();
        void AddFagenhet(Fagenhet fagenhet);
        void RemoveFagenhet(Fagenhet fagenhet);
        void UpdateFagenhet(Fagenhet oldFagenhet, Fagenhet newFagenhet);
    }
}
