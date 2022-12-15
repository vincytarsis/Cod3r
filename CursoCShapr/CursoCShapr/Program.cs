using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes; 
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Primeiro Programa - Comentarios", Comentarios.Executar},
                {"Primeiro Programa - Variaveis e Constantes", VariaveisEConstantes.Executar},
                {"Inferencias - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Coneversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                
                // Estrutura de Controle  
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If e Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If e Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construturos - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retornos - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Gat e Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor versos Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrao - Classes e Métodos", ParametroPadrao.Executar},
                
                // Colecões
                {"Array - Colecoes", Colecoes.Array.Executar},
                {"Lis t - Colecoes", ColecoesList.Executar},
                {"Array List - Colecoes", ColecoesArrayList.Executar},
                {"Set - Colecoes", ColecoesSet.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"Stack - Colecoes", ColecoesStack.Executar},
                {"Dictionaty - Colecoes", ColecoesDictionary.Executar},

                //Orientação a Objeto
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OOEncapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegate Função Anonima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates como Parametros - Métodos e Funções", DelegateComoParametros.Executar},
                {"Metodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                
                //Exceções
                {"Primeira Excecão - Exceções", PrimeiraExcecao.Executar},
                {"Excecões Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                
                //API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                {"File Info - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo Diretory Info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo Date Time - Usando API", ExemploDateTime.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
