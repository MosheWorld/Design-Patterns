public class Memento
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public double Budget { get; set; }

    public Memento(string name, string phone, double budget)
    {
        this.Name = name;
        this.Phone = phone;
        this.Budget = budget;
    }
}