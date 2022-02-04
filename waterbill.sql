-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2021 at 09:26 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `waterbill`
--
CREATE DATABASE IF NOT EXISTS `waterbill` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `waterbill`;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Username` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Username`, `Password`) VALUES
('admin', 'admin'),
('user', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `billNo` varchar(15) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(15) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`billNo`, `name`, `email`, `address`) VALUES
('0001', 'ABC', '21,Akuregoda Ro', 'ABC@gmail.com'),
('0002', 'Dilshan', '25,Baddagana RD', 'dilshan@gmail.com'),
('0003', 'Jhon', 'GoodShed , Kand', 'jhon@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `customer_bill`
--

CREATE TABLE `customer_bill` (
  `billNo` varchar(15) NOT NULL,
  `year` int(5) NOT NULL,
  `month` varchar(15) NOT NULL,
  `units_consumed` int(10) NOT NULL,
  `charge` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_bill`
--

INSERT INTO `customer_bill` (`billNo`, `year`, `month`, `units_consumed`, `charge`) VALUES
('0001', 2021, 'February', 5, 0),
('0001', 2021, 'January', 10, 0),
('0001', 2021, 'March', 78, 0),
('0001', 2021, 'May', 21, 0),
('0002', 2021, 'February', 10, 0),
('0002', 2021, 'January', 15, 0),
('0002', 2021, 'March', 31, 0),
('0002', 2021, 'May', 34, 0),
('0003', 2021, 'February', 12, 0),
('0003', 2021, 'January', 20, 0),
('0003', 2021, 'March', 32, 0),
('0003', 2021, 'May', 22, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`billNo`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `customer_bill`
--
ALTER TABLE `customer_bill`
  ADD PRIMARY KEY (`billNo`,`month`,`year`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customer_bill`
--
ALTER TABLE `customer_bill`
  ADD CONSTRAINT `customer_bill_ibfk_1` FOREIGN KEY (`billNo`) REFERENCES `customer` (`billNo`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
