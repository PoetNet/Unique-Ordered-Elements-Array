namespace UniqueOrderedElementsArray;
public class UniqueElementsGetter
{
    public static Queue<T> GetUniqueElementsInOrder<T>(IEnumerable<T> items)
    {
        Queue<T> arranged = new ();
        T firstItem = items.First();

        foreach (T currentItem in items)
        {
            if (currentItem.Equals(firstItem)) arranged.Enqueue(currentItem);
            else if (currentItem.Equals(arranged.Last())) { }
            else arranged.Enqueue(currentItem);
        }

        return arranged;
    }
}
