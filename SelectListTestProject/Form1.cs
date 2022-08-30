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
            selectList1.AddItem("Hello 2");
            selectList1.AddItem("Hello 3");
        }

        private void selectList1_ItemSelected(object sender, ItemSelectedEventArgs eventArgs) =>
            MessageBox.Show(eventArgs.SelectedItem.Text);
    }
}