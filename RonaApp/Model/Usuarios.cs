using System;

public class Usuarios
{
    private string _nombre;
    private string _password;
    private bool _agregacion;
    private bool _visualizacion;
    public string Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            _password = value;
        }
    }
    public bool Agregacion
    {
        get => _agregacion;
        set
        {
            _agregacion = value;
        }
    }
    public bool Visualizacion
    {
        get => _visualizacion;
        set
        {
            _visualizacion = value;
        }
    }
    public Usuarios(string nombre,string password,bool agregacion,bool visualizacion)
	{
        this.Nombre = nombre;
        this.Password = password;
        this.Agregacion = agregacion;
        this.Visualizacion = visualizacion;
	}
    public Usuarios()
    {

    }
}
