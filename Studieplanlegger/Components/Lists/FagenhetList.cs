using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class FagenhetList
    {
        public List<Fagenhet> fagenheter;

        public FagenhetList()
        {
            fagenheter = new List<Fagenhet>();
        }

        public void AddFagenhet(Fagenhet fagenhet)
        {
            fagenheter.Add(fagenhet);
        }

        public void RemoveFagenhet(Fagenhet fagenhet)
        {
            fagenheter.Remove(fagenhet);
        }

        public void UpdateFagenhet(Fagenhet oldFagenhet, Fagenhet newFagenhet)
        {
            int index = fagenheter.IndexOf(oldFagenhet);
            if (index != -1)
            {
                fagenheter[index] = newFagenhet;
            }
        }
    }
}
