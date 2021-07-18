create database Produtos
use Produtos

create table Produtos(Codigo int not null, Nomee nvarchar(50), Descri��o nvarchar(50), 
Valor  decimal(5,2),Fornecedor int, primary key(Codigo))

insert into Produtos(Codigo, Nomee, Descri��o, Valor, Fornecedor) values

(1,'Caneta Azul', 'Caneta Azul Bic ponta grossa', 1.55, 1),
(2,'Caneta Vermelha', 'Caneta Vermelha Bic ponta grossa', 1.55, 1),
(3,'Caneta Verde', 'Caneta Verde Bic ponta grossa', 1.55, 1),
(4,'Caneta Preta', 'Caneta Preta Bic ponta grossa', 1.55, 1),
(5,'Borracha Branca','Borracha Branca Macia',1.10,2),
(6,'Borracha Verde','Borracha Verde Macia',1.10,2),
(7,'R�gua','R�gua 30cm',2.00,2),
(8,'L�pis HB','L�pis HB n�1',1.80,2),
(9,'L�pis HB','L�pis HB n�2',1.80,3),
(10,'Papel Contact','Transparente',15.66,3),
(11,'Papel Contact','Geladeira',17.45,3),
(12,'Papel Contact','Preto',1.80,3),
(13,'Corretivo Carbex','L�quido',2.50,4),
(14,'Corretivo Carbex','Fita',4.50,4),
(15,'Corretivo Escolar','Caneta Bic',5.60,4),
(16,'R�gua Escolar','Transparente',3.00,4),
(17,'R�gua Escolar','Colorida',4.50,5),
(18,'R�gua Escolar','Desenho',6.80,5),
(19,'Fich�rio Escolar','Feminino',45.00,5),
(20,'Fich�rio Escolar','Masculino',54.00,5);
