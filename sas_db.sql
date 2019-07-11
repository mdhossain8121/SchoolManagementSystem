-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 27, 2019 at 02:10 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `sas_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance_tbl`
--

CREATE TABLE IF NOT EXISTS `attendance_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DATE` date NOT NULL,
  `STATUS` char(1) NOT NULL DEFAULT 'P',
  `STUDENT_ID` int(11) NOT NULL,
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `class_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `class_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CLASS_NAME` varchar(50) NOT NULL DEFAULT '0',
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `class_setup_tbl`
--

INSERT INTO `class_setup_tbl` (`ID`, `CLASS_NAME`, `CRT_BY`, `CRT_DATE`, `UPD_BY`, `UPD_DATE`) VALUES
(1, 'One', 0, '2019-06-18 11:54:31', 0, '2019-06-18 11:54:31'),
(2, 'Two', 0, '2019-06-18 11:54:40', 0, '2019-06-18 11:54:40'),
(3, 'Three', 0, '2019-06-18 11:54:43', 0, '2019-06-18 11:54:43'),
(4, 'Four', 0, '2019-06-18 11:55:25', 0, '2019-06-18 11:55:25'),
(5, 'Five', 0, '2019-06-18 11:55:29', 0, '2019-06-18 11:55:29'),
(6, 'Six', 0, '2019-06-18 11:55:32', 0, '2019-06-18 11:55:32'),
(7, 'Nine', 0, '2019-06-19 12:32:45', 0, '2019-06-19 12:32:45'),
(8, 'Ten', 0, '2019-06-19 12:32:49', 0, '2019-06-19 12:32:49');

-- --------------------------------------------------------

--
-- Table structure for table `class_wise_section_tbl`
--

CREATE TABLE IF NOT EXISTS `class_wise_section_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CLASS_ID` int(11) NOT NULL,
  `SECTION_ID` int(11) NOT NULL,
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CLASS_ID_SECTION_ID` (`CLASS_ID`,`SECTION_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `class_wise_section_tbl`
--

INSERT INTO `class_wise_section_tbl` (`ID`, `CLASS_ID`, `SECTION_ID`, `ACTIVE_STATUS`) VALUES
(1, 1, 1, 1),
(2, 1, 2, 1),
(3, 1, 3, 1),
(4, 2, 2, 1),
(5, 2, 3, 1),
(6, 3, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `class_wise_subject_tbl`
--

CREATE TABLE IF NOT EXISTS `class_wise_subject_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CLASS_ID` int(11) NOT NULL,
  `SUBJECT_ID` int(11) NOT NULL,
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CLASS_ID_SUBJECT_ID` (`CLASS_ID`,`SUBJECT_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `class_wise_subject_tbl`
--

INSERT INTO `class_wise_subject_tbl` (`ID`, `CLASS_ID`, `SUBJECT_ID`, `ACTIVE_STATUS`) VALUES
(1, 1, 1, 1),
(2, 1, 3, 1),
(3, 2, 3, 1),
(4, 1, 4, 1),
(5, 6, 5, 1),
(6, 6, 1, 1),
(7, 6, 3, 1),
(8, 3, 3, 1),
(9, 5, 5, 1),
(10, 1, 9, 0),
(11, 1, 5, 1),
(12, 3, 4, 1);

-- --------------------------------------------------------

--
-- Table structure for table `exam_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `exam_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(50) NOT NULL,
  `STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `result_tbl`
--

CREATE TABLE IF NOT EXISTS `result_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EXAM_ID` int(11) NOT NULL,
  `STUDENT_ID` int(11) NOT NULL,
  `SECTION_ID` int(11) NOT NULL,
  `CLASSID` int(11) NOT NULL,
  `TOTAL_MARKS` int(11) NOT NULL,
  `MARKS` int(11) NOT NULL,
  `SUBJECT_ID` int(11) NOT NULL,
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `role_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `role_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ROLE_NAME` varchar(50) NOT NULL,
  `DESCRIPTION` varchar(50) DEFAULT NULL,
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `role_setup_tbl`
--

INSERT INTO `role_setup_tbl` (`ID`, `ROLE_NAME`, `DESCRIPTION`, `ACTIVE_STATUS`, `CRT_BY`, `CRT_DATE`, `UPD_BY`, `UPD_DATE`) VALUES
(1, 'Admin', 'admin', 1, 0, '2019-06-26 10:45:21', 0, '2019-06-26 10:45:21'),
(2, 'User', 'user', 1, 0, '2019-06-26 10:51:47', 0, '2019-06-26 10:51:47');

-- --------------------------------------------------------

--
-- Table structure for table `section_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `section_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SECTION_NAME` varchar(100) NOT NULL,
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `section_setup_tbl`
--

INSERT INTO `section_setup_tbl` (`ID`, `SECTION_NAME`, `ACTIVE_STATUS`, `CRT_BY`, `CRT_DATE`, `UPD_BY`, `UPD_DATE`) VALUES
(1, 'Section-A', 1, 0, '2019-06-20 17:17:57', 0, '2019-06-20 17:17:57'),
(2, 'Section-B', 1, 0, '2019-06-23 12:25:47', 0, '2019-06-23 12:25:47'),
(3, 'Section-C', 1, 0, '2019-06-23 12:25:52', 0, '2019-06-23 12:25:52'),
(4, 'Section-D', 1, 0, '2019-06-23 12:25:56', 0, '2019-06-23 12:25:56'),
(5, 'Section-E', 1, 0, '2019-06-23 12:26:00', 0, '2019-06-23 12:26:00');

-- --------------------------------------------------------

--
-- Table structure for table `section_wise_student_tbl`
--

CREATE TABLE IF NOT EXISTS `section_wise_student_tbl` (
  `SECTION_ID` int(11) NOT NULL,
  `STUDENT_ID` int(11) NOT NULL,
  PRIMARY KEY (`SECTION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `setup_child_tbl`
--

CREATE TABLE IF NOT EXISTS `setup_child_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SETUPMASTERID` int(11) NOT NULL,
  `VALUE` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `setup_master_tbl`
--

CREATE TABLE IF NOT EXISTS `setup_master_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(50) NOT NULL,
  `STATUS` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `student_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `student_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `STUNAME` varchar(150) NOT NULL,
  `MOBILE` varchar(150) NOT NULL,
  `PRESENTADDRESS` varchar(250) NOT NULL,
  `PERMANENTADDRESS` varchar(250) NOT NULL,
  `STARTDATE` datetime NOT NULL,
  `ENDDATE` datetime NOT NULL,
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `subject_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `subject_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SUBJECT_NAME` varchar(150) NOT NULL,
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `ATTRIBUTE` int(1) NOT NULL DEFAULT '1' COMMENT '0 = OPTIONAL, 1 = COMPULSORY',
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `subject_setup_tbl`
--

INSERT INTO `subject_setup_tbl` (`ID`, `SUBJECT_NAME`, `CRT_BY`, `ATTRIBUTE`, `ACTIVE_STATUS`, `CRT_DATE`, `UPD_BY`, `UPD_DATE`) VALUES
(1, 'yyyyyyy', 0, 0, 0, '2019-06-15 15:24:29', 0, '2019-06-15 15:24:29'),
(3, 'Math', 0, 1, 1, '2019-06-15 15:24:42', 0, '2019-06-15 15:24:42'),
(4, 'Bnagla', 0, 1, 1, '2019-06-19 12:30:30', 0, '2019-06-19 12:30:30'),
(5, 'Computer', 0, 1, 1, '2019-06-19 12:30:33', 0, '2019-06-19 12:30:33'),
(6, 'Higher Math', 0, 1, 1, '2019-06-19 12:30:54', 0, '2019-06-19 12:30:54'),
(7, 'Chemistry', 0, 1, 1, '2019-06-19 12:31:08', 0, '2019-06-19 12:31:08'),
(8, 'Physics', 0, 1, 1, '2019-06-19 12:31:15', 0, '2019-06-19 12:31:15'),
(9, 'Biology', 0, 1, 1, '2019-06-19 12:31:18', 0, '2019-06-19 12:31:18'),
(10, 'Agriculture', 0, 1, 1, '2019-06-19 17:56:25', 0, '2019-06-19 17:56:25'),
(11, 'Garostho', 0, 0, 1, '2019-06-19 18:08:04', 0, '2019-06-19 18:08:04'),
(12, 'ddddddd', 0, 0, 1, '2019-06-19 18:14:34', 0, '2019-06-19 18:14:34'),
(13, 'Religion', 0, 1, 1, '2019-06-26 14:55:33', 0, '2019-06-26 14:55:33');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_setup_tbl`
--

CREATE TABLE IF NOT EXISTS `teacher_setup_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TEACHER_NAME` varchar(150) NOT NULL,
  `MOBILE` varchar(150) NOT NULL,
  `PRESENTADDRESS` varchar(250) NOT NULL,
  `PERMANENTADDRESS` varchar(250) NOT NULL,
  `JOINING_DATE` datetime NOT NULL,
  `END_DATE` datetime NOT NULL,
  `STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user_tbl`
--

CREATE TABLE IF NOT EXISTS `user_tbl` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `USER_NAME` varchar(50) NOT NULL,
  `PASSWORD` varchar(200) NOT NULL,
  `ROLE_ID` int(11) NOT NULL,
  `ACTIVE_STATUS` int(1) NOT NULL DEFAULT '1' COMMENT '0 = INACTIVE, 1 = ACTIVE',
  `CRT_BY` int(11) NOT NULL COMMENT 'USER ID',
  `CRT_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UPD_BY` int(11) NOT NULL COMMENT 'USER ID',
  `UPD_DATE` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `USER_NAME` (`USER_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
