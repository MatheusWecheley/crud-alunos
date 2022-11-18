<h2>Olá, este é um repositorio referente a vaga de desenvolvedor back end!</h2>

### Para correta instalação e execução desse projeto, é recomendada ter globalmente instalado Visual Studio 2019 ou 2022 e MS SQL Server.

## Instalação
Após o git clone, inicialize a aplicação pelo Visual Studio.

# Documentação

<h3>Dependencias</h3>

* **VB.Net**
* **Windows Forms**
* **MS SQL Server**


## IMPORTANTE
Ao iniciar o projeto, irá parecer o Form_Db para fazer a conexão com o banco de dados**.<br>
![image](https://user-images.githubusercontent.com/100442318/202713656-4fcc9b1d-d16e-44b1-8a7c-7d65f9b71eb5.png)
![image](https://user-images.githubusercontent.com/100442318/202713683-33908cb0-0362-4d18-871f-9b51e8ec597e.png)
<br/>
Ao informar os dados, solicitará a reinicialização do projeto.<br/>

# Iniciando a aplicação

Após reinicializar o projeto, irá aparecer um aviso de que foi criado a tabela <b>Alunos<b/> para operação dos mesmos.<br/>
 <br/>
 ![image](https://user-images.githubusercontent.com/100442318/202714379-4d2b0edc-200b-4e7b-ab88-528a1a5d8252.png)


## Operações
 
  * Criar aluno:
  
  **Ao preencher <b>Todos<b/> os campos(caso já exista um aluno com este mesmo nome, irá aparecer um aviso)clicando no botão Salvar, sera inserido o aluno no banco de dados.**
 ![image](https://user-images.githubusercontent.com/100442318/202715076-1a19ef2d-67fd-4862-95ea-2dd2865f42c6.png)
![image](https://user-images.githubusercontent.com/100442318/202715092-bcc32f3e-4c50-4db9-b086-824aa7586606.png)

  
  * /universities <br>
  Nesta rotá onde sera possivel realizar as operações (CRUD) <br>
  
   * `GET` <br>
      Usando GET, retornará as 20 primeiras universidades de cada um dos países populados do banco. 
      * `Filter` <br>
      Permitido filtro de busca por pais e navegação de paginas. (limite de 20 por pagina) 
      Ex: `localhost:3000/universities?country=brazil&page=3` <br>
   * `GET:ID` <br>
      Retornando dados da busca da universidade pelo ID da mesma. Ex: `localhost:3000/universities/32381733823da`<br>
   * `POST` <br>
      Metodo para cadastro de Universidades, permitindo os campos (alpha_two_code, web_pages, name, country, domains, state-province). Não permitindo cadastrar outra         universidade com mesmo nome na mesma collection.
   * `PUT` <br>
      Buscando a universiade pelo ID e permitindo alterar os campos (web_pages, name, domains);
   * `DELETE` <br>
      Buscando a universidade pelo ID e permitindo DELETAR a mesma.    
      
  
  
