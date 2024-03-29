﻿namespace SelectListLibrary;

public class SelectList : ListView
{
    private new bool MultiSelect { get; set; }
    private new bool FullRowSelect { get; set; }

    public event ItemSelectedHandler? ItemSelected;

    public SelectList()
    {
        base.MultiSelect = false;
        base.FullRowSelect = true;
    }

    private new SelectedListViewItemCollection SelectedItems =>
        base.SelectedItems;

    public ListViewItem? SelectedItem
    {
        get =>
            base.SelectedItems.Count <= 0
                ? null
                : base.SelectedItems[0];
        set
        {
            SelectedItems.Clear();

            if (value == null)
                return;

            value.Selected = true;
        }
    }

    protected override void OnMouseDoubleClick(MouseEventArgs e)
    {
        base.OnMouseDoubleClick(e);

        var item = GetItemAt(e.X, e.Y);

        if (item == null)
            return;

        SelectedItems.Clear();
        item.Selected = true;
        
        ItemSelected?.Invoke(this, new ItemSelectedEventArgs(item));
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.KeyCode == Keys.Enter)
        {
            e.Handled = true;

            if (SelectedItem != null)
                ItemSelected?.Invoke(this, new ItemSelectedEventArgs(SelectedItem));
        }
    }

    public ListViewItem AddItem() =>
        AddItem(0, "", null);

    public ListViewItem AddItem(string text) =>
        AddItem(0, text, null);

    public ListViewItem AddItem(int imageIndex, string text) =>
        AddItem(imageIndex, text, null);
    
    public ListViewItem AddItem(int imageIndex, string text, object? tag)
    {
        var li = Items.Add(text);
        li.ImageIndex = imageIndex;
        li.Tag = tag;
        return li;
    }

    public bool Select(Func<ListViewItem, bool> criteria)
    {
        foreach (ListViewItem listViewItem in Items)
        {
            if (!criteria(listViewItem))
                continue;

            SelectedItems.Clear();
            listViewItem.Selected = true;
            listViewItem.EnsureVisible();
            Focus();
            return true;
        }

        return false;   
    }
}