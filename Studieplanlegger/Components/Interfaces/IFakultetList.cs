using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IFakultetList
    {
        List<Fakultet> GetFakulteter();
        void AddFakultet(Fakultet fakultet);
        void RemoveFakultet(Fakultet fakultet);
        void UpdateFakultet(Fakultet oldFakultet, Fakultet newFakultet);
    }
}
