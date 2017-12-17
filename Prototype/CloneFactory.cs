public class CloneFactory
{
    public IAnimal GetClone(IAnimal animalSample)
    {
        return animalSample.MakeCopy();
    }
}