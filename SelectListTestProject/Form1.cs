using SelectListLibrary;

namespace SelectListTestProject
{
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

        private void selectList1_ItemSelected(object sender, ItemSelectedEventArgs eventArgs) =>
            MessageBox.Show(eventArgs.SelectedItem.Text);

        private void button1_Click(object sender, EventArgs e)
        {
            selectList1.Select(item => item.Text == @"Hello 2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var prompt = new Prompt("Hello, hello!");
            prompt.AddColumn("Something", 200);
            prompt.AddColumn("Also something", 100);
            prompt.AddItem("Hello 1");
            var selected = prompt.AddItem(0, "Hello 2");
            prompt.AddItem(1, "Hello 3");
            //prompt.SelectedListItem = x => x == selected;
            MessageBox.Show(prompt.Ask(this)?.Text ?? "Cancel!");
        }
    }
}