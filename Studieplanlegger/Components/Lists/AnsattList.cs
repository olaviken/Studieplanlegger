using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class Ansattlist: Interfaces.IAnsattlist
    {
        private List<Ansatt> ansatte;

       public List<Ansatt> GetAnsatte()
        {
            return ansatte;
        }

        public void AddAnsatt(Ansatt ansatt)
        {
            ansatte.Add(ansatt);
        }

        public void RemoveAnsatt(Ansatt ansatt)
        {
            ansatte.Remove(ansatt);
        }

        public void UpdateAnsatt(Ansatt oldAnsatt, Ansatt newAnsatt)
        {
            int index = ansatte.IndexOf(oldAnsatt);
            if (index != -1)
            {
                ansatte[index] = newAnsatt;
            }
        }
    }
}
