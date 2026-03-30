using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IEmneList
    {
        List<Emne> GetEmner();
        void Add(Emne emne);
        void Remove(Emne emne);
        void Update(Emne oldEmne, Emne newEmne);
    }
}
