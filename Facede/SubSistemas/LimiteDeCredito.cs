﻿namespace Facede.SubSistemas
{
    public class LimiteDeCredito
    {
        public bool TemLimiteDisponivel(Cliente cliente, double valor)
        {
            Console.WriteLine($"Consultando limite de crédito do cliente {cliente.Nome}\n consultado com sucesso!");

            if (valor> 200000.00)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
