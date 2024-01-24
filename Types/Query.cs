namespace hc_project_children.Types;

[QueryType]
public static class Query
{
    [UseProjection]
    public static IQueryable<Parent> GetParents(DatabaseContext dbContext)
    {
        return dbContext.Parents;
    }
}
