using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Form3 : Form
    {
        int selectedBookId = -1;
        private string connectionString = "server=localhost;user=root;password=;database=biblioteka";

        public class AutorComboItem
        {
            public int Id { get; set; }
            public string WyswietlanaNazwa { get; set; }

            public override string ToString() => WyswietlanaNazwa;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void okno_startowe_btn_Click(object sender, EventArgs e)
        {
            Form1 oknoStartowe = new Form1();
            oknoStartowe.Show();
            this.Hide();
        }

        private void autorzy_btn_Click(object sender, EventArgs e)
        {
            Form2 oknoAutorzy = new Form2();
            oknoAutorzy.Show();
            this.Hide();
        }

        private void LoadBooks()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            k.id,
                            k.tytul, 
                            k.kategoria, 
                            k.rok_wydania, 
                            k.liczba_stron,
                            CONCAT(a.imie, ' ', a.nazwisko) AS autor
                        FROM 
                            Ksiazki k
                        INNER JOIN 
                            Autorzy a ON k.id_autora = a.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void LoadAuthorsToComboBox()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, imie, nazwisko, kraj FROM Autorzy";

                    using (var cmd = new MySqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBoxAutorzy.Items.Clear();

                        while (reader.Read())
                        {
                            var autor = new AutorComboItem
                            {
                                Id = reader.GetInt32("id"),
                                WyswietlanaNazwa = $"{reader["imie"]} {reader["nazwisko"]} ({reader["kraj"]})"
                            };

                            comboBoxAutorzy.Items.Add(autor);
                        }
                    }
                }

                comboBoxAutorzy.DisplayMember = "WyswietlanaNazwa";
                comboBoxAutorzy.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (!(comboBoxAutorzy.SelectedItem is AutorComboItem wybranyAutor))
            {
                MessageBox.Show("Wybierz autora z listy.");
                return;
            }

            string tytul = tytul_textBox.Text.Trim();
            string kategoria = kategoria_textBox.Text.Trim();
            DateTime rokWydania = rok_dateTimePicker.Value.Date;
            int liczbaStron = (int)strony_numericUpDown.Value;

            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(kategoria))
            {
                MessageBox.Show("Uzupełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Ksiazki (tytul, kategoria, rok_wydania, liczba_stron, id_autora)
                        VALUES (@tytul, @kategoria, @rok, @strony, @idAutora)";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tytul", tytul);
                        cmd.Parameters.AddWithValue("@kategoria", kategoria);
                        cmd.Parameters.AddWithValue("@rok", rokWydania);
                        cmd.Parameters.AddWithValue("@strony", liczbaStron);
                        cmd.Parameters.AddWithValue("@idAutora", wybranyAutor.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Książka została dodana.");
                ClearBookForm();
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania książki: " + ex.Message);
            }
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz książkę do usunięcia.");
                return;
            }

            int ksiazkaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            string tytul = dataGridView1.SelectedRows[0].Cells["tytul"].Value.ToString();

            var confirmResult = MessageBox.Show($"Czy na pewno chcesz usunąć książkę: \"{tytul}\"?",
                                                "Potwierdzenie usunięcia",
                                                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteRezerwacje = "DELETE FROM Rezerwacje WHERE id_ksiazki = @id";
                    using (var cmd1 = new MySqlCommand(deleteRezerwacje, connection))
                    {
                        cmd1.Parameters.AddWithValue("@id", ksiazkaId);
                        cmd1.ExecuteNonQuery();
                    }

                    string deleteKsiazka = "DELETE FROM Ksiazki WHERE id = @id";
                    using (var cmd2 = new MySqlCommand(deleteKsiazka, connection))
                    {
                        cmd2.Parameters.AddWithValue("@id", ksiazkaId);
                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Książka została usunięta.");
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["id"].Value);

                tytul_textBox.Text = row.Cells["tytul"].Value.ToString();
                kategoria_textBox.Text = row.Cells["kategoria"].Value.ToString();
                strony_numericUpDown.Value = Convert.ToInt32(row.Cells["liczba_stron"].Value);

                if (DateTime.TryParse(row.Cells["rok_wydania"].Value.ToString(), out DateTime data))
                {
                    rok_dateTimePicker.Value = data;
                }

                string autorString = row.Cells["autor"].Value.ToString(); // np. "Jan Kowalski"
                foreach (var item in comboBoxAutorzy.Items)
                {
                    if (item is AutorComboItem autor &&
                        autor.WyswietlanaNazwa.StartsWith(autorString)) // dopasowanie do imienia i nazwiska
                    {
                        comboBoxAutorzy.SelectedItem = autor;
                        break;
                    }
                }
            }
        }

        private void edytuj_btn_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Wybierz książkę do edycji.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tytul_textBox.Text) ||
                string.IsNullOrWhiteSpace(kategoria_textBox.Text) ||
                comboBoxAutorzy.SelectedIndex == -1)
            {
                MessageBox.Show("Uzupełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE Ksiazki 
                        SET tytul = @tytul, 
                            kategoria = @kategoria, 
                            rok_wydania = @rok, 
                            liczba_stron = @strony, 
                            id_autora = @id_autora
                        WHERE id = @id";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tytul", tytul_textBox.Text);
                        cmd.Parameters.AddWithValue("@kategoria", kategoria_textBox.Text);
                        cmd.Parameters.AddWithValue("@rok", rok_dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@strony", (int)strony_numericUpDown.Value);
                        cmd.Parameters.AddWithValue("@id_autora", ((AutorComboItem)comboBoxAutorzy.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("@id", selectedBookId);

                        int affected = cmd.ExecuteNonQuery();
                        MessageBox.Show(affected > 0 ? "Zaktualizowano książkę." : "Nie udało się zaktualizować.");
                    }
                }

                LoadBooks();
                ClearBookForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            ClearBookForm();
        }

        private void ClearBookForm()
        {
            tytul_textBox.Clear();
            kategoria_textBox.Clear();
            strony_numericUpDown.Value = 1;
            rok_dateTimePicker.Value = DateTime.Now;
            comboBoxAutorzy.SelectedIndex = -1;
            selectedBookId = -1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadKategorieKsiazek();
            LoadBooks();
            LoadAuthorsToComboBox();
        }

        private void znajdz_btn_Click(object sender, EventArgs e)
        {
            string szukanaFraza = znajdz_ksiazke_textBox.Text.Trim();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    MySqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(szukanaFraza))
                    {
                        // Jeśli pole jest puste – pokaż wszystkie książki
                        query = @"
                    SELECT
                        k.id,
                        k.tytul,
                        k.kategoria,
                        k.rok_wydania,
                        k.liczba_stron,
                        CONCAT(a.imie, ' ', a.nazwisko) AS autor
                    FROM
                        Ksiazki k
                    INNER JOIN
                        Autorzy a ON k.id_autora = a.id";
                        cmd = new MySqlCommand(query, connection);
                    }
                    else
                    {
                        // Jeśli coś wpisano – filtruj po tytule
                        query = @"
                    SELECT
                        k.id,
                        k.tytul,
                        k.kategoria,
                        k.rok_wydania,
                        k.liczba_stron,
                        CONCAT(a.imie, ' ', a.nazwisko) AS autor
                    FROM
                        Ksiazki k
                    INNER JOIN
                        Autorzy a ON k.id_autora = a.id
                    WHERE
                        k.tytul LIKE @fraza";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@fraza", "%" + szukanaFraza + "%");
                    }

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable wynik = new DataTable();
                        adapter.Fill(wynik);
                        dataGridView1.DataSource = wynik;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania książek: " + ex.Message);
            }
        }

        private void LoadKategorieKsiazek()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT kategoria FROM Ksiazki ORDER BY kategoria";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBoxKategoria.Items.Clear();
                        comboBoxKategoria.Items.Add(""); // Pusta = wszystkie

                        while (reader.Read())
                        {
                            comboBoxKategoria.Items.Add(reader["kategoria"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania kategorii: " + ex.Message);
            }
        }

        private void klienci_btn_Click(object sender, EventArgs e)
        {
            Form4 form4
                = new Form4();
            form4.Show();
            this.Hide();

        }

        private void rezerwacje_btn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void ksiazki_btn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxKategoria.SelectedItem?.ToString();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    if (string.IsNullOrEmpty(selectedCategory))
                    {
                        query = @"
                    SELECT k.id, k.tytul, k.kategoria, k.rok_wydania, k.liczba_stron,
                           CONCAT(a.imie, ' ', a.nazwisko) AS autor
                    FROM Ksiazki k
                    INNER JOIN Autorzy a ON k.id_autora = a.id";
                    }
                    else
                    {
                        query = @"
                    SELECT k.id, k.tytul, k.kategoria, k.rok_wydania, k.liczba_stron,
                           CONCAT(a.imie, ' ', a.nazwisko) AS autor
                    FROM Ksiazki k
                    INNER JOIN Autorzy a ON k.id_autora = a.id
                    WHERE k.kategoria = @kategoria";
                    }

                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(selectedCategory))
                            command.Parameters.AddWithValue("@kategoria", selectedCategory);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas filtrowania książek: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            int rokOd = dateTimePicker1.Value.Year;
            int rokDo = dateTimePicker2.Value.Year;

            if (rokOd > rokDo)
            {
                MessageBox.Show("Data 'od' nie może być większa niż data 'do'.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT k.id, k.tytul, k.kategoria, k.rok_wydania, k.liczba_stron,
                       CONCAT(a.imie, ' ', a.nazwisko) AS autor
                FROM Ksiazki k
                INNER JOIN Autorzy a ON k.id_autora = a.id
               WHERE YEAR(k.rok_wydania) BETWEEN @rokOd AND @rokDo";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rokOd", rokOd);
                        command.Parameters.AddWithValue("@rokDo", rokDo);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas filtrowania po dacie: " + ex.Message);
            }
        }

        private void data_wyczysc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
            SELECT k.id, k.tytul, k.kategoria, k.rok_wydania, k.liczba_stron,
                   CONCAT(a.imie, ' ', a.nazwisko) AS autor
            FROM Ksiazki k
            INNER JOIN Autorzy a ON k.id_autora = a.id";

                    using (var command = new MySqlCommand(query, connection))
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania książek: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string szukanaFraza = textBox1.Text.Trim();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    MySqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(szukanaFraza))
                    {
                        // Jeśli pole jest puste – pokaż wszystkie książki
                        query = @"
                SELECT
                    k.id,
                    k.tytul,
                    k.kategoria,
                    k.rok_wydania,
                    k.liczba_stron,
                    CONCAT(a.imie, ' ', a.nazwisko) AS autor
                FROM
                    Ksiazki k
                INNER JOIN
                    Autorzy a ON k.id_autora = a.id";
                        cmd = new MySqlCommand(query, connection);
                    }
                    else
                    {
                        // Szukanie tylko po imieniu lub nazwisku autora
                        query = @"
                SELECT
                    k.id,
                    k.tytul,
                    k.kategoria,
                    k.rok_wydania,
                    k.liczba_stron,
                    CONCAT(a.imie, ' ', a.nazwisko) AS autor
                FROM
                    Ksiazki k
                INNER JOIN
                    Autorzy a ON k.id_autora = a.id
                WHERE
                    a.imie LIKE @fraza OR
                    a.nazwisko LIKE @fraza";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@fraza", "%" + szukanaFraza + "%");
                    }

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable wynik = new DataTable();
                        adapter.Fill(wynik);
                        dataGridView1.DataSource = wynik;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania autora: " + ex.Message);
            }

        }
    }
}
