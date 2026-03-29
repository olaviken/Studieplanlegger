using Studieplanlegger.Components.Classes;

namespace Studieplanlegger.Components.Lists
{
    public class Ansattlist
    {
        public List<Ansatt> ansatte;

       public Ansattlist() 
        {
            ansatte = new List<Ansatt>();
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
