using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class EmneList
    {
        public List<Emne> emner;

        public EmneList()
        {
            emner = new List<Emne>();
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
