namespace SelectListLibrary;

public partial class PromptDialog : Form
{
    internal Func<ListViewItem, bool>? SelectedListItem { get; set; }
    internal ListViewItem? SelectedItem { get; set; }

    public PromptDialog()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        if (selectList1.SelectedItem == null)
        {
            MessageBox.Show(@"Nothing is selected.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        SelectedItem = selectList1.SelectedItem;
        DialogResult = DialogResult.OK;
    }

    private void PromptDialog_Shown(object sender, EventArgs e)
    {
        if (SelectedListItem != null)
            selectList1.Select(SelectedListItem);
    }

    private void selectList1_ItemSelected(object sender, ItemSelectedEventArgs eventArgs)
    {
        btnOk_Click(sender, EventArgs.Empty);
    }
}