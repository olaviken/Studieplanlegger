using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class EmneList : Interfaces.IEmneList
    {
        private List<Emne> emner;

        public List<Emne> GetEmner()
        {
            return emner;
        }

        public void Add(Emne emne)
        {
            emner.Add(emne);
        }

        public void Remove(Emne emne)
        {
            emner.Remove(emne);
        }

        public void Update(Emne oldEmne, Emne newEmne)
        {
            int index = emner.IndexOf(oldEmne);
            if (index != -1)
            {
                emner[index] = newEmne;
            }
        }

    }
}
