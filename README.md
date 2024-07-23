# Sistema de Controle de Bar

O Sr. John Wick, proprietário do Bar Academia do Programador, precisa controlar melhor o que cada cliente consumiu em seu estabelecimento para aumentar a produtividade e alavancar o sucesso do seu bar. A equipe do Bar Academia do Programador precisa de mais agilidade na realização das atividades e processos e, desta forma, necessita de um sistema que ajude a controlar as questões financeiras do estabelecimento.

## Requisitos Funcionais

### Gerenciamento de Clientes
- Adicionar novos clientes.
- Listar todos os clientes cadastrados.
- Editar as informações dos clientes.
- Excluir clientes.

### Gerenciamento de Garçons
- Adicionar novos garçons.
- Listar todos os garçons cadastrados.
- Editar as informações dos garçons.
- Excluir garçons.

### Gerenciamento de Mesas
- Adicionar novas mesas.
- Listar todas as mesas cadastradas.
- Editar as informações das mesas.
- Excluir mesas.

### Gerenciamento de Produtos
- Adicionar novos produtos ao cardápio.
- Listar todos os produtos disponíveis.
- Editar as informações dos produtos.
- Excluir produtos.

### Registro de Consumo
- Registrar o consumo dos clientes.
- Associar cada consumo a um cliente específico e a uma mesa específica.
- Permitir adicionar e remover pedidos de uma determinada conta.

### Relatórios e Faturamento
- Gerar um relatório detalhado do consumo por cliente.
- Gerar um relatório geral do bar, incluindo o total faturado.
- Visualizar as contas abertas e o total faturado no dia.

## Regras de Negócio

### Cliente
- Cada cliente deve ter um ID único.
- O nome do cliente é obrigatório e deve ser único.

### Garçom
- Cada garçom deve ter um ID único.
- O nome do garçom é obrigatório e deve ser único.

### Mesa
- Cada mesa deve ter um ID único.
- O número da mesa é obrigatório e deve ser único.

### Produto
- Cada produto deve ter um ID único.
- O nome do produto é obrigatório.
- O preço do produto é obrigatório.

### Consumo
- Cada registro de consumo deve incluir a data e hora do consumo, o cliente, o garçom que atendeu e a mesa.
- Cada consumo deve estar associado a um ou mais produtos.

## Estrutura do Projeto

### Início com Clientes
- Implementar a funcionalidade de gerenciamento de clientes (adicionar, listar, editar, excluir).

### Expansão para Garçons, Mesas e Produtos
- Adicionar funcionalidades semelhantes para garçons, mesas e produtos.

### Registro de Consumo e Relatórios
- Implementar o registro de consumo e a geração de relatórios detalhados e gerais.
