﻿namespace FinOps.Model
{
    public class Notification
    {
        public Notification(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}