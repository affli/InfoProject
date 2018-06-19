-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 19 juin 2018 à 12:01
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
) ENGINE=MyISAM AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`client_id`, `name`, `email`, `phonenum`) VALUES
(42, '', '', ''),
(41, '', '', '');

-- --------------------------------------------------------

--
-- Structure de la table `command`
--

DROP TABLE IF EXISTS `command`;
CREATE TABLE IF NOT EXISTS `command` (
  `command_id` int(11) NOT NULL AUTO_INCREMENT,
  `cleat` int(11) NOT NULL,
  `classicdoor` int(11) NOT NULL,
  `glassdoor` int(11) NOT NULL,
  `panel` int(11) NOT NULL,
  `rails` int(11) NOT NULL,
  `supportangle` int(11) NOT NULL,
  PRIMARY KEY (`command_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `command`
--

INSERT INTO `command` (`command_id`, `cleat`, `classicdoor`, `glassdoor`, `panel`, `rails`, `supportangle`) VALUES
(2, 14, 24, 78, 47, 568, 65),
(4, 17, 45, 65, 58, 47, 58),
(5, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `orders`
--

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `command_id` int(11) NOT NULL AUTO_INCREMENT,
  `cleat` int(11) NOT NULL,
  `classicdoor` int(11) NOT NULL,
  `glassdoor` int(11) NOT NULL,
  `Panel_HB` int(11) NOT NULL,
  `Panel_GD` int(11) NOT NULL,
  `Panel_AR` int(11) NOT NULL,
  `Rails_Front` int(11) NOT NULL,
  `Rails_Back` int(11) NOT NULL,
  `Rails_Lateral` int(11) NOT NULL,
  `supportangle` int(11) NOT NULL,
  PRIMARY KEY (`command_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `orders`
--

INSERT INTO `orders` (`command_id`, `cleat`, `classicdoor`, `glassdoor`, `Panel_HB`, `Panel_GD`, `Panel_AR`, `Rails_Front`, `Rails_Back`, `Rails_Lateral`, `supportangle`) VALUES
(1, 12, 6, 0, 6, 6, 3, 6, 6, 12, 4);

-- --------------------------------------------------------

--
-- Structure de la table `provider`
--

DROP TABLE IF EXISTS `provider`;
CREATE TABLE IF NOT EXISTS `provider` (
  `provider_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) CHARACTER SET utf8 NOT NULL,
  `adress` varchar(80) CHARACTER SET utf8 NOT NULL,
  `website` varchar(40) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`provider_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `provider`
--

INSERT INTO `provider` (`provider_id`, `name`, `adress`, `website`) VALUES
(13, 'zfze', 'zfz', 'zefze'),
(11, 'ezfz', 'ezzz', 'fzef');

-- --------------------------------------------------------

--
-- Structure de la table `stock`
--

DROP TABLE IF EXISTS `stock`;
CREATE TABLE IF NOT EXISTS `stock` (
  `stock_id` int(11) NOT NULL AUTO_INCREMENT,
  `stuff` varchar(40) CHARACTER SET utf8 NOT NULL,
  `color` varchar(10) CHARACTER SET utf8 NOT NULL,
  `height` int(10) NOT NULL,
  `width` int(10) NOT NULL,
  PRIMARY KEY (`stock_id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `stock`
--

INSERT INTO `stock` (`stock_id`, `stuff`, `color`, `height`, `width`) VALUES
(13, '', 'zfze', 42, 424),
(15, 'Door', '3', 3, 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
