using projeto_fuleiro.Models;
using projeto_fuleiro.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_fuleiro.Services
{
    public class ProdutoService
    {
        private ProdutoRepository produtoRepo = new ProdutoRepository();
        private EstoqueRepository estoqueRepo = new EstoqueRepository();

        public void CadastrarProduto(string nome, decimal preco, int quantidade)
        {
            Produto p = new Produto
            {
                Nome = nome,
                Preco = preco
            };

            int produtoId = produtoRepo.Inserir(p);

            Estoque e = new Estoque
            {
                ProdutoId = produtoId,
                Quantidade = quantidade
            };

            estoqueRepo.Inserir(e);
        }
    }
}
