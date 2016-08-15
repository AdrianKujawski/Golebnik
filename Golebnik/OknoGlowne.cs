using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Golebnik
{
	public partial class OknoGlowne : Form
	{
		private Golab[] _tablicaGolebii;

		private readonly string sciezkaFolderu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
		                                         "\\Golebnik";

		private readonly string sciezkaZapisuListyGolebii = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
		                                                    "\\Golebnik\\list.dat";

		public OknoGlowne()
		{
			InitializeComponent();
			listaGolebii.Sorting = SortOrder.Ascending;
			if (!File.Exists(sciezkaZapisuListyGolebii))
			{
				Directory.CreateDirectory(sciezkaFolderu);
				File.Create(sciezkaZapisuListyGolebii);
			}
		}

		// WCZYTYWANIE OBRAZU
		private void load_image(object sender, EventArgs e)
		{
			Image wczytaneZdjecie = null;
			var przegladajZdjecie = new OpenFileDialog();
			przegladajZdjecie.DefaultExt = ".jpg";
			przegladajZdjecie.Filter = ".jpg (*.*)|*.jpg|.png(*.*)|*.png";
			var result = przegladajZdjecie.ShowDialog();

			if (przegladajZdjecie.FileName != "")
			{
				wczytaneZdjecie = Image.FromFile(przegladajZdjecie.FileName);
			}

			if (result == DialogResult.OK)
			{
				ImageBoxZdjecieGolebia.Image = wczytaneZdjecie;
			}

			przegladajZdjecie.Dispose();
		}

		// ZAPISYWANIE GOLEBIA
		private void PrzyciskZapiszGolebia(object sender, EventArgs e)
		{
			if (textBox_nrObraczki.Text == "")
			{
				MessageBox.Show("Wpisz numer obrączki!");
			}
			else
			{
				var informacjeOPliku = new FileInfo(sciezkaZapisuListyGolebii);

				if (informacjeOPliku.Length > 0)
					_tablicaGolebii = DeserializajaTablicyGolebii();
				else
					_tablicaGolebii = new Golab[1];

				var wolneMiejsce = SzukajWolnegoMiejscaWTablicy(_tablicaGolebii);

				if (wolneMiejsce != -1) // JESLI ZNAJDZIE WOLNE MIEJSCE W TABLICY
				{
					var golabDoZapisu = new Golab();
					golabDoZapisu.nrObraczki = textBox_nrObraczki.Text;
					golabDoZapisu.barwa = textBox_barwa.Text;
					golabDoZapisu.plec = comboBox1.Text;
					golabDoZapisu.rodzajGolebia = comboBox2.Text;
					golabDoZapisu.zdjecie = ImageBoxZdjecieGolebia.Image;
					_tablicaGolebii[wolneMiejsce] = golabDoZapisu;

					SerializajaTablicyGolebii(_tablicaGolebii);
				}
				else // JESLI NIE MA WOLNEGO MIEJSCA W TABLICY
				{
					Array.Resize(ref _tablicaGolebii, _tablicaGolebii.Length + 1);
					var golabDoZapisu = new Golab
					{
						nrObraczki = textBox_nrObraczki.Text,
						barwa = textBox_barwa.Text,
						plec = comboBox1.Text,
						rodzajGolebia = comboBox2.Text,
						zdjecie = ImageBoxZdjecieGolebia.Image
					};
					_tablicaGolebii[_tablicaGolebii.Length - 1] = golabDoZapisu;

					SerializajaTablicyGolebii(_tablicaGolebii);
				}

				_tablicaGolebii = null;
				MessageBox.Show("Zapisano gołębia");
				UsunTekst();
			}
		}

		// WCZYTYWANIE LISTY GOLEBII
		private void PrzyciskWczytajGolebie(object sender, EventArgs e)
		{
			listaGolebii.Items.Clear();
			var informacjeOPliku = new FileInfo(sciezkaZapisuListyGolebii);
			if (File.Exists(sciezkaZapisuListyGolebii) && informacjeOPliku.Length > 0)
			{
				var strumienOdczytu = new FileStream(sciezkaZapisuListyGolebii, FileMode.Open);
				var zmienNaBiarny = new BinaryFormatter();

				_tablicaGolebii = (Golab[]) zmienNaBiarny.Deserialize(strumienOdczytu);

				WczytajGolebieDoListy();

				strumienOdczytu.Close();
			}
		}

		// SZYKANIE WOLNEGO MIEJSCA W TALBICY
		public int SzukajWolnegoMiejscaWTablicy(object[] tablica)
		{
			if (tablica != null)
			{
				for (var i = 0; i < tablica.Length; i++)
				{
					if (tablica[i] == null)
						return i;
				}
			}
			return -1;
		}

		// USUWANIE TEKSTU PO WCZYTANIU GOLEBIA
		public void UsunTekst()
		{
			textBox_nrObraczki.Text = "";
			textBox_barwa.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";
			ImageBoxZdjecieGolebia.Image = null;
		}

		// DESERIALIZACJA TABLICY GOLEBII
		public Golab[] DeserializajaTablicyGolebii()
		{
			if (File.Exists(sciezkaZapisuListyGolebii))
			{
				var strumien = new FileStream(sciezkaZapisuListyGolebii, FileMode.Open);
				var deserializer = new BinaryFormatter();

				var tablica = (Golab[]) deserializer.Deserialize(strumien);
				strumien.Close();
				return tablica;
			}

			return new Golab[1];
		}

		// SERIALIZACJA TABLICY GOLEBII
		public void SerializajaTablicyGolebii(Golab[] tablica)
		{
			var strumien = new FileStream(sciezkaZapisuListyGolebii, FileMode.Open);
			var serializer = new BinaryFormatter();
			serializer.Serialize(strumien, tablica);
			strumien.Close();
		}

		private void listaGolebii_Click(object sender, EventArgs e)
		{
			WyswietlGolebia();
		}

		// WYSWIETLANIE GOLEBIA W OKNIE
		public void WyswietlGolebia()
		{
			var golabDoWyswietlenia = SzukajGolebia(_tablicaGolebii, listaGolebii.FocusedItem.Text);
			picturebox_wczytaneZdjecie.Image = golabDoWyswietlenia.zdjecie;
			wczytany_nrObraczki.Text = golabDoWyswietlenia.nrObraczki;
			wczytany_barwa.Text = golabDoWyswietlenia.barwa;
			wczytany_plec.Text = golabDoWyswietlenia.plec;
			wczytany_rodzaj.Text = golabDoWyswietlenia.rodzajGolebia;
		}

		// SZUKANIE GOLEBIA
		public Golab SzukajGolebia(Golab[] tablica, string numerObraczki)
		{
			if (listaGolebii.Items.Count != 0)
			{
				foreach (var element in _tablicaGolebii)
				{
					if (element != null && (element.nrObraczki == numerObraczki))
					{
						return element;
					}
				}
			}
			return null;
		}

		// USUWANIE GOLEBIA
		private void button_usunGolebia_Click(object sender, EventArgs e)
		{
			if (listaGolebii.Items.Count != 0 && listaGolebii.SelectedIndices.Count > 0)
			{
				var golabDoUsuniecia = SzukajGolebia(_tablicaGolebii, listaGolebii.FocusedItem.Text);
				int indeksGolebia;

				Array.Sort(_tablicaGolebii);
				indeksGolebia = Array.BinarySearch(_tablicaGolebii, golabDoUsuniecia);


				_tablicaGolebii[indeksGolebia] = null;
				SerializajaTablicyGolebii(_tablicaGolebii);
				listaGolebii.Items.Clear();

				if (comboBox3 != null)
				{
					if (comboBox3.Text == "Rozpłodowy" || comboBox3.Text == "Lotowy")
					{
						WczytajGolebieWgRodzaju();
						NumerowanieListyGolebii();
					}
					else
					{
						WczytajGolebieDoListy();
					}
				}
				else
				{
					WczytajGolebieDoListy();
				}
			}
		}

		// WCZYTYWANIE LISTY GOLEBII
		public void WczytajGolebieDoListy()
		{
			if (_tablicaGolebii != null)
			{
				foreach (var element in _tablicaGolebii)
				{
					if (element != null)
					{
						var golabItem = new ListViewItem(element.nrObraczki);
						listaGolebii.Items.Add(golabItem);
					}
				}
				NumerowanieListyGolebii();
			}
		}

		// SZUKANIE GOLEBIA W OKNIE LISTA GOLEBII
		private void button_szukaj_Click(object sender, EventArgs e)
		{
			if (listaGolebii.FocusedItem != null)
			{
				listaGolebii.FocusedItem.Selected = false;
				listaGolebii.FocusedItem.Focused = false;
			}

			var nrObraczki = szukajBox.Text;
			if (listaGolebii.Items.Count >= 1)
			{
				for (var i = 0; i < listaGolebii.Items.Count; i++)
				{
					if (nrObraczki == listaGolebii.Items[i].Text)
					{
						listaGolebii.Items[i].Selected = true;
						listaGolebii.Items[i].Focused = true;
						listaGolebii.Select();
						WyswietlGolebia();
						break;
					}
				}
			}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			WczytajGolebieWgRodzaju();
			NumerowanieListyGolebii();
		}

		public void NumerowanieListyGolebii()
		{
			for (var i = 0; i < listaGolebii.Items.Count; i++)
			{
				listaGolebii.Items[i].SubItems.Add((i + 1).ToString());
			}
		}

		public void WczytajGolebieWgRodzaju()
		{
			listaGolebii.Items.Clear();
			if (_tablicaGolebii != null)
			{
				foreach (var element in _tablicaGolebii)
				{
					if (element != null && element.rodzajGolebia == comboBox3.Text)
					{
						listaGolebii.Items.Add(new ListViewItem(element.nrObraczki));
					}
				}
			}
			listaGolebii.Sort();
		}
	}
}