CREATE DATABASE  IF NOT EXISTS `bd_fincaoropendula` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `bd_fincaoropendula`;
-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_fincaoropendula
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actividades`
--

DROP TABLE IF EXISTS `actividades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `actividades` (
  `idActividad` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idActividad`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actividades`
--

LOCK TABLES `actividades` WRITE;
/*!40000 ALTER TABLE `actividades` DISABLE KEYS */;
INSERT INTO `actividades` VALUES (1,'Cortar maleza','Se cortara la meleza '),(2,'Abonar','Se le pondra abono a las plantas de café');
/*!40000 ALTER TABLE `actividades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciclo`
--

DROP TABLE IF EXISTS `ciclo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ciclo` (
  `idCiclo` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `lugar` varchar(255) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fechaInicial` date DEFAULT NULL,
  `fechaFinal` date DEFAULT NULL,
  PRIMARY KEY (`idCiclo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciclo`
--

LOCK TABLES `ciclo` WRITE;
/*!40000 ALTER TABLE `ciclo` DISABLE KEYS */;
INSERT INTO `ciclo` VALUES (1,'Ciclo Productivo 2020','Finca Oropendula','Ciclo de la produccion del año 2020','2020-01-01','2020-12-31'),(2,'Ciclo productivo 2019','Finca oropendula','Ciclo de la produción del presente año','2019-01-01','2019-12-31');
/*!40000 ALTER TABLE `ciclo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `corte_final`
--

DROP TABLE IF EXISTS `corte_final`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `corte_final` (
  `idCorte` int(10) NOT NULL AUTO_INCREMENT,
  `idTotalCorte` int(10) DEFAULT NULL,
  PRIMARY KEY (`idCorte`),
  KEY `idTotalCorte` (`idTotalCorte`),
  CONSTRAINT `corte_final_ibfk_1` FOREIGN KEY (`idTotalCorte`) REFERENCES `total_corte` (`idTotalCorte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corte_final`
--

LOCK TABLES `corte_final` WRITE;
/*!40000 ALTER TABLE `corte_final` DISABLE KEYS */;
/*!40000 ALTER TABLE `corte_final` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dia_corte`
--

DROP TABLE IF EXISTS `dia_corte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dia_corte` (
  `idDiaCorte` int(10) NOT NULL AUTO_INCREMENT,
  `idCortero` int(10) NOT NULL,
  `idLote` int(10) DEFAULT NULL,
  `fecha` date NOT NULL,
  `latasCortadas` double(10,0) NOT NULL,
  PRIMARY KEY (`idDiaCorte`),
  KEY `idCortero` (`idCortero`),
  KEY `idLote` (`idLote`),
  CONSTRAINT `dia_corte_ibfk_1` FOREIGN KEY (`idCortero`) REFERENCES `planilla_corteros` (`idCortero`),
  CONSTRAINT `dia_corte_ibfk_2` FOREIGN KEY (`idLote`) REFERENCES `lotes` (`idLote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dia_corte`
--

LOCK TABLES `dia_corte` WRITE;
/*!40000 ALTER TABLE `dia_corte` DISABLE KEYS */;
/*!40000 ALTER TABLE `dia_corte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_is`
--

DROP TABLE IF EXISTS `historial_is`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `historial_is` (
  `idHistorial` int(11) NOT NULL AUTO_INCREMENT,
  `ipMaquina` varchar(30) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `fecha` varchar(50) NOT NULL,
  PRIMARY KEY (`idHistorial`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_is`
--

LOCK TABLES `historial_is` WRITE;
/*!40000 ALTER TABLE `historial_is` DISABLE KEYS */;
INSERT INTO `historial_is` VALUES (1,'005056C00001',1,'19-06-2020 10:21:49'),(2,'005056C00001',1,'20-06-2020 07:06:10'),(3,'005056C00001',1,'20-06-2020 07:17:31'),(4,'005056C00001',1,'20-06-2020 07:32:03'),(5,'005056C00001',1,'20-06-2020 08:46:11'),(6,'005056C00001',1,'20-06-2020 08:47:53'),(7,'005056C00001',1,'20-06-2020 08:53:21'),(8,'005056C00001',1,'20-06-2020 08:56:32'),(9,'005056C00001',1,'20-06-2020 09:01:36'),(10,'005056C00001',1,'20-06-2020 09:04:18'),(11,'005056C00001',1,'20-06-2020 09:09:05'),(12,'005056C00001',1,'20-06-2020 09:13:11'),(13,'005056C00001',1,'20-06-2020 09:15:28'),(14,'005056C00001',1,'20-06-2020 09:18:05'),(15,'005056C00001',1,'20-06-2020 09:23:52'),(16,'005056C00001',1,'20-06-2020 09:25:36');
/*!40000 ALTER TABLE `historial_is` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insumos`
--

DROP TABLE IF EXISTS `insumos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `insumos` (
  `idInsumo` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `unidadDeMedida` varchar(100) DEFAULT NULL,
  `costoUnitario` double(10,0) DEFAULT NULL,
  PRIMARY KEY (`idInsumo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumos`
--

LOCK TABLES `insumos` WRITE;
/*!40000 ALTER TABLE `insumos` DISABLE KEYS */;
INSERT INTO `insumos` VALUES (1,'AZITROSTAR XTRA',NULL,'LT',1700),(2,'PH MASTER',NULL,'LT',300),(3,'SILIMAX',NULL,'LT',360),(4,'Pruba',NULL,'LT',1222);
/*!40000 ALTER TABLE `insumos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insumos_utilizados`
--

DROP TABLE IF EXISTS `insumos_utilizados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `insumos_utilizados` (
  `idInsumo` int(10) NOT NULL,
  `idRegistro` int(10) NOT NULL,
  PRIMARY KEY (`idInsumo`,`idRegistro`),
  KEY `idRegistro` (`idRegistro`),
  CONSTRAINT `insumos_utilizados_ibfk_1` FOREIGN KEY (`idInsumo`) REFERENCES `insumos` (`idInsumo`),
  CONSTRAINT `insumos_utilizados_ibfk_2` FOREIGN KEY (`idRegistro`) REFERENCES `registromp` (`idRegistro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumos_utilizados`
--

LOCK TABLES `insumos_utilizados` WRITE;
/*!40000 ALTER TABLE `insumos_utilizados` DISABLE KEYS */;
/*!40000 ALTER TABLE `insumos_utilizados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ip`
--

DROP TABLE IF EXISTS `ip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ip` (
  `ipFisico` varchar(30) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  PRIMARY KEY (`ipFisico`,`idUsuario`),
  KEY `idUsuario` (`idUsuario`),
  CONSTRAINT `ip_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ip`
--

LOCK TABLES `ip` WRITE;
/*!40000 ALTER TABLE `ip` DISABLE KEYS */;
INSERT INTO `ip` VALUES ('005056C00001',1);
/*!40000 ALTER TABLE `ip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lotes`
--

DROP TABLE IF EXISTS `lotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lotes` (
  `idLote` int(10) NOT NULL AUTO_INCREMENT,
  `nombreLote` varchar(100) NOT NULL,
  `nombreDueno` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `variedad` varchar(100) DEFAULT NULL,
  `fechaSiembra` date DEFAULT NULL,
  `tamano` double(100,0) DEFAULT NULL,
  PRIMARY KEY (`idLote`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lotes`
--

LOCK TABLES `lotes` WRITE;
/*!40000 ALTER TABLE `lotes` DISABLE KEYS */;
INSERT INTO `lotes` VALUES (1,'Guitarrón','Chano','Paca','2015-06-15',50),(2,'Prueba','Emma','Catimor','2020-04-20',50),(3,'Prueb2','Aaron','Marsellesa','2018-02-14',23);
/*!40000 ALTER TABLE `lotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mano_de_obra`
--

DROP TABLE IF EXISTS `mano_de_obra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `mano_de_obra` (
  `idTrabajador` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idTrabajador`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mano_de_obra`
--

LOCK TABLES `mano_de_obra` WRITE;
/*!40000 ALTER TABLE `mano_de_obra` DISABLE KEYS */;
/*!40000 ALTER TABLE `mano_de_obra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planilla_corteros`
--

DROP TABLE IF EXISTS `planilla_corteros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `planilla_corteros` (
  `idCortero` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `cedula` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`idCortero`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planilla_corteros`
--

LOCK TABLES `planilla_corteros` WRITE;
/*!40000 ALTER TABLE `planilla_corteros` DISABLE KEYS */;
/*!40000 ALTER TABLE `planilla_corteros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `precios_corte`
--

DROP TABLE IF EXISTS `precios_corte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `precios_corte` (
  `idPrecio` int(10) NOT NULL AUTO_INCREMENT,
  `precioLata` double(10,0) NOT NULL,
  PRIMARY KEY (`idPrecio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `precios_corte`
--

LOCK TABLES `precios_corte` WRITE;
/*!40000 ALTER TABLE `precios_corte` DISABLE KEYS */;
/*!40000 ALTER TABLE `precios_corte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registromp`
--

DROP TABLE IF EXISTS `registromp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `registromp` (
  `idRegistro` int(10) NOT NULL AUTO_INCREMENT,
  `idLote` int(10) DEFAULT NULL,
  `idActividad` int(10) DEFAULT NULL,
  `idCiclo` int(10) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `diasHombre` double(10,0) DEFAULT NULL,
  `c/u_diasHombre` double(10,0) DEFAULT NULL,
  `costoTotalDiasHombre` double(10,0) DEFAULT NULL,
  `cantidadInsumo` double(10,0) DEFAULT NULL,
  `costoTotalInsumo` double(10,0) DEFAULT NULL,
  `Total` double(10,0) DEFAULT NULL,
  PRIMARY KEY (`idRegistro`),
  KEY `idLote` (`idLote`),
  KEY `idActividad` (`idActividad`),
  KEY `idCiclo` (`idCiclo`),
  CONSTRAINT `registromp_ibfk_1` FOREIGN KEY (`idLote`) REFERENCES `lotes` (`idLote`),
  CONSTRAINT `registromp_ibfk_2` FOREIGN KEY (`idActividad`) REFERENCES `actividades` (`idActividad`),
  CONSTRAINT `registromp_ibfk_3` FOREIGN KEY (`idCiclo`) REFERENCES `ciclo` (`idCiclo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registromp`
--

LOCK TABLES `registromp` WRITE;
/*!40000 ALTER TABLE `registromp` DISABLE KEYS */;
/*!40000 ALTER TABLE `registromp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `total_corte`
--

DROP TABLE IF EXISTS `total_corte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `total_corte` (
  `idTotalCorte` int(10) NOT NULL AUTO_INCREMENT,
  `idCiclo` int(10) DEFAULT NULL,
  `totalLatas` double(10,0) NOT NULL,
  `totalDinero` double(10,0) DEFAULT NULL,
  PRIMARY KEY (`idTotalCorte`),
  KEY `idCiclo` (`idCiclo`),
  CONSTRAINT `total_corte_ibfk_1` FOREIGN KEY (`idCiclo`) REFERENCES `ciclo` (`idCiclo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `total_corte`
--

LOCK TABLES `total_corte` WRITE;
/*!40000 ALTER TABLE `total_corte` DISABLE KEYS */;
/*!40000 ALTER TABLE `total_corte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `total_dia_corte`
--

DROP TABLE IF EXISTS `total_dia_corte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `total_dia_corte` (
  `idTotalDiaCorte` int(10) NOT NULL AUTO_INCREMENT,
  `idDiaCorte` int(10) NOT NULL,
  `totalDia` double(10,0) DEFAULT NULL,
  PRIMARY KEY (`idTotalDiaCorte`),
  KEY `idDiaCorte` (`idDiaCorte`),
  CONSTRAINT `total_dia_corte_ibfk_1` FOREIGN KEY (`idDiaCorte`) REFERENCES `dia_corte` (`idDiaCorte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `total_dia_corte`
--

LOCK TABLES `total_dia_corte` WRITE;
/*!40000 ALTER TABLE `total_dia_corte` DISABLE KEYS */;
/*!40000 ALTER TABLE `total_dia_corte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `nombreUsuario` varchar(20) NOT NULL,
  `claveUsuario` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `estado` int(1) NOT NULL,
  `tipo_usuario` varchar(15) NOT NULL,
  PRIMARY KEY (`idUsuario`) USING BTREE,
  KEY `tipo_usuario` (`tipo_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Admon','admin','admin',1,'Administrador');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bd_fincaoropendula'
--

--
-- Dumping routines for database 'bd_fincaoropendula'
--
/*!50003 DROP PROCEDURE IF EXISTS `AgregarActividades` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarActividades`(IN `pNombre` varchar(100),IN `pDescripcion` varchar(255))
BEGIN

	Insert INTO actividades(actividades.nombre, actividades.descripcion) VALUES(pNombre,pDescripcion);



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AgregarCiclo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarCiclo`(IN `pNombre` varchar(255),IN `pLugar` varchar(255),IN `pDescripcion` varchar(255),IN `pFechaInicial` date,IN `pFechaFinal` date)
BEGIN

	INSERT INTO ciclo(ciclo.nombre, ciclo.lugar, ciclo.descripcion, ciclo.fechaInicial, ciclo.fechaFinal) VALUES(pNombre, pLugar, pDescripcion, pFechaInicial, pFechaFinal);



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AgregarInsumo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarInsumo`(IN `pNombre` varchar(100),IN `pUnidadMedida` varchar(100),IN `pCostoUnitario` double)
BEGIN

	INSERT INTO insumos(nombre, unidadDeMedida, costoUnitario) VALUES (pNombre,pUnidadMedida,pCostoUnitario);



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AgregarLote` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarLote`(IN `pNombreLote` varchar(100),IN `pDueno` varchar(100),IN `pVariedad` varchar(100),IN `pFechaSiembra` date,IN `pTamano` double)
BEGIN

	INSERT INTO lotes(lotes.nombreLote, lotes.nombreDueno, lotes.variedad, lotes.fechaSiembra, lotes.tamano) VALUES(pNombreLote, pDueno, pVariedad, pFechaSiembra, pTamano);



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarActividades` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarActividades`()
BEGIN

	SELECT actividades.nombre as "Nombre de la actividad", actividades.descripcion as "Descripción" FROM actividades;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarCiclos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarCiclos`()
BEGIN

	SELECT ciclo.nombre as "Nombre del ciclo", ciclo.lugar as "Lugar", ciclo.descripcion as "Descripción", ciclo.fechaInicial as "Fecha inicial", ciclo.fechaFinal as "Fecha final" FROM ciclo;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarInsumos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarInsumos`()
BEGIN

	SELECT idInsumo as "N°", insumos.nombre as "Nombre", insumos.unidadDeMedida as "Unidad de Md.", insumos.costoUnitario as "Costo Unitario(C$)" FROM insumos;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarLotes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarLotes`()
BEGIN

	SELECT lotes.nombreLote as "Nombre del lote", lotes.variedad as "Variedad", lotes.fechaSiembra as "Siembra", lotes.tamano as "Tamaño", lotes.nombreDueno as "Dueño" FROM lotes;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SesionUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SesionUsuario`(IN `pUsuario` varchar(20),IN `PClave` varchar(20),IN `pAccion` varchar(10), OUT respuesta varchar(10),IN pIp varchar(30),IN pIdUsuario int,IN pFecha varchar (50) )
BEGIN
	Declare reg INT;
	declare est INT;
	set reg=0;
	set est =0;
		select COUNT(*) into reg from usuarios WHERE nombreUsuario = pUsuario and claveUsuario = PClave;
	
				if reg>0 then
					IF pAccion = "Entrar" then
				#-------------------------Iniciar sesión -----------------------------------------------------------
						select estado into est from usuarios WHERE nombreUsuario = pUsuario and claveUsuario = PClave;
					if est = 0 then
						set  respuesta ="INICIAR";#iniciar Sesión
						UPDATE usuarios set estado = 1 where nombreUsuario = pUsuario and claveUsuario = PClave;
						insert into ip(ip.ipFisico,ip.idUsuario) values (pIp,pIdUsuario);
						insert into Historial_IS(ipMaquina,idUsuario,fecha) VALUES (pIp,pIdUsuario,pFecha);
						#select "Inició sesion";
							ELSEIF est = 1 then
								set respuesta = "OPEN";#La sesión esta abierta, no se puede iniciar sesion
							#	select "Sesion en uso";
						 End If;
			#---------------------------------------------------------------------------------------------------------
					ELSEIF pAccion = "Salir" then
						 
			#------------------------------------------Cerrar sesión -------------------------------------------------
			UPDATE usuarios set estado = 0 where nombreUsuario = pUsuario and claveUsuario = PClave;
			Delete from ip where ip.ipFisico = pIp;
			set respuesta ="CERRADA";#cerrar sesión
			#---------------------------------------------------------------------------------------------------------
					End If;
			ELSE
			SET respuesta = "ERROR";
				End if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-20 23:33:03
