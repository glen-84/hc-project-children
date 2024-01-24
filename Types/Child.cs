namespace hc_project_children.Types;

public sealed class Child
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public string Name { get; set; } = null!;
}
