-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Cze 05, 2025 at 10:04 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biblioteka`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `autorzy`
--

CREATE TABLE `autorzy` (
  `id` int(11) NOT NULL,
  `imie` varchar(30) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  `kraj` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `autorzy`
--

INSERT INTO `autorzy` (`id`, `imie`, `nazwisko`, `kraj`) VALUES
(1, 'Adam', 'Mickiewicz', 'Polska'),
(2, 'Henryk', 'Sienkiewicz', 'Polska'),
(3, 'Juliusz', 'Słowacki', 'Polska'),
(4, 'Bolesław', 'Prus', 'Polska'),
(5, 'Stanisław', 'Lem', 'Polska'),
(6, 'George', 'Orwell', 'Wielka Brytania'),
(7, 'Jane', 'Austen', 'Wielka Brytania'),
(8, 'J.K.', 'Rowling', 'Wielka Brytania'),
(9, 'Stephen', 'King', 'USA'),
(10, 'Ernest', 'Hemingway', 'USA'),
(11, 'Gabriel', 'García Márquez', 'Kolumbia'),
(12, 'Franz', 'Kafka', 'Czechy'),
(13, 'Leo', 'Tolstoy', 'Rosja'),
(14, 'Fyodor', 'Dostoevsky', 'Rosja'),
(15, 'Victor', 'Hugo', 'Francja'),
(16, 'Albert', 'Camus', 'Francja'),
(17, 'Haruki', 'Murakami', 'Japonia'),
(18, 'Umberto', 'Eco', 'Włochy'),
(19, 'Isabel', 'Allende', 'Chile'),
(20, 'Mark', 'Twain', 'USA');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klienci`
--

CREATE TABLE `klienci` (
  `id` int(11) NOT NULL,
  `imie` varchar(30) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  `pesel` varchar(11) NOT NULL,
  `miasto` varchar(50) NOT NULL,
  `ulica` varchar(50) NOT NULL,
  `kod_pocztowy` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `klienci`
--

INSERT INTO `klienci` (`id`, `imie`, `nazwisko`, `pesel`, `miasto`, `ulica`, `kod_pocztowy`) VALUES
(1, 'Janek', 'Kowalski', '90010112345', 'Warszawa', 'Polna 1', '00-001'),
(2, 'Anna', 'Nowak', '91020223456', 'Kraków', 'Leśna 2', '30-002'),
(3, 'Piotr', 'Wiśniewski', '92030334567', 'Gdańsk', 'Kwiatowa 3', '80-003'),
(4, 'Ewa', 'Kamińska', '93040445678', 'Poznań', 'Szkolna 4', '60-004'),
(5, 'Tomasz', 'Lewandowski', '94050556789', 'Wrocław', 'Długa 5', '50-005'),
(6, 'Katarzyna', 'Zielińska', '95060667890', 'Łódź', 'Krótka 6', '90-006'),
(7, 'Michał', 'Dąbrowski', '96070778901', 'Szczecin', 'Morska 7', '70-007'),
(8, 'Agnieszka', 'Wójcik', '97080889012', 'Bydgoszcz', 'Lipowa 8', '85-008'),
(9, 'Paweł', 'Kaczmarek', '98090990123', 'Lublin', 'Topolowa 9', '20-009'),
(10, 'Magdalena', 'Mazur', '99010101234', 'Białystok', 'Jesionowa 10', '15-010'),
(11, 'Grzegorz', 'Krawczyk', '88020212345', 'Gdynia', 'Zielona 11', '81-011'),
(12, 'Natalia', 'Piotrowska', '87030323456', 'Katowice', 'Brzozowa 12', '40-012'),
(13, 'Rafał', 'Grabowski', '86040434567', 'Częstochowa', 'Bukowa 13', '42-013'),
(14, 'Karolina', 'Pawlak', '85050545678', 'Radom', 'Jaworowa 14', '26-014'),
(15, 'Wojciech', 'Michalski', '84060656789', 'Toruń', 'Jesienna 15', '87-015'),
(16, 'Joanna', 'Król', '83070767890', 'Kielce', 'Zimowa 16', '25-016'),
(17, 'Łukasz', 'Wieczorek', '82080878901', 'Rzeszów', 'Wiosenna 17', '35-017'),
(18, 'Barbara', 'Jankowska', '81090989012', 'Opole', 'Letnia 18', '45-018'),
(19, 'Krzysztof', 'Zając', '80010190123', 'Zielona Góra', 'Piękna 19', '65-019'),
(20, 'Małgorzata', 'Szymańska', '79020201234', 'Olsztyn', 'Nowa 20', '10-020');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazki`
--

CREATE TABLE `ksiazki` (
  `id` int(11) NOT NULL,
  `tytul` varchar(60) NOT NULL,
  `kategoria` varchar(40) NOT NULL,
  `rok_wydania` date NOT NULL,
  `liczba_stron` int(11) DEFAULT NULL,
  `id_autora` int(11) NOT NULL,
  `ilosc_sztuk` int(11) NOT NULL DEFAULT 1,
  `ilosc_dostepnych` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ksiazki`
--

INSERT INTO `ksiazki` (`id`, `tytul`, `kategoria`, `rok_wydania`, `liczba_stron`, `id_autora`, `ilosc_sztuk`, `ilosc_dostepnych`) VALUES
(1, 'Pan Tadeusz', 'Epika', '1834-01-01', 340, 1, 340, 339),
(2, 'Quo Vadis', 'Historyczna', '1896-01-01', 480, 2, 5, 3),
(3, 'Kordian', 'Dramat', '1834-01-01', 150, 3, 2, 2),
(4, 'Lalka', 'Powieść', '1890-01-01', 680, 4, 3, 1),
(5, 'Solaris', 'Science Fiction', '1961-01-01', 300, 5, 4, 3),
(6, '1984', 'Dystopia', '1949-01-01', 328, 6, 6, 5),
(7, 'Duma i uprzedzenie', 'Romans', '1813-01-01', 279, 7, 3, 2),
(8, 'Harry Potter', 'Fantasy', '1997-01-01', 400, 8, 8, 7),
(9, 'Lśnienie', 'Horror', '1977-01-01', 447, 9, 3, 3),
(10, 'Stary człowiek i morze', 'Nowela', '1952-01-01', 127, 10, 5, 4),
(11, 'Sto lat samotności', 'Magiczny realizm', '1967-01-01', 417, 11, 2, 1),
(12, 'Proces', 'Egzystencjalna', '1925-01-01', 231, 12, 2, 1),
(13, 'Wojna i pokój', 'Historyczna', '1869-01-01', 1225, 13, 2, 2),
(14, 'Zbrodnia i kara', 'Psychologiczna', '1866-01-01', 545, 14, 4, 2),
(15, 'Nędznicy', 'Społeczna', '1862-01-01', 1232, 15, 3, 2),
(16, 'Dżuma', 'Egzystencjalna', '1947-01-01', 308, 16, 3, 2),
(17, 'Norwegian Wood', 'Obyczajowa', '1987-01-01', 296, 17, 3, 2),
(18, 'Imię róży', 'Kryminał', '1980-01-01', 502, 18, 3, 3),
(19, 'Dom duchów', 'Magiczny realizm', '1982-01-01', 368, 19, 2, 1),
(20, 'Przygody Tomka Sawyera', 'Przygodowa', '1876-01-01', 274, 20, 4, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacje`
--

CREATE TABLE `rezerwacje` (
  `id` int(11) NOT NULL,
  `id_klienta` int(11) NOT NULL,
  `id_ksiazki` int(11) NOT NULL,
  `data_rezerwacji` datetime NOT NULL DEFAULT current_timestamp(),
  `data_oddania` date DEFAULT NULL,
  `status` enum('w trakcie','zakonczono') NOT NULL DEFAULT 'w trakcie'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rezerwacje`
--

INSERT INTO `rezerwacje` (`id`, `id_klienta`, `id_ksiazki`, `data_rezerwacji`, `data_oddania`, `status`) VALUES
(1, 1, 2, '2025-06-01 10:00:00', '2025-06-15', 'w trakcie'),
(2, 2, 4, '2025-06-01 12:00:00', '2025-06-15', 'w trakcie'),
(3, 3, 5, '2025-06-02 09:30:00', '2025-06-16', 'w trakcie'),
(4, 4, 1, '2025-06-02 14:45:00', '2025-06-16', 'zakonczono'),
(5, 5, 3, '2025-06-03 08:00:00', '2025-06-17', 'w trakcie'),
(6, 1, 6, '2025-06-03 10:15:00', '2025-06-17', 'zakonczono'),
(7, 2, 7, '2025-06-04 11:20:00', '2025-06-18', 'w trakcie'),
(8, 3, 8, '2025-06-04 13:05:00', '2025-06-18', 'w trakcie'),
(9, 4, 9, '2025-06-05 15:30:00', '2025-06-19', 'zakonczono'),
(10, 5, 10, '2025-06-05 16:00:00', '2025-06-19', 'w trakcie'),
(11, 1, 1, '2025-06-06 10:00:00', '2025-06-20', 'w trakcie'),
(12, 2, 2, '2025-06-06 11:00:00', '2025-06-20', 'zakonczono'),
(13, 3, 3, '2025-06-07 12:00:00', '2025-06-21', 'w trakcie'),
(14, 4, 4, '2025-06-07 13:00:00', '2025-06-21', 'w trakcie'),
(15, 5, 5, '2025-06-08 14:00:00', '2025-06-22', 'zakonczono'),
(16, 1, 6, '2025-06-08 15:00:00', '2025-06-22', 'w trakcie'),
(17, 2, 7, '2025-06-09 16:00:00', '2025-06-23', 'w trakcie'),
(18, 3, 8, '2025-06-09 17:00:00', '2025-06-23', 'w trakcie'),
(19, 4, 9, '2025-06-10 18:00:00', '2025-06-24', 'w trakcie'),
(20, 5, 10, '2025-06-10 19:00:00', '2025-06-24', 'w trakcie'),
(21, 11, 1, '2025-06-05 21:56:12', '2025-06-07', 'w trakcie'),
(22, 9, 2, '2025-06-05 21:59:41', '2025-06-20', 'w trakcie');

--
-- Wyzwalacze `rezerwacje`
--
DELIMITER $$
CREATE TRIGGER `ustaw_date_oddania` BEFORE INSERT ON `rezerwacje` FOR EACH ROW BEGIN
  IF NEW.data_oddania IS NULL THEN
    SET NEW.data_oddania = DATE_ADD(NEW.data_rezerwacji, INTERVAL 14 DAY);
  END IF;
END
$$
DELIMITER ;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `autorzy`
--
ALTER TABLE `autorzy`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `klienci`
--
ALTER TABLE `klienci`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `pesel` (`pesel`);

--
-- Indeksy dla tabeli `ksiazki`
--
ALTER TABLE `ksiazki`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_autora` (`id_autora`);

--
-- Indeksy dla tabeli `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_klienta` (`id_klienta`),
  ADD KEY `id_ksiazki` (`id_ksiazki`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autorzy`
--
ALTER TABLE `autorzy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `klienci`
--
ALTER TABLE `klienci`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `ksiazki`
--
ALTER TABLE `ksiazki`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `rezerwacje`
--
ALTER TABLE `rezerwacje`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ksiazki`
--
ALTER TABLE `ksiazki`
  ADD CONSTRAINT `ksiazki_ibfk_1` FOREIGN KEY (`id_autora`) REFERENCES `autorzy` (`id`);

--
-- Constraints for table `rezerwacje`
--
ALTER TABLE `rezerwacje`
  ADD CONSTRAINT `rezerwacje_ibfk_1` FOREIGN KEY (`id_klienta`) REFERENCES `klienci` (`id`),
  ADD CONSTRAINT `rezerwacje_ibfk_2` FOREIGN KEY (`id_ksiazki`) REFERENCES `ksiazki` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
