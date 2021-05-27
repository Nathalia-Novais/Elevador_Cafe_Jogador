using System;
namespace elevador.classes
{
    public class servico : Elevadorcs
    {
        public int maxcaixa = 4;
        public int CaixasAtuais;
        
            
        public string AdicionarCaixa()
        {
           
            if (CaixasAtuais <= maxcaixa)
            {
                CaixasAtuais = CaixasAtuais + 1;
                maxcaixa = maxcaixa - 1;
                return $"Caixa adicionada, atualmente tem {CaixasAtuais} caixas e o seu elevador só tem a capaciddade de levar {maxcaixa} caixas";
            }
            else
            {
                return "Número máximo de caixas atingido";
            }
        }
        public string RetirarCaixa()
        {
            if (CaixasAtuais >= 1)
            {
                CaixasAtuais = CaixasAtuais - 1;
                return $"Caixa retirada, atualmente tem {CaixasAtuais} caixas";
            }
            else
            {
                return "Nenhuma caixa presente";
            }
        }

    }
}