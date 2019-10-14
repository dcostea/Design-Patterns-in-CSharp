namespace IteratorSample
{
    /// <summary>
    /// The 'AbstractIterator' interface
    /// </summary>
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
