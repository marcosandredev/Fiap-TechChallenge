# Fiap-TechChallenge

Requisitos
- Cadastrar/Atualizar e Pegar dados de Jogadores, Transferencias e Clubes;
- Gerar relatório por ranking ranking por gols, assistencias e cartões;
- Gerar relatório paginado de jogadores, clubes e tranferencias;
- As transferências só devem ser permitidas se o jogador estiver cadastrado no sistema;
- As transferências só devem ser permitidas se os clubes envolvidos estiverem cadastrados no sistema;
- O acesso ao sistema deve ser restrito a usuários autorizados, como administradores e analisatas;

Critério de aceite (requisito mínimo)
- Clube
	- O Clube deve ter no minímo 23 jogadores, caso não tenha, ele fica inativo;
	
- Transferencias	
	- Em tranferencias, o clube anterior ou o novo clube podem ser Sem Clube ou Aposentado.
	- As tranferencias só podem ser por venda, empréstimo, fim de contrato ou recisão;

- Jogadores
	- Jogadores Aposentados devem ter uma flag dizendo que não estão ativos;
	- O jogador não pode estar em mais de um clube;
