using Newtonsoft.Json;
using System.Text;

namespace PhoneShop
{
	public partial class PhoneShopForm : Form
	{
		public class Phone
		{
			public static string[] produsers = { "Samsung", "Apple", "Poco", "Huawei", "LG" };
			public static string[] simTypes = { "Mini-SIM", "Micro-SIM", "Nano-SIM", "ESIM" };

			public string Model { get; private set; }
			public string Producer { get; private set; }
			public string Country { get; private set; }
			public DateTime YearOfRelease { get; private set; }
			public string? ImageLocation { get; private set; }

			public double Diagonal { get; private set; }
			public int NumberOfCameras { get; private set; }
			public string SIMType { get; private set; }
			public int CommunicationGeneration { get; private set; }
			public int RAM { get; private set; }
			public int ROM { get; private set; }
			public double Weight { get; private set; }
			public string? AdditionalCharacteristics { get; private set; }

			public DateTime DateOfProduction { get; private set; }
			public int WarrantyPeriod { get; private set; }
			//public int Дата окончания
			public int Price { get; private set; }
			public int Points { get; private set; }
			public int Promotion { get; private set; } //в процентах
			public Phone(PhoneShopForm form)
			{
				Model = form.textBoxModel.Text;
				Producer = form.comboBoxProducers.SelectedText;
				Country = form.comboBoxCountry.SelectedText;
				YearOfRelease = form.dateTimePickerYearOfRelease.Value;
				ImageLocation = form.pictureBoxPhoneImage.ImageLocation;

				Diagonal = (double)form.numericUpDownDiagonal.Value;
				NumberOfCameras = (int)form.numericUpDownNumberOfCameras.Value;
				SIMType = form.comboBoxSimType.SelectedText;
				foreach (RadioButton rb in form.groupBoxCommunicationGeneration.Controls)
					if (rb.Checked)
						CommunicationGeneration = rb.Text[0];
				RAM = form.trackBarRAM.Value;
				ROM = form.trackBarROM.Value;
				Weight = (double)form.numericUpDownWeight.Value;
				AdditionalCharacteristics = form.richTextBoxAdditionalCharacteristics.Text;

				//обработать дату на вводе
				//DateOfProduction = DateTime.Parse(form.maskedTextBoxYearOfProduction.Text); 
			}

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
			MessageBox.Show("сделай отдельную форму", "achtung");
		}

		private void trackBarOM_ValueChanged(object sender, EventArgs e)
		{
			labelOM.Text = $"{trackBarRAM.Value} Гб";
		}

		private void trackBarPM_ValueChanged(object sender, EventArgs e)
		{
			labelPM.Text = $"{trackBarROM.Value} Гб";
		}

		private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void numericUpDownWarrantyPeriod_ValueChanged(object sender, EventArgs e)
		{
			labelWarrantyPeriod.Text = (numericUpDownWarrantyPeriod.Value == 0 || numericUpDownWarrantyPeriod.Value % 10 == 0) ? "лет" :
				numericUpDownWarrantyPeriod.Value == 1 ? "год " :
				numericUpDownWarrantyPeriod.Value < 5 ? "года" : "лет";
		}


		private void ttmiQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ttmiSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new() { DefaultExt = "json" };
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				Phone phone = new Phone(this);
				string json = Newtonsoft.Json.JsonConvert.SerializeObject(phone);
				FileStream fs = File.Create(sfd.FileName);
				fs.Write(Encoding.UTF8.GetBytes(json));
				fs.Close();
			}
			else return;
		}
	}
}
