-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.31 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para carwashdb
CREATE DATABASE IF NOT EXISTS `carwashdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `carwashdb`;

-- Copiando estrutura para tabela carwashdb.tb_carro
CREATE TABLE IF NOT EXISTS `tb_carro` (
  `Car_ID` int NOT NULL AUTO_INCREMENT,
  `Car_Nome` varchar(300) DEFAULT NULL,
  `Car_Placa` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Car_Cor` varchar(50) DEFAULT NULL,
  `Car_Marca` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Car_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela carwashdb.tb_carro: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb_carro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_carro` ENABLE KEYS */;

-- Copiando estrutura para tabela carwashdb.tb_cliente
CREATE TABLE IF NOT EXISTS `tb_cliente` (
  `Cli_ID` int NOT NULL AUTO_INCREMENT,
  `Cli_Nome` varchar(200) DEFAULT NULL,
  `Cli_CPF` varchar(50) DEFAULT NULL,
  `Cli_Genero` varchar(50) DEFAULT NULL,
  `Car_ID` int DEFAULT NULL,
  PRIMARY KEY (`Cli_ID`),
  KEY `FK1` (`Car_ID`),
  CONSTRAINT `FK1` FOREIGN KEY (`Car_ID`) REFERENCES `tb_carro` (`Car_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela carwashdb.tb_cliente: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;

-- Copiando estrutura para tabela carwashdb.tb_lavagem
CREATE TABLE IF NOT EXISTS `tb_lavagem` (
  `Lav_ID` int NOT NULL AUTO_INCREMENT,
  `Lav_Horario` time DEFAULT NULL,
  `Lav_Data` date DEFAULT NULL,
  `Cli_ID` int DEFAULT NULL,
  `Car_ID` int DEFAULT NULL,
  PRIMARY KEY (`Lav_ID`),
  KEY `FK_tb_lavagem_tb_cliente` (`Cli_ID`),
  KEY `FK_tb_lavagem_tb_carro` (`Car_ID`),
  CONSTRAINT `FK_tb_lavagem_tb_carro` FOREIGN KEY (`Car_ID`) REFERENCES `tb_carro` (`Car_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tb_lavagem_tb_cliente` FOREIGN KEY (`Cli_ID`) REFERENCES `tb_cliente` (`Cli_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela carwashdb.tb_lavagem: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb_lavagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_lavagem` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
