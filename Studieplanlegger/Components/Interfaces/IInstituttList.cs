using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IInstituttList
    {
        List<Institutt> GetInstitutter();
        void AddInstitutt(Institutt institutt);
        void RemoveInstitutt(Institutt institutt);

        void UpdateInstitutt(Institutt oldInstitutt, Institutt newInstitutt);
    }
}
