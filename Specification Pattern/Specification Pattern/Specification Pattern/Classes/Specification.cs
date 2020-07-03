namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T data, ref ICollection<string> errors);

        public Specification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
    }
}
