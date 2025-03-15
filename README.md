# Gerenciamento de Usuários MVC em C#

Este projeto implementa um sistema de gerenciamento de usuários utilizando o padrão MVC em C# com Windows Forms.

## Funcionalidades

* Cadastro de novos usuários com ID, nome, sobrenome, sexo e departamento.
* Exibição dos usuários cadastrados em uma lista.
* Edição e exclusão de usuários existentes.
* Interface gráfica intuitiva e fácil de usar.

## Estrutura do Projeto

* **UsuariosMVC.sln:** Arquivo de solução do Visual Studio.
* **UsuariosMVC/:** Pasta do projeto principal.
    * **Properties/:** Contém configurações e recursos do projeto.
    * **Referências/:** Bibliotecas e dependências externas.
    * **App.config:** Arquivo de configuração do aplicativo.
    * **Controller.cs:** Lógica de controle que interage entre a View e o Model.
    * **FrmUsuarios.cs:** Interface gráfica do usuário (GUI) construída com Windows Forms.
    * **ListaUsuario.cs:** Classe para gerenciar a lista de usuários.
    * **Program.cs:** Ponto de entrada principal do aplicativo.
    * **Usuario.cs:** Modelo de dados para a entidade Usuário.
