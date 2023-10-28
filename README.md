<!DOCTYPE html>
<html>
<head>
    <title>FIAP - Grupo XX - TECH CHALLENGE</title>
</head>
<body>
    <h1>FIAP - Grupo XX - TECH CHALLENGE</h1>

    <h2>O problema:</h2>
    <p>A Confederação Brasileira de Futebol (CBF), como parte de sua constante evolução e compromisso com a excelência no gerenciamento de informações relacionadas ao futebol, reconheceu a necessidade de desenvolver uma API (Interface de Programação de Aplicativos) robusta e eficiente.</p>
    <p>Esta iniciativa visa simplificar e aprimorar a forma como os dados essenciais do futebol brasileiro são acessados, gerenciados e compartilhados.</p>
    <p>Com a crescente complexidade das operações envolvendo jogadores, clubes, transferências, estatísticas e contratos, a CBF reconhece a importância de estabelecer um sistema tecnologicamente avançado que promova a transparência, precisão e acessibilidade aos dados relacionados ao futebol nacional.</p>

    <h2>Requisitos Levantados:</h2>
    <ul>
        <li>Cadastrar, atualizar e obter dados de Jogadores, transferências, clubes e temporadas.</li>
        <li>Gerar relatório por ranking de gols, assistências e cartões.</li>
        <li>Gerar relatório paginado de jogadores, clubes e transferências.</li>
        <li>As transferências só devem ser permitidas se o jogador estiver cadastrado no sistema.</li>
        <li>As transferências só devem ser permitidas se os clubes envolvidos estiverem cadastrados no sistema.</li>
        <li>O acesso ao sistema deve ser restrito a usuários autorizados, como administradores e analistas.</li>
    </ul>

    <h2>Critérios de Aceite (MVP):</h2>
    <ul>
        <li><strong>Clube</strong>
            <ul>
                <li>O clube deve possuir uma data de fundação, residir em uma cidade e possuir jogadores.</li>
            </ul>
        </li>
        <li><strong>Jogadores</strong>
            <ul>
                <li>O jogador deve estar regularizado com os dados cadastrais, estar ativo (não aposentado) e não pertencer a mais de um clube.</li>
                <li>Jogadores que estiverem aposentados, não podem ser utilizados no sistema e devem ter uma sinalização para essa situação. (Flag no banco de dados como falso)</li>
            </ul>
        </li>
        <li><strong>Transferências</strong>
            <ul>
                <li>As transferências só podem ser por venda, empréstimo, retorno de empréstimo, troca, fim de contrato ou rescisão e estarem vinculadas a uma temporada.</li>
                <li>O jogador pode ser transferido mesmo que esteja sem clube ou aposentado.</li>
                <li>Caso a transferência por algum motivo não aconteça, deve existir uma sinalização dizendo que ela não está ativa. (Flag no banco de dados)</li>
                <li>As transferências devem possuir uma data de início e uma previsão de fim (final de contrato).</li>
                <li>As transferências devem informar o clube de destino e o clube de origem.</li>
            </ul>
        </li>
        <li><strong>Temporada</strong>
            <ul>
                <li>A temporada deve ter uma data de início e fim e uma sinalização se ela está ativa ou não.</li>
                <li>Não podem existir mais de uma temporada no mesmo ano.</li>
            </ul>
        </li>
        <li><strong>Estatísticas</strong>
            <ul>
                <li>Deve existir uma consulta para mostrar os jogadores com mais cartões amarelos e vermelhos por temporada.</li>
                <li>Deve existir uma consulta para mostrar os jogadores com mais gols por temporada.</li>
                <li>Deve existir uma consulta para mostrar os jogadores com mais assistências por temporada.</li>
                <li>Deve existir uma consulta para mostrar os jogadores com mais partidas por temporada.</li>
                <li>Deve existir uma consulta para mostrar os clubes com mais gols, cartões, assistências e partidas por temporada.</li>
            </ul>
        </li>
    </ul>
</body>
</html>
