/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns.Behavior
{
    public class Mediator
    {
        static void Main(string[] args)
        {
            MediadorConcreto mediador = new MediadorConcreto();
            Colaborador user1 = new Colaborador(mediador, "angelo");
            Colaborador user2 = new Colaborador(mediador, "gabriel");
            mediador.AdcionarColaborador(user1);
            user1.EnviarMensagem("heloow");
            user1.ReceberMensagem("testando");
        }
    }

    public interface IMediador
    {
        void EnviarMensagem(string mensagem, Colaborador colaborador);
    }
    public class MediadorConcreto : IMediador
    {
        private List<Colaborador> _colaborador = new List<Colaborador>();
        public void AdcionarColaborador(Colaborador colaborador)
        {
            _colaborador.Add(colaborador);
        }
        public void EnviarMensagem(string mensagem, Colaborador colaborador)
        {
            foreach(var colaboradores in _colaborador)
            {
                if(colaboradores != colaboradores)
                {
                    colaborador.ReceberMensagem(mensagem);
                }
            }
        }
    }
    public class Colaborador
    {
        private IMediador _mediador;
        private string _nome;

        public Colaborador(IMediador mediador, string nome)
        {
            _mediador = mediador;
            _nome = nome;
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{_nome} enviou: {mensagem}");
            _mediador.EnviarMensagem(mensagem, this);
        }
        public void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"{_nome} recebeu: {mensagem}");
        }

    }
}
*/