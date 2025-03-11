namespace PhoneShop
{
	public partial class PhoneShopForm : Form
	{
		class Phone
		{
			public static string[] produsers = { "Samsung", "Apple", "Poco", "Huawei", "LG" };
			public static string[] simTypes = { "Mini-SIM", "Micro-SIM", "Nano-SIM", "ESIM" };
			string Model { get; set; }
			string Producer { get; set; }
		}
		public PhoneShopForm()
		{
			InitializeComponent();
			comboBoxProducers.Items.AddRange(Phone.produsers);
			comboBoxSimType.Items.AddRange(Phone.simTypes);
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("������ ��������� �����", "achtung");
		}

		private void trackBarOM_ValueChanged(object sender, EventArgs e)
		{
			labelOM.Text = $"{trackBarOM.Value} ��";
		}

		private void trackBarPM_ValueChanged(object sender, EventArgs e)
		{
			labelPM.Text = $"{trackBarPM.Value} ��";
		}

		private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void numericUpDownWarrantyPeriod_ValueChanged(object sender, EventArgs e)
		{
			labelWarrantyPeriod.Text = (numericUpDownWarrantyPeriod.Value == 0 || numericUpDownWarrantyPeriod.Value % 10 == 0) ? "���" :
				numericUpDownWarrantyPeriod.Value == 1  ? "��� " :
				numericUpDownWarrantyPeriod.Value < 5 ? "����" : "���";
		}
	}
}
