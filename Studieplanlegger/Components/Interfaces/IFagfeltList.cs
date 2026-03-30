using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IFagfeltList
    {
        List<Fagfelt> GetFagfelter();
        void AddFagfelt(Fagfelt fagfelt);
        void RemoveFagfelt(Fagfelt fagfelt);
        void UpdateFagfelt(Fagfelt oldFagfelt, Fagfelt newFagfelt);
    }
}
