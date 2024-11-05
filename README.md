<h2>Descrição</h2>
<p>Este projeto foi desenvolvido utilizando ASP.NET, Entity Framework, Swagger e SQL Server. A API disponibiliza endpoints para gerenciar informações de Autores e Livros, organizados em controllers específicos para cada entidade. Cada controller inclui 6 endpoints para realizar operações de CRUD, possibilitando a criação, leitura, atualização e exclusão de registros. Em endpoints específicos, como "BuscarLivroPorIdAutor", a resposta também inclui os dados do autor relacionados ao livro, retornando tanto as informações do livro quanto do autor associado.</p>

<h2>Propósito</h2>
<p>Este projeto foi criado como um exercício de aprendizado para aplicar e aprimorar meus conhecimentos. Portanto, ainda há várias oportunidades para melhorias no código, que serão implementadas futuramente neste ou em projetos similares.</p>

<h2>Operações CRUD</h2>
<p>Cada controller possui 6 endpoints, conforme listado a seguir:</p>

<h3>GET:</h3>
<ul>
  <li><strong>Listar Autores</strong>: Retorna uma lista de todos os autores.</li>
  <li><strong>Buscar Autor por Id</strong>: Retorna os dados de um autor específico pelo seu Id.</li>
  <li><strong>Buscar Autor por Id do Livro</strong>: Retorna o autor associado a um livro específico, a partir do Id do livro.</li>
  <li><strong>Listar Livros</strong>: Retorna uma lista de todos os livros.</li>
  <li><strong>Buscar Livro por Id</strong>: Retorna os dados de um livro específico pelo seu Id.</li>
  <li><strong>Buscar Livro por Id do Autor</strong>: Retorna todos os livros associados a um autor específico.</li>
</ul>

<h3>POST:</h3>
<ul>
  <li><strong>Criar Autor</strong>: Cadastra um novo autor no banco de dados.</li>
  <li><strong>Criar Livro</strong>: Cadastra um novo livro no banco de dados.</li>
</ul>

<h3>PUT:</h3>
<ul>
  <li><strong>Editar Autor</strong>: Atualiza as informações de um autor existente no banco de dados.</li>
  <li><strong>Editar Livro</strong>: Atualiza as informações de um livro existente no banco de dados.</li>
</ul>

<h3>DELETE:</h3>
<ul>
  <li><strong>Remover Autor</strong>: Remove um autor do banco de dados pelo seu Id.</li>
  <li><strong>Remover Livro</strong>: Remove um livro do banco de dados pelo seu Id.</li>
</ul>

<h2>Imagens do Projeto</h2>
<p>Abaixo estão algumas capturas de tela para demonstrar a interface e funcionalidades do projeto:</p>

<p>
  <img src="https://github.com/user-attachments/assets/631ff15d-82c1-45a0-a138-e44dcbbe11be" alt="Imagem 1 - Interface Principal" width="1000">
  <br> <em>Imagem 1: Interface Principal</em>
</p>
<p>
  <img src="https://github.com/user-attachments/assets/d07ee7ce-02ea-46f5-bd8a-8a41baf23c59" alt="Imagem 2 - Exemplo de Endpoint" width="1000">
  <br> <em>Imagem 2: Exemplo de Endpoint</em>
</p>
<p>
  <img src="https://github.com/user-attachments/assets/43d858b9-1e7b-49ba-8ad1-9685ceba5e88" alt="Imagem 3 - Resultado de Busca" width="1000">
  <br> <em>Imagem 3: Resultado de Busca</em>
</p>
