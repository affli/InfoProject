-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 21 mars 2018 à 11:31
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
-- Base de données :  `catalogue`
--

-- --------------------------------------------------------

--
-- Structure de la table `cornières`
--

DROP TABLE IF EXISTS `cornières`;
CREATE TABLE IF NOT EXISTS `cornières` (
  `PK_Cornières` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `cornières`
--

INSERT INTO `cornières` (`PK_Cornières`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Cornières', 'COR36BL', '1x32(h)', 36, 0, 0, 'White', 84, 32, 0.35, 4, 0.3, 3, 0.23, 9),
(2, 'Cornières', 'COR46BL', '1x42(h)', 46, 0, 0, 'White', 89, 32, 0.45, 4, 0.37, 12, 0.3, 9),
(3, 'Cornières', 'COR56BL', '1x52(h)', 56, 0, 0, 'White', 89, 32, 0.55, 4, 0.46, 3, 0.35, 9),
(4, 'Cornières', 'COR72BL', '2x32(h)', 72, 0, 0, 'White', 82, 32, 0.66, 4, 0.54, 12, 0.45, 18),
(5, 'Cornières', 'COR92BL', '2x42(h)', 92, 0, 0, 'White', 85, 32, 0.86, 4, 0.72, 6, 0.6, 18),
(6, 'Cornières', 'COR108BL', '3x32(h)', 108, 0, 0, 'White', 84, 32, 0.97, 4, 0.85, 7, 0.65, 13),
(7, 'Cornières', 'COR112BL', '2x52(h)', 112, 0, 0, 'White', 82, 32, 1.06, 4, 0.89, 12, 0.74, 13),
(8, 'Cornières', 'COR138BL', '3x42(h)', 138, 0, 0, 'White', 83, 32, 1.27, 4, 1.08, 11, 0.8, 14),
(9, 'Cornières', 'COR144BL', '4x32(h)', 144, 0, 0, 'White', 86, 32, 1.28, 4, 1.08, 3, 0.85, 14),
(10, 'Cornières', 'COR168BL', '3x52(h)', 168, 0, 0, 'White', 89, 32, 1.57, 4, 1.3, 5, 1.06, 12),
(11, 'Cornières', 'COR180BL', '5x32(h)', 180, 0, 0, 'White', 89, 32, 1.59, 4, 1.33, 7, 1.02, 9),
(12, 'Cornières', 'COR184BL', '4x42(h)', 184, 0, 0, 'White', 89, 32, 1.68, 4, 1.36, 3, 1.11, 16),
(13, 'Cornières', 'COR216BL', '6x32(h)', 216, 0, 0, 'White', 84, 32, 1.9, 4, 1.63, 10, 1.3, 14),
(14, 'Cornières', 'COR224BL', '4x52(h)', 224, 0, 0, 'White', 84, 32, 2.08, 4, 1.71, 7, 1.33, 10),
(15, 'Cornières', 'COR230BL', '5x42(h)', 230, 0, 0, 'White', 83, 32, 2.09, 4, 1.71, 4, 1.42, 15),
(16, 'Cornières', 'COR252BL', '7x32(h)', 252, 0, 0, 'White', 80, 32, 2.21, 4, 1.81, 9, 1.4, 17),
(17, 'Cornières', 'COR276BL', '6x42(h)', 276, 0, 0, 'White', 86, 32, 2.5, 4, 2.16, 7, 1.64, 14),
(18, 'Cornières', 'COR280BL', '5x52(h)', 280, 0, 0, 'White', 84, 32, 2.59, 4, 2.3, 10, 1.75, 10),
(19, 'Cornières', 'COR36BR', '1x32(h)', 36, 0, 0, 'Brown', 82, 32, 0.28, 4, 0.24, 6, 0.18, 16),
(20, 'Cornières', 'COR46BR', '1x42(h)', 46, 0, 0, 'Brown', 87, 32, 0.36, 4, 0.29, 4, 0.24, 9),
(21, 'Cornières', 'COR56BR', '1x52(h)', 56, 0, 0, 'Brown', 86, 32, 0.44, 4, 0.38, 9, 0.27, 13),
(22, 'Cornières', 'COR72BR', '2x32(h)', 72, 0, 0, 'Brown', 85, 32, 0.528, 4, 0.46, 12, 0.37, 12),
(23, 'Cornières', 'COR92BR', '2x42(h)', 92, 0, 0, 'Brown', 83, 32, 0.688, 4, 0.58, 12, 0.43, 8),
(24, 'Cornières', 'COR108BR', '3x32(h)', 108, 0, 0, 'Brown', 87, 32, 0.776, 4, 0.69, 7, 0.48, 11),
(25, 'Cornières', 'COR112BR', '2x52(h)', 112, 0, 0, 'Brown', 82, 32, 0.848, 4, 0.74, 5, 0.54, 11),
(26, 'Cornières', 'COR138BR', '3x42(h)', 138, 0, 0, 'Brown', 87, 32, 1.016, 4, 0.85, 12, 0.64, 15),
(27, 'Cornières', 'COR144BR', '4x32(h)', 144, 0, 0, 'Brown', 87, 32, 1.024, 4, 0.82, 11, 0.68, 13),
(28, 'Cornières', 'COR168BR', '3x52(h)', 168, 0, 0, 'Brown', 83, 32, 1.256, 4, 1.08, 4, 0.79, 16),
(29, 'Cornières', 'COR180BR', '5x32(h)', 180, 0, 0, 'Brown', 89, 32, 1.272, 4, 1.11, 11, 0.8, 9),
(30, 'Cornières', 'COR184BR', '4x42(h)', 184, 0, 0, 'Brown', 84, 32, 1.344, 4, 1.2, 5, 0.83, 17),
(31, 'Cornières', 'COR216BR', '6x32(h)', 216, 0, 0, 'Brown', 81, 32, 1.52, 4, 1.24, 11, 1.05, 8),
(32, 'Cornières', 'COR224BR', '4x52(h)', 224, 0, 0, 'Brown', 83, 32, 1.664, 4, 1.46, 9, 1.14, 11),
(33, 'Cornières', 'COR230BR', '5x42(h)', 230, 0, 0, 'Brown', 80, 32, 1.672, 4, 1.44, 6, 1.14, 13),
(34, 'Cornières', 'COR252BR', '7x32(h)', 252, 0, 0, 'Brown', 89, 32, 1.768, 4, 1.53, 10, 1.21, 17),
(35, 'Cornières', 'COR276BR', '6x42(h)', 276, 0, 0, 'Brown', 90, 32, 2, 4, 1.6, 13, 1.28, 13),
(36, 'Cornières', 'COR280BR', '5x52(h)', 280, 0, 0, 'Brown', 86, 32, 2.072, 4, 1.84, 10, 1.4, 11),
(37, 'Cornières', 'COR36GL', '1x32(h)', 36, 0, 0, 'Galvanized', 81, 32, 0.35, 4, 0.3, 7, 0.24, 14),
(38, 'Cornières', 'COR46GL', '1x42(h)', 46, 0, 0, 'Galvanized', 82, 32, 0.45, 4, 0.37, 10, 0.27, 14),
(39, 'Cornières', 'COR56GL', '1x52(h)', 56, 0, 0, 'Galvanized', 82, 32, 0.55, 4, 0.48, 8, 0.37, 15),
(40, 'Cornières', 'COR72GL', '2x32(h)', 72, 0, 0, 'Galvanized', 83, 32, 0.66, 4, 0.58, 4, 0.4, 13),
(41, 'Cornières', 'COR92GL', '2x42(h)', 92, 0, 0, 'Galvanized', 82, 32, 0.86, 4, 0.75, 5, 0.52, 12),
(42, 'Cornières', 'COR108GL', '3x32(h)', 108, 0, 0, 'Galvanized', 87, 32, 0.97, 4, 0.84, 6, 0.66, 14),
(43, 'Cornières', 'COR112GL', '2x52(h)', 112, 0, 0, 'Galvanized', 88, 32, 1.06, 4, 0.94, 8, 0.68, 14),
(44, 'Cornières', 'COR138GL', '3x42(h)', 138, 0, 0, 'Galvanized', 89, 32, 1.27, 4, 1.02, 6, 0.88, 11),
(45, 'Cornières', 'COR144GL', '4x32(h)', 144, 0, 0, 'Galvanized', 84, 32, 1.28, 4, 1.13, 12, 0.84, 9),
(46, 'Cornières', 'COR168GL', '3x52(h)', 168, 0, 0, 'Galvanized', 88, 32, 1.57, 4, 1.27, 11, 1.05, 15),
(47, 'Cornières', 'COR180GL', '5x32(h)', 180, 0, 0, 'Galvanized', 84, 32, 1.59, 4, 1.33, 9, 1.05, 9),
(48, 'Cornières', 'COR184GL', '4x42(h)', 184, 0, 0, 'Galvanized', 86, 32, 1.68, 4, 1.46, 11, 1.11, 17),
(49, 'Cornières', 'COR216GL', '6x32(h)', 216, 0, 0, 'Galvanized', 88, 32, 1.9, 4, 1.71, 10, 1.21, 13),
(50, 'Cornières', 'COR224GL', '4x52(h)', 224, 0, 0, 'Galvanized', 87, 32, 2.08, 4, 1.69, 4, 1.38, 16),
(51, 'Cornières', 'COR230GL', '5x42(h)', 230, 0, 0, 'Galvanized', 88, 32, 2.09, 4, 1.73, 9, 1.39, 15),
(52, 'Cornières', 'COR252GL', '7x32(h)', 252, 0, 0, 'Galvanized', 89, 32, 2.21, 4, 1.84, 3, 1.54, 13),
(53, 'Cornières', 'COR276GL', '6x42(h)', 276, 0, 0, 'Galvanized', 81, 32, 2.5, 4, 2.03, 7, 1.53, 17),
(54, 'Cornières', 'COR280GL', '5x52(h)', 280, 0, 0, 'Galvanized', 86, 32, 2.59, 4, 2.26, 13, 1.66, 15),
(55, 'Cornières', 'COR36NR', '1x32(h)', 36, 0, 0, 'Black', 84, 32, 0.245, 4, 0.21, 7, 0.15, 17),
(56, 'Cornières', 'COR46NR', '1x42(h)', 46, 0, 0, 'Black', 90, 32, 0.315, 4, 0.26, 9, 0.2, 11),
(57, 'Cornières', 'COR56NR', '1x52(h)', 56, 0, 0, 'Black', 89, 32, 0.385, 4, 0.34, 6, 0.27, 12),
(58, 'Cornières', 'COR72NR', '2x32(h)', 72, 0, 0, 'Black', 81, 32, 0.462, 4, 0.39, 13, 0.31, 13),
(59, 'Cornières', 'COR92NR', '2x42(h)', 92, 0, 0, 'Black', 87, 32, 0.602, 4, 0.51, 10, 0.38, 14),
(60, 'Cornières', 'COR108NR', '3x32(h)', 108, 0, 0, 'Black', 86, 32, 0.679, 4, 0.55, 13, 0.44, 15),
(61, 'Cornières', 'COR112NR', '2x52(h)', 112, 0, 0, 'Black', 89, 32, 0.742, 4, 0.62, 6, 0.45, 12),
(62, 'Cornières', 'COR138NR', '3x42(h)', 138, 0, 0, 'Black', 83, 32, 0.889, 4, 0.75, 11, 0.55, 13),
(63, 'Cornières', 'COR144NR', '4x32(h)', 144, 0, 0, 'Black', 88, 32, 0.896, 4, 0.8, 5, 0.62, 11),
(64, 'Cornières', 'COR168NR', '3x52(h)', 168, 0, 0, 'Black', 80, 32, 1.099, 4, 0.99, 11, 0.73, 16),
(65, 'Cornières', 'COR180NR', '5x32(h)', 180, 0, 0, 'Black', 83, 32, 1.113, 4, 0.94, 9, 0.7, 11),
(66, 'Cornières', 'COR184NR', '4x42(h)', 184, 0, 0, 'Black', 88, 32, 1.176, 4, 1.04, 6, 0.75, 17),
(67, 'Cornières', 'COR216NR', '6x32(h)', 216, 0, 0, 'Black', 80, 32, 1.33, 4, 1.17, 9, 0.92, 13),
(68, 'Cornières', 'COR224NR', '4x52(h)', 224, 0, 0, 'Black', 84, 32, 1.456, 4, 1.25, 6, 0.88, 13),
(69, 'Cornières', 'COR230NR', '5x42(h)', 230, 0, 0, 'Black', 83, 32, 1.463, 4, 1.28, 11, 0.96, 17),
(70, 'Cornières', 'COR252NR', '7x32(h)', 252, 0, 0, 'Black', 80, 32, 1.547, 4, 1.27, 9, 0.98, 16),
(71, 'Cornières', 'COR276NR', '6x42(h)', 276, 0, 0, 'Black', 83, 32, 1.75, 4, 1.52, 7, 1.18, 12),
(72, 'Cornières', 'COR280NR', '5x52(h)', 280, 0, 0, 'Black', 86, 32, 1.813, 4, 1.49, 8, 1.24, 15),
(73, 'Cornières', 'COR50BLDEC', '50(h)découpée', 50, 0, 0, 'White', 84, 32, 1.1, 4, 0.69, 3, 0.42, 9),
(74, 'Cornières', 'COR50BRDEC', '50(h)découpée', 50, 0, 0, 'Brown', 86, 32, 0.88, 4, 0.57, 9, 0.32, 13),
(75, 'Cornières', 'COR50GLDEC', '50(h)découpée', 50, 0, 0, 'Galvanized', 82, 32, 1.1, 4, 0.72, 8, 0.44, 15),
(76, 'Cornières', 'COR50NRDEC', '50(h)découpée', 50, 0, 0, 'Black', 82, 32, 0.77, 4, 0.51, 6, 0.32, 12),
(77, 'Cornières', 'COR75BLDEC', '75(h)découpée', 75, 0, 0, 'White', 89, 32, 1.32, 4, 0.81, 12, 0.54, 18),
(78, 'Cornières', 'COR75BRDEC', '75(h)découpée', 75, 0, 0, 'Brown', 83, 32, 1.06, 4, 0.69, 12, 0.44, 12),
(79, 'Cornières', 'COR75GLDEC', '75(h)découpée', 75, 0, 0, 'Galvanized', 84, 32, 1.32, 4, 0.87, 4, 0.48, 13),
(80, 'Cornières', 'COR75NRDEC', '75(h)découpée', 75, 0, 0, 'Black', 81, 32, 0.92, 4, 0.59, 13, 0.37, 13),
(81, 'Cornières', 'COR100BLDEC', '100(h)découpée', 100, 0, 0, 'White', 85, 32, 1.72, 4, 1.08, 6, 0.72, 18),
(82, 'Cornières', 'COR100BRDEC', '100(h)découpée', 100, 0, 0, 'Brown', 84, 32, 1.38, 4, 0.87, 12, 0.52, 8),
(83, 'Cornières', 'COR100GLDEC', '100(h)découpée', 100, 0, 0, 'Galvanized', 84, 32, 1.72, 4, 1.13, 5, 0.62, 12),
(84, 'Cornières', 'COR100NRDEC', '100(h)découpée', 100, 0, 0, 'Black', 87, 32, 1.2, 4, 0.77, 10, 0.46, 14),
(85, 'Cornières', 'COR125BLDEC', '125(h)découpée', 125, 0, 0, 'White', 83, 32, 1.94, 4, 1.28, 7, 0.78, 13),
(86, 'Cornières', 'COR125BRDEC', '125(h)découpée', 125, 0, 0, 'Brown', 84, 32, 1.55, 4, 1.04, 7, 0.58, 11),
(87, 'Cornières', 'COR125GLDEC', '125(h)découpée', 125, 0, 0, 'Galvanized', 83, 32, 1.94, 4, 1.26, 6, 0.79, 14),
(88, 'Cornières', 'COR125NRDEC', '125(h)découpée', 125, 0, 0, 'Black', 86, 32, 1.36, 4, 0.83, 13, 0.53, 15),
(89, 'Cornières', 'COR150BLDEC', '150(h)découpée', 150, 0, 0, 'White', 89, 32, 2.54, 4, 1.62, 11, 0.96, 14),
(90, 'Cornières', 'COR150BRDEC', '150(h)découpée', 150, 0, 0, 'Brown', 87, 32, 2.03, 4, 1.28, 12, 0.77, 15),
(91, 'Cornières', 'COR150GLDEC', '150(h)découpée', 150, 0, 0, 'Galvanized', 87, 32, 2.54, 4, 1.53, 6, 1.06, 11),
(92, 'Cornières', 'COR150NRDEC', '150(h)découpée', 150, 0, 0, 'Black', 87, 32, 1.78, 4, 1.13, 11, 0.66, 13),
(93, 'Cornières', 'COR175BLDEC', '175(h)découpée', 175, 0, 0, 'White', 81, 32, 3.14, 4, 1.95, 5, 1.27, 12),
(94, 'Cornières', 'COR175BRDEC', '175(h)découpée', 175, 0, 0, 'Brown', 83, 32, 2.51, 4, 1.62, 4, 0.95, 16),
(95, 'Cornières', 'COR175GLDEC', '175(h)découpée', 175, 0, 0, 'Galvanized', 86, 32, 3.14, 4, 1.91, 11, 1.26, 15),
(96, 'Cornières', 'COR175NRDEC', '175(h)découpée', 175, 0, 0, 'Black', 85, 32, 2.2, 4, 1.49, 11, 0.88, 16),
(97, 'Cornières', 'COR200BLDEC', '200(h)découpée', 200, 0, 0, 'White', 85, 32, 3.36, 4, 2.04, 3, 1.33, 16),
(98, 'Cornières', 'COR200BRDEC', '200(h)découpée', 200, 0, 0, 'Brown', 86, 32, 2.69, 4, 1.8, 5, 1, 17),
(99, 'Cornières', 'COR200GLDEC', '200(h)découpée', 200, 0, 0, 'Galvanized', 84, 32, 3.36, 4, 2.19, 11, 1.33, 17),
(100, 'Cornières', 'COR200NRDEC', '200(h)découpée', 200, 0, 0, 'Black', 90, 32, 2.35, 4, 1.56, 6, 0.9, 17),
(101, 'Cornières', 'COR225BLDEC', '225(h)découpée', 225, 0, 0, 'White', 88, 32, 3.8, 4, 2.45, 10, 1.56, 14),
(102, 'Cornières', 'COR225BRDEC', '225(h)découpée', 225, 0, 0, 'Brown', 86, 32, 3.04, 4, 1.86, 11, 1.26, 8),
(103, 'Cornières', 'COR225GLDEC', '225(h)découpée', 225, 0, 0, 'Galvanized', 86, 32, 3.8, 4, 2.57, 10, 1.45, 13),
(104, 'Cornières', 'COR225NRDEC', '225(h)découpée', 225, 0, 0, 'Black', 88, 32, 2.66, 4, 1.76, 9, 1.1, 13),
(105, 'Cornières', 'COR250BLDEC', '250(h)découpée', 250, 0, 0, 'White', 87, 32, 4.42, 4, 2.72, 9, 1.68, 17),
(106, 'Cornières', 'COR250BRDEC', '250(h)découpée', 250, 0, 0, 'Brown', 81, 32, 3.54, 4, 2.3, 10, 1.45, 17),
(107, 'Cornières', 'COR250GLDEC', '250(h)découpée', 250, 0, 0, 'Galvanized', 82, 32, 4.42, 4, 2.76, 3, 1.85, 13),
(108, 'Cornières', 'COR250NRDEC', '250(h)découpée', 250, 0, 0, 'Black', 86, 32, 3.09, 4, 1.91, 9, 1.18, 16),
(109, 'Cornières', 'COR275BLDEC', '275(h)découpée', 275, 0, 0, 'White', 82, 32, 5, 4, 3.24, 7, 1.97, 14),
(110, 'Cornières', 'COR275BRDEC', '275(h)découpée', 275, 0, 0, 'Brown', 82, 32, 4, 4, 2.4, 13, 1.54, 13),
(111, 'Cornières', 'COR275GLDEC', '275(h)découpée', 275, 0, 0, 'Galvanized', 87, 32, 5, 4, 3.05, 7, 1.84, 17),
(112, 'Cornières', 'COR275NRDEC', '275(h)découpée', 275, 0, 0, 'Black', 81, 32, 3.5, 4, 2.28, 7, 1.42, 12),
(113, 'Cornières', 'COR300BLDEC', '300(h)découpée', 300, 0, 0, 'White', 90, 32, 5.18, 4, 3.45, 10, 2.1, 10),
(114, 'Cornières', 'COR300BRDEC', '300(h)découpée', 300, 0, 0, 'Brown', 88, 32, 4.14, 4, 2.76, 10, 1.68, 11),
(115, 'Cornières', 'COR300GLDEC', '300(h)découpée', 300, 0, 0, 'Galvanized', 83, 32, 5.18, 4, 3.39, 13, 1.99, 15),
(116, 'Cornières', 'COR300NRDEC', '300(h)découpée', 300, 0, 0, 'Black', 84, 32, 3.63, 4, 2.24, 8, 1.49, 15),
(117, 'Cornières', 'COR325BLDEC', '325(h)découpée', 325, 0, 0, 'White', 86, 32, 5.18, 4, 3.45, 10, 2.1, 10),
(118, 'Cornières', 'COR325BRDEC', '325(h)découpée', 325, 0, 0, 'Brown', 88, 32, 4.14, 4, 2.76, 10, 1.68, 11),
(119, 'Cornières', 'COR325GLDEC', '325(h)découpée', 325, 0, 0, 'Galvanized', 90, 32, 5.18, 4, 3.39, 13, 1.99, 15),
(120, 'Cornières', 'COR325NRDEC', '325(h)découpée', 325, 0, 0, 'Black', 87, 32, 3.63, 4, 2.24, 8, 1.49, 15),
(121, 'Cornières', 'COR350BLDEC', '350(h)découpée', 350, 0, 0, 'White', 84, 32, 5.18, 4, 3.45, 10, 2.1, 10),
(122, 'Cornières', 'COR350BRDEC', '350(h)découpée', 350, 0, 0, 'Brown', 84, 32, 4.14, 4, 2.76, 10, 1.68, 11),
(123, 'Cornières', 'COR350GLDEC', '350(h)découpée', 350, 0, 0, 'Galvanized', 83, 32, 5.18, 4, 3.39, 13, 1.99, 15),
(124, 'Cornières', 'COR350NRDEC', '350(h)découpée', 350, 0, 0, 'Black', 85, 32, 3.63, 4, 2.24, 8, 1.49, 15),
(125, 'Cornières', 'COR375BLDEC', '375(h)découpée', 375, 0, 0, 'White', 82, 32, 5.18, 4, 3.45, 10, 2.1, 10),
(126, 'Cornières', 'COR375BRDEC', '375(h)découpée', 375, 0, 0, 'Brown', 81, 32, 4.14, 4, 2.76, 10, 1.68, 11),
(127, 'Cornières', 'COR375GLDEC', '375(h)découpée', 375, 0, 0, 'Galvanized', 86, 32, 5.18, 4, 3.39, 13, 1.99, 15),
(128, 'Cornières', 'COR375NRDEC', '375(h)découpée', 375, 0, 0, 'Black', 89, 32, 3.63, 4, 2.24, 8, 1.49, 15);

-- --------------------------------------------------------

--
-- Structure de la table `coupelles`
--

DROP TABLE IF EXISTS `coupelles`;
CREATE TABLE IF NOT EXISTS `coupelles` (
  `PK_Coupelles` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix-Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `coupelles`
--

INSERT INTO `coupelles` (`PK_Coupelles`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix-Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Coupelles', 'COUPEL', '6cmDiam', 0, 0, 0, NULL, 42, 16, 0.005, 2, 0.004, 13, 0.0035, 13);

-- --------------------------------------------------------

--
-- Structure de la table `panneau_ar`
--

DROP TABLE IF EXISTS `panneau_ar`;
CREATE TABLE IF NOT EXISTS `panneau_ar` (
  `PK_Panneau_Ar` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `panneau_ar`
--

INSERT INTO `panneau_ar` (`PK_Panneau_Ar`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Panneau Ar', 'PAR32100BL', '32(h)x100(L)', 32, 0, 100, 'White', 21, 8, 16, 1, 12.92, 13, 9.81, 14),
(2, 'Panneau Ar', 'PAR32120BL', '32(h)x120(L)', 32, 0, 120, 'White', 30, 8, 19.2, 1, 15.54, 6, 12.31, 10),
(3, 'Panneau Ar', 'PAR3232BL', '32(h)x32(L)', 32, 0, 32, 'White', 23, 8, 5.12, 1, 4.24, 10, 3.34, 14),
(4, 'Panneau Ar', 'PAR3242BL', '32(h)x42(L)', 32, 0, 42, 'White', 29, 8, 6.72, 1, 6, 7, 4.36, 13),
(5, 'Panneau Ar', 'PAR3252BL', '32(h)x52(L)', 32, 0, 52, 'White', 21, 8, 8.32, 1, 7.36, 7, 5.51, 14),
(6, 'Panneau Ar', 'PAR3262BL', '32(h)x62(L)', 32, 0, 62, 'White', 26, 8, 9.92, 1, 8.88, 12, 6.22, 17),
(7, 'Panneau Ar', 'PAR3280BL', '32(h)x80(L)', 32, 0, 80, 'White', 25, 8, 12.8, 1, 10.43, 10, 8.17, 12),
(8, 'Panneau Ar', 'PAR42100BL', '42(h)x100(L)', 42, 0, 100, 'White', 27, 8, 26, 1, 22.63, 6, 16.3, 11),
(9, 'Panneau Ar', 'PAR42120BL', '42(h)x120(L)', 42, 0, 120, 'White', 30, 8, 31.2, 1, 25.98, 7, 21.59, 16),
(10, 'Panneau Ar', 'PAR4232BL', '42(h)x32(L)', 42, 0, 32, 'White', 23, 8, 8.32, 1, 7.1, 10, 5.71, 14),
(11, 'Panneau Ar', 'PAR4242BL', '42(h)x42(L)', 42, 0, 42, 'White', 29, 8, 10.92, 1, 9.82, 4, 7.03, 9),
(12, 'Panneau Ar', 'PAR4252BL', '42(h)x52(L)', 42, 0, 52, 'White', 24, 8, 13.52, 1, 11.72, 7, 8.48, 13),
(13, 'Panneau Ar', 'PAR4262BL', '42(h)x62(L)', 42, 0, 62, 'White', 30, 8, 16.12, 1, 13.69, 6, 10.64, 17),
(14, 'Panneau Ar', 'PAR4280BL', '42(h)x80(L)', 42, 0, 80, 'White', 24, 8, 20.8, 1, 16.86, 6, 13.83, 8),
(15, 'Panneau Ar', 'PAR52100BL', '52(h)x100(L)', 52, 0, 100, 'White', 27, 8, 26, 1, 21.89, 9, 17.85, 9),
(16, 'Panneau Ar', 'PAR52120BL', '52(h)x120(L)', 52, 0, 120, 'White', 30, 8, 31.2, 1, 26.99, 6, 20.81, 18),
(17, 'Panneau Ar', 'PAR5232BL', '52(h)x32(L)', 52, 0, 32, 'White', 28, 8, 8.32, 1, 7.32, 5, 5.33, 17),
(18, 'Panneau Ar', 'PAR5242BL', '52(h)x42(L)', 52, 0, 42, 'White', 20, 8, 10.92, 1, 9.11, 9, 7.52, 16),
(19, 'Panneau Ar', 'PAR5252BL', '52(h)x52(L)', 52, 0, 52, 'White', 22, 8, 13.52, 1, 10.98, 9, 8.45, 14),
(20, 'Panneau Ar', 'PAR5262BL', '52(h)x62(L)', 52, 0, 62, 'White', 28, 8, 16.12, 1, 14.09, 11, 10.72, 15),
(21, 'Panneau Ar', 'PAR5280BL', '52(h)x80(L)', 52, 0, 80, 'White', 28, 8, 20.8, 1, 16.91, 13, 13.57, 18),
(22, 'Panneau Ar', 'PAR32100BR', '32(h)x100(L)', 32, 0, 100, 'Brown', 23, 8, 12.8, 1, 11.31, 11, 8.93, 11),
(23, 'Panneau Ar', 'PAR32120BR', '32(h)x120(L)', 32, 0, 120, 'Brown', 29, 8, 15.36, 1, 13.31, 5, 10.09, 17),
(24, 'Panneau Ar', 'PAR3232BR', '32(h)x32(L)', 32, 0, 32, 'Brown', 26, 8, 4.096, 1, 3.29, 7, 2.46, 16),
(25, 'Panneau Ar', 'PAR3242BR', '32(h)x42(L)', 32, 0, 42, 'Brown', 21, 8, 5.376, 1, 4.46, 8, 3.34, 13),
(26, 'Panneau Ar', 'PAR3252BR', '32(h)x52(L)', 32, 0, 52, 'Brown', 24, 8, 6.656, 1, 5.65, 4, 4.28, 10),
(27, 'Panneau Ar', 'PAR3262BR', '32(h)x62(L)', 32, 0, 62, 'Brown', 27, 8, 7.936, 1, 6.43, 7, 5.51, 8),
(28, 'Panneau Ar', 'PAR3280BR', '32(h)x80(L)', 32, 0, 80, 'Brown', 29, 8, 10.24, 1, 8.44, 3, 6.16, 11),
(29, 'Panneau Ar', 'PAR42100BR', '42(h)x100(L)', 42, 0, 100, 'Brown', 24, 8, 16.8, 1, 13.61, 13, 10.12, 15),
(30, 'Panneau Ar', 'PAR42120BR', '42(h)x120(L)', 42, 0, 120, 'Brown', 21, 8, 20.16, 1, 16.16, 10, 13.25, 10),
(31, 'Panneau Ar', 'PAR4232BR', '42(h)x32(L)', 42, 0, 32, 'Brown', 25, 8, 5.376, 1, 4.66, 13, 3.53, 17),
(32, 'Panneau Ar', 'PAR4242BR', '42(h)x42(L)', 42, 0, 42, 'Brown', 25, 8, 7.056, 1, 5.73, 10, 4.71, 15),
(33, 'Panneau Ar', 'PAR4252BR', '42(h)x52(L)', 42, 0, 52, 'Brown', 26, 8, 8.736, 1, 7.24, 10, 5.68, 11),
(34, 'Panneau Ar', 'PAR4262BR', '42(h)x62(L)', 42, 0, 62, 'Brown', 27, 8, 10.416, 1, 9.09, 5, 6.75, 17),
(35, 'Panneau Ar', 'PAR4280BR', '42(h)x80(L)', 42, 0, 80, 'Brown', 26, 8, 13.44, 1, 11.33, 4, 9.41, 17),
(36, 'Panneau Ar', 'PAR52100BR', '52(h)x100(L)', 52, 0, 100, 'Brown', 23, 8, 20.8, 1, 17.2, 7, 14.07, 13),
(37, 'Panneau Ar', 'PAR52120BR', '52(h)x120(L)', 52, 0, 120, 'Brown', 24, 8, 24.96, 1, 19.98, 9, 16.12, 10),
(38, 'Panneau Ar', 'PAR5232BR', '52(h)x32(L)', 52, 0, 32, 'Brown', 22, 8, 6.656, 1, 5.99, 9, 4.11, 10),
(39, 'Panneau Ar', 'PAR5242BR', '52(h)x42(L)', 52, 0, 42, 'Brown', 20, 8, 8.736, 1, 7.48, 5, 5.64, 14),
(40, 'Panneau Ar', 'PAR5252BR', '52(h)x52(L)', 52, 0, 52, 'Brown', 24, 8, 10.816, 1, 9.26, 8, 6.66, 10),
(41, 'Panneau Ar', 'PAR5262BR', '52(h)x62(L)', 52, 0, 62, 'Brown', 28, 8, 12.896, 1, 10.67, 8, 8.46, 15),
(42, 'Panneau Ar', 'PAR5280BR', '52(h)x80(L)', 52, 0, 80, 'Brown', 28, 8, 16.64, 1, 14.23, 13, 10.31, 17);

-- --------------------------------------------------------

--
-- Structure de la table `panneau_gd`
--

DROP TABLE IF EXISTS `panneau_gd`;
CREATE TABLE IF NOT EXISTS `panneau_gd` (
  `PK_Panneau_GD` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `panneau_gd`
--

INSERT INTO `panneau_gd` (`PK_Panneau_GD`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Panneau GD', 'PAG3232BL', '32(h)x32(p)', 32, 32, 0, 'White', 45, 16, 5.12, 2, 4.53, 13, 3.43, 12),
(2, 'Panneau GD', 'PAG3242BL', '32(h)x42(p)', 32, 42, 0, 'White', 50, 16, 6.72, 2, 5.82, 10, 4.12, 12),
(3, 'Panneau GD', 'PAG3252BL', '32(h)x52(p)', 32, 52, 0, 'White', 41, 16, 8.32, 2, 6.9, 7, 5.62, 10),
(4, 'Panneau GD', 'PAG3262BL', '32(h)x62(p)', 32, 62, 0, 'White', 49, 16, 9.92, 2, 8.31, 5, 6.31, 10),
(5, 'Panneau GD', 'PAG4232BL', '42(h)x32(p)', 42, 32, 0, 'White', 49, 16, 6.72, 2, 5.46, 11, 4.3, 9),
(6, 'Panneau GD', 'PAG4242BL', '42(h)x42(p)', 42, 42, 0, 'White', 43, 16, 8.82, 2, 7.65, 6, 5.79, 14),
(7, 'Panneau GD', 'PAG4252BL', '42(h)x52(p)', 42, 52, 0, 'White', 45, 16, 10.92, 2, 9.16, 5, 7.09, 10),
(8, 'Panneau GD', 'PAG4262BL', '42(h)x62(p)', 42, 62, 0, 'White', 43, 16, 13.02, 2, 10.93, 7, 9.06, 17),
(9, 'Panneau GD', 'PAG5232BL', '52(h)x32(p)', 52, 32, 0, 'White', 50, 16, 8.32, 2, 6.83, 9, 5.71, 11),
(10, 'Panneau GD', 'PAG5242BL', '52(h)x42(p)', 52, 42, 0, 'White', 47, 16, 10.92, 2, 9.32, 9, 7.05, 12),
(11, 'Panneau GD', 'PAG5252BL', '52(h)x52(p)', 52, 52, 0, 'White', 47, 16, 13.52, 2, 11.51, 6, 9.44, 9),
(12, 'Panneau GD', 'PAG5262BL', '52(h)x62(p)', 52, 62, 0, 'White', 48, 16, 16.12, 2, 14.35, 12, 10.43, 17),
(13, 'Panneau GD', 'PAG3232BR', '32(h)x32(p)', 32, 32, 0, 'Brown', 44, 16, 4.096, 2, 3.6, 9, 2.52, 17),
(14, 'Panneau GD', 'PAG3242BR', '32(h)x42(p)', 32, 42, 0, 'Brown', 48, 16, 5.376, 2, 4.47, 6, 3.28, 10),
(15, 'Panneau GD', 'PAG3252BR', '32(h)x52(p)', 32, 52, 0, 'Brown', 42, 16, 6.656, 2, 5.49, 7, 4.25, 11),
(16, 'Panneau GD', 'PAG3262BR', '32(h)x62(p)', 32, 62, 0, 'Brown', 41, 16, 7.936, 2, 6.49, 13, 4.9, 9),
(17, 'Panneau GD', 'PAG4232BR', '42(h)x32(p)', 42, 32, 0, 'Brown', 41, 16, 5.376, 2, 4.42, 9, 3.58, 15),
(18, 'Panneau GD', 'PAG4242BR', '42(h)x42(p)', 42, 42, 0, 'Brown', 43, 16, 7.056, 2, 6.2, 9, 4.84, 8),
(19, 'Panneau GD', 'PAG4252BR', '42(h)x52(p)', 42, 52, 0, 'Brown', 47, 16, 8.736, 2, 7.05, 8, 5.98, 14),
(20, 'Panneau GD', 'PAG4262BR', '42(h)x62(p)', 42, 62, 0, 'Brown', 45, 16, 10.416, 2, 9.29, 4, 6.91, 15),
(21, 'Panneau GD', 'PAG5232BR', '52(h)x32(p)', 52, 32, 0, 'Brown', 47, 16, 6.656, 2, 5.39, 5, 4.62, 14),
(22, 'Panneau GD', 'PAG5242BR', '52(h)x42(p)', 52, 42, 0, 'Brown', 49, 16, 8.736, 2, 7.36, 3, 5.55, 16),
(23, 'Panneau GD', 'PAG5252BR', '52(h)x52(p)', 52, 52, 0, 'Brown', 47, 16, 10.816, 2, 8.81, 11, 7.27, 9),
(24, 'Panneau GD', 'PAG5262BR', '52(h)x62(p)', 52, 62, 0, 'Brown', 44, 16, 12.896, 2, 11, 11, 8.75, 13);

-- --------------------------------------------------------

--
-- Structure de la table `panneau_hb`
--

DROP TABLE IF EXISTS `panneau_hb`;
CREATE TABLE IF NOT EXISTS `panneau_hb` (
  `PK_Panneau_HB` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `panneau_hb`
--

INSERT INTO `panneau_hb` (`PK_Panneau_HB`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Panneau HB', 'PAH32100BL', '32(p)x100(L)', 0, 32, 100, 'White', 49, 16, 16, 2, 12.97, 6, 11.07, 15),
(2, 'Panneau HB', 'PAH32120BL', '32(p)x120(L)', 0, 32, 120, 'White', 47, 16, 19.2, 2, 16.99, 6, 12.39, 11),
(3, 'Panneau HB', 'PAH3232BL', '32(p)x32(L)', 0, 32, 32, 'White', 50, 16, 5.12, 2, 4.31, 7, 3.33, 14),
(4, 'Panneau HB', 'PAH3242BL', '32(p)x42(L)', 0, 32, 42, 'White', 42, 16, 6.72, 2, 5.41, 4, 4.33, 17),
(5, 'Panneau HB', 'PAH3252BL', '32(p)x52(L)', 0, 32, 52, 'White', 41, 16, 8.32, 2, 6.66, 11, 5.31, 17),
(6, 'Panneau HB', 'PAH3262BL', '32(p)x62(L)', 0, 32, 62, 'White', 44, 16, 9.92, 2, 8.49, 8, 6.31, 14),
(7, 'Panneau HB', 'PAH3280BL', '32(p)x80(L)', 0, 32, 80, 'White', 48, 16, 12.8, 2, 10.73, 11, 8.22, 13),
(8, 'Panneau HB', 'PAH42100BL', '42(p)x100(L)', 0, 42, 100, 'White', 46, 16, 21, 2, 17.7, 6, 14.3, 10),
(9, 'Panneau HB', 'PAH42120BL', '42(p)x120(L)', 0, 42, 120, 'White', 41, 16, 25.2, 2, 22.21, 13, 16.22, 10),
(10, 'Panneau HB', 'PAH4232BL', '42(p)x32(L)', 0, 42, 32, 'White', 43, 16, 6.72, 2, 5.71, 3, 4.55, 17),
(11, 'Panneau HB', 'PAH4242BL', '42(p)x42(L)', 0, 42, 42, 'White', 40, 16, 8.82, 2, 7.33, 4, 5.95, 18),
(12, 'Panneau HB', 'PAH4252BL', '42(p)x52(L)', 0, 42, 52, 'White', 46, 16, 10.92, 2, 9.72, 7, 6.95, 13),
(13, 'Panneau HB', 'PAH4262BL', '42(p)x62(L)', 0, 42, 62, 'White', 45, 16, 13.02, 2, 10.91, 11, 8.55, 10),
(14, 'Panneau HB', 'PAH4280BL', '42(p)x80(L)', 0, 42, 80, 'White', 50, 16, 16.8, 2, 13.6, 7, 11.46, 12),
(15, 'Panneau HB', 'PAH52100BL', '52(p)x100(L)', 0, 52, 100, 'White', 49, 16, 26, 2, 23.33, 4, 18.15, 15),
(16, 'Panneau HB', 'PAH52120BL', '52(p)x120(L)', 0, 52, 120, 'White', 49, 16, 31.2, 2, 28, 6, 20.47, 16),
(17, 'Panneau HB', 'PAH5232BL', '52(p)x32(L)', 0, 52, 32, 'White', 45, 16, 8.32, 2, 7.25, 5, 5.06, 8),
(18, 'Panneau HB', 'PAH5242BL', '52(p)x42(L)', 0, 52, 42, 'White', 44, 16, 10.92, 2, 9.46, 12, 7.32, 12),
(19, 'Panneau HB', 'PAH5252BL', '52(p)x52(L)', 0, 52, 52, 'White', 42, 16, 13.52, 2, 11.25, 8, 8.46, 14),
(20, 'Panneau HB', 'PAH5262BL', '52(p)x62(L)', 0, 52, 62, 'White', 46, 16, 16.12, 2, 13.65, 12, 11.02, 12),
(21, 'Panneau HB', 'PAH5280BL', '52(p)x80(L)', 0, 52, 80, 'White', 41, 16, 20.8, 2, 17.55, 7, 12.67, 12),
(22, 'Panneau HB', 'PAH62100BL', '62(p)x100(L)', 0, 62, 100, 'White', 44, 16, 31, 2, 26.08, 4, 20.87, 16),
(23, 'Panneau HB', 'PAH62120BL', '62(p)x120(L)', 0, 62, 120, 'White', 43, 16, 37.2, 2, 33.13, 6, 25.73, 17),
(24, 'Panneau HB', 'PAH6232BL', '62(p)x32(L)', 0, 62, 32, 'White', 44, 16, 9.92, 2, 8.92, 11, 6.76, 14),
(25, 'Panneau HB', 'PAH6242BL', '62(p)x42(L)', 0, 62, 42, 'White', 44, 16, 13.02, 2, 11.02, 6, 8.38, 17),
(26, 'Panneau HB', 'PAH6252BL', '62(p)x52(L)', 0, 62, 52, 'White', 44, 16, 16.12, 2, 14.1, 6, 9.68, 12),
(27, 'Panneau HB', 'PAH6262BL', '62(p)x62(L)', 0, 62, 62, 'White', 46, 16, 19.22, 2, 15.86, 12, 12.92, 14),
(28, 'Panneau HB', 'PAH6280BL', '62(p)x80(L)', 0, 62, 80, 'White', 48, 16, 24.8, 2, 22.2, 5, 15.1, 10),
(29, 'Panneau HB', 'PAH32100BR', '32(p)x100(L)', 0, 32, 100, 'Brown', 42, 16, 12.8, 2, 11.29, 10, 7.77, 9),
(30, 'Panneau HB', 'PAH32120BR', '32(p)x120(L)', 0, 32, 120, 'Brown', 50, 16, 15.36, 2, 13.3, 9, 10.73, 14),
(31, 'Panneau HB', 'PAH3232BR', '32(p)x32(L)', 0, 32, 32, 'Brown', 41, 16, 4.096, 2, 3.34, 9, 2.64, 14),
(32, 'Panneau HB', 'PAH3242BR', '32(p)x42(L)', 0, 32, 42, 'Brown', 46, 16, 5.376, 2, 4.3, 7, 3.61, 16),
(33, 'Panneau HB', 'PAH3252BR', '32(p)x52(L)', 0, 32, 52, 'Brown', 48, 16, 6.656, 2, 5.67, 11, 4.51, 15),
(34, 'Panneau HB', 'PAH3262BR', '32(p)x62(L)', 0, 32, 62, 'Brown', 44, 16, 7.936, 2, 6.92, 4, 4.94, 11),
(35, 'Panneau HB', 'PAH3280BR', '32(p)x80(L)', 0, 32, 80, 'Brown', 48, 16, 10.24, 2, 8.6, 8, 6.2, 17),
(36, 'Panneau HB', 'PAH42100BR', '42(p)x100(L)', 0, 42, 100, 'Brown', 43, 16, 16.8, 2, 15.01, 4, 10.23, 8),
(37, 'Panneau HB', 'PAH42120BR', '42(p)x120(L)', 0, 42, 120, 'Brown', 45, 16, 20.16, 2, 17.65, 8, 12.4, 15),
(38, 'Panneau HB', 'PAH4232BR', '42(p)x32(L)', 0, 42, 32, 'Brown', 43, 16, 5.376, 2, 4.41, 10, 3.34, 9),
(39, 'Panneau HB', 'PAH4242BR', '42(p)x42(L)', 0, 42, 42, 'Brown', 44, 16, 7.056, 2, 5.92, 9, 4.7, 11),
(40, 'Panneau HB', 'PAH4252BR', '42(p)x52(L)', 0, 42, 52, 'Brown', 46, 16, 8.736, 2, 7.07, 5, 5.87, 16),
(41, 'Panneau HB', 'PAH4262BR', '42(p)x62(L)', 0, 42, 62, 'Brown', 48, 16, 10.416, 2, 9.28, 6, 7.11, 16),
(42, 'Panneau HB', 'PAH4280BR', '42(p)x80(L)', 0, 42, 80, 'Brown', 45, 16, 13.44, 2, 11.02, 12, 8.22, 10),
(43, 'Panneau HB', 'PAH52100BR', '52(p)x100(L)', 0, 52, 100, 'Brown', 42, 16, 20.8, 2, 17.94, 12, 14.2, 14),
(44, 'Panneau HB', 'PAH52120BR', '52(p)x120(L)', 0, 52, 120, 'Brown', 49, 16, 24.96, 2, 20.67, 6, 16.37, 8),
(45, 'Panneau HB', 'PAH5232BR', '52(p)x32(L)', 0, 52, 32, 'Brown', 42, 16, 6.656, 2, 5.44, 8, 4.12, 10),
(46, 'Panneau HB', 'PAH5242BR', '52(p)x42(L)', 0, 52, 42, 'Brown', 45, 16, 8.736, 2, 7.03, 7, 5.48, 15),
(47, 'Panneau HB', 'PAH5252BR', '52(p)x52(L)', 0, 52, 52, 'Brown', 43, 16, 10.816, 2, 9.67, 12, 6.51, 14),
(48, 'Panneau HB', 'PAH5262BR', '52(p)x62(L)', 0, 52, 62, 'Brown', 42, 16, 12.896, 2, 10.83, 6, 8.75, 17),
(49, 'Panneau HB', 'PAH5280BR', '52(p)x80(L)', 0, 52, 80, 'Brown', 48, 16, 16.64, 2, 14.27, 7, 10.38, 9),
(50, 'Panneau HB', 'PAH62100BR', '62(p)x100(L)', 0, 62, 100, 'Brown', 50, 16, 24.8, 2, 21.16, 12, 15.11, 17),
(51, 'Panneau HB', 'PAH62120BR', '62(p)x120(L)', 0, 62, 120, 'Brown', 45, 16, 29.76, 2, 26.55, 12, 18.22, 9),
(52, 'Panneau HB', 'PAH6232BR', '62(p)x32(L)', 0, 62, 32, 'Brown', 48, 16, 7.936, 2, 6.52, 5, 5.12, 17),
(53, 'Panneau HB', 'PAH6242BR', '62(p)x42(L)', 0, 62, 42, 'Brown', 40, 16, 10.416, 2, 9.12, 11, 6.39, 16),
(54, 'Panneau HB', 'PAH6252BR', '62(p)x52(L)', 0, 62, 52, 'Brown', 45, 16, 12.896, 2, 11.56, 10, 8.04, 10),
(55, 'Panneau HB', 'PAH6262BR', '62(p)x62(L)', 0, 62, 62, 'Brown', 45, 16, 15.376, 2, 13.41, 7, 10.41, 12),
(56, 'Panneau HB', 'PAH6280BR', '62(p)x80(L)', 0, 62, 80, 'Brown', 50, 16, 19.84, 2, 17.8, 7, 12.21, 18);

-- --------------------------------------------------------

--
-- Structure de la table `porte`
--

DROP TABLE IF EXISTS `porte`;
CREATE TABLE IF NOT EXISTS `porte` (
  `PK_Porte` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `porte`
--

INSERT INTO `porte` (`PK_Porte`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Porte ', 'POR3232BL', '32(h)x32(L)', 32, 0, 32, 'White', 41, 16, 5.12, 2, 4.31, 7, 3.14, 8),
(2, 'Porte ', 'POR3242BL', '32(h)x42(L)', 32, 0, 42, 'White', 42, 16, 6.72, 2, 5.6, 10, 4.35, 14),
(3, 'Porte ', 'POR3252BL', '32(h)x52(L)', 32, 0, 52, 'White', 46, 16, 8.32, 2, 6.82, 12, 5.53, 13),
(4, 'Porte ', 'POR3262BL', '32(h)x62(L)', 32, 0, 62, 'White', 42, 16, 9.92, 2, 7.95, 12, 6.88, 14),
(5, 'Porte ', 'POR4232BL', '42(h)x32(L)', 42, 0, 32, 'White', 47, 16, 6.72, 2, 5.69, 6, 4.2, 17),
(6, 'Porte ', 'POR4242BL', '42(h)x42(L)', 42, 0, 42, 'White', 44, 16, 8.82, 2, 7.23, 6, 5.84, 13),
(7, 'Porte ', 'POR4252BL', '42(h)x52(L)', 42, 0, 52, 'White', 43, 16, 10.92, 2, 9.56, 10, 6.67, 10),
(8, 'Porte ', 'POR4262BL', '42(h)x62(L)', 42, 0, 62, 'White', 49, 16, 13.02, 2, 11.16, 5, 8.23, 11),
(9, 'Porte ', 'POR5232BL', '52(h)x32(L)', 52, 0, 32, 'White', 47, 16, 8.32, 2, 7.25, 7, 5.23, 16),
(10, 'Porte ', 'POR5242BL', '52(h)x42(L)', 52, 0, 42, 'White', 41, 16, 10.92, 2, 9.12, 12, 6.96, 14),
(11, 'Porte ', 'POR5252BL', '52(h)x52(L)', 52, 0, 52, 'White', 49, 16, 13.52, 2, 11.01, 11, 8.29, 10),
(12, 'Porte ', 'POR5262BL', '52(h)x62(L)', 52, 0, 62, 'White', 40, 16, 16.12, 2, 13.86, 4, 10.95, 13),
(13, 'Porte ', 'POR3232BR', '32(h)x32(L)', 32, 0, 32, 'Brown', 46, 16, 5.12, 2, 4.14, 4, 3.45, 8),
(14, 'Porte ', 'POR3242BR', '32(h)x42(L)', 32, 0, 42, 'Brown', 42, 16, 6.72, 2, 5.98, 7, 4.68, 13),
(15, 'Porte ', 'POR3252BR', '32(h)x52(L)', 32, 0, 52, 'Brown', 47, 16, 8.32, 2, 7.31, 5, 5.4, 14),
(16, 'Porte ', 'POR3262BR', '32(h)x62(L)', 32, 0, 62, 'Brown', 40, 16, 9.92, 2, 8.4, 7, 5.97, 17),
(17, 'Porte ', 'POR4232BR', '42(h)x32(L)', 42, 0, 32, 'Brown', 46, 16, 6.72, 2, 5.96, 11, 4.43, 11),
(18, 'Porte ', 'POR4242BR', '42(h)x42(L)', 42, 0, 42, 'Brown', 43, 16, 8.82, 2, 7.41, 12, 5.75, 15),
(19, 'Porte ', 'POR4252BR', '42(h)x52(L)', 42, 0, 52, 'Brown', 46, 16, 10.92, 2, 9.76, 4, 7.15, 12),
(20, 'Porte ', 'POR4262BR', '42(h)x62(L)', 42, 0, 62, 'Brown', 49, 16, 13.02, 2, 11.54, 5, 7.83, 17),
(21, 'Porte ', 'POR5232BR', '52(h)x32(L)', 52, 0, 32, 'Brown', 43, 16, 8.32, 2, 7.15, 11, 5.24, 13),
(22, 'Porte ', 'POR5242BR', '52(h)x42(L)', 52, 0, 42, 'Brown', 45, 16, 10.92, 2, 8.76, 3, 6.97, 10),
(23, 'Porte ', 'POR5252BR', '52(h)x52(L)', 52, 0, 52, 'Brown', 42, 16, 13.52, 2, 11.66, 6, 8.43, 12),
(24, 'Porte ', 'POR5262BR', '52(h)x62(L)', 52, 0, 62, 'Brown', 46, 16, 32.24, 2, 25.99, 11, 21.36, 10),
(25, 'Porte ', 'POR3232VE', '32(h)x32(L)', 32, 0, 32, 'Glass', 46, 16, 10.24, 2, 8.79, 11, 6.3, 16),
(26, 'Porte ', 'POR3242VE', '32(h)x42(L)', 32, 0, 42, 'Glass', 50, 16, 13.44, 2, 11.23, 5, 9, 14),
(27, 'Porte ', 'POR3252VE', '32(h)x52(L)', 32, 0, 52, 'Glass', 42, 16, 16.64, 2, 13.48, 11, 11.53, 15),
(28, 'Porte ', 'POR3262VE', '32(h)x62(L)', 32, 0, 62, 'Glass', 40, 16, 19.84, 2, 17.74, 6, 13.05, 10),
(29, 'Porte ', 'POR4232VE', '42(h)x32(L)', 42, 0, 32, 'Glass', 43, 16, 13.44, 2, 11.57, 10, 8.72, 18),
(30, 'Porte ', 'POR4242VE', '42(h)x42(L)', 42, 0, 42, 'Glass', 45, 16, 17.64, 2, 15.27, 10, 10.7, 15),
(31, 'Porte ', 'POR4252VE', '42(h)x52(L)', 42, 0, 52, 'Glass', 45, 16, 21.84, 2, 19.47, 5, 14.89, 15),
(32, 'Porte ', 'POR4262VE', '42(h)x62(L)', 42, 0, 62, 'Glass', 48, 16, 26.04, 2, 20.85, 9, 18.22, 15),
(33, 'Porte ', 'POR5232VE', '52(h)x32(L)', 52, 0, 32, 'Glass', 46, 16, 16.64, 2, 13.7, 13, 11.12, 9),
(34, 'Porte ', 'POR5242VE', '52(h)x42(L)', 52, 0, 42, 'Glass', 44, 16, 21.84, 2, 18.81, 12, 14.55, 15),
(35, 'Porte ', 'POR5252VE', '52(h)x52(L)', 52, 0, 52, 'Glass', 47, 16, 27.04, 2, 23.04, 12, 17.02, 11),
(36, 'Porte ', 'POR5262VE', '52(h)x62(L)', 52, 0, 62, 'Glass', 46, 16, 32.24, 2, 27.45, 8, 20.61, 17);

-- --------------------------------------------------------

--
-- Structure de la table `tasseau`
--

DROP TABLE IF EXISTS `tasseau`;
CREATE TABLE IF NOT EXISTS `tasseau` (
  `PK_Tasseau` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `tasseau`
--

INSERT INTO `tasseau` (`PK_Tasseau`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Tasseau', 'TAS27', '27(h32)', 32, 0, 0, NULL, 83, 32, 0.2, 4, 0.17, 10, 0.13, 14),
(2, 'Tasseau', 'TAS37', '37(h42)', 42, 0, 0, NULL, 84, 32, 0.3, 4, 0.25, 4, 0.19, 8),
(3, 'Tasseau', 'TAS47', '47(h52)', 52, 0, 0, NULL, 88, 32, 0.4, 4, 0.34, 10, 0.24, 10);

-- --------------------------------------------------------

--
-- Structure de la table `traverse_ar`
--

DROP TABLE IF EXISTS `traverse_ar`;
CREATE TABLE IF NOT EXISTS `traverse_ar` (
  `PK_Traverse_Ar` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `traverse_ar`
--

INSERT INTO `traverse_ar` (`PK_Traverse_Ar`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Traverse Ar', 'TRR100', '100(L)', 0, 0, 100, NULL, 49, 16, 2, 2, 1.67, 10, 1.26, 10),
(2, 'Traverse Ar', 'TRR120', '120(L)', 0, 0, 120, NULL, 49, 16, 2.2, 2, 1.88, 4, 1.38, 10),
(3, 'Traverse Ar', 'TRR32', '32(L)', 0, 0, 32, NULL, 41, 16, 1, 2, 0.89, 8, 0.69, 10),
(4, 'Traverse Ar', 'TRR42', '42(L)', 0, 0, 42, NULL, 44, 16, 1.2, 2, 0.98, 10, 0.75, 10),
(5, 'Traverse Ar', 'TRR52', '52(L)', 0, 0, 52, NULL, 44, 16, 1.4, 2, 1.2, 6, 0.94, 10),
(6, 'Traverse Ar', 'TRR62', '62(L)', 0, 0, 62, NULL, 44, 16, 1.6, 2, 1.35, 12, 1.11, 10),
(7, 'Traverse Ar', 'TRR80', '80(L)', 0, 0, 80, NULL, 45, 16, 1.8, 2, 1.52, 3, 1.16, 11);

-- --------------------------------------------------------

--
-- Structure de la table `traverse_av`
--

DROP TABLE IF EXISTS `traverse_av`;
CREATE TABLE IF NOT EXISTS `traverse_av` (
  `PK_Traverse_Av` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `traverse_av`
--

INSERT INTO `traverse_av` (`PK_Traverse_Av`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Traverse Av', 'TRF100', '100(L)', 0, 0, 100, NULL, 48, 16, 2.2, 2, 1.93, 5, 1.48, 12),
(2, 'Traverse Av', 'TRF120', '120(L)', 0, 0, 120, NULL, 42, 16, 2.4, 2, 1.98, 5, 1.63, 8),
(3, 'Traverse Av', 'TRF32', '32(L)', 0, 0, 32, NULL, 45, 16, 1.5, 2, 1.32, 8, 1.05, 16),
(4, 'Traverse Av', 'TRF42', '42(L)', 0, 0, 42, NULL, 43, 16, 1.7, 2, 1.49, 8, 1.17, 14),
(5, 'Traverse Av', 'TRF52', '52(L)', 0, 0, 52, NULL, 44, 16, 1.8, 2, 1.53, 6, 1.2, 9),
(6, 'Traverse Av', 'TRF62', '62(L)', 0, 0, 62, NULL, 42, 16, 1.9, 2, 1.63, 8, 1.28, 16),
(7, 'Traverse Av', 'TRF80', '80(L)', 0, 0, 80, NULL, 44, 16, 2, 2, 1.61, 4, 1.21, 12);

-- --------------------------------------------------------

--
-- Structure de la table `traverse_gd`
--

DROP TABLE IF EXISTS `traverse_gd`;
CREATE TABLE IF NOT EXISTS `traverse_gd` (
  `PK_Traverse_GD` int(11) DEFAULT NULL,
  `Réf` varchar(255) DEFAULT NULL,
  `Code` varchar(255) DEFAULT NULL,
  `Dimensions(cm)` varchar(255) DEFAULT NULL,
  `hauteur` double DEFAULT NULL,
  `profondeur` double DEFAULT NULL,
  `largeur` double DEFAULT NULL,
  `Couleur` varchar(255) DEFAULT NULL,
  `Enstock` double DEFAULT NULL,
  `Stock minimum` double DEFAULT NULL,
  `Prix_Client` double DEFAULT NULL,
  `Nb-Pièces/casier` double DEFAULT NULL,
  `Prix-Fourn 1` double DEFAULT NULL,
  `Delai-Fourn 1` double DEFAULT NULL,
  `Prix-Fourn2` double DEFAULT NULL,
  `Delai-Fourn2` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `traverse_gd`
--

INSERT INTO `traverse_gd` (`PK_Traverse_GD`, `Réf`, `Code`, `Dimensions(cm)`, `hauteur`, `profondeur`, `largeur`, `Couleur`, `Enstock`, `Stock minimum`, `Prix_Client`, `Nb-Pièces/casier`, `Prix-Fourn 1`, `Delai-Fourn 1`, `Prix-Fourn2`, `Delai-Fourn2`) VALUES
(1, 'Traverse GD', 'TRG32', '32(p)', 0, 32, 0, NULL, 82, 32, 1, 4, 0.9, 9, 0.63, 11),
(2, 'Traverse GD', 'TRG42', '42(p)', 0, 42, 0, NULL, 83, 32, 1.2, 4, 1.01, 4, 0.76, 17),
(3, 'Traverse GD', 'TRG52', '52(p)', 0, 52, 0, NULL, 82, 32, 1.4, 4, 1.21, 12, 0.85, 14),
(4, 'Traverse GD', 'TRG62', '62(p)', 0, 62, 0, NULL, 82, 32, 1.6, 4, 1.43, 8, 0.98, 12);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
