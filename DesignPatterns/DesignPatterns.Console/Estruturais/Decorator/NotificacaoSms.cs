using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Estruturais.Decorator;

public class NotificacaoSms
{
    public NotificacaoSms(Notificacao notificacao)
    {
        Notificacao = notificacao;
    }

    public Notificacao Notificacao { get; set; }

    public void EnviarNotificacao(string mensagem)
    {
        // Enviar notificação por sms

        Notificacao.EnviarNotificacao(mensagem);
    }
}
