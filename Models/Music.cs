using System.ComponentModel.DataAnnotations;

namespace RazorPagesMusic.Models;

public class Music
{ 
    public int Id {get; set;}
    public string? Titulo {get; set;}

    [DataType(DataType.Date)]
    public string? FechaEstreno {get; set;}
    
    public string? Genero {get; set;}


    public int Precio {get; set;}

}