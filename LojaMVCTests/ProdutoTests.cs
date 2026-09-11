using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTests
{ 
    public class ProdutoTests
    {
//Primeiro fato
        [Fact]
        public void ValorProduto_Maior_que_Zero()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Mouse",
                Preco = 0,
                Estoque = 50
            };

            //Act

            var resultado = produto.Validation();

            //Assert 

            Assert.False(resultado);
        }
        //2 fato
        [Fact]

        public void Estoque_Invalido_Quando_For_Negativo()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Teclado",
                Preco = 50,
                Estoque = -1
            };
            //Act
            var resultado = produto.Validation();

            //Assert
            Assert.False(resultado);
        }
        //3 fato
        [Fact]

        public void Verifica_Se_Produto_Vazio_Ou_Nulo()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = " ",
                Preco = 50,
                Estoque = 50
            };
            //Act
            var resultado = produto.Validation();

            //Assert
            Assert.False(resultado);
        }

        [Fact]

        public void VerificaNome_Valido_Verifica_Preco_Valido_Verifica_Estoque_Valido()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Monitor",
                Preco = 50,
                Estoque = 50
            };
            //Act
            var resultado = produto.Validation();

            //Assert
            Assert.True(resultado);
        }



    }
}
