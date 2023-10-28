FIAP - Grupo XX - TECH CHALLENGE

O problema:

A Confederação Brasileira de Futebol (CBF), como parte de sua constante evolução e compromisso com a excelência no gerenciamento de informações relacionadas ao futebol, reconheceu a necessidade de desenvolver uma API (Interface de Programação de Aplicativos) robusta e eficiente. 
Esta iniciativa visa simplificar e aprimorar a forma como os dados essenciais do futebol brasileiro são acessados, gerenciados e compartilhados.
Com a crescente complexidade das operações envolvendo jogadores, clubes, transferências, estatísticas e contratos, a CBF reconhece a importância de estabelecer um sistema tecnologicamente avançado que promova a transparência, precisão e acessibilidade aos dados relacionados ao futebol nacional. 

Requisitos Levantados:
- Cadastrar, atualizar e obter dados de Jogadores, transferências, clubes e temporadas.
- Gerar relatório por ranking de gols, assistâncias e cartões.
- Gerar relatório paginado de jogadores, clubes e tranferências.
- As transferências só devem ser permitidas se o jogador estiver cadastrado no sistema.
- As transferências só devem ser permitidas se os clubes envolvidos estiverem cadastrados no sistema.
- O acesso ao sistema deve ser restrito a usuários autorizados, como administradores e analistas.

Critérios de Aceite (MVP):
- Clube
	O clube deve possuir uma data de fundação, residir em uma cidade e possuir jogadores.
 
- Jogadores
	O jogador deve estar regularizado com os dados cadastrais, estar ativo ( não aposentado ) e não pertercer a mais de um clube.
	Jogadores que estiverem aposentados, não podem ser utilizados no sistema e devem ter uma sinalização para essa situação.  ( Flag no banco de dados como falso)
 
- Transferências
	As transferências só podem ser por venda, empréstimo, retorno de empréstimo, troca, fim de contrato ou recisão e estarem vinculadas a uma temporada.
	O jogador pode ser transferido mesmo que esteja sem clube ou aposentado.
	Caso a transferência por algum motivo não aconteça, deve existir uma sinalização dizendo que ela não está ativa.   ( Flag no banco de dados )
	As transferências devem possuir uma data de início e uma previsão de fim. ( final de contrato ).
	As transferências devem informar o clube de destino e o clube de origem.
 
- Temporada
	A temporada deve ter uma data de início e fim e uma sinalização se ela está ativa ou não.
	Não podem existir mais de uma temporada no mesmo ano.
 
- Estatísticas
	Deve existir uma consulta para mostrar os jogadores com mais cartões amarelos e vermelhos por temporada.
	Deve existir uma consulta para mostrar os jogadores com mais gols por temporada.
	Deve existir uma consulta para mostrar os jogadores com mais assistências por temporada.
	Deve existir uma consulta para mostrar os jogadores com mais partidas por temporada.
	Deve existar uma consulta para mostrar os clubes com mais gols, cartões, assistências e partidas por temporada.
