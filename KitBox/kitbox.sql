-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 06 mars 2018 à 19:43
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `kitbox`
--
CREATE DATABASE IF NOT EXISTS `kitbox` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `kitbox`;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `client_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `phonenum` varchar(30) NOT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `depth`
--

DROP TABLE IF EXISTS `depth`;
CREATE TABLE IF NOT EXISTS `depth` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `depth` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `depth`
--

INSERT INTO `depth` (`id`, `depth`) VALUES
(1, 32),
(2, 42),
(3, 52),
(4, 62);

-- --------------------------------------------------------

--
-- Structure de la table `floor`
--

DROP TABLE IF EXISTS `floor`;
CREATE TABLE IF NOT EXISTS `floor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `floor` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `floor`
--

INSERT INTO `floor` (`id`, `floor`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7);

-- --------------------------------------------------------

--
-- Structure de la table `heights`
--

DROP TABLE IF EXISTS `heights`;
CREATE TABLE IF NOT EXISTS `heights` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `heights` int(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `heights`
--

INSERT INTO `heights` (`id`, `heights`) VALUES
(1, 32),
(2, 42),
(3, 52);

-- --------------------------------------------------------

--
-- Structure de la table `width`
--

DROP TABLE IF EXISTS `width`;
CREATE TABLE IF NOT EXISTS `width` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `width` int(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `width`
--

INSERT INTO `width` (`id`, `width`) VALUES
(1, 32),
(2, 42),
(3, 52),
(4, 62),
(5, 80),
(6, 100),
(7, 120);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
