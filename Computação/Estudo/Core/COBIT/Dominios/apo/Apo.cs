using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computacao.COBIT
{
    //Dominio para a Gestão Empresaria de TI
    public class Apo : Dominio
    {
        public Apo()
        {
            Nome = "Alinhar, Planejar e Monitorar";
            Sigla = "APO";
            Objetivo = "";
            Processos = new Processo[13]
            {
                new Processo(){
                    Nome = "Gerenciar o Framework de Gestão de TI",
                },
                new Processo(){
                    Nome = "Gerenciar a Estratégia",
                },
                new Processo(){
                    Nome = "Gerenciar a Arquitetura Corporativa",
                },
                new Processo(){
                    Nome = "Gerenciar a Inovação",
                },
                new Processo(){
                    Nome = "Gerenciar o Portfólio",
                },
                new Processo(){
                    Nome = "Gerenciar Orçamento e Custos",
                },
                new Processo(){
                    Nome = "Gerenciar Recursos Humanos",
                },
                new Processo(){
                    Nome = "Gerenciar as Relações",
                },
                new Processo(){
                    Nome = "Gerenciar os Acordos de Serviço",
                },
                new Processo(){
                    Nome = "Gerenciar os Fornecedores",
                },
                new Processo(){
                    Nome = "Gerenciar a Qualidade",
                },
                new Processo(){
                    Nome = "Gerenciar os Riscos",
                },
                new Processo(){
                    Nome = "Gerenciar a Segurança",
                },
            };
        }
    }
}