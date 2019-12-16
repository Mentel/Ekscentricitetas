-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 2019 m. Grd 16 d. 11:47
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

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

DROP TABLE IF EXISTS `daiktas`;
CREATE TABLE IF NOT EXISTS `daiktas` (
  `pavadinimas` varchar(255) NOT NULL,
  `aprasymas` varchar(255) NOT NULL,
  `kodas` int(11) NOT NULL,
  `kaina` double NOT NULL,
  `parduodamas` tinyint(1) NOT NULL,
  `kiekis` int(11) NOT NULL,
  `bukle` varchar(255) NOT NULL,
  `pagaminimo_data` date NOT NULL,
  `fk_Sandelisid` int(11) NOT NULL,
  PRIMARY KEY (`kodas`),
  KEY `sandeliuojamas` (`fk_Sandelisid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `daikto_kiekis_nuoma`
--

DROP TABLE IF EXISTS `daikto_kiekis_nuoma`;
CREATE TABLE IF NOT EXISTS `daikto_kiekis_nuoma` (
  `kiekis` int(11) NOT NULL,
  `id_Daikto_kiekis_nuoma` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Nuomos_sutartisid` int(11) NOT NULL,
  `fk_Daiktaskodas` int(11) NOT NULL,
  PRIMARY KEY (`id_Daikto_kiekis_nuoma`),
  KEY `yra1` (`fk_Nuomos_sutartisid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `daikto_kiekis_pardavimas`
--

DROP TABLE IF EXISTS `daikto_kiekis_pardavimas`;
CREATE TABLE IF NOT EXISTS `daikto_kiekis_pardavimas` (
  `kiekis` int(11) NOT NULL,
  `id_Daikto_kiekis_pardavimas` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Pardavimo_sutartisid` int(11) NOT NULL,
  `fk_Daiktaskodas` int(11) NOT NULL,
  PRIMARY KEY (`id_Daikto_kiekis_pardavimas`),
  KEY `yra2` (`fk_Pardavimo_sutartisid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `is_vartotojas`
--

DROP TABLE IF EXISTS `is_vartotojas`;
CREATE TABLE IF NOT EXISTS `is_vartotojas` (
  `vardas` varchar(255) NOT NULL,
  `pavarde` varchar(255) NOT NULL,
  `gimimo_data` date NOT NULL,
  `el_pastas` varchar(255) NOT NULL,
  `adresas` varchar(255) NOT NULL,
  `slapyvardis` varchar(255) NOT NULL,
  `slaptazodis` varchar(255) NOT NULL,
  `dirba_nuo` date NOT NULL,
  `darbo_valandos` varchar(255) NOT NULL,
  `alga` double NOT NULL,
  `parduotuves_adresas` varchar(255) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Sandelisid` int(11) DEFAULT NULL,
  `typeSelector` char(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `dirba` (`fk_Sandelisid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `klientas`
--

DROP TABLE IF EXISTS `klientas`;
CREATE TABLE IF NOT EXISTS `klientas` (
  `vardas` varchar(255) NOT NULL,
  `pavarde` varchar(255) NOT NULL,
  `el_pastas` varchar(255) DEFAULT NULL,
  `telefono_nr` varchar(255) DEFAULT NULL,
  `adresas` varchar(255) NOT NULL,
  `pasto_kodas` varchar(255) NOT NULL,
  `id_Klientas` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_Klientas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `nuomos_sutartis`
--

DROP TABLE IF EXISTS `nuomos_sutartis`;
CREATE TABLE IF NOT EXISTS `nuomos_sutartis` (
  `sudarymo_data` date NOT NULL,
  `grazinimo_data` date DEFAULT NULL,
  `kaina` double NOT NULL,
  `pastabos` varchar(255) DEFAULT NULL,
  `id_Nuomos_sutartis` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISVartotojas` int(11) NOT NULL,
  PRIMARY KEY (`id_Nuomos_sutartis`),
  KEY `uzsako1` (`fk_Klientasid`),
  KEY `sudaro1` (`fk_ISVartotojas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `pardavimo_sutartis`
--

DROP TABLE IF EXISTS `pardavimo_sutartis`;
CREATE TABLE IF NOT EXISTS `pardavimo_sutartis` (
  `sudarymo_data` date NOT NULL,
  `kaina` double NOT NULL,
  `id_Pardavimo_sutartis` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISvartotojas` int(11) NOT NULL,
  PRIMARY KEY (`id_Pardavimo_sutartis`),
  KEY `uzsako2` (`fk_Klientasid`),
  KEY `sudaro2` (`fk_ISvartotojas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `sandelis`
--

DROP TABLE IF EXISTS `sandelis`;
CREATE TABLE IF NOT EXISTS `sandelis` (
  `adresas` varchar(255) NOT NULL,
  `pasto_kodas` varchar(255) NOT NULL,
  `plotas` double NOT NULL,
  `telefono_nr` varchar(255) NOT NULL,
  `el_pastas` varchar(255) NOT NULL,
  `id_Sandelis` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_Sandelis`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

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

DROP TABLE IF EXISTS `taisomasirenginys`;
CREATE TABLE IF NOT EXISTS `taisomasirenginys` (
  `pavadinimas` varchar(255) DEFAULT NULL,
  `kodas` int(11) DEFAULT NULL,
  `komentaras` varchar(255) DEFAULT NULL,
  `id_TaisomasIrenginys` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Taisymasid` int(11) NOT NULL,
  PRIMARY KEY (`id_TaisomasIrenginys`),
  KEY `taiso` (`fk_Taisymasid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `taisymas`
--

DROP TABLE IF EXISTS `taisymas`;
CREATE TABLE IF NOT EXISTS `taisymas` (
  `palikimo_data` date NOT NULL,
  `kaina` int(11) NOT NULL,
  `gedimas` int(11) NOT NULL,
  `busena` char(17) NOT NULL,
  `id_Taisymas` int(11) NOT NULL AUTO_INCREMENT,
  `fk_Klientasid` int(11) NOT NULL,
  `fk_ISVartotojas` int(11) NOT NULL,
  PRIMARY KEY (`id_Taisymas`),
  KEY `uzsako3` (`fk_Klientasid`),
  KEY `sukuria` (`fk_ISVartotojas`)
) ;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `uzsakymas`
--

DROP TABLE IF EXISTS `uzsakymas`;
CREATE TABLE IF NOT EXISTS `uzsakymas` (
  `sukurimo_data` date NOT NULL,
  `altiktas` tinyint(1) NOT NULL DEFAULT 0,
  `altikimo_data` date DEFAULT NULL,
  `kiekis` int(11) NOT NULL,
  `id_Uzsakymas` int(11) NOT NULL AUTO_INCREMENT,
  `fk_ISvartotojas` int(11) NOT NULL,
  PRIMARY KEY (`id_Uzsakymas`),
  KEY `sudaro3` (`fk_ISvartotojas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `uzsakymo_daiktas`
--

DROP TABLE IF EXISTS `uzsakymo_daiktas`;
CREATE TABLE IF NOT EXISTS `uzsakymo_daiktas` (
  `fk_Daikto_kodas` int(11) NOT NULL,
  `fk_Uzsakymoid` int(11) NOT NULL,
  PRIMARY KEY (`fk_Daikto_kodas`,`fk_Uzsakymoid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Sukurta duomenų struktūra lentelei `veiklos_istorija`
--

DROP TABLE IF EXISTS `veiklos_istorija`;
CREATE TABLE IF NOT EXISTS `veiklos_istorija` (
  `data` date NOT NULL,
  `veiksmas` varchar(255) NOT NULL,
  `id_Veiklos_istorija` int(11) NOT NULL AUTO_INCREMENT,
  `fk_ISvartotojas` int(11) NOT NULL,
  PRIMARY KEY (`id_Veiklos_istorija`),
  KEY `fk_ISvartotojas` (`fk_ISvartotojas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  ADD CONSTRAINT `yra1` FOREIGN KEY (`fk_Nuomos_sutartisid`) REFERENCES `nuomos_sutartis` (`id_Nuomos_sutartis`);

--
-- Apribojimai lentelei `daikto_kiekis_pardavimas`
--
ALTER TABLE `daikto_kiekis_pardavimas`
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
  ADD CONSTRAINT `sudaro3` FOREIGN KEY (`fk_ISvartotojas`) REFERENCES `is_vartotojas` (`id`);

--
-- Apribojimai lentelei `uzsakymo_daiktas`
--
ALTER TABLE `uzsakymo_daiktas`
  ADD CONSTRAINT `yra3` FOREIGN KEY (`fk_Daikto_kodas`) REFERENCES `daiktas` (`kodas`);

--
-- Apribojimai lentelei `veiklos_istorija`
--
ALTER TABLE `veiklos_istorija`
  ADD CONSTRAINT `veiklos_istorija_ibfk_1` FOREIGN KEY (`fk_ISvartotojas`) REFERENCES `is_vartotojas` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
