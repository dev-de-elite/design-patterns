// See https://aka.ms/new-console-template for more information
using DesignPatterns.Console.Estruturais.Decorator;

Console.WriteLine("Hello, World!");

var notificacao = new Notificacao();

var notificacaoSms = new NotificacaoSms(notificacao);

notificacaoSms.EnviarNotificacao("texto");