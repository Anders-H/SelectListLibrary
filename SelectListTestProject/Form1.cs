using SelectListLibrary;
#pragma warning disable CA1416

namespace SelectListTestProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        selectList1.AddItem("Hello 1");
        selectList1.AddItem(0, "Hello 2");
        selectList1.AddItem(1, "Hello 3");
    }

    private void selectList1_ItemSelected(object sender, ItemSelectedEventArgs eventArgs)
    {
        MessageBox.Show(eventArgs.SelectedItem.Text);
    }


    private void button1_Click(object sender, EventArgs e)
    {
        // Select an item in the list on this form.
        selectList1.Select(item => item.Text == @"Hello 2");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Promot the user for an item.
        var prompt = new Prompt("Hello, hello!");

        //Create the columns
        prompt.AddColumn("Something", 200);
        prompt.AddColumn("Also something", 100);
        prompt.AddColumn("Really something", 300);

        //Add the items
        prompt.AddItem("Hello 1");
        prompt.AddItem(0, "Hello 2");
        prompt.AddItem(1, "Hello 3");
        prompt.AddItem(2, "Hello 4", null, "Something...");

        //prompt.SelectedListItem = x => x == selected;
        MessageBox.Show(prompt.Ask(this)?.Text ?? "Cancel!");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        // Promot the user for an item with one default selected (Hello 3).
        var prompt = new Prompt("Hello, hello!");

        //Create the columns
        prompt.AddColumn("Something", 200);
        prompt.AddColumn("Also something", 100);
        prompt.AddColumn("Really something", 300);

        //Add the items
        prompt.AddItem("Hello 1");
        prompt.AddItem(0, "Hello 2");
        prompt.AddItem(1, "Hello 3");
        prompt.AddItem(2, "Hello 4", null, "Something...");

        prompt.SelectedListItem = x => x.Text == @"Hello 3";
        MessageBox.Show(prompt.Ask(this)?.Text ?? "Cancel!");
    }
}