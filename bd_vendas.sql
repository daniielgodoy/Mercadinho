-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22/03/2024 às 04:11
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_vendas`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_clientes`
--

CREATE TABLE `tbl_clientes` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tbl_clientes`
--

INSERT INTO `tbl_clientes` (`id`, `nome`) VALUES
(1, 'Carlos');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_funcionarios`
--

CREATE TABLE `tbl_funcionarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `cargo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tbl_funcionarios`
--

INSERT INTO `tbl_funcionarios` (`id`, `nome`, `cpf`, `senha`, `cargo`) VALUES
(1, 'Daniel', '51839043830', '123', 'Gerente'),
(2, 'Miguel', '12345678901', '1', 'Funcionário');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_itens_vendas`
--

CREATE TABLE `tbl_itens_vendas` (
  `id` int(11) NOT NULL,
  `fk_produtos` int(11) NOT NULL,
  `fk_vendas` int(11) NOT NULL,
  `quantidade` double NOT NULL,
  `valor_venda` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tbl_itens_vendas`
--

INSERT INTO `tbl_itens_vendas` (`id`, `fk_produtos`, `fk_vendas`, `quantidade`, `valor_venda`) VALUES
(1, 2, 1, 250, 497.5),
(2, 3, 1, 120, 478.8),
(3, 1, 1, 343, 511.07),
(4, 3, 2, 24, 95.76),
(5, 1, 2, 5, 7.45),
(6, 2, 2, 5, 9.95),
(7, 3, 3, 1, 3.99);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_produtos`
--

CREATE TABLE `tbl_produtos` (
  `id` int(11) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `preco` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tbl_produtos`
--

INSERT INTO `tbl_produtos` (`id`, `descricao`, `preco`) VALUES
(1, 'Banana', 1.49),
(2, 'Pera', 1.99),
(3, 'Leite', 3.99);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tbl_vendas`
--

CREATE TABLE `tbl_vendas` (
  `id` int(11) NOT NULL,
  `data_compra` date DEFAULT NULL,
  `fk_clientes` int(11) DEFAULT NULL,
  `fk_funcionarios` int(11) DEFAULT NULL,
  `valor_total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `tbl_vendas`
--

INSERT INTO `tbl_vendas` (`id`, `data_compra`, `fk_clientes`, `fk_funcionarios`, `valor_total`) VALUES
(1, '2024-03-22', 1, 2, 1487.37),
(2, '2024-03-22', 1, 2, 113.16),
(3, '2024-03-22', 1, 2, 3.99);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tbl_clientes`
--
ALTER TABLE `tbl_clientes`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tbl_funcionarios`
--
ALTER TABLE `tbl_funcionarios`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tbl_itens_vendas`
--
ALTER TABLE `tbl_itens_vendas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tbl_itens_tbl_produtos_idx` (`fk_produtos`),
  ADD KEY `tbl_itens_tbl_vendas_idx` (`fk_vendas`);

--
-- Índices de tabela `tbl_produtos`
--
ALTER TABLE `tbl_produtos`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tbl_vendas`
--
ALTER TABLE `tbl_vendas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `tbl_vendas_tbl_cliente_idx` (`fk_clientes`),
  ADD KEY `tbl_vendas_tbl_funcionarios_idx` (`fk_funcionarios`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tbl_clientes`
--
ALTER TABLE `tbl_clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tbl_funcionarios`
--
ALTER TABLE `tbl_funcionarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tbl_itens_vendas`
--
ALTER TABLE `tbl_itens_vendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `tbl_produtos`
--
ALTER TABLE `tbl_produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tbl_vendas`
--
ALTER TABLE `tbl_vendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `tbl_itens_vendas`
--
ALTER TABLE `tbl_itens_vendas`
  ADD CONSTRAINT `tbl_itens_tbl_produtos` FOREIGN KEY (`fk_produtos`) REFERENCES `tbl_produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tbl_itens_tbl_vendas` FOREIGN KEY (`fk_vendas`) REFERENCES `tbl_vendas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Restrições para tabelas `tbl_vendas`
--
ALTER TABLE `tbl_vendas`
  ADD CONSTRAINT `tbl_vendas_tbl_clientes` FOREIGN KEY (`fk_clientes`) REFERENCES `tbl_clientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tbl_vendas_tbl_funcionarios` FOREIGN KEY (`fk_funcionarios`) REFERENCES `tbl_funcionarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
