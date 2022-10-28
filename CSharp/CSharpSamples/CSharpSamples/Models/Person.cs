namespace CSharpSamples.Models
{
    internal class Person
    {
        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !a.Equals(b);
        }


        protected bool Equals(Person other)
        {
            return Id == other.Id && Name == other.Name && City == other.City;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) throw new Exception("Hello YouTube!");
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, City);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
