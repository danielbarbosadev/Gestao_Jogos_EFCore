using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoJogosEFCore.Models;
using GestaoJogosEFCore.Repositories;

namespace GestaoJogosEFCore.Services
{
    public class JogoService
    {
        private readonly JogoRepository _repository;

        public JogoService(JogoRepository repository)
        {
            _repository = repository;
        }

        public List<Jogo> Listar() => _repository.Listar();

        public Jogo? BuscarPorId(int id) => _repository.BuscarPorId(id);

        public void Adicionar(Jogo jogo) => _repository.Adicionar(jogo);

        public bool Atualizar(Jogo jogoAtualizado) => _repository.Atualizar(jogoAtualizado);

        public bool Excluir(int id) => _repository.Excluir(id);

        public List<Desenvolvedora> ListarDesenvolvedora() => _repository.ListarDesenvolvedora();

        public void AdicionarDesenvolvedora(Desenvolvedora desenvolvedora) => _repository.AdicionarDesenvolvedora(desenvolvedora);
    }
}