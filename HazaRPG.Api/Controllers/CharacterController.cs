using System.Net;
using HazaRPG.Api.Models;
using HazaRPG.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HazaRPG.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ILogger<CharacterController> _logger;

        private readonly ICharacterRepository _characterRepository;

        public CharacterController(ILogger<CharacterController> logger, ICharacterRepository characterRepository)
        {
            _logger = logger;
            _characterRepository = characterRepository;
        }
        
        // GET api/v1/[controller]/characters[?pageSize=3&pageIndex=10]
        [HttpGet]
        [Route("characters")]
        //[ProducesResponseType(typeof(PaginatedItemsViewModel<CatalogItem>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<Character>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> ItemsAsync()
        {
            //var models = new List<Character>
            //{
            //    new()
            //    {
            //        Id = 1,
            //        Name = "Coco",
            //        Aggro = 2,
            //        Attack = 20,
            //        Defense = 30,
            //        Health = 100,
            //        ArtifactEquipment = null,
            //        AttackEquipment = new AttackEquipment()
            //        {
            //            Name = "Spear",
            //            EquipmentActions = new List<EquipmentAction>()
            //            {
            //                new()
            //                {
            //                    Stamina = 2,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.AttackDice1,
            //                        Dice.DodgeDice
            //                    }
            //                }
            //            }
            //        },
            //        DefenseEquipment = new DefenseEquipment()
            //        {
            //            Name = "Wood gauntlet",
            //            EquipmentActions = new List<EquipmentAction>()
            //            {
            //                new()
            //                {
            //                    Stamina = 2,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.DefenseDice1,
            //                        Dice.DodgeDice
            //                    }
            //                },
                            
            //                new()
            //                {
            //                    Stamina = 3,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.DefenseDice1,
            //                        Dice.AttackDice1
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new()
            //    {
            //        Id = 2,
            //        Name = "Valou",
            //        Aggro = 5,
            //        Attack = 10,
            //        Defense = 10,
            //        Health = 200,
            //        ArtifactEquipment = null,
            //        AttackEquipment = new AttackEquipment()
            //        {
            //            Name = "Spear",
            //            EquipmentActions = new List<EquipmentAction>()
            //            {
            //                new()
            //                {
            //                    Stamina = 2,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.AttackDice1,
            //                        Dice.DodgeDice
            //                    }
            //                }
            //            }
            //        },
            //        DefenseEquipment = new DefenseEquipment()
            //        {
            //            Name = "Wood gauntlet",
            //            EquipmentActions = new List<EquipmentAction>()
            //            {
            //                new()
            //                {
            //                    Stamina = 2,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.DefenseDice1,
            //                        Dice.DodgeDice
            //                    }
            //                },
                            
            //                new()
            //                {
            //                    Stamina = 3,
            //                    Dices = new List<Dice>()
            //                    {
            //                        Dice.DefenseDice1,
            //                        Dice.AttackDice1
            //                    }
            //                }
            //            }
            //        }
            //    }
            //};

            var characters = await _characterRepository.GetCharacterListAsync();
            return Ok(characters);
        }
    }
}