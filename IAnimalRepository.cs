namespace APBD_Zadanie_3;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimal(string orderBy);
    void AddAnimal(AnimalPostDto animalPostDto);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int id);
    bool AnimalIdExists(int id);
    
}