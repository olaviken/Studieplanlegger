using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IAnsattlist
    {
        List<Ansatt> GetAnsatte();

        void AddAnsatt(Ansatt ansatt);
        void RemoveAnsatt(Ansatt ansatt);
        void UpdateAnsatt(Ansatt oldAnsatt, Ansatt newAnsatt);
    }
}
