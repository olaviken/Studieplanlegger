using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class FakultetList
    {
        public List<Fakultet> fakulteter;

        public FakultetList()
        {
            fakulteter = new List<Fakultet>();
        }

        public void AddFakultet(Fakultet fakultet)
        {
            fakulteter.Add(fakultet);
        }

        public void RemoveFakultet(Fakultet fakultet)
        {
            fakulteter.Remove(fakultet);
        }

        public void UpdateFakultet(Fakultet oldFakultet, Fakultet newFakultet)
        {
            int index = fakulteter.IndexOf(oldFakultet);
            if (index != -1)
            {
                fakulteter[index] = newFakultet;
            }
        }
    }
}
