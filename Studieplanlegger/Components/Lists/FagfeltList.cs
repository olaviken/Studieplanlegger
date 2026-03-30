using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class FagfeltList :Interfaces.IFagfeltList
    {
        private List<Fagfelt> fagfelter;

        public List<Fagfelt> GetFagfelter()
        {
            return fagfelter;
        }

        public void AddFagfelt(Fagfelt fagfelt)
        {
            fagfelter.Add(fagfelt);
        }

        public void RemoveFagfelt(Fagfelt fagfelt)
        {
            fagfelter.Remove(fagfelt);
        }

        public void UpdateFagfelt(Fagfelt oldFagfelt, Fagfelt newFagfelt)
        {
            int index = fagfelter.IndexOf(oldFagfelt);
            if (index != -1)
            {
                fagfelter[index] = newFagfelt;
            }
        }
    }
}
