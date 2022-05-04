using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Web;
using System.IO;

namespace StudentuSarasas
{
	public partial class Form1 : Form
	{
		List<StudentasModel> studentai = new List<StudentasModel>(); //Sukūriamas studentų sąrašas, kuris bus naudojamas listbox'o pildymui
		public Form1()
		{
			InitializeComponent();

			LoadStudentai();
		}

		private void LoadStudentai()	//Iš db paimami duomenys ir supildomi į listbox'ą
		{
			studentai = SqliteDataAccess.LoadStudentai();

			studentaiList.DataSource = null;
			studentaiList.DataSource = studentai;
			studentaiList.DisplayMember = "pilnasVardas";
		}
		public static byte[] ImageToByte(Image img)	//Konvertuojama iš nuotaukos į byte[]
		{
			ImageConverter converter = new ImageConverter();
			return (byte[])converter.ConvertTo(img, typeof(byte[]));
		}
		private void pridetiPrideti_Click(object sender, EventArgs e)	//Pridedamas naujas studentas
		{
			StudentasModel s = new StudentasModel();
			//Paimami duomenys iš laukelių
			s.vardas = pridetiVardas.Text;
			s.pavarde = pridetiPavarde.Text;

			if (pridetiPictureBox.Image != null)	//Jei pasirinkta nuotrauka, ji konvertuojama į base64
			{
				byte[] imageArray = ImageToByte(pridetiPictureBox.Image);
				s.nuotrauka = Convert.ToBase64String(imageArray);
			}

			SqliteDataAccess.SaveStudentas(s);	//Duomenys įrašomi į db
			LoadStudentai();    //Perkraunami duomenys listbox'e, kad matytųsi pakeitimai

			//Pridėjimui skirti laukeliai išvalomi
			pridetiVardas.Text = "";
			pridetiPavarde.Text = "";
			pridetiPictureBox.Image = null;
			pridetiPictureBox.ImageLocation = null;
			
		}
		private void redaguotiTrinti_Click(object sender, EventArgs e)	//Trinamas studentas
		{
			if(studentaiList.SelectedIndex != -1)	//Įsitikinama, kad studentas yra pasirinktas
			{
				var pasirinktas = studentaiList.SelectedItem as StudentasModel;	//Iš listbox'o gaunamas studento modelis
				SqliteDataAccess.DeleteStudentas(pasirinktas);	//Studentas ištrinamas iš db
				LoadStudentai();    //Perkraunami duomenys listbox'e, kad matytųsi pakeitimai
			}
		}

		private void redaguotiRedaguoti_Click(object sender, EventArgs e)	//Redaguojami duomenys
		{
			if (studentaiList.SelectedIndex != -1) {	//Įsitikinama, kad studentas pasirinktas
				var pasirinktas = studentaiList.SelectedItem as StudentasModel;
				StudentasModel s = new StudentasModel();
				//Surenkami duomenys iš laukelių
				s.vardas = redaguotiVardas.Text;
				s.pavarde = redaguotiPavarde.Text;

				if (redaguotiPictureBox.ImageLocation != null)	//Jei pasirinkta nauja nuotrauka, dirbama su ja
				{
					byte[] imageArray = ImageToByte(redaguotiPictureBox.Image);
					s.nuotrauka = Convert.ToBase64String(imageArray);
				}
				else if (pasirinktas.nuotrauka != null)	//Jei nuotrauka nepasirinkta, bet jau yra įrašyta db, dirbame su jau esama
				{
					s.nuotrauka = pasirinktas.nuotrauka;
				}
				s.Id = pasirinktas.Id;
				SqliteDataAccess.EditStudentas(s);	//Duomenys redaguojami
				LoadStudentai();    //Perkraunami duomenys listbox'e, kad matytųsi pakeitimai
			}
		}

		private void pridetiNuotrauka_Click(object sender, EventArgs e)	//Pasirenkama naujo studento pridejimui naudojama nuotrauka
		{  
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (open.ShowDialog() == DialogResult.OK)
			{
				pridetiPictureBox.ImageLocation = open.FileName;
				pridetiPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void studentaiList_SelectedIndexChanged(object sender, EventArgs e)	//Kai pasirenkamas kitas studentas iš listbox'o
		{
			var pasirinktas = studentaiList.SelectedItem as StudentasModel;
			if (pasirinktas != null)
			{
				//Redagavimo laukeliai užpildomi pasirinkto studento duomenimis
				redaguotiVardas.Text = pasirinktas.vardas;
				redaguotiPavarde.Text = pasirinktas.pavarde;
				if (pasirinktas.nuotrauka != null)
				{
					byte[] bytes = Convert.FromBase64String(pasirinktas.nuotrauka);
					using (MemoryStream ms = new MemoryStream(bytes))
					{
						redaguotiPictureBox.Image = Image.FromStream(ms);
					}
					redaguotiPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				}
				else
				{
					redaguotiPictureBox.Image = null;
				}
			}
		}

		private void redaguotiNuotrauka_Click(object sender, EventArgs e)	//Pasirenkama nuotrauka studento redagavimui
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
			if (open.ShowDialog() == DialogResult.OK)
			{
				redaguotiPictureBox.ImageLocation = open.FileName;
				redaguotiPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}
	}
}
