-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: watchlistwebsite
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `peliculas`
--

DROP TABLE IF EXISTS `peliculas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `peliculas` (
  `PeliculaId` int NOT NULL AUTO_INCREMENT,
  `Titulo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Genero` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Resumen` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `RutaImagen` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `WatchlistId` int DEFAULT NULL,
  PRIMARY KEY (`PeliculaId`),
  KEY `IX_Peliculas_WatchlistId` (`WatchlistId`),
  CONSTRAINT `FK_Peliculas_Watchlists_WatchlistId` FOREIGN KEY (`WatchlistId`) REFERENCES `watchlists` (`WatchlistId`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peliculas`
--

LOCK TABLES `peliculas` WRITE;
/*!40000 ALTER TABLE `peliculas` DISABLE KEYS */;
INSERT INTO `peliculas` VALUES (1,'El Padrino','Drama','La historia de la familia mafiosa Corleone.','imagen1.jpg',NULL),(2,'Pulp Fiction','Crimen','Varias historias interconectadas en el mundo del crimen.','imagen2.jpg',NULL),(3,'Forrest Gump','Drama','La vida de un hombre con discapacidad intelectual.','imagen3.jpg',NULL),(4,'Titanic','Romance','El trágico hundimiento del famoso buque.','imagen4.jpg',NULL),(5,'El Señor de los Anillos: La Comunidad del Anillo','Fantasía','Un grupo se embarca en una épica aventura para destruir un anillo.','imagen5.jpg',NULL),(6,'La La Land','Musical','Una historia de amor entre un pianista y una actriz.','imagen6.jpg',NULL),(7,'Avatar','Ciencia Ficción','Un exmarine es enviado a un planeta alienígena.','imagen7.jpg',NULL),(8,'Jurassic Park','Aventura','Parque temático con dinosaurios se sale de control.','imagen8.jpg',NULL),(9,'El Resplandor','Terror','Un hombre se vuelve loco mientras cuida un hotel aislado.','imagen9.jpg',NULL),(10,'Inception','Ciencia Ficción','Un ladrón entra en los sueños de las personas para robar secretos.','imagen10.jpg',NULL),(11,'Casablanca','Romance','Un drama romántico durante la Segunda Guerra Mundial.','imagen11.jpg',NULL),(12,'The Dark Knight','Acción','Batman enfrenta al Joker en una batalla épica.','imagen12.jpg',NULL),(13,'Blade Runner','Ciencia Ficción','Un cazador de androides persigue a replicantes en un futuro distópico.','imagen13.jpg',NULL),(14,'The Shawshank Redemption','Drama','La historia de un hombre inocente en prisión.','imagen14.jpg',NULL),(15,'Matrix','Ciencia Ficción','Un programador descubre la verdad sobre la realidad.','imagen15.jpg',NULL),(16,'E.T. the Extra-Terrestrial','Ciencia Ficción','Un niño encuentra y protege a un alienígena.','imagen16.jpg',NULL),(17,'The Godfather Part II','Drama','La continuación de la saga de la familia Corleone.','imagen17.jpg',NULL),(18,'Back to the Future','Aventura','Viaje en el tiempo con un DeLorean.','imagen18.jpg',NULL),(19,'The Silence of the Lambs','Crimen','Una agente del FBI busca la ayuda de Hannibal Lecter para atrapar a un asesino.','imagen19.jpg',NULL),(20,'Schindler\'s List','Drama','La historia de Oskar Schindler y su lista durante el Holocausto.','imagen20.jpg',NULL),(21,'The Great Gatsby','Drama','La vida decadente de Jay Gatsby en la década de 1920.','imagen21.jpg',NULL),(22,'The Shining','Terror','Una familia aislada en un hotel enfrenta horrores sobrenaturales.','imagen22.jpg',NULL),(23,'The Matrix Reloaded','Ciencia Ficción','Neo continúa su lucha contra las máquinas.','imagen23.jpg',NULL),(24,'Interstellar','Ciencia Ficción','Un grupo de astronautas busca un nuevo hogar para la humanidad.','imagen24.jpg',NULL),(25,'A Clockwork Orange','Drama','La historia de un joven delincuente y su experiencia con la reforma.','imagen25.jpg',NULL),(26,'The Social Network','Drama','La creación de Facebook y sus repercusiones legales.','imagen26.jpg',NULL),(27,'Fight Club','Drama','Un hombre descontento forma un club secreto de lucha.','imagen27.jpg',NULL),(28,'The Wizard of Oz','Aventura','Dorothy viaja a la Ciudad Esmeralda en el mundo de Oz.','imagen28.jpg',NULL),(29,'Gone with the Wind','Drama','La historia de amor y conflicto durante la Guerra Civil estadounidense.','imagen29.jpg',NULL),(30,'The Godfather Part III','Drama','La conclusión de la trilogía de la familia Corleone.','imagen30.jpg',NULL);
/*!40000 ALTER TABLE `peliculas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-14 23:52:58
