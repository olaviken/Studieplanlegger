using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class AktivitetList : Interfaces.IAktivitetsList
    {
        private List<Aktivitet> aktiviteter = new();

        public List<Aktivitet> GetAktiviteter()
        {
            return aktiviteter;
        }

        public void AddAktivitet(Aktivitet aktivitet)
        {
            aktiviteter.Add(aktivitet);
        }

        public void RemoveAktivitet(Aktivitet aktivitet)
        {
            aktiviteter.Remove(aktivitet);
        }

        public void UpdateAktivitet(Aktivitet oldAktivitet, Aktivitet newAktivitet)
        {
            int index = aktiviteter.IndexOf(oldAktivitet);
            if (index != -1)
            {
                aktiviteter[index] = newAktivitet;
            }
        }
    }
}
