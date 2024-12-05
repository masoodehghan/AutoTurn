namespace AutoTurn.Infrastructure.Persistence;


public abstract class PagedList<T>
{
    protected IQueryable<T> PageList(IQueryable<T> model, int? pageIndex = null, int pageSize = 10)
    {

        var TruePageIndex = pageIndex ?? 0;
        int ItemIndex = pageSize * TruePageIndex;

        return model.Skip(ItemIndex).Take(pageSize);
    }
}
