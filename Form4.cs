using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    // KLIENCI
    public partial class Form4: Form
    {
        int selectedClientId = -1;
        private string connectionString = "server=localhost;user=root;password=;database=biblioteka";

        public Form4()
        {
            InitializeComponent();
        }

        private void LoadClients()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    id, imie, nazwisko, pesel, miasto, ulica, kod_pocztowy
                FROM 
                    Klienci";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wczytywania klientów: " + ex.Message);
            }
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
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private bool ValidateClientData(string pesel, string kod_pocztowy)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(pesel, @"^\d{11}$"))
            {
                MessageBox.Show("PESEL musi mieć dokładnie 11 cyfr.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(kod_pocztowy, @"^\d{2}-\d{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi mieć format XX-XXX, gdzie X to cyfra.");
                return false;
            }

            return true;
        }


        private bool IsPeselUnique(string pesel)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Klienci WHERE pesel = @pesel";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pesel", pesel);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 0; // true jeśli PESEL nie występuje jeszcze w bazie
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas sprawdzania unikalności PESEL: " + ex.Message);
                return false;
            }
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            string imie = imie_textBox.Text.Trim();
            string nazwisko = nazwisko_textBox.Text.Trim();
            string pesel = pesel_textBox.Text.Trim();
            string miasto = miasto_textBox.Text.Trim();
            string ulica = ulica_textBox.Text.Trim();
            string kod_pocztowy = kod_pocztowy_textBox.Text.Trim();

            // Walidacja formatu PESEL i kodu pocztowego
            if (!ValidateClientData(pesel, kod_pocztowy))
                return;

            // Sprawdzenie unikalności PESEL
            if (!IsPeselUnique(pesel))
            {
                MessageBox.Show("Podany PESEL już istnieje w bazie. Wprowadź unikalny PESEL.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Klienci (imie, nazwisko, pesel, miasto, ulica, kod_pocztowy)
                VALUES (@imie, @nazwisko, @pesel, @miasto, @ulica, @kod_pocztowy)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", imie);
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);
                        command.Parameters.AddWithValue("@pesel", pesel);
                        command.Parameters.AddWithValue("@miasto", miasto);
                        command.Parameters.AddWithValue("@ulica", ulica);
                        command.Parameters.AddWithValue("@kod_pocztowy", kod_pocztowy);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Klient został dodany pomyślnie.");
                ClearFields();
                LoadClients(); // odśwież listę klientów, jeśli masz taką metodę
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania klienta: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedClientId = Convert.ToInt32(row.Cells["id"].Value);

                imie_textBox.Text = row.Cells["imie"].Value.ToString();
                nazwisko_textBox.Text = row.Cells["nazwisko"].Value.ToString();
                pesel_textBox.Text = row.Cells["pesel"].Value.ToString();
                miasto_textBox.Text = row.Cells["miasto"].Value.ToString();
                ulica_textBox.Text = row.Cells["ulica"].Value.ToString();
                kod_pocztowy_textBox.Text = row.Cells["kod_pocztowy"].Value.ToString();
                znajdz_autora_textBox.Text = row.Cells["pesel"].Value.ToString();
            }

        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Nie wybrano klienta do usunięcia.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć tego klienta?",
                                                "Potwierdzenie usunięcia",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteRezerwacjeQuery = "DELETE FROM rezerwacje WHERE id_klienta = @id";

                        using (var deleteCommand = new MySqlCommand(deleteRezerwacjeQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", selectedClientId);
                            deleteCommand.ExecuteNonQuery();
                        }


                        string query = "DELETE FROM Klienci WHERE id = @id";

                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedClientId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Klient został usunięty.");
                    ClearFields();
                    LoadClients();
                    selectedClientId = -1; // resetuj po usunięciu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania klienta: " + ex.Message);
                }
            }
        }

        private void edytuj_btn_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Nie wybrano klienta do edycji.");
                return;
            }

            // Dalej używaj selectedClientId zamiast pobierania id z zaznaczonego wiersza

            string imie = imie_textBox.Text.Trim();
            string nazwisko = nazwisko_textBox.Text.Trim();
            string pesel = pesel_textBox.Text.Trim();
            string miasto = miasto_textBox.Text.Trim();
            string ulica = ulica_textBox.Text.Trim();
            string kod_pocztowy = kod_pocztowy_textBox.Text.Trim();

            // walidacje...
            if (!ValidateClientData(pesel, kod_pocztowy))
                return;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string queryCheck = "SELECT COUNT(*) FROM Klienci WHERE pesel = @pesel AND id != @id";
                    using (var cmdCheck = new MySqlCommand(queryCheck, connection))
                    {
                        cmdCheck.Parameters.AddWithValue("@pesel", pesel);
                        cmdCheck.Parameters.AddWithValue("@id", selectedClientId);
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Podany PESEL jest już używany przez innego klienta.");
                            return;
                        }
                    }

                    string query = @"
                UPDATE Klienci SET
                    imie = @imie,
                    nazwisko = @nazwisko,
                    pesel = @pesel,
                    miasto = @miasto,
                    ulica = @ulica,
                    kod_pocztowy = @kod_pocztowy
                WHERE id = @id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", imie);
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);
                        command.Parameters.AddWithValue("@pesel", pesel);
                        command.Parameters.AddWithValue("@miasto", miasto);
                        command.Parameters.AddWithValue("@ulica", ulica);
                        command.Parameters.AddWithValue("@kod_pocztowy", kod_pocztowy);
                        command.Parameters.AddWithValue("@id", selectedClientId);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dane klienta zostały zaktualizowane.");
                ClearFields();
                LoadClients();
                selectedClientId = -1; // reset po edycji
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas aktualizacji klienta: " + ex.Message);
            }
        }


        private void ClearFields()
        {
            imie_textBox.Clear();
            nazwisko_textBox.Clear();
            pesel_textBox.Clear();
            miasto_textBox.Clear();
            ulica_textBox.Clear();
            kod_pocztowy_textBox.Clear();
        }


        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void rezerwacje_btn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void znajdz_btn_Click(object sender, EventArgs e)
        {
            string pesel = znajdz_autora_textBox.Text.Trim();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string klientQuery;

                    if (string.IsNullOrEmpty(pesel))
                    {
                        // Jeśli PESEL nie podano – pobierz wszystkich klientów
                        klientQuery = @"
                    SELECT
                        id,
                        imie,
                        nazwisko,
                        pesel,
                        miasto,
                        ulica,
                        kod_pocztowy
                    FROM
                        Klienci";
                    }
                    else
                    {
                        // Jeśli PESEL podano – pobierz klienta z podanym PESEL
                        klientQuery = @"
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
                    }

                    using (var klientCmd = new MySqlCommand(klientQuery, connection))
                    {
                        if (!string.IsNullOrEmpty(pesel))
                            klientCmd.Parameters.AddWithValue("@pesel", pesel);

                        using (var adapter1 = new MySqlDataAdapter(klientCmd))
                        {
                            DataTable klientDT = new DataTable();
                            adapter1.Fill(klientDT);
                            dataGridView1.DataSource = klientDT;

                            if (!string.IsNullOrEmpty(pesel))
                            {
                                if (klientDT.Rows.Count > 0)
                                {
                                    int klientId = Convert.ToInt32(klientDT.Rows[0]["id"]);

                                    // Pobierz wypożyczenia klienta
                                    string wypozyczeniaQuery = @"
                                SELECT
                                    ks.tytul,
                                    ks.kategoria,
                                    ks.rok_wydania,
                                    ks.liczba_stron,
                                    CONCAT(a.imie, ' ', a.nazwisko) AS autor,
                                    r.data_rezerwacji,
                                    r.data_oddania
                                FROM
                                    Rezerwacje r
                                INNER JOIN Ksiazki ks ON r.id_ksiazki = ks.id
                                INNER JOIN Autorzy a ON ks.id_autora = a.id
                                WHERE
                                    r.id_klienta = @klientId";

                                    using (var wypozyczeniaCmd = new MySqlCommand(wypozyczeniaQuery, connection))
                                    {
                                        wypozyczeniaCmd.Parameters.AddWithValue("@klientId", klientId);
                                        using (var adapter2 = new MySqlDataAdapter(wypozyczeniaCmd))
                                        {
                                            DataTable wypozyczeniaDT = new DataTable();
                                            adapter2.Fill(wypozyczeniaDT);
                                            dataGridView2.DataSource = wypozyczeniaDT;
                                        }
                                    }
                                }
                                else
                                {
                                    dataGridView2.DataSource = null;
                                    MessageBox.Show("Nie znaleziono klienta o podanym numerze PESEL.");
                                }
                            }
                            else
                            {
                                // Jeśli nie szukano po PESEL – wyczyść rezerwacje
                                dataGridView2.DataSource = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania: " + ex.Message);
            }
        }


    }
}
