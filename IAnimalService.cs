namespace APBD_Zadanie_3;

public interface IAnimalService
{
    
    IEnumerable<Animal> GetAnimal(string orderBy);
    void AddAnimal(AnimalPostDto animalPostDto);
    void UpdateAnimal(int id, Animal animal);
    void DeleteAnimal(int id);
    
}