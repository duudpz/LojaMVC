using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTests
{
    public class ClienteTests
    {
        [Fact]
        public void Verificar_Email_Idade_Nome_Cliente()
        {
            var cliente = new Cliente()
            {
                //Arrage
                Nome = "",
                Email = "",
                Idade = 12,
                Ativo = true

            };
            //Act
            var resultado = cliente.Validado();
            //Assert
            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Cliente_Apto_Ou_Inativo()
        {
            var cliente = new Cliente()
            {
                //Arrage
                Nome = "Maria Edu",
                Email = "duda@gmail.com",
                Idade = 17,
                Ativo = true

            };
            //Act
            var resultado = cliente.EstaValidado();
            //Assert
            Assert.False(resultado);
        }

            [Fact]
            public void Verificar_Cliente_Sem_Dados_Pessoais()
            {
                var cliente = new Cliente()
                {
                    //Arrage
                    Nome = "",
                    Email = "duda@gmail.com",
                    Idade = 17,
                    Ativo = true

                };
                //Act
                var resultado = cliente.SemDadosPessoais();
                //Assert
                Assert.False(resultado);

            }
        }
    }

