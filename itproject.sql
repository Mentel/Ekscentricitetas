-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 2019 m. Grd 18 d. 00:35
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `itproject`
--

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `daiktas`
--

CREATE TABLE `daiktas` (
  `pavadinimas` varchar(255) COLLATE utf8_bin NOT NULL,
  `aprasymas` varchar(255) COLLATE utf8_bin NOT NULL,
  `kodas` int(11) NOT NULL,
  `kaina` double NOT NULL,
  `parduodamas` tinyint(1) NOT NULL,
  `kiekis` int(11) NOT NULL,
  `bukle` varchar(255) COLLATE utf8_bin NOT NULL,
  `pagaminimo_data` date NOT NULL,
  `fk_Sandelisid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Sukurta duomenų kopija lentelei `daiktas`
--

INSERT INTO `daiktas` (`pavadinimas`, `aprasymas`, `kodas`, `kaina`, `parduodamas`, `kiekis`, `bukle`, `pagaminimo_data`, `fk_Sandelisid`) VALUES
('Nidia Geforce 970', 'Vaizdo plokšte', 150, 199.99, 1, 1100, 'Naujas', '2018-10-00', 2),
('Samsung F12345', 'Monitorius', 151, 500.51, 0, 1010, 'Naujas', '2015-12-00', 1),
('ąčęėĄČĖĖĘ', 'asdasd', 522, 500, 1, 540, 'Naujas', '2019-12-03', 2),
('AMD Radeon 5000', 'Vaizdo plokšte', 560, 299.99, 1, 500, 'Naujas', '2015-01-00', 2);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `daikto_kiekis_nuoma`
--

CREATE TABLE `daikto_kiekis_nuoma` (
  `kiekis` int(11) NOT NULL,
  `id_Daikto_kiekis_nuoma` int(11) NOT NULL,
  `fk_Nuomos_sutartisid` int(11) NOT NULL,
  `fk_Daiktaskodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `daikto_kiekis_pardavimas`
--

CREATE TABLE `daikto_kiekis_pardavimas` (
  `kiekis` int(11) NOT NULL,
  `id_Daikto_kiekis_pardavimas` int(11) NOT NULL,
  `fk_Pardavimo_sutartisid` int(11) NOT NULL,
  `fk_Daiktaskodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `is_vartotojas`
--

CREATE TABLE `is_vartotojas` (
  `vardas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `pavarde` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `gimimo_data` date NOT NULL,
  `el_pastas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `adresas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `slapyvardis` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `slaptazodis` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `dirba_nuo` date NOT NULL,
  `darbo_valandos` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `alga` double NOT NULL,
  `parduotuves_adresas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `id` int(11) NOT NULL,
  `fk_Sandelisid` int(11) DEFAULT NULL,
  `typeSelector` char(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `is_vartotojas`
--

INSERT INTO `is_vartotojas` (`vardas`, `pavarde`, `gimimo_data`, `el_pastas`, `adresas`, `slapyvardis`, `slaptazodis`, `dirba_nuo`, `darbo_valandos`, `alga`, `parduotuves_adresas`, `id`, `fk_Sandelisid`, `typeSelector`) VALUES
('Valdas', 'Šorys', '1998-10-06', 'valdas@test.com', 'Kaunas, Gričiupio g. 5696', 'valdas123', 'nezinau', '2019-12-01', '9:00-18:00', 958, 'Kaunas', 1, 1, '1'),
('Algirdas', 'Vasiliauskas', '1998-02-11', 'alg@alg.lt', 'Kaunas Kauno g.', 'algirdas145', 'algirdas123', '2019-12-02', '9:00-18:00', 1000, 'Kaunas', 2, 2, '1');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `klientas`
--

CREATE TABLE `klientas` (
  `vardas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `pavarde` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `el_pastas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `telefono_nr` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `adresas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `pasto_kodas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `id_Klientas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `klientas`
--

INSERT INTO `klientas` (`vardas`, `pavarde`, `el_pastas`, `telefono_nr`, `adresas`, `pasto_kodas`, `id_Klientas`) VALUES
('Algirdas', 'Algirdas', 'Algirdas@Algirdas.com', '869326421', 'Kaunas Kauno g.', 'LT-58658', 1);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `nuomos_sutartis`
--

CREATE TABLE `nuomos_sutartis` (
  `sudarymo_data` date NOT NULL,
  `grazinimo_data` date DEFAULT NULL,
  `kaina` double NOT NULL,
  `pastabos` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `id_Nuomos_sutartis` int(11) NOT NULL,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISVartotojas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `pardavimo_sutartis`
--

CREATE TABLE `pardavimo_sutartis` (
  `sudarymo_data` date NOT NULL,
  `kaina` double NOT NULL,
  `id_Pardavimo_sutartis` int(11) NOT NULL,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISvartotojas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `sandelis`
--

CREATE TABLE `sandelis` (
  `adresas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `pasto_kodas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `plotas` double NOT NULL,
  `telefono_nr` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `el_pastas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `id_Sandelis` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `sandelis`
--

INSERT INTO `sandelis` (`adresas`, `pasto_kodas`, `plotas`, `telefono_nr`, `el_pastas`, `id_Sandelis`) VALUES
('asdasd', 'asdasd', 10, 'asdasd', 'asdasd', 1),
('Kaunas', 'LT-12345', 500, '+37061234567', 'sandelis1@gmail.com', 2);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `taisomasirenginys`
--

CREATE TABLE `taisomasirenginys` (
  `pavadinimas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `kodas` int(11) DEFAULT NULL,
  `komentaras` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `id_TaisomasIrenginys` int(11) NOT NULL,
  `fk_Taisymasid` int(11) NOT NULL,
  `busena` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `taisomasirenginys`
--

INSERT INTO `taisomasirenginys` (`pavadinimas`, `kodas`, `komentaras`, `id_TaisomasIrenginys`, `fk_Taisymasid`, `busena`) VALUES
('Procesorius', 12, 'Sudeges', 1, 1, 'Pataisytas'),
('Ekranas', 2, 'Išsilieję skystieji kristalai.', 2, 1, 'Taisomas'),
('Ekranas', 55, 'Iskiles', 55, 1, 'Taisomas'),
('Procesorius', 66, 'Sugedes nepataisomai', 66, 2, 'Nepataisomas'),
('Kompiuteris', 68, 'Neisijungia', 68, 1, 'Laukia savo eiles');

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `taisymas`
--

CREATE TABLE `taisymas` (
  `palikimo_data` date NOT NULL,
  `kaina` int(11) NOT NULL,
  `id_Taisymas` int(11) NOT NULL,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISVartotojas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `taisymas`
--

INSERT INTO `taisymas` (`palikimo_data`, `kaina`, `id_Taisymas`, `fk_Klientasid`, `fk_ISVartotojas`) VALUES
('2019-12-11', 25, 1, 1, 1),
('2019-12-10', 30, 2, 1, 2);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `uzsakymas`
--

CREATE TABLE `uzsakymas` (
  `sukurimo_data` date NOT NULL,
  `altiktas` tinyint(1) NOT NULL DEFAULT '0',
  `altikimo_data` date DEFAULT NULL,
  `kiekis` int(11) NOT NULL,
  `id_Uzsakymas` int(11) NOT NULL,
  `fk_ISvartotojas` int(11) NOT NULL,
  `fk_daiktokodas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Sukurta duomenų kopija lentelei `uzsakymas`
--

INSERT INTO `uzsakymas` (`sukurimo_data`, `altiktas`, `altikimo_data`, `kiekis`, `id_Uzsakymas`, `fk_ISvartotojas`, `fk_daiktokodas`) VALUES
('2019-12-17', 1, '2019-12-17', 10, 5, 1, 522),
('2019-12-17', 1, '2019-12-17', 500, 6, 1, 151),
('2019-12-17', 1, '2019-12-17', 10, 7, 1, 151),
('2019-12-17', 1, '2019-12-17', 500, 8, 1, 150),
('2019-12-17', 1, '2019-12-17', 500, 9, 1, 150),
('2019-12-17', 0, NULL, 500, 10, 1, 560);

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `veiklos_istorija`
--

CREATE TABLE `veiklos_istorija` (
  `data` date NOT NULL,
  `veiksmas` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `id_Veiklos_istorija` int(11) NOT NULL,
  `fk_ISvartotojas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `daiktas`
--
ALTER TABLE `daiktas`
  ADD PRIMARY KEY (`kodas`),
  ADD KEY `sandeliuojamas` (`fk_Sandelisid`);

--
-- Indexes for table `daikto_kiekis_nuoma`
--
ALTER TABLE `daikto_kiekis_nuoma`
  ADD PRIMARY KEY (`id_Daikto_kiekis_nuoma`),
  ADD KEY `yra1` (`fk_Nuomos_sutartisid`),
  ADD KEY `fkc_daikto_kiekis_nuoma_daiktas` (`fk_Daiktaskodas`);

--
-- Indexes for table `daikto_kiekis_pardavimas`
--
ALTER TABLE `daikto_kiekis_pardavimas`
  ADD PRIMARY KEY (`id_Daikto_kiekis_pardavimas`),
  ADD KEY `yra2` (`fk_Pardavimo_sutartisid`),
  ADD KEY `fkc_daikto_kiekis_pardavimas_daiktas` (`fk_Daiktaskodas`);

--
-- Indexes for table `is_vartotojas`
--
ALTER TABLE `is_vartotojas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `dirba` (`fk_Sandelisid`);

--
-- Indexes for table `klientas`
--
ALTER TABLE `klientas`
  ADD PRIMARY KEY (`id_Klientas`);

--
-- Indexes for table `nuomos_sutartis`
--
ALTER TABLE `nuomos_sutartis`
  ADD PRIMARY KEY (`id_Nuomos_sutartis`),
  ADD KEY `uzsako1` (`fk_Klientasid`),
  ADD KEY `sudaro1` (`fk_ISVartotojas`);

--
-- Indexes for table `pardavimo_sutartis`
--
ALTER TABLE `pardavimo_sutartis`
  ADD PRIMARY KEY (`id_Pardavimo_sutartis`),
  ADD KEY `uzsako2` (`fk_Klientasid`),
  ADD KEY `sudaro2` (`fk_ISvartotojas`);

--
-- Indexes for table `sandelis`
--
ALTER TABLE `sandelis`
  ADD PRIMARY KEY (`id_Sandelis`);

--
-- Indexes for table `taisomasirenginys`
--
ALTER TABLE `taisomasirenginys`
  ADD PRIMARY KEY (`id_TaisomasIrenginys`),
  ADD KEY `taiso` (`fk_Taisymasid`);

--
-- Indexes for table `taisymas`
--
ALTER TABLE `taisymas`
  ADD PRIMARY KEY (`id_Taisymas`),
  ADD KEY `uzsako3` (`fk_Klientasid`),
  ADD KEY `sukuria` (`fk_ISVartotojas`);

--
-- Indexes for table `uzsakymas`
--
ALTER TABLE `uzsakymas`
  ADD PRIMARY KEY (`id_Uzsakymas`),
  ADD KEY `sudaro3` (`fk_ISvartotojas`),
  ADD KEY `fk_daiktokodas` (`fk_daiktokodas`);

--
-- Indexes for table `veiklos_istorija`
--
ALTER TABLE `veiklos_istorija`
  ADD PRIMARY KEY (`id_Veiklos_istorija`),
  ADD KEY `fk_ISvartotojas` (`fk_ISvartotojas`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `daikto_kiekis_nuoma`
--
ALTER TABLE `daikto_kiekis_nuoma`
  MODIFY `id_Daikto_kiekis_nuoma` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `daikto_kiekis_pardavimas`
--
ALTER TABLE `daikto_kiekis_pardavimas`
  MODIFY `id_Daikto_kiekis_pardavimas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `is_vartotojas`
--
ALTER TABLE `is_vartotojas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `klientas`
--
ALTER TABLE `klientas`
  MODIFY `id_Klientas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `nuomos_sutartis`
--
ALTER TABLE `nuomos_sutartis`
  MODIFY `id_Nuomos_sutartis` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pardavimo_sutartis`
--
ALTER TABLE `pardavimo_sutartis`
  MODIFY `id_Pardavimo_sutartis` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sandelis`
--
ALTER TABLE `sandelis`
  MODIFY `id_Sandelis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `taisomasirenginys`
--
ALTER TABLE `taisomasirenginys`
  MODIFY `id_TaisomasIrenginys` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT for table `taisymas`
--
ALTER TABLE `taisymas`
  MODIFY `id_Taisymas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `uzsakymas`
--
ALTER TABLE `uzsakymas`
  MODIFY `id_Uzsakymas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `veiklos_istorija`
--
ALTER TABLE `veiklos_istorija`
  MODIFY `id_Veiklos_istorija` int(11) NOT NULL AUTO_INCREMENT;

--
-- Apribojimai eksportuotom lentelėm
--

--
-- Apribojimai lentelei `daiktas`
--
ALTER TABLE `daiktas`
  ADD CONSTRAINT `sandeliuojamas` FOREIGN KEY (`fk_Sandelisid`) REFERENCES `sandelis` (`id_Sandelis`);

--
-- Apribojimai lentelei `daikto_kiekis_nuoma`
--
ALTER TABLE `daikto_kiekis_nuoma`
  ADD CONSTRAINT `fkc_daikto_kiekis_nuoma_daiktas` FOREIGN KEY (`fk_Daiktaskodas`) REFERENCES `daiktas` (`kodas`),
  ADD CONSTRAINT `yra1` FOREIGN KEY (`fk_Nuomos_sutartisid`) REFERENCES `nuomos_sutartis` (`id_Nuomos_sutartis`);

--
-- Apribojimai lentelei `daikto_kiekis_pardavimas`
--
ALTER TABLE `daikto_kiekis_pardavimas`
  ADD CONSTRAINT `fkc_daikto_kiekis_pardavimas_daiktas` FOREIGN KEY (`fk_Daiktaskodas`) REFERENCES `daiktas` (`kodas`),
  ADD CONSTRAINT `yra2` FOREIGN KEY (`fk_Pardavimo_sutartisid`) REFERENCES `pardavimo_sutartis` (`id_Pardavimo_sutartis`);

--
-- Apribojimai lentelei `is_vartotojas`
--
ALTER TABLE `is_vartotojas`
  ADD CONSTRAINT `dirba` FOREIGN KEY (`fk_Sandelisid`) REFERENCES `sandelis` (`id_Sandelis`);

--
-- Apribojimai lentelei `nuomos_sutartis`
--
ALTER TABLE `nuomos_sutartis`
  ADD CONSTRAINT `sudaro1` FOREIGN KEY (`fk_ISVartotojas`) REFERENCES `is_vartotojas` (`id`),
  ADD CONSTRAINT `uzsako1` FOREIGN KEY (`fk_Klientasid`) REFERENCES `klientas` (`id_Klientas`);

--
-- Apribojimai lentelei `pardavimo_sutartis`
--
ALTER TABLE `pardavimo_sutartis`
  ADD CONSTRAINT `sudaro2` FOREIGN KEY (`fk_ISvartotojas`) REFERENCES `is_vartotojas` (`id`),
  ADD CONSTRAINT `uzsako2` FOREIGN KEY (`fk_Klientasid`) REFERENCES `klientas` (`id_Klientas`);

--
-- Apribojimai lentelei `taisomasirenginys`
--
ALTER TABLE `taisomasirenginys`
  ADD CONSTRAINT `taiso` FOREIGN KEY (`fk_Taisymasid`) REFERENCES `taisymas` (`id_Taisymas`);

--
-- Apribojimai lentelei `taisymas`
--
ALTER TABLE `taisymas`
  ADD CONSTRAINT `sukuria` FOREIGN KEY (`fk_ISVartotojas`) REFERENCES `is_vartotojas` (`id`),
  ADD CONSTRAINT `uzsako3` FOREIGN KEY (`fk_Klientasid`) REFERENCES `klientas` (`id_Klientas`);

--
-- Apribojimai lentelei `uzsakymas`
--
ALTER TABLE `uzsakymas`
  ADD CONSTRAINT `sudaro3` FOREIGN KEY (`fk_ISvartotojas`) REFERENCES `is_vartotojas` (`id`),
  ADD CONSTRAINT `uzsakytas` FOREIGN KEY (`fk_daiktokodas`) REFERENCES `daiktas` (`kodas`);

--
-- Apribojimai lentelei `veiklos_istorija`
--
ALTER TABLE `veiklos_istorija`
  ADD CONSTRAINT `veiklos_istorija_ibfk_1` FOREIGN KEY (`fk_ISvartotojas`) REFERENCES `is_vartotojas` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
