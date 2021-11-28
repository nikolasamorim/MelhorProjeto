Create database melhorprojeto;
use melhorprojeto;

CREATE TABLE tbl_dados (
  `id` varchar(45) NOT NULL,
  `ngca` varchar(45) NOT NULL,
  `n02` varchar(45) NOT NULL,
  `a01` varchar(45) NOT NULL,
  primary key(id)
) ENGINE=InnoDB;


CREATE TABLE tbl_usuarios(
  `cpf` varchar(12) not null unique,
  `nome` varchar(45) not null,
  `email` varchar(60) not null,
  `senha` varchar(20) not null,
  `rg` varchar(12) not null,
  `datanascimento` date not null,
  `rua` varchar(45) not null,
  `numero` varchar(12) not null,
  `cidade` varchar(45) not null,
  `estado` varchar(45) not null,
  `pais` varchar(45) not null,
  `bairro` varchar(12) not null,
  `telefone` varchar(12) not null,
  primary key(cpf)
)ENGINE=INNODB;


