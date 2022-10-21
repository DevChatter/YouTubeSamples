namespace CSharpSamples;

public record PersonRecord(string Name, DateOnly Birthday);

public class PersonClass
{
    public string Name { get; set; }
    public DateOnly Birthday { get; set; }

    public PersonClass(string name, DateOnly birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public override string ToString()
    {
        return $"PersonClass {{ Name = {Name}, Birthday = {Birthday} }}";
    }

    protected bool Equals(PersonClass other)
    {
        return Name == other.Name && Birthday == other.Birthday;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((PersonClass)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Birthday);
    }
}
