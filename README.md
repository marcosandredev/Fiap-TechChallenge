<h1 align="center">FIAP - Grupo XX - TECH CHALLENGE</h1>
<br>

<h3 align="center">Integrantes do Grupo:</h3>
<br>
<li>Bruno Moura     - RM 350846</li>
<li>Igor Broetto    - RM 351931</li>
<li>Marcos André    - RM 351923</li>
<li>Tiago Vazzoller - RM 351733</li>
<li>Victor Hugo     - RM 351315</li>
<br>

<p>A Confederação Brasileira de Futebol (CBF), como parte de sua constante evolução e compromisso com a excelência no gerenciamento de informações relacionadas ao futebol, reconheceu a necessidade de desenvolver uma API (Interface de Programação de Aplicativos) robusta e eficiente.</p>
<p></p>Esta iniciativa visa simplificar e aprimorar a forma como os dados essenciais do futebol brasileiro são acessados, gerenciados e compartilhados.
Com a crescente complexidade das operações envolvendo jogadores, clubes, transferências, estatísticas e contratos, a CBF reconhece a importância de estabelecer um sistema tecnologicamente avançado que promova a transparência, precisão e acessibilidade aos dados relacionados ao futebol nacional.</p>

<h3 align="center">Requisitos Levantados:</h3>
<li>Cadastrar, atualizar e obter dados de Jogadores, transferências, clubes e temporadas.</li>
<li>Gerar relatório por ranking de gols, assistências e cartões.</li>
<li>Gerar relatório paginado de jogadores, clubes e tranferências.</li>
<li>As transferências só devem ser permitidas se o jogador estiver cadastrado no sistema.</li>
<li>As transferências só devem ser permitidas se os clubes envolvidos estiverem cadastrados no sistema.</li>
<li>O acesso ao sistema deve ser restrito a usuários autorizados, como administradores e analistas.</li>
<li>Para adicionar, atualizar ou excluir, somente com autorização de Administrador.</li>
<li>Ao excluir, não pode excluir o registro do banco de dados e sim deixar uma flag como desativado</li>
<br>

<h3 align="center">Critérios de Aceite (MVP):</h3>

- Clube
	<p>O clube deve possuir uma data de fundação, residir em uma cidade e possuir jogadores.</p>
 	<br>
- Jogadores
	<p>O jogador deve estar regularizado com os dados cadastrais, estar ativo ( não aposentado ) e não pertercer a mais de um clube.</p>
	<p>Jogadores que estiverem aposentados, não podem ser utilizados no sistema e devem ter uma sinalização para essa situação.  ( Flag no banco de dados como falso)</p>
 	<br>
- Transferências
	<p>As transferências só podem ser por venda, empréstimo, retorno de empréstimo, troca, fim de contrato ou recisão e estarem vinculadas a uma temporada.</p>
	<p>O jogador pode ser transferido mesmo que esteja sem clube ou aposentado.</p>
	<p>Caso a transferência por algum motivo não aconteça, deve existir uma sinalização dizendo que ela não está ativa.   ( Flag no banco de dados )</p>
	<p>As transferências devem possuir uma data de início e uma previsão de fim. ( final de contrato ).</p>
	<p>As transferências devem informar o clube de destino e o clube de origem.</p>
 	<br>
- Temporada
	<p>A temporada deve ter uma data de início e fim e uma sinalização se ela está ativa ou não.</p>
	<p>Não podem existir mais de uma temporada no mesmo ano.</p>
 	<br>
- Estatísticas
	<p>Deve existir uma consulta para mostrar os jogadores com mais cartões amarelos e vermelhos por temporada.</p>
	<p>Deve existir uma consulta para mostrar os jogadores com mais gols por temporada.</p>
	<p>Deve existir uma consulta para mostrar os jogadores com mais assistências por temporada.</p>
	<p>Deve existir uma consulta para mostrar os jogadores com mais partidas por temporada.</p>
	<p>Deve existar uma consulta para mostrar os clubes com mais gols, cartões, assistências e partidas por temporada.</p>
 	<br>
<h3 align="center">Para poder rodar o projeto</h3>
<br>
<p>Clone o projeto usando Visual Studio 2022 ou Visual Studio Code</p>
<br>
<p>Tenha Instalado o .Net 7.0, caso não tenha, pode fazer download do link abaixo:</p>
 <pre> https://dotnet.microsoft.com/pt-br/download/dotnet/7.0</pre>
<br>
<p>Este projeto está usando o SQL Server, você pode usar a instancia do SQL se estiver instalado em sua máquina ou em Docker:</p>
<p>Via Docker:</p>
 <pre> docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest</pre>
 <br>
 <p>Em appsettings.Development.json colocar a string de conexão com seus dados:</p>
 <pre> "ConnectionStrings": {
    "CBFConnection": Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
  }</pre>
<br>

<p>Ao rodar o projeto deve-se criar um usuário Administrador para poder inserir, atualizar e deletar os registros:</p>
<pre>api/usuário/create</pre>
<p>Crie seu usuário com permissão 1 para administrador</p>
<p>Depois vá na rota:</p>
<pre>/api/Login/GerarToken</pre>
<p>Insira os dados de e-mail e senha cadastrados no endpoint anterior para gerar o token</p>
<p>Pegue o token da resposta e vá até o authorize no topo direito da tela e coloque Bearer + token </p>
<br>

