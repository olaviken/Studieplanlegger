using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class UndervisningskategoriList
    {
        public List<Undervisningskategori> undervisningskategorier;

        public UndervisningskategoriList()
        {
            undervisningskategorier = new List<Undervisningskategori>();
        }

        public void AddUndervisningskategori(Undervisningskategori undervisningskategori)
        {
            undervisningskategorier.Add(undervisningskategori);
        }

        public void RemoveUndervisningskategori(Undervisningskategori undervisningskategori)
        {
            undervisningskategorier.Remove(undervisningskategori);
        }

        public void UpdateUndervisningskategori(Undervisningskategori oldUndervisningskategori, Undervisningskategori newUndervisningskategori)
        {
            int index = undervisningskategorier.IndexOf(oldUndervisningskategori);
            if (index != -1)
            {
                undervisningskategorier[index] = newUndervisningskategori;
            }
        }   
    }
}
