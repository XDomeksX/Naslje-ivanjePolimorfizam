using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjePolimorfizam
{
    internal class Cake : Dessert
    {
        bool containsGluten;
        string cakeType;

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.ContainsGluten = containsGluten;
            this.CakeType = cakeType;
        }

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public override string getDessertType()
        {
            return cakeType + " cake";
        }
        public override string ToString()
        {
            return base.ToString() + this.containsGluten + this.cakeType;
        }
    }
}
