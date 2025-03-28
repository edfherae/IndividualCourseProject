using Newtonsoft.Json;
using System.Text;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PhoneShop
{
	public partial class PhoneShopForm : Form
	{
		AppDbContext dbContext = new();
		// �������� ��� ��������� �������� �����
		#region �����
		public string TextBoxModel => textBoxModel.Text;
		public string ComboBoxProducers => comboBoxProducers.Text;
		public string ComboBoxCountry => comboBoxCountry.Text;
		public DateTime DateTimePickerYearOfRelease => dateTimePickerYearOfRelease.Value;
		public string PictureBoxPhoneImage => pictureBoxPhoneImage.ImageLocation;
		#endregion

		#region �����������
		public double NumericUpDownDiagonal => (double)numericUpDownDiagonal.Value;
		public int NumericUpDownNumberOfCameras => (int)numericUpDownNumberOfCameras.Value;
		public string ComboBoxSimType => comboBoxSimType.Text;
		public int GroupBoxCommunicationGeneration
		{
			get
			{
				foreach (RadioButton rb in groupBoxCommunicationGeneration.Controls)
					if (rb.Checked)
						return rb.Text[0];
				return 0; //�� ������ ��� ����
			}
		}
		public int TrackBarRAM => trackBarRAM.Value;
		public int TrackBarROM => trackBarROM.Value;
		public double NumericUpDownWeight => (double)numericUpDownWeight.Value;
		public string RichTextBoxAdditionalCharacteristics => richTextBoxAdditionalCharacteristics.Text;
		#endregion

		#region �����������
		public DateTime MaskedTextBoxDateOfProduction => DateTime.Parse(maskedTextBoxDateOfProduction.Text);
		public int NumericUpDownWarrantyPeriod => (int)numericUpDownWarrantyPeriod.Value;
		public double TextBoxPrice => double.Parse(textBoxPrice.Text);
		public int? NumericUpDownPoints => checkBoxPoints.Checked ? (int?)numericUpDownPoints.Value : null;
		public int? PromotionDiscount => checkBoxPromotion.Checked && rbPromotionDiscount.Checked ? (int?)int.Parse(maskedTextBoxDiscount.Text) : null;
		public int? PromotionPoints => checkBoxPromotion.Checked && rbPromotionDiscount.Checked ? (int?)int.Parse(maskedTextBoxPoints.Text) : null;
		#endregion
		public PhoneShopForm()
		{
			InitializeComponent();
			comboBoxProducers.Items.AddRange(Phone.produsers);
			comboBoxSimType.Items.AddRange(Phone.simTypes);
			comboBoxCountry.Items.AddRange(Phone.countries);
			foreach (Phone ph in dbContext.Phones.ToList())
				listBoxPhones.Items.Add(ph);
		}
		public void FormFromPhone(Phone phone) // init Form from Phone
		{
			textBoxModel.Text = phone.Model;
			comboBoxProducers.Text = phone.Producer;
			comboBoxCountry.Text = phone.Country;
			dateTimePickerYearOfRelease.Value = phone.YearOfRelease;
			pictureBoxPhoneImage.ImageLocation = phone.ImageLocation;

			numericUpDownDiagonal.Value = (decimal)phone.Diagonal;
			numericUpDownNumberOfCameras.Value = (decimal)phone.NumberOfCameras;
			comboBoxSimType.Text = phone.SIMType;
			switch (phone.CommunicationGeneration)
			{
				case 4: { radioButton4G.Checked = true; break; }
				case 5: { radioButton5G.Checked = true; break; }
			}
			trackBarRAM.Value = phone.RAM;
			trackBarROM.Value = phone.ROM;
			numericUpDownWeight.Value = (decimal)phone.Weight;
			richTextBoxAdditionalCharacteristics.Text = phone.AdditionalCharacteristics;

			maskedTextBoxDateOfProduction.Text = phone.DateOfProduction.ToString("dd.MM.yyyy");
			numericUpDownWarrantyPeriod.Value = phone.WarrantyPeriod;
			dateTimePickerWarrantyPeriodEnd.Value = MaskedTextBoxDateOfProduction.AddYears(phone.WarrantyPeriod);
			textBoxPrice.Text = phone.Price.ToString();
			if (phone.Points != null)
			{
				checkBoxPoints.Checked = true;
				numericUpDownPoints.Value = (decimal)phone.Points;
			}
			if (phone.PromotionDiscount != null)
			{
				checkBoxPromotion.Checked = true;
				rbPromotionDiscount.Checked = true;
				maskedTextBoxDiscount.Enabled = true;
				maskedTextBoxDiscount.Text = phone.PromotionDiscount.ToString();
			}
			else if (phone.PromotionPoints != null)
			{
				checkBoxPromotion.Checked = true;
				rbPromotionPoints.Checked = true;
				maskedTextBoxPoints.Enabled = true;
				maskedTextBoxPoints.Text = phone.PromotionPoints.ToString();
			}
		}
		private void ResetForm()
		{
			textBoxModel.ResetText();
			comboBoxProducers.ResetText(); comboBoxProducers.SelectedIndex = -1;
			comboBoxCountry.ResetText(); comboBoxCountry.SelectedIndex = -1;
			dateTimePickerYearOfRelease.ResetText();
			pictureBoxPhoneImage.ImageLocation = "";

			numericUpDownDiagonal.ResetText();
			numericUpDownNumberOfCameras.ResetText();
			comboBoxSimType.ResetText(); comboBoxSimType.SelectedIndex = -1;
			radioButton4G.Checked = false; radioButton5G.Checked = false;
			trackBarRAM.Value = 1; labelRAM.Text = "1";
			trackBarROM.Value = 16; labelROM.Text = "1";
			numericUpDownWeight.ResetText();
			richTextBoxAdditionalCharacteristics.ResetText();

			maskedTextBoxDateOfProduction.ResetText();
			numericUpDownWarrantyPeriod.ResetText();
			dateTimePickerWarrantyPeriodEnd.ResetText();
			textBoxPrice.ResetText();
			checkBoxPoints.Checked = false;
			numericUpDownPoints.ResetText();

			checkBoxPromotion.Checked = false;

			rbPromotionDiscount.Checked = false;
			rbPromotionDiscount.Enabled = false;
			maskedTextBoxDiscount.ResetText();
			maskedTextBoxDiscount.Enabled = false;

			rbPromotionPoints.Checked = false;
			rbPromotionDiscount.Enabled = false;
			maskedTextBoxPoints.ResetText();
			maskedTextBoxDiscount.Enabled = false;
		}
		//public bool CheckNullAndChangeBackColor()
		//{
		//	if (string.IsNullOrEmpty(TextBoxModel)) this.textBoxModel.BackColor = Color.MistyRose;
		//	if (string.IsNullOrEmpty(ComboBoxProducers)) this.comboBoxProducers.BackColor = Color.MistyRose;
		//	if (string.IsNullOrEmpty(ComboBoxCountry)) this.comboBoxCountry.BackColor = Color.MistyRose;
		//	if (string.IsNullOrEmpty(ComboBoxSimType)) this.comboBoxSimType.BackColor = Color.MistyRose;
		//	if (GroupBoxCommunicationGeneration == null) this.groupBoxCommunicationGeneration.BackColor = Color.MistyRose;
		//	if (string.IsNullOrEmpty(NumericUpDownDiagonal)) this.textBoxModel.BackColor = Color.MistyRose;


		//	NumericUpDownDiagonal == 0 ||
		//	NumericUpDownNumberOfCameras == 0 ||
		//	TrackBarRAM == 0 ||
		//	TrackBarROM == 0 ||
		//	NumericUpDownWeight == 0 ||
		//	NumericUpDownWarrantyPeriod == 0 ||
		//	TextBoxPrice == 0)
		//	{
		//		BackColor = "MistyRose";
		//	}
		//}
		private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("������ ������� ������ ��318\n" + "������� ���", "achtung");
		}

		private void trackBarOM_ValueChanged(object sender, EventArgs e)
		{
			labelRAM.Text = $"{trackBarRAM.Value} ��";
		}

		private void trackBarPM_ValueChanged(object sender, EventArgs e)
		{
			labelROM.Text = $"{trackBarROM.Value} ��";
		}

		private void maskedTextBoxYearOfProduction_KeyUp(object sender, KeyEventArgs e)
		{
			DateTime date;
			if (!DateTime.TryParse(maskedTextBoxDateOfProduction.Text, out date))
			{
				maskedTextBoxDateOfProduction.Text = "";
				MessageBox.Show("���� �� ������������� �������", "achtung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void numericUpDownWarrantyPeriod_ValueChanged(object sender, EventArgs e)
		{
			labelWarrantyPeriod.Text = (numericUpDownWarrantyPeriod.Value == 0 || numericUpDownWarrantyPeriod.Value % 10 == 0) ? "���" :
				numericUpDownWarrantyPeriod.Value == 1 ? "��� " :
				numericUpDownWarrantyPeriod.Value < 5 ? "����" : "���";
		}


		private void ttmiQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		//��������� ���� �� ����������!!
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
		//������ .json!!
		private void ttmiLoad_Click(object sender, EventArgs e)
		{
			this.ResetForm();
			OpenFileDialog ofd = new();
			Phone phone = new();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				//Object obj = JsonConvert.DeserializeObject(File.ReadAllText(ofd.FileName));
				FormFromPhone(JsonConvert.DeserializeObject<Phone>(File.ReadAllText(ofd.FileName)));
			}
		}

		private void maskedTextBoxYearOfProduction_Leave(object sender, EventArgs e)
		{
			//string[] day_month_year = maskedTextBoxYearOfProduction.Text.Split('.');
			DateTime date;
			if (!DateTime.TryParse(maskedTextBoxDateOfProduction.Text.AsSpan(), out date))
			{
				MessageBox.Show("������������ ������ ����! ��������� �����.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				maskedTextBoxDateOfProduction.Text = "";
			}
			else if (date < dateTimePickerYearOfRelease.Value)
			{
				MessageBox.Show("���� ������������ ������ ���� �������! ��������� �����.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				maskedTextBoxDateOfProduction.Text = "";
			}

		}

		private void textBoxPrice_Leave(object sender, EventArgs e)
		{
			CheckPrice(textBoxPrice.Text);
		}

		private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) CheckPrice(textBoxPrice.Text);
		}
		private bool CheckPrice(string value)
		{
			double price;
			if (!double.TryParse(value, out price))
			{
				MessageBox.Show("�������� �������� ������ ���� ������", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBoxPrice.Text = "";
				return false;
			}
			return true;
		}

		private void checkBoxPoints_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDownPoints.Enabled = checkBoxPoints.Checked;
		}

		private void checkBoxPromotion_CheckedChanged(object sender, EventArgs e)
		{
			rbPromotionDiscount.Enabled = checkBoxPromotion.Checked;
			rbPromotionDiscount.Checked = false;

			rbPromotionPoints.Enabled = checkBoxPromotion.Checked;
			rbPromotionPoints.Checked = false;
		}

		private void buttonChooseImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				this.pictureBoxPhoneImage.ImageLocation = ofd.FileName;
				pictureBoxPhoneImage.Refresh();
			}
		}
		private void buttonAddToDB_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("�� �������?", "achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Phone phone = new(this);
				dbContext.Phones.Add(phone);
				dbContext.SaveChanges();
				foreach (Phone ph in dbContext.Phones.ToList())
					listBoxPhones.Items.Add(ph);
			}
		}

		private void buttonReloadDB_Click(object sender, EventArgs e)
		{
			listBoxPhones.Items.Clear();
			foreach (Phone ph in dbContext.Phones.ToList())
				listBoxPhones.Items.Add(ph);
		}

		private void listBoxPhones_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxPhones.SelectedIndex != -1)
				this.FormFromPhone((Phone)listBoxPhones.SelectedItem);
		}

		private void buttonResetForm_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("�� �������?", "achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				this.ResetForm();
		}

		private void rbPromotionDiscount_CheckedChanged(object sender, EventArgs e)
		{
			maskedTextBoxDiscount.Enabled = rbPromotionDiscount.Checked;
		}

		private void rbPromotionPoints_CheckedChanged(object sender, EventArgs e)
		{
			maskedTextBoxPoints.Enabled = rbPromotionPoints.Checked;
		}
	}
	public class Phone
	{
		public static string[] produsers = { "Samsung", "Apple", "Poco", "Huawei", "LG" };
		public static string[] simTypes = { "Mini-SIM", "Micro-SIM", "Nano-SIM", "ESIM" };
		public static string[] countries = { "������", "�������", "��������", "��������" };

		public int Id { get; set; }
		public string Model { get; set; }
		public string Producer { get; set; }
		public string Country { get; set; }
		public DateTime YearOfRelease { get; set; }
		public string? ImageLocation { get; set; }

		public double Diagonal { get; set; }
		public int NumberOfCameras { get; set; }
		public string SIMType { get; set; }
		public int CommunicationGeneration { get; set; }
		public int RAM { get; set; }
		public int ROM { get; set; }
		public double Weight { get; set; }
		public string? AdditionalCharacteristics { get; set; }

		public DateTime DateOfProduction { get; set; }
		public int WarrantyPeriod { get; set; }
		//public int ���� ���������
		public double Price { get; set; }
		public int? Points { get; set; }
		public int? PromotionDiscount { get; set; } //� ���������
		public int? PromotionPoints { get; set; } //� ���������
		public Phone() { }
		public Phone(PhoneShopForm form) // init Phone from Form
		{
			Model = form.TextBoxModel;
			Producer = form.ComboBoxProducers;
			Country = form.ComboBoxCountry;
			YearOfRelease = form.DateTimePickerYearOfRelease;
			ImageLocation = form.PictureBoxPhoneImage;

			Diagonal = (double)form.NumericUpDownDiagonal;
			NumberOfCameras = (int)form.NumericUpDownNumberOfCameras;
			SIMType = form.ComboBoxSimType;
			CommunicationGeneration = form.GroupBoxCommunicationGeneration;
			RAM = form.TrackBarRAM;
			ROM = form.TrackBarROM;
			Weight = (double)form.NumericUpDownWeight;
			AdditionalCharacteristics = form.RichTextBoxAdditionalCharacteristics;

			DateOfProduction = form.MaskedTextBoxDateOfProduction;
			WarrantyPeriod = (int)form.NumericUpDownWarrantyPeriod;
			Price = form.TextBoxPrice;
			//��������� �������� ��� ������
			Points = form.NumericUpDownPoints;
			PromotionDiscount = form.PromotionDiscount;
			PromotionPoints = form.PromotionPoints;
		}
		public override string ToString()
		{
			return $"{Id}. {Model}";
		}
	}
	public class AppDbContext : DbContext
	{
		public DbSet<Phone> Phones { get; set; }
		public AppDbContext() { Database.EnsureCreated(); }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-OKGA20J\\SQLEXPRESS;Integrated Security=True; Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}
	}
}
