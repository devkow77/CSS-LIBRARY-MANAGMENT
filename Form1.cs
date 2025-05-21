using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=biblioteka";

        private int selectedAuthorId = -1;
        private int selectedBookId = -1;

        public Form1()
        {
            InitializeComponent();
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView3.CellClick += dataGridView3_CellClick;
        }

        private void LoadLibrary()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT ksiazki.id, ksiazki.tytul, ksiazki.id_autora, autorzy.imie, autorzy.nazwisko
                        FROM ksiazki
                        JOIN autorzy ON ksiazki.id_autora = autorzy.id";

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

        private void LoadAuthors()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM autorzy";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ksiazki";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView3.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLibrary();
            LoadAuthors();
            LoadBooks();
        }

        private void dodaj_autora_btn_Click(object sender, EventArgs e)
        {
            string imieAutora = imie_textBox.Text.Trim();
            string nazwiskoAutora = nazwisko_textBox.Text.Trim();

            if (string.IsNullOrEmpty(imieAutora) || string.IsNullOrEmpty(nazwiskoAutora))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM autorzy WHERE imie = @imie AND nazwisko = @nazwisko";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@imie", imieAutora);
                        checkCmd.Parameters.AddWithValue("@nazwisko", nazwiskoAutora);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Autor już istnieje.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO autorzy(imie, nazwisko) VALUES (@imie, @nazwisko)";
                    using (var cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@imie", imieAutora);
                        cmd.Parameters.AddWithValue("@nazwisko", nazwiskoAutora);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Autor został dodany." : "Nie udało się dodać autora.");
                    }
                }

                LoadAuthors();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void wyczysc_autora_btn_Click(object sender, EventArgs e)
        {
            imie_textBox.Clear();
            nazwisko_textBox.Clear();
            selectedAuthorId = -1;
        }

        private void wyczysc_ksiazke_btn_Click(object sender, EventArgs e)
        {
            tytul_textBox.Clear();
            idAutora_textBox.Value = 0;
            selectedBookId = -1;
        }

        private void dodaj_ksiazke_btn_Click(object sender, EventArgs e)
        {
            string tytul = tytul_textBox.Text.Trim();
            int idAutora = (int)idAutora_textBox.Value;

            if (string.IsNullOrEmpty(tytul) || idAutora == 0)
            {
                MessageBox.Show("Uzupełnij tytuł i wybierz poprawne ID autora.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM ksiazki WHERE tytul = @tytul AND id_autora = @id_autora";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@tytul", tytul);
                        checkCmd.Parameters.AddWithValue("@id_autora", idAutora);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Taka książka już istnieje dla wybranego autora.");
                            return;
                        }
                    }

                    string query = "INSERT INTO ksiazki(tytul, id_autora) VALUES (@tytul, @id_autora)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tytul", tytul);
                        cmd.Parameters.AddWithValue("@id_autora", idAutora);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Książka została dodana." : "Nie udało się dodać książki.");
                    }
                }

                LoadBooks();
                LoadLibrary();
                tytul_textBox.Clear();
                idAutora_textBox.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                selectedAuthorId = Convert.ToInt32(row.Cells["id"].Value);
                imie_textBox.Text = row.Cells["imie"].Value.ToString();
                nazwisko_textBox.Text = row.Cells["nazwisko"].Value.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["id"].Value);
                tytul_textBox.Text = row.Cells["tytul"].Value.ToString();
                idAutora_textBox.Value = Convert.ToInt32(row.Cells["id_autora"].Value);
            }
        }

        private void edytuj_autora_btn_Click(object sender, EventArgs e)
        {
            if (selectedAuthorId == -1)
            {
                MessageBox.Show("Wybierz autora do edycji.");
                return;
            }

            string imie = imie_textBox.Text.Trim();
            string nazwisko = nazwisko_textBox.Text.Trim();

            if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE autorzy SET imie = @imie, nazwisko = @nazwisko WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@imie", imie);
                        cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                        cmd.Parameters.AddWithValue("@id", selectedAuthorId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Autor zaktualizowany." : "Nie udało się zaktualizować autora.");
                    }
                }

                LoadAuthors();
                LoadLibrary();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
                selectedAuthorId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void edytuj_ksiazke_btn_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Wybierz książkę do edycji.");
                return;
            }

            string tytul = tytul_textBox.Text.Trim();
            int idAutora = (int)idAutora_textBox.Value;

            if (string.IsNullOrEmpty(tytul) || idAutora == 0)
            {
                MessageBox.Show("Wypełnij tytuł i ID autora.");
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE ksiazki SET tytul = @tytul, id_autora = @id_autora WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@tytul", tytul);
                        cmd.Parameters.AddWithValue("@id_autora", idAutora);
                        cmd.Parameters.AddWithValue("@id", selectedBookId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Książka zaktualizowana." : "Nie udało się zaktualizować książki.");
                    }
                }

                LoadBooks();
                LoadLibrary();
                tytul_textBox.Clear();
                idAutora_textBox.Value = 0;
                selectedBookId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void usun_autora_btn_Click(object sender, EventArgs e)
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

                    // Najpierw usuń książki tego autora (jeśli są powiązania)
                    string deleteBooksQuery = "DELETE FROM ksiazki WHERE id_autora = @id";
                    using (var deleteBooksCmd = new MySqlCommand(deleteBooksQuery, connection))
                    {
                        deleteBooksCmd.Parameters.AddWithValue("@id", selectedAuthorId);
                        deleteBooksCmd.ExecuteNonQuery();
                    }

                    // Teraz usuń autora
                    string deleteAuthorQuery = "DELETE FROM autorzy WHERE id = @id";
                    using (var deleteAuthorCmd = new MySqlCommand(deleteAuthorQuery, connection))
                    {
                        deleteAuthorCmd.Parameters.AddWithValue("@id", selectedAuthorId);
                        int rowsAffected = deleteAuthorCmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Autor został usunięty." : "Nie udało się usunąć autora.");
                    }
                }

                LoadAuthors();
                LoadBooks();
                LoadLibrary();
                imie_textBox.Clear();
                nazwisko_textBox.Clear();
                selectedAuthorId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void usun_ksiazke_btn_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Wybierz książkę do usunięcia.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć tę książkę?",
                                                 "Potwierdź usunięcie",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteBookQuery = "DELETE FROM ksiazki WHERE id = @id";
                    using (var cmd = new MySqlCommand(deleteBookQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedBookId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Książka została usunięta." : "Nie udało się usunąć książki.");
                    }
                }

                LoadBooks();
                LoadLibrary();
                tytul_textBox.Clear();
                idAutora_textBox.Value = 0;
                selectedBookId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}
