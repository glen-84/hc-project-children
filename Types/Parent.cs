namespace hc_project_children.Types;

public sealed class Parent
{
    public long Id { get; set; }

    public IList<Child> Children { get; set; } = null!;

    public string Name { get; set; } = null!;
}
