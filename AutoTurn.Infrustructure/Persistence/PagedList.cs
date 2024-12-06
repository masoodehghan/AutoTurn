namespace AutoTurn.Infrastructure.Persistence;


public abstract class PagedList<T>
{
    protected IQueryable<T> PageList(IQueryable<T> model, int? pageIndex = null, int pageSize = 10)
    {

        var TruePageIndex = pageIndex ?? 0;
        int ItemIndex = pageSize * TruePageIndex;

        if(ItemIndex < 0 || pageIndex < 0)
        {
            ItemIndex = 0;
        }

        return model.Skip(ItemIndex).Take(pageSize);
    }
}
