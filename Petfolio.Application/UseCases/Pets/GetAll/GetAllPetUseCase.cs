using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    id = 1,
                    Name = "spike",
                    Type = PetType.Dog
                },
                new ResponseShortPetJson
                {
                    id = 2,
                    Name = "mel",
                    Type = PetType.Dog
                },
                new ResponseShortPetJson
                {
                    id = 3,
                    Name = "Chanel",
                    Type = PetType.Dog
                },
                new ResponseShortPetJson
                {
                    id = 4,
                    Name = "botas",
                    Type = PetType.Cat
                }
            }
        };
    }
}