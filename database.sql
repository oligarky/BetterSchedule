-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: courseschedule
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `course_schedule`
--

DROP TABLE IF EXISTS `course_schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `course_schedule` (
  `Title` varchar(255) NOT NULL,
  `Subject Description` varchar(255) NOT NULL,
  `Course` int NOT NULL,
  `Section` int NOT NULL,
  `Hours` int NOT NULL,
  `CRN` int NOT NULL,
  `Term` varchar(255) NOT NULL,
  `Instructor` varchar(255) NOT NULL,
  `Meeting Day` text NOT NULL,
  `Meeting Time Start` time NOT NULL,
  `Meeting Time End` time NOT NULL,
  `Building` text NOT NULL,
  `Room` varchar(255) NOT NULL,
  `Campus` text NOT NULL,
  `Status` text NOT NULL,
  `Attribute` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CRN`),
  UNIQUE KEY `CRN_UNIQUE` (`CRN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course_schedule`
--

LOCK TABLES `course_schedule` WRITE;
/*!40000 ALTER TABLE `course_schedule` DISABLE KEYS */;
INSERT INTO `course_schedule` VALUES ('WIRELESS NETWORKS Laboratory (LAB)','COMP',2160,2,0,24271,'Summer 2023','Firouzbakht, Koorosh','F','13:00:00','14:50:00','Wentworth Hall','4','Wentworth Institute Technology','0 of 24',''),('PRECALCULUS Lecture (LEC)','MATH',1500,1,4,33699,'Summer 2023','Batcho, Thomas','MTTR','17:00:00','18:15:00','Annex Central','14','Wentworth Institute Technology','25 of 25',''),('ENGINEERING CALCULUS I Lecture (LEC)','MATH',1750,1,4,33700,'Summer 2023','Cotton, Joseph','MTTR','12:30:00','13:45:00','Dobbs Hall','310','Wentworth Institute Technology','24 of 25',''),('ACTIVE CALCULUS 1A Lecture (LEC)','MATH',1776,1,2,33701,'Summer 2023','Henriksen, Mel','MTTR','08:00:00','09:15:00','Online Section','0','Wentworth Institute Technology','24 of 25',''),('ACTIVE CALCULUS 1B Lecture (LEC)','MATH',1777,2,2,33702,'Summer 2023','TBA','MTTR','08:00:00','09:15:00','Online Section','0','Wentworth Institute Technology','25 of 25',''),('ACTIVE CALCULUS 1B Lecture (LEC)','MATH',1777,1,2,33703,'Summer 2023','Henriksen, Mel','MTTR','09:30:00','10:45:00','Online Section','0','Wentworth Institute Technology','24 of 25',''),('ENGINEERING CALCULUS II Lecture (LEC)','MATH',1850,1,4,33704,'Summer 2023','Cotton, Joseph','MTTR','14:00:00','15:15:00','Annex Central','207','Wentworth Institute Technology','16 of 25',''),('ACTIVE CALCULUS 2A Lecture (LEC)','MATH',1876,1,2,33705,'Summer 2023','Cunningham, Gabe','MTTR','08:00:00','09:15:00','Online Section','0','Wentworth Institute Technology','22 of 25',''),('ACTIVE CALCULUS 2B Lecture (LEC)','MATH',1877,1,2,33706,'Summer 2023','Cunningham, Gabe','MTTR','09:30:00','10:45:00','Online Section','0','Wentworth Institute Technology','23 of 25',''),('ACTIVE CALCULUS 2B Lecture (LEC)','MATH',1877,2,2,33707,'Summer 2023','TBA','MTTR','09:30:00','10:45:00','Online Section','0','Wentworth Institute Technology','23 of 25',''),('INTRODUCTION TO OPERERATIONS RESEARCH Lecture (LEC)','MATH',1900,1,4,33708,'Summer 2023','McDonald, Christopher G.','MTTR','12:30:00','13:45:00','Wentworth Hall','306','Wentworth Institute Technology','8 of 25',''),('MULTIVARIABLE CALCULUS Lecture (LEC)','MATH',2025,1,4,33709,'Summer 2023','Cotton, Joseph','MTTR','11:00:00','12:15:00','Annex South','4','Wentworth Institute Technology','7 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,1,4,33710,'Summer 2023','Federico, Katelyn L.','MWF','11:00:00','12:15:00','Beatty Hall','420','Wentworth Institute Technology','0 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,2,4,33711,'Summer 2023','Zhang, Yu','MWF','12:30:00','13:45:00','Beatty Hall','420','Wentworth Institute Technology','0 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,3,4,33712,'Summer 2023','Zhang, Yu','MWF','15:30:00','16:45:00','Dobbs Hall','306','Wentworth Institute Technology','12 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,4,4,33713,'Summer 2023','Federico, Katelyn L.','MWF','08:00:00','09:15:00','Beatty Hall','420','Wentworth Institute Technology','0 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,5,4,33714,'Summer 2023','Federico, Katelyn L.','MWF','09:30:00','10:45:00','Dobbs Hall','307','Wentworth Institute Technology','0 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,6,4,33715,'Summer 2023','Zhang, Yu','MWF','14:00:00','15:15:00','Beatty Hall','420','Wentworth Institute Technology','12 of 25',''),('PROBABILITY & STATISTICS FOR ENGINEERS Lecture (LEC)','MATH',2100,7,4,33716,'Summer 2023','Habtemicael, Semere','MWTR','14:30:00','16:50:00','Wentworth Hall','205','Wentworth Institute Technology','14 of 24',''),('DIFFERENTIAL EQUATIONS Lecture (LEC)','MATH',2500,1,4,33717,'Summer 2023','Melfi, Lauren','MTTR','11:00:00','12:15:00','Rubenstein Hall','104','Wentworth Institute Technology','15 of 25',''),('DIFFERENTIAL EQUATIONS & SYSTEMS MODELING Lecture (LEC)','MATH',2750,1,4,33718,'Summer 2023','Melfi, Lauren','MTTR','09:30:00','10:45:00','Beatty Hall','418','Wentworth Institute Technology','6 of 25',''),('LINEAR ALGEBRA & MATRIX THEORY Lecture (LEC)','MATH',2860,1,4,33719,'Summer 2023','McDonald, Christopher G.','MTTR','14:00:00','15:15:00','Beatty Hall','421','Wentworth Institute Technology','21 of 25',''),('MACHINE LEARNING Lecture (LEC)','MATH',4050,1,4,33720,'Summer 2023','Qranfal, Youssef','MWF','12:30:00','13:45:00','Beatty Hall','421','Wentworth Institute Technology','6 of 25',''),('MACHINE LEARNING Lecture (LEC)','MATH',4050,2,4,33721,'Summer 2023','Qranfal, Youssef','MWF','14:00:00','15:15:00','Dobbs Hall','307','Wentworth Institute Technology','5 of 25',''),('APPLIED MATHEMATICS FINAL YEAR DESIGN I Lecture (LEC)','MATH',5000,1,4,33724,'Summer 2023','Morrow, Steven','MTTR','09:30:00','10:45:00','Wentworth Hall','307','Wentworth Institute Technology','17 of 25',''),('COMPUTER SCIENCE II Lecture (LEC)','COMP',1050,1,4,33813,'Summer 2023','Okeke, Kenechukwu Kingsley','MW','09:30:00','10:50:00','Beatty Hall','421','Wentworth Institute Technology','22 of 25',''),('COMPUTER SCIENCE II - LAB Laboratory (LAB)','COMP',1050,2,0,33814,'Summer 2023','Okeke, Kenechukwu Kingsley','F','10:00:00','11:50:00','Beatty Hall','421','Wentworth Institute Technology','22 of 25',''),('DATA STRUCTURES Lecture (LEC)','COMP',2000,1,4,33815,'Summer 2023','Rosenberg, Dave','MW','08:00:00','09:20:00','Beatty Hall','421','Wentworth Institute Technology','15 of 25',''),('DATA STRUCTURES Laboratory (LAB)','COMP',2000,2,0,33816,'Summer 2023','Rosenberg, Dave','F','08:00:00','09:50:00','Beatty Hall','421','Wentworth Institute Technology','15 of 25',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,1,4,33869,'Summer 2023','Deligiannidis, Leonidas','F','12:00:00','12:50:00','Dobbs Hall','306','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,2,0,33870,'Summer 2023','Deligiannidis, Leonidas','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,3,4,33871,'Summer 2023','Deligiannidis, Leonidas','F','12:00:00','12:50:00','Wentworth Hall','10','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,4,0,33872,'Summer 2023','Deligiannidis, Leonidas','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,5,4,33873,'Summer 2023','Folajimi, Yetunde','F','12:00:00','12:50:00','Wentworth Hall','308','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,6,0,33874,'Summer 2023','Folajimi, Yetunde','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,7,4,33875,'Summer 2023','Folajimi, Yetunde','F','12:00:00','12:50:00','Wentworth Hall','4','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,8,0,33876,'Summer 2023','Folajimi, Yetunde','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,9,4,33877,'Summer 2023','Gyllinsky, Joshua','F','12:00:00','12:50:00','CEIS','422','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,10,0,33878,'Summer 2023','Gyllinsky, Joshua','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,11,4,33879,'Summer 2023','Othman, Salem','F','12:00:00','12:50:00','CEIS','423','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,12,0,33880,'Summer 2023','Othman, Salem','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,13,4,33881,'Summer 2023','Othman, Salem','F','12:00:00','12:50:00','Wentworth Hall','305','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,14,0,33882,'Summer 2023','Othman, Salem','MTWTR','11:00:00','12:20:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,15,4,33883,'Summer 2023','Gyllinsky, Joshua','F','12:00:00','12:50:00','Wentworth Hall','306','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,16,0,33884,'Summer 2023','Gyllinsky, Joshua','MTWTR','11:00:00','12:20:00','Wentworth Hall','307','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,17,4,33885,'Summer 2023','Olmsted, Aspen','F','12:00:00','12:50:00','Beatty Hall','418','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,18,0,33886,'Summer 2023','Olmsted, Aspen','MTWTR','11:00:00','12:20:00','Wentworth Hall','305','Wentworth Institute Technology','0 of 14',''),('SENIOR PROJECT Lecture (LEC)','COMP',5500,19,4,33887,'Summer 2023','TBA','F','12:00:00','12:50:00','Wentworth Hall','205','Wentworth Institute Technology','4 of 14',''),('SENIOR PROJECT Laboratory (LAB)','COMP',5500,20,0,33888,'Summer 2023','TBA','MTWTR','11:00:00','12:20:00','Wentworth Hall','310','Wentworth Institute Technology','4 of 14',''),('ENVIROMENT HIST: NEW ENGLAND Lecture (LEC)','HIST',3800,1,4,33995,'Summer 2023','Howard, Ella','MW','15:00:00','16:50:00','Annex Central','201','Wentworth Institute Technology','0 of 25',''),('ANCIENT WORLD CIVILIZATIONS Lecture (LEC)','HIST',4100,1,4,33996,'Summer 2023','Gordon, Jody','MWTR','17:00:00','19:20:00','Wentworth Hall','310','Wentworth Institute Technology','0 of 12',''),('MODERN AMERICAN HISTORY Lecture (LEC)','HIST',4175,1,4,33997,'Summer 2023','Lange, Allison','TTR','10:00:00','11:50:00','Beatty Hall','402A','Wentworth Institute Technology','1 of 25',''),('MODERN AMERICAN HISTORY Lecture (LEC)','HIST',4175,2,4,33998,'Summer 2023','Lange, Allison','TTR','13:00:00','14:50:00','Annex Central','210','Wentworth Institute Technology','0 of 25',''),('BOSTON HISTORY Lecture (LEC)','HIST',4223,1,4,33999,'Summer 2023','Howard, Ella','MW','13:00:00','14:50:00','none','0','Wentworth Institute Technology','0 of 25',''),('RELIGION & CULTURE Lecture (LEC)','HUMN',4121,1,4,34000,'Summer 2023','Bernier, Ronald','TTR','13:00:00','14:50:00','Annex Central','14','Wentworth Institute Technology','0 of 25',''),('CONTEMPORARY ART & THEORY Lecture (LEC)','HUMN',4243,1,4,34001,'Summer 2023','Rizzo, Rachel','MW','10:00:00','11:50:00','Annex Central','5','Wentworth Institute Technology','0 of 25',''),('CONTEMPORARY ART & THEORY Lecture (LEC)','HUMN',4243,2,4,34002,'Summer 2023','Rizzo, Rachel','TTR','10:00:00','11:50:00','Annex Central','5','Wentworth Institute Technology','0 of 25',''),('TOYS ARE U.S.: AMERICA AT PLAY Lecture (LEC)','HUMN',4320,1,4,34003,'Summer 2023','Bernier, Ronald','TTR','08:00:00','21:50:00','Wentworth Hall','208','Wentworth Institute Technology','0 of 25',''),('TOYS ARE U.S.: AMERICA AT PLAY Lecture (LEC)','HUMN',4320,2,4,34004,'Summer 2023','Bernier, Ronald','TTR','10:00:00','11:50:00','Annex Central','203','Wentworth Institute Technology','0 of 25',''),('INTRODUCTION TO OPERERATIONS RESEARCH Lecture (LEC)','MATH',1900,2,4,34184,'Summer 2023','Habtemicael, Semere','MWF','17:00:00','19:20:00','Annex Central','209','Wentworth Institute Technology','9 of 25',''),('WIRELESS NETWORKS Lecture (LEC)','COMP',2160,1,4,34266,'Summer 2023','Firouzbakht, Koorosh','MW','14:00:00','15:15:00','Wentworth Hall','4','Wentworth Institute Technology','0 of 24',''),('INTRODUCTION TO ABSTRACT ALGEBRA Lecture (LEC)','MATH',4400,1,4,34286,'Summer 2023','Qranfal, Youssef','MWF','11:00:00','12:15:00','none','0','Wentworth Institute Technology','19 of 25',''),('SOCIAL NETWORK ANALYSIS Online Lecture (OLC)','COMP',7800,2,3,34299,'Summer 2023','Perez, Beatrice ','MW','17:00:00','18:20:00','Online Section','0','Wentworth Institute Technology','20 of 20',''),('SOFTWARE SECURITY Lecture (LEC)','COMP',3800,11,4,34300,'Summer 2023','TBA','TTR','09:30:00','10:50:00','CEIS','422','Wentworth Institute Technology','3 of 24',''),('SOFTWARE SECURITY Laboratory (LAB)','COMP',3800,12,0,34301,'Summer 2023','TBA','F','10:00:00','11:50:00','CEIS','422','Wentworth Institute Technology','3 of 24','');
/*!40000 ALTER TABLE `course_schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `degree_audit`
--

DROP TABLE IF EXISTS `degree_audit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `degree_audit` (
  `Met` tinyint NOT NULL,
  `Rule` varchar(255) DEFAULT NULL,
  `Subject` varchar(255) NOT NULL,
  `Course` int NOT NULL,
  `Term` int NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Credits` decimal(10,0) NOT NULL,
  `Grade` varchar(2) NOT NULL,
  `Source` char(1) NOT NULL,
  PRIMARY KEY (`Subject`,`Course`),
  KEY `Course_idx` (`Course`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `degree_audit`
--

LOCK TABLES `degree_audit` WRITE;
/*!40000 ALTER TABLE `degree_audit` DISABLE KEYS */;
/*!40000 ALTER TABLE `degree_audit` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-29 15:39:50
