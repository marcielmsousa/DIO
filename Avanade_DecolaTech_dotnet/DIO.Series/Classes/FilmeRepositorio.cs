using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {

        public List<Filme> listaFilme = new List<Filme>();

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }

        public void Insere(Filme objeto)
        {
            listaFilme.Add(objeto); 
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Atualiza(int id, Filme objeto)
        {
            listaFilme[id] = objeto;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }
    }
}