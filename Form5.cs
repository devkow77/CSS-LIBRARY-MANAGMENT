using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotekaProjekt
{
    public partial class Form5: Form
    {
        int selectedBookId = -1;
        private string connectionString = "server=localhost;user=root;password=;database=biblioteka";

        public Form5()
        {
            InitializeComponent();
        }

        private void okno_startowe_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void autorzy_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void ksiazki_btn_Click(object sender, EventArgs e)
        {
            Form3 form3
                = new Form3();
            form3.Show();
            this.Hide();

        }

        private void klienci_btn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void znajdz_btn_Click(object sender, EventArgs e)
        {
            string pesel = znajdz_autora_textBox.Text.Trim();

            if (string.IsNullOrEmpty(pesel))
            {
                MessageBox.Show("Wprowadź numer PESEL.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT
                    id,
                    imie,
                    nazwisko,
                    pesel,
                    miasto,
                    ulica,
                    kod_pocztowy
                FROM
                    Klienci
                WHERE
                    pesel = @pesel";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pesel", pesel);

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Nie znaleziono klienta o podanym numerze PESEL.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                            else
                            {
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message, "Błąd zapytania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    k.ilosc_sztuk,
                    k.ilosc_dostepnych,
                    CONCAT(a.imie, ' ', a.nazwisko) AS autor
                FROM
                    Ksiazki k
                INNER JOIN
                    Autorzy a ON k.id_autora = a.id
                WHERE
                    k.ilosc_dostepnych > 0";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania książek: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string tytul = znajdz_ksiazke_textBox.Text.Trim();

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
                    k.ilosc_sztuk,
                    k.ilosc_dostepnych,
                    CONCAT(a.imie, ' ', a.nazwisko) AS autor
                FROM
                    Ksiazki k
                INNER JOIN
                    Autorzy a ON k.id_autora = a.id";

                    if (!string.IsNullOrEmpty(tytul))
                    {
                        query += " WHERE k.tytul LIKE @tytul";
                    }

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(tytul))
                        {
                            cmd.Parameters.AddWithValue("@tytul", "%" + tytul + "%");
                        }

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Nie znaleziono książki o podanym tytule.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView2.DataSource = null;
                            }
                            else
                            {
                                dataGridView2.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania książki: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void rezerwuj_btn_Click(object sender, EventArgs e)
        {
            // Sprawdź czy wybrano klienta
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdź czy wybrano książkę
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz książkę do rezerwacji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int klientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            int ksiazkaId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value);
            DateTime dataRezerwacji = DateTime.Now;
            DateTime dataOddania = dateTimePicker1.Value;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Sprawdź czy książka ma dostępne egzemplarze
                    string checkQuery = "SELECT ilosc_dostepnych FROM Ksiazki WHERE id = @id";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@id", ksiazkaId);
                        var result = checkCmd.ExecuteScalar();

                        if (result == null || Convert.ToInt32(result) <= 0)
                        {
                            MessageBox.Show("Brak dostępnych egzemplarzy tej książki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 1. Wstaw rezerwację
                    string insertQuery = @"
                INSERT INTO Rezerwacje (id_klienta, id_ksiazki, data_rezerwacji, data_oddania)
                VALUES (@klientId, @ksiazkaId, @dataRezerwacji, @dataOddania)";
                    using (var insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@klientId", klientId);
                        insertCmd.Parameters.AddWithValue("@ksiazkaId", ksiazkaId);
                        insertCmd.Parameters.AddWithValue("@dataRezerwacji", dataRezerwacji);
                        insertCmd.Parameters.AddWithValue("@dataOddania", dataOddania);
                        insertCmd.ExecuteNonQuery();
                    }

                    // 2. Zmniejsz dostępność książki
                    string updateQuery = "UPDATE Ksiazki SET ilosc_dostepnych = ilosc_dostepnych - 1 WHERE id = @id";
                    using (var updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@id", ksiazkaId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Rezerwacja została zapisana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Odśwież listę książek
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas rezerwacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
