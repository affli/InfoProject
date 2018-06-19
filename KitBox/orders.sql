-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mar 19 Juin 2018 à 11:56
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
-- Structure de la table `orders`
--

CREATE TABLE `orders` (
  `command_id` int(11) NOT NULL,
  `cleat` int(11) NOT NULL,
  `classicdoor` int(11) NOT NULL,
  `glassdoor` int(11) NOT NULL,
  `Panel_HB` int(11) NOT NULL,
  `Panel_GD` int(11) NOT NULL,
  `Panel_AR` int(11) NOT NULL,
  `Rails_Front` int(11) NOT NULL,
  `Rails_Back` int(11) NOT NULL,
  `Rails_Lateral` int(11) NOT NULL,
  `supportangle` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `orders`
--

INSERT INTO `orders` (`command_id`, `cleat`, `classicdoor`, `glassdoor`, `Panel_HB`, `Panel_GD`, `Panel_AR`, `Rails_Front`, `Rails_Back`, `Rails_Lateral`, `supportangle`) VALUES
(1, 12, 6, 0, 6, 6, 3, 6, 6, 12, 4);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`command_id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `orders`
--
ALTER TABLE `orders`
  MODIFY `command_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
