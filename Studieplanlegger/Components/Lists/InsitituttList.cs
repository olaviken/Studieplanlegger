using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class InsitituttList
    {
        public List<Institutt> institutter;

        public InsitituttList()
        {
            institutter = new List<Institutt>();
        }   

        public void AddInstitutt(Institutt institutt)
        {
            institutter.Add(institutt);
        }

        public void RemoveInstitutt(Institutt institutt)
        {
            institutter.Remove(institutt);
        }

        public void UpdateInstitutt(Institutt oldInstitutt, Institutt newInstitutt)
        {
            int index = institutter.IndexOf(oldInstitutt);
            if (index != -1)
            {
                institutter[index] = newInstitutt;
            }
        }

    }
}
