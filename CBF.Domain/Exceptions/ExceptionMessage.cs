﻿namespace CBF.Domain.Exceptions;
public static class ExceptionMessage
{
    public static string Id_Not_Found = "Id não encontrado";
    public static string Bad_Request = "Requisição inválida";
    public static string Unknown_Error = "Erro Desconhecido";
    public static string Invalid_User = "Usuário e senha inválidos";
    public static string Jogadores_Nasc_Not_Found = "Não encontrado jogadores para nacionalidade informada";
    public static string Clubes_Not_Found = "Não encontrado clubes para o nome informado";
    public static string Jogador_Already_Exists = "Jogador já cadastrado";
    public static string Clube_Already_Exists = "Clube já cadastrado";
    public static string Season_Already_Exist = "Já existe uma temporada no período selecionado";
}
