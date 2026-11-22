# Gerência Churrascaria

Sistema para gerenciar uma churrascaria, feito em C# com Windows Forms e SQL Server. Dá para cadastrar e consultar funcionários, fornecedores, estoque e contas a pagar, e o login tem dois níveis de acesso.

Fiz esse projeto para a disciplina de Projeto de Software. Ele é dividido em 3 camadas: as telas, as regras de negócio e o acesso ao banco.

## Tecnologias

- C# com Windows Forms (.NET Framework 4.8)
- SQL Server Express
- Visual Studio

## Como o projeto está organizado

- TCCTH: as telas do sistema
- BLL: as regras de negócio (Funcionario, Login, Fornecedor, Estoque, PagarContas, Cep e ValidarCPF)
- DAO: a conexão com o banco e as validações de CPF, CNPJ, e-mail e data

## O que o sistema faz

- Login com limite de tentativas
- Fornecedores: cadastrar, consultar, editar e excluir. Valida o CNPJ e o e-mail e preenche o endereço pelo CEP
- Estoque: cadastrar, consultar, editar e excluir os produtos, cada um ligado a um fornecedor
- Funcionários: cadastrar, consultar, editar e excluir. Valida CPF, e-mail e data de nascimento. Também dá para cadastrar os cargos
- Contas a pagar: cadastrar, consultar, editar, excluir e marcar como paga. Na tela aparece quanto falta pagar, quanto já foi pago e quantas contas estão vencidas
- Criar usuário de acesso para um funcionário

Quando um funcionário é excluído ele não some do banco, só fica inativo. O login dele é bloqueado junto, então ele não consegue mais entrar no sistema.

## Níveis de acesso

- Administrador (nível 1): acessa todas as telas
- Comum (nível 2): acessa só fornecedores e estoque

Funcionários, contas a pagar e criar usuário são só do administrador.

## Diagramas

O diagrama de classes e o diagrama de casos de uso foram entregues junto com a atividade no Classroom.

## Banco de dados

O banco se chama CHURRASTRABALHO e usa as tabelas Funcionario, Cargo, tb_Login, CEP, Fornecedor, Estoque e ContaPagar.

## Autor

Matheus Kayque Xavier Gameleira
