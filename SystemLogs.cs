using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SystemLogs
{
    protected List<string> logs = new List<string>(); // Lista para armazenar logs
    protected List<string> defaultMessages = new List<string>(); // Lista para mensagens padrão
    protected List<string> errorMessages = new List<string>(); // Lista para mensagens de erro
    protected List<string> warningMessages = new List<string>(); // Lista para mensagens de aviso

    public static void Log(string message)
    {
        // Simula o registro de logs no console
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }

    public static void LogError(string errorMessage)
    {
        // Simula o registro de erros no console
        Console.WriteLine($"[ERROR] {DateTime.Now}: {errorMessage}");
    }

    public static void LogWarning(string warningMessage)
    {
        // Simula o registro de avisos no console
        Console.WriteLine($"[WARNING] {DateTime.Now}: {warningMessage}");
    }

    public void setDefaultMessage(string message)
    {
        defaultMessages.Add(message);
    }

    public void setErrorMessage(string message)
    {
        errorMessages.Add(message);
    }

    public void setWarningMessage(string message)
    {
        warningMessages.Add(message);
    }

    public void showDefaultMessages()
    {
        Console.WriteLine("Mensagens Padrão:");
        foreach (var message in defaultMessages)
        {
            Console.WriteLine(message);
        }
    }
    public void showErrorMessages()
    {
        Console.WriteLine("Mensagens de Erro:");
        foreach (var message in errorMessages)
        {
            Console.WriteLine(message);
        }
    }
    public void showWarningMessages()
    {
        Console.WriteLine("Mensagens de Aviso:");
        foreach (var message in warningMessages)
        {
            Console.WriteLine(message);
        }
    }

    public void systemStatus()
    {
        Console.WriteLine("Status do Sistema:");
        Console.WriteLine($"Logs: {logs.Count} registros");
        Console.WriteLine($"Mensagens Padrão: {defaultMessages.Count} registros");
        Console.WriteLine($"Mensagens de Erro: {errorMessages.Count} registros");
        Console.WriteLine($"Mensagens de Aviso: {warningMessages.Count} registros");
        Console.WriteLine("Sistema Operacional: " + Environment.OSVersion);
        Console.WriteLine("Data e Hora Atual: " + DateTime.Now);
        Console.WriteLine("Versão do .NET: " + Environment.Version);
        Console.WriteLine("Versão do Sistema: " + SystemParameters.systemVersion);
        Console.WriteLine("Status Atual: Ativo");
    }
}

