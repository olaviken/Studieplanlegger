using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class FakultetList : Interfaces.IFakultetList
    {
        private List<Fakultet> fakulteter;

        public List<Fakultet> GetFakulteter()
        {
            return fakulteter;
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
