using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Interfaces
{
    public interface IAktivitetsList
    {
        List<Aktivitet> GetAktiviteter();
        void AddAktivitet(Aktivitet aktivitet);
        void RemoveAktivitet(Aktivitet aktivitet);
        void UpdateAktivitet(Aktivitet oldAktivitet, Aktivitet newAktivitet);
    }
}
