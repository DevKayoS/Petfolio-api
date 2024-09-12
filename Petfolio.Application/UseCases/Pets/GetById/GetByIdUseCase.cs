using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Spike",
            Type = PetType.Dog,
            Birthday = new DateTime(year: 2018, month: 1, day: 7)
        };
        
   
    }
}