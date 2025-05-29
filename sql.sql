-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2023-06-15 04:28:40
-- 伺服器版本： 10.4.28-MariaDB
-- PHP 版本： 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `集貨樂章`
--

-- --------------------------------------------------------

--
-- 資料表結構 `訂單資料表`
--

CREATE TABLE `訂單資料表` (
  `C_ID` varchar(5) DEFAULT NULL,
  `O_ID` varchar(20) NOT NULL,
  `D_ID` varchar(20) DEFAULT NULL,
  `O_name` char(10) DEFAULT NULL,
  `O_weight` decimal(10,1) DEFAULT NULL,
  `O_remark` varchar(30) DEFAULT NULL,
  `O_in` tinyint(1) DEFAULT NULL,
  `O_intime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `訂單資料表`
--

INSERT INTO `訂單資料表` (`C_ID`, `O_ID`, `D_ID`, `O_name`, `O_weight`, `O_remark`, `O_in`, `O_intime`) VALUES
('F9160', 'DL0293847373F', NULL, '衛生紙', 1.6, '', 1, '2023-06-15 04:50:12'),
('F9160', 'HE643872094583W', 'I1803', '冬季外套', 0.7, '衣服', 1, '2023-06-15 04:03:36'),
('F9160', 'HG483058496311L', NULL, '水壺', 0.0, '', 0, NULL),
('F9160', 'HG938473627384Q', NULL, '安全帽', 0.0, '', 0, NULL),
('F9160', 'HT096748953276P', 'I1803', '手機殼', 0.3, '', 1, '2023-06-15 03:59:41'),
('F9160', 'KJ764385093761O', NULL, '襪子', 1.1, '可愛的襪子', 1, '2023-06-15 03:41:07');

-- --------------------------------------------------------

--
-- 資料表結構 `集貨資料表`
--

CREATE TABLE `集貨資料表` (
  `C_ID` varchar(5) DEFAULT NULL,
  `D_ID` varchar(20) NOT NULL,
  `D_weight` float DEFAULT NULL,
  `PAY` varchar(3) DEFAULT NULL,
  `Fare` int(8) DEFAULT NULL,
  `D_car` varchar(10) DEFAULT NULL,
  `Employee_ID` varchar(10) DEFAULT NULL,
  `bank_num1` int(3) NOT NULL,
  `bank_num2` int(5) NOT NULL,
  `D_method` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `集貨資料表`
--

INSERT INTO `集貨資料表` (`C_ID`, `D_ID`, `D_weight`, `PAY`, `Fare`, `D_car`, `Employee_ID`, `bank_num1`, `bank_num2`, `D_method`) VALUES
('F9160', 'D4704', 3.5, '未付款', 280, 'XXAAA', 'AA111', 700, 88888, 1),
('F9160', 'F8480', 2.7, '已付款', 223, 'XXCCC', 'CC333', 700, 56544, 1),
('F9160', 'I1803', 1, '已付款', 92, 'XXBBB', 'BB222', 333, 33333, 0),
('F9160', 'T1977', 1.6, '未付款', 112, 'XXBBB', 'BB222', 333, 65655, 0);

-- --------------------------------------------------------

--
-- 資料表結構 `顧客資料表`
--

CREATE TABLE `顧客資料表` (
  `C_ID` char(5) NOT NULL,
  `C_name` varchar(4) DEFAULT NULL,
  `C_pd` varchar(12) DEFAULT NULL,
  `C_phone` varchar(10) DEFAULT NULL,
  `C_Address` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `顧客資料表`
--

INSERT INTO `顧客資料表` (`C_ID`, `C_name`, `C_pd`, `C_phone`, `C_Address`) VALUES
('F9160', '陳英禎', 'jc920615', '0912169529', '嘉義市西區民生南路87號'),
('J3277', '王大明', 'a12345', '0918277171', '臺北市中正區青島東路18號'),
('N6325', '莊又諠', 'wq1234', '0928372615', '臺中市西屯區環中路15號'),
('P1131', '陳怡虹', 'a12345', '0928374000', '嘉義市西區新民路100號');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `訂單資料表`
--
ALTER TABLE `訂單資料表`
  ADD PRIMARY KEY (`O_ID`),
  ADD KEY `C_ID` (`C_ID`),
  ADD KEY `O_ID` (`O_ID`),
  ADD KEY `D_ID` (`D_ID`);

--
-- 資料表索引 `集貨資料表`
--
ALTER TABLE `集貨資料表`
  ADD PRIMARY KEY (`D_ID`),
  ADD KEY `C_ID` (`C_ID`),
  ADD KEY `D_ID` (`D_ID`);

--
-- 資料表索引 `顧客資料表`
--
ALTER TABLE `顧客資料表`
  ADD PRIMARY KEY (`C_ID`),
  ADD KEY `C_ID` (`C_ID`);

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `訂單資料表`
--
ALTER TABLE `訂單資料表`
  ADD CONSTRAINT `訂單資料表_ibfk_1` FOREIGN KEY (`C_ID`) REFERENCES `顧客資料表` (`C_ID`),
  ADD CONSTRAINT `訂單資料表_ibfk_2` FOREIGN KEY (`D_ID`) REFERENCES `集貨資料表` (`D_ID`);

--
-- 資料表的限制式 `集貨資料表`
--
ALTER TABLE `集貨資料表`
  ADD CONSTRAINT `集貨資料表_ibfk_1` FOREIGN KEY (`C_ID`) REFERENCES `顧客資料表` (`C_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
