namespace SelectListLibrary;

public class ItemSelectedEventArgs : EventArgs
{
    public ListViewItem SelectedItem { get; }

    public ItemSelectedEventArgs(ListViewItem item)
    {
        SelectedItem = item;
    }
}