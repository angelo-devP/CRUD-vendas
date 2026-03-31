using projeto_fuleiro.Models;
using projeto_fuleiro.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_fuleiro.Services
{
    public class EstoqueService
    {
        private ProdutoRepository produtoRepo = new ProdutoRepository();
        private EstoqueRepository estoqueRepo = new EstoqueRepository();

        public void Movimentar(string nome, int quantidade, string tipo)
        {
            Produto produto = produtoRepo.BuscarPorNome(nome);

            if (produto == null)
                throw new Exception("Produto não encontrado");

            Estoque estoque = estoqueRepo.BuscarPorProduto(produto.Id);

            if (tipo == "E")
            {
                estoque.Quantidade += quantidade;
            }
            else if (tipo == "S")
            {
                if (estoque.Quantidade < quantidade)
                    throw new Exception("Estoque insuficiente");

                estoque.Quantidade -= quantidade;
            }

            estoqueRepo.Atualizar(estoque);
        }
    }
}
