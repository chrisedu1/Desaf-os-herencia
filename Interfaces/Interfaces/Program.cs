using System;

class Program
{
    static void Main(string[] args)
    {
        NotificarEmail email = new NotificarEmail("ejemplo@gmail.com");
        NotificarWhatsApp whatsapp = new NotificarWhatsApp("12345678");
        NotificarSMS sms = new NotificarSMS("98765432");

        email.Notificar("Este es un correo de ejemplo.");
        whatsapp.Notificar("Este es un mensaje de WhatsApp de ejemplo.");
        sms.Notificar("Este es un mensaje de SMS de ejemplo.");
    }
}

public interface INotificable
{
    void Notificar(string mensaje);
}

public class NotificarEmail : INotificable
{
    private string direccionCorreo;

    public NotificarEmail(string direccionCorreo)
    {
        this.direccionCorreo = direccionCorreo;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo a {direccionCorreo}: {mensaje}");
    }
}

public class NotificarWhatsApp : INotificable
{
    private string numeroTelefono;

    public NotificarWhatsApp(string numeroTelefono)
    {
        this.numeroTelefono = numeroTelefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje de WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}

public class NotificarSMS : INotificable
{
    private string numeroTelefono;

    public NotificarSMS(string numeroTelefono)
    {
        this.numeroTelefono = numeroTelefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
    }
}
