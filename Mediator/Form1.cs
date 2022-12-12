namespace Mediator
{
	public partial class MediatorExample : Form
	{
		public MediatorExample()
		{
			InitializeComponent();
			ItemTextBox.Focus();
		}

		private void AddNewItemButton_Click(object sender, EventArgs e)
		{
			var item = ItemTextBox.Text;
			if(item.Length > 0)
				ItemListBox.Items.Add(item);
			
			else
				MessageBox.Show("No item to add","Error",
								 MessageBoxButtons.OK,
								 MessageBoxIcon.Error);

			ItemTextBox.Clear();
		}

		private void ItemTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				AddNewItemButton.PerformClick();
			
		}
	}
}