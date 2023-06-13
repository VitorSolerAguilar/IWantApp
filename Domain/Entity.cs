namespace IWantApp.Domain;

public abstract class Entity
{
    public Entity()
    {
        // A classe ja cria um Id automaticamente para a classe que herdar seus atributos
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

    public string CraetedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
}
