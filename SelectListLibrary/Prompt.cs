namespace SelectListLibrary;

public class Prompt
{
    private readonly List<ListViewItem> _items;
    private readonly List<ColumnHeader> _columns;
    private readonly string _title;
    public Func<ListViewItem, bool>? SelectedListItem { get; set; }

    public Prompt(string title)
    {
        _items = new List<ListViewItem>();
        _columns = new List<ColumnHeader>();
        _title = title;
    }

    public ColumnHeader AddColumn(string text, int width)
    {
        var column = new ColumnHeader
        {
            Text = text,
            Width = width
        };

        _columns.Add(column);
        return column;
    }

    public ListViewItem AddItem() =>
        AddItem(0, "", null);

    public ListViewItem AddItem(string text) =>
        AddItem(0, text, null);

    public ListViewItem AddItem(int imageIndex, string text) =>
        AddItem(imageIndex, text, null);

    public ListViewItem AddItem(int imageIndex, string text, object? tag)
    {
        var li = new ListViewItem
        {
            Text = text,
            ImageIndex = imageIndex,
            Tag = tag
        };

        _items.Add(li);
        return li;
    }

    public ListViewItem? Ask(IWin32Window owner)
    {
        var x = new PromptDialog();
        x.Text = _title;

        foreach (var columnHeader in _columns)
            x.selectList1.Columns.Add(columnHeader);

        foreach (var listViewItem in _items)
            x.selectList1.Items.Add(listViewItem);

        if (SelectedListItem != null)
            x.selectList1.Select(SelectedListItem);

        return x.ShowDialog(owner) == DialogResult.OK ? x.selectList1.SelectedItem : null;
    }
}