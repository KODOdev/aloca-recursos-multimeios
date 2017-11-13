-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.7.20-log


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema db_aloca_recursos
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ db_aloca_recursos;
USE db_aloca_recursos;

--
-- Table structure for table `db_aloca_recursos`.`tb_professor`
--

DROP TABLE IF EXISTS `tb_professor`;
CREATE TABLE `tb_professor` (
  `matricula_professor` int(10) unsigned NOT NULL,
  `nome_professor` varchar(100) NOT NULL,
  `telefone_professor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`matricula_professor`),
  UNIQUE KEY `matricula_professor_UNIQUE` (`matricula_professor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabela que aloca os professores.';

--
-- Dumping data for table `db_aloca_recursos`.`tb_professor`
--

/*!40000 ALTER TABLE `tb_professor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_professor` ENABLE KEYS */;


--
-- Table structure for table `db_aloca_recursos`.`tb_recursos`
--

DROP TABLE IF EXISTS `tb_recursos`;
CREATE TABLE `tb_recursos` (
  `codigo_recurso` int(10) unsigned NOT NULL,
  `quantidade_recurso` int(10) unsigned NOT NULL,
  `descricao_recurso` varchar(50) NOT NULL,
  PRIMARY KEY (`codigo_recurso`),
  UNIQUE KEY `codigo_recurso_UNIQUE` (`codigo_recurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabela de alocação dos recursos.';

--
-- Dumping data for table `db_aloca_recursos`.`tb_recursos`
--

/*!40000 ALTER TABLE `tb_recursos` DISABLE KEYS */;
INSERT INTO `tb_recursos` (`codigo_recurso`,`quantidade_recurso`,`descricao_recurso`) VALUES 
 (1,2,'Monitor');
/*!40000 ALTER TABLE `tb_recursos` ENABLE KEYS */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
