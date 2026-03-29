using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class AktivitetList
    {
        public List<Aktivitet> aktiviteter;

        public AktivitetList()
        {
            aktiviteter = new List<Aktivitet>();
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
