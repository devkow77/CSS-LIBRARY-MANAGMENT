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
    // AUTORZY
    public partial class Form2: Form
    {
        int selectedAuthorId = -1; // Zmienna do przechowywania ID wybranego autora
        private string connectionString = "server=localhost;user=root;password=;database=biblioteka";
        public Form2()
        {
            InitializeComponent();
        }

        private void okno_startowe_btn_Click(object sender, EventArgs e)
        {
            Form1 startForm = new Form1();
            startForm.Show();
            this.Hide();
        }

        private void LoadAuthors()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT id, imie, nazwisko, kraj
                        FROM Autorzy
                    ";

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

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadKrajeAutorow();
            LoadAuthors();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            string imieAutora = imie_textBox.Text.Trim();
            string nazwiskoAutora = nazwisko_textBox.Text.Trim();
            string krajAutora = kraj_textBox.Text.Trim();

            if (string.IsNullOrEmpty(imieAutora) || string.IsNullOrEmpty(nazwiskoAutora) || string.IsNullOrEmpty(krajAutora))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM autorzy WHERE imie = @imie AND nazwisko = @nazwisko AND kraj = @kraj";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@imie", imieAutora);
                        checkCmd.Parameters.AddWithValue("@nazwisko", nazwiskoAutora);
                        checkCmd.Parameters.AddWithValue("@kraj", krajAutora);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Autor już istnieje.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Autorzy(imie, nazwisko, kraj) VALUES (@imie, @nazwisko, @kraj)";
                    using (var cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@imie", imieAutora);
                        cmd.Parameters.AddWithValue("@nazwisko", nazwiskoAutora);
                        cmd.Parameters.AddWithValue("@kraj", krajAutora);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Autor został dodany." : "Nie udało się dodać autora.");
                    }
                }

                LoadAuthors();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
                kraj_textBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            imie_textBox.Clear();
            nazwisko_textBox.Clear();
            kraj_textBox.Clear();
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            if (selectedAuthorId == -1)
            {
                MessageBox.Show("Wybierz autora do usunięcia.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć tego autora? Wszystkie jego książki również zostaną usunięte!",
                                                 "Potwierdź usunięcie",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Usuń rezerwacje powiązane z książkami tego autora
                    string deleteReservationsQuery = @"
                    DELETE FROM Rezerwacje 
                    WHERE id_ksiazki IN (SELECT id FROM Ksiazki WHERE id_autora = @id)";
                    using (var deleteReservationsCmd = new MySqlCommand(deleteReservationsQuery, connection))
                    {
                        deleteReservationsCmd.Parameters.AddWithValue("@id", selectedAuthorId);
                        deleteReservationsCmd.ExecuteNonQuery();
                    }

                    // Usuń książki tego autora
                    string deleteBooksQuery = "DELETE FROM Ksiazki WHERE id_autora = @id";
                    using (var deleteBooksCmd = new MySqlCommand(deleteBooksQuery, connection))
                    {
                        deleteBooksCmd.Parameters.AddWithValue("@id", selectedAuthorId);
                        deleteBooksCmd.ExecuteNonQuery();
                    }

                    // Usuń autora
                    string deleteAuthorQuery = "DELETE FROM Autorzy WHERE id = @id";
                    using (var deleteAuthorCmd = new MySqlCommand(deleteAuthorQuery, connection))
                    {
                        deleteAuthorCmd.Parameters.AddWithValue("@id", selectedAuthorId);
                        int rowsAffected = deleteAuthorCmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Autor został usunięty." : "Nie udało się usunąć autora.");
                    }
                }

                LoadAuthors();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
                kraj_textBox.Clear();
                selectedAuthorId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedAuthorId = Convert.ToInt32(row.Cells["id"].Value);
                imie_textBox.Text = row.Cells["imie"].Value.ToString();
                nazwisko_textBox.Text = row.Cells["nazwisko"].Value.ToString();
                kraj_textBox.Text = row.Cells["kraj"].Value.ToString();
            }
        }

        private void edytuj_btn_Click(object sender, EventArgs e)
        {
            if (selectedAuthorId == -1)
            {
                MessageBox.Show("Wybierz autora do edycji.");
                return;
            }

            string imie = imie_textBox.Text.Trim();
            string nazwisko = nazwisko_textBox.Text.Trim();
            string kraj = kraj_textBox.Text.Trim();

            if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko) || string.IsNullOrEmpty(kraj))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Autorzy SET imie = @imie, nazwisko = @nazwisko, kraj = @kraj WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@imie", imie);
                        cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                        cmd.Parameters.AddWithValue("@kraj", kraj);
                        cmd.Parameters.AddWithValue("@id", selectedAuthorId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Autor zaktualizowany." : "Nie udało się zaktualizować autora.");
                    }
                }

                LoadAuthors();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
                kraj_textBox.Clear();
                selectedAuthorId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void ksiazki_btn_Click(object sender, EventArgs e)
        {
            Form3 ksiazkiForm = new Form3();
            ksiazkiForm.Show();
            this.Hide();
        }

        private void znajdz_btn_Click(object sender, EventArgs e)
        {
            string szukanyAutor = znajdz_autora_textBox.Text.Trim();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    MySqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(szukanyAutor))
                    {
                        // Pole puste – pokaż wszystkich autorów
                        query = @"
                    SELECT
                        id,
                        imie,
                        nazwisko,
                        kraj
                    FROM
                        Autorzy";
                        cmd = new MySqlCommand(query, connection);
                    }
                    else
                    {
                        // Filtruj po imieniu lub nazwisku autora
                        query = @"
                    SELECT
                        id,
                        imie,
                        nazwisko,
                        kraj
                    FROM
                        Autorzy
                    WHERE
                        imie LIKE @fraza OR nazwisko LIKE @fraza";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@fraza", "%" + szukanyAutor + "%");
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
                MessageBox.Show("Błąd podczas wyszukiwania autorów: " + ex.Message);
            }
        }

        private void autorzy_btn_Click(object sender, EventArgs e)
        {

        }

        private void rezerwacje_btn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void LoadKrajeAutorow()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT kraj FROM Autorzy ORDER BY kraj";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBoxKraj.Items.Clear();
                        comboBoxKraj.Items.Add(""); // Pusta opcja = wszyscy

                        while (reader.Read())
                        {
                            comboBoxKraj.Items.Add(reader["kraj"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania krajów: " + ex.Message);
            }
        }


        private void kraj_btn_Click(object sender, EventArgs e)
        {
            string selectedCountry = comboBoxKraj.SelectedItem?.ToString();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (string.IsNullOrEmpty(selectedCountry))
                    {
                        query = "SELECT * FROM Autorzy";
                    }
                    else
                    {
                        query = "SELECT * FROM Autorzy WHERE kraj = @kraj";
                    }

                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(selectedCountry))
                            command.Parameters.AddWithValue("@kraj", selectedCountry);

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
                MessageBox.Show("Błąd podczas filtrowania autorów: " + ex.Message);
            }
        }
    }
}
