using System;

namespace CriandoExcecoesPersonalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException // excessão de dominio do negocio que deve ser criada na pasta exception dentro de entities
    {
        public DomainException(string message): base(message) // costrutor que passa uma mensagem para o construtor da class ApplicationException
        {
            
        }
    }
}
