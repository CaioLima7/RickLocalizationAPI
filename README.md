# RickLocalizationAPI


.NET CORE 3.1
bibs .net standard 2.1


Repository, Disposable, xUnit, EF CORE(code first), Swagger


Passo a passo:

- Entrar no cmd(máquina deve ter o visual studio instalado, pois iremos usar o SqlLocalDB), caso não tenha instalado, instalar pelo instalador do VS.
  digitar o seguinte comando:
    SqlLocalDb create RickLocalizationDB

- No visual studio, entrar em Ferramentas > Gerenciador de pacotes nuget > Console
  Em projeto padrão, selecionar "Repository"
    Digitar o seguinte comando:
      Update-Database 
      OBS: caso dê erro, tente entrar na conexao(SQL Server) e executar a seguinte linha: create database RickLocalizationDB
      
      
- Agora com o banco de dados e suas tabelas criadas, vamos dar uma carga inicial no "database", 
  Entre conexao criada:
    (localDB)\RickLocalizationDB
    windows auth
      
- usando a conexao, use o script localizado em scripts/CargaBancodeDados.sql


  
      
      
  

