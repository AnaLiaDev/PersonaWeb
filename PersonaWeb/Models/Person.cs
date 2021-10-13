using System.ComponentModel.DataAnnotations; //se crea cuando ponés la línea 13 + ctrl "."

namespace PersonaWeb.Models
{
    public enum SexType
    {
        Femenine = 0,
        Masculine = 1,
    }
    //Se crea el tipo de dato para el sexo
    public class Person
    {
        [Key] //llave principal
        public int PersonID { get; set; } //escribir prop y tab tab para que se cree automaticamente
        [Required] // Sea obligatorio
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Por favor ingrese entre 5 a 60 caracteres")]
        [Display(Name = "Nombre de la persona")] //eso es para lo que se ve en la pagina web
        public string Name { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Required]
        [Display(Name = "Sexo")]
        public SexType Sex { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Display(Name = "Pasatiempo")]

        public string Hobbie { get; set; } //escribir prop y tab tab para que se cree automaticamente

    }
}

