namespace APBD_Zadanie_3;

public class AnimalService : IAnimalService
{
    
    private readonly IAnimalRepository _animalRepository;
    
    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }
    
    
    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        string orderByValidated = ValidateOrderBy(orderBy);
        IEnumerable<Animal> animals = _animalRepository.GetAnimal(orderByValidated);
        return animals;
    }

    public IEnumerable<Animal> GetAnimal(string orderBy)
    {
        throw new NotImplementedException();
    }

    public void AddAnimal(AnimalPostDto animalPostDto)
    {
        _animalRepository.AddAnimal(animalPostDto);
    }

    public void UpdateAnimal(int id, Animal animal)
    {
        if(!_animalRepository.AnimalIdExists(id))
        {
            throw new ArgumentException("Animal with given id does not exist");
        }
        animal.Id = id;
        _animalRepository.UpdateAnimal(animal);
    }

    public void DeleteAnimal(int id)
    {
        _animalRepository.DeleteAnimal(id);
    }
    
    private string ValidateOrderBy(string orderBy)
    {
        if(orderBy == null)
        {
            return "name";
        }
        if (orderBy != "name" && orderBy != "category" && orderBy != "description" && orderBy != "area")
        {
            throw new ArgumentException("Invalid orderBy parameter");
        }
        return orderBy;
    }
    
    
    
}